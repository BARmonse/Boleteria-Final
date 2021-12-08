﻿using Boleteria_Final.Soporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Boleteria_Final
{
    internal class Linea
    {
        public string LLEGADA_CLIENTE = "Llegada cliente";
        public string FIN_ATENCION = "Fin atencion";
        public string ATENCION_RAPIDA = "";

        public double idFila;
        public double desde;
        public double hasta;

        public GeneradorLenguaje aleatorios;
        public Truncador truncador;
        public double tiempoPromedioSistema { get; set; }
        public string evento { get; set; }
        public double reloj { get; set; }
        public double tiempoLlegada { get; set; }
        public double siguienteLlegada { get; set; }
        public double tiempoAtencion { get; set; }
        public Linea lineaAnterior { get; set; }
        public GestorColas colas;
        public Servidor boleteria { get; set; }
        public double colaMaxima { get; set; }
        public double rndAtencionRapida { get; set; }
        public List<Cliente> clientes;
        public ConcurrentQueue<Cliente> clientesLibres;
        public double clientesAtendidos;

        public Linea()
        {
            this.siguienteLlegada = 0;
            this.aleatorios = new GeneradorLenguaje();
            this.clientes = new List<Cliente>();
            this.clientesLibres = new ConcurrentQueue<Cliente>();
            this.boleteria = new Servidor();
            this.truncador = new Truncador(2);
            this.rndAtencionRapida = -1;
            this.clientesAtendidos = 0;
            this.evento = "Inicialización";
            this.tiempoPromedioSistema = 0;
        }

        public Linea(Linea lineaAnterior, GestorColas colas, double desde, double hasta, double idFila)
        {
            this.lineaAnterior = lineaAnterior;
            this.truncador = lineaAnterior.truncador;
            this.colas = colas;
            this.desde = desde;
            this.hasta = hasta;
            this.colaMaxima = lineaAnterior.colaMaxima;
            this.aleatorios = lineaAnterior.aleatorios;
            this.clientesLibres = lineaAnterior.clientesLibres;
            this.idFila = idFila;
            this.colaMaxima = lineaAnterior.colaMaxima;
            this.boleteria = lineaAnterior.boleteria;
            this.clientes = lineaAnterior.clientes;
            this.reloj = lineaAnterior.reloj;
            this.rndAtencionRapida = -1;
            this.clientesAtendidos = lineaAnterior.clientesAtendidos;
        }

        public Servidor obtenerBoleteria()
        {
            return (Servidor) this.boleteria.Clone();
        }

        private Cliente buscarClienteLibre()
        {
            Cliente libre;
            Boolean correcto = clientesLibres.TryDequeue(out libre);
            if (correcto)
            {
                return libre;
            }

            Cliente res = new Cliente();
            this.clientes.Add(res);
            if (idFila <= hasta)
            {
                //colas.agregarColumna();
            }

            return res;
        }

        public void calcularEvento() {
            this.reloj = lineaAnterior.siguienteLlegada;
            this.evento = LLEGADA_CLIENTE;

            if (reloj > lineaAnterior.boleteria.finAtencion &&
                lineaAnterior.boleteria.finAtencion > 0)
            {
                this.reloj = lineaAnterior.boleteria.finAtencion;
                this.evento = FIN_ATENCION;
            }
        }

        public void calcularSiguienteLlegada(double a, double b) {
            if (this.evento.Equals(LLEGADA_CLIENTE)) {
                this.tiempoLlegada = a + (b - a) * aleatorios.siguienteAleatorio();
                this.siguienteLlegada = reloj + tiempoLlegada;
                return;
            }
            this.siguienteLlegada = lineaAnterior.siguienteLlegada;
        }
        public void calcularFinAtencion(double media1, double desv1, double media2, double desv2) {
            calcularFinAtencionEventoLlegadaCliente(media1, desv1,media2,desv2);
            calcularFinAtencionEventoFinAtencion(media1, desv1,media2,desv2);
        }
      

        private void calcularFinAtencionEventoLlegadaCliente(double media1, double desviacion1,double media2,double desviacion2) {
            if (this.evento.Equals(LLEGADA_CLIENTE)) {

                Cliente clienteActual = buscarClienteLibre();
                if (lineaAnterior.boleteria.estaOcupado()) {
                    esperarAtencion(clienteActual);
                }
                else {
                    rndAtencionRapida = aleatorios.siguienteAleatorio();
                    if (rndAtencionRapida < 0.4)
                    {
                        atender(clienteActual, media1, desviacion1);
                    }
                    else
                    {
                        atender(clienteActual, media2, desviacion2);
                    }
                }
            }
        }

        private void calcularFinAtencionEventoFinAtencion(double media1, double desviacion1, double media2, double desviacion2) {
            if (this.evento.Equals(FIN_ATENCION))
            {
                clientesAtendidos++;
                Cliente clienteRecienAtendido = boleteria.obtenerClienteActual();
                clientesLibres.Enqueue(clienteRecienAtendido);

                if (lineaAnterior.boleteria.tieneCola())
                {
                    Cliente clienteActual = boleteria.siguienteCliente();
                    rndAtencionRapida = aleatorios.siguienteAleatorio();
                    if (rndAtencionRapida < 0.4)
                    {
                        atender(clienteActual, media1, desviacion1);
                    }
                    else
                    {
                        atender(clienteActual, media2, desviacion2);
                    }
                }
                else
                {
                    boleteria.liberar();
                }
            }
            
        }

        private void esperarAtencion(Cliente cliente) {
            boleteria.agregarFinAtencion(lineaAnterior.boleteria.obtenerFinAtencion());
            boleteria.agregarACola(cliente);
            cliente.esperarAtencion();
        }
        private void atender(Cliente cliente, double media, double desviacion) {
            cliente.atender();
            tiempoAtencion = aleatorios.siguienteAleatorio(media, desviacion);
            boleteria.agregarFinAtencion(this.reloj + tiempoAtencion);
            boleteria.clienteActual = cliente;
        }

        public void hayAtencionRapida()
        {
            if (rndAtencionRapida != -1)
            {
                ATENCION_RAPIDA = rndAtencionRapida > 0.4 ? "SI" : "NO";
            }
            else
            {
                ATENCION_RAPIDA = "";
            }
        }

        public void calcularColaMaxima()
        {
            if (boleteria.cola.Count > lineaAnterior.colaMaxima)
            {
                colaMaxima = boleteria.cola.Count;
                return;
            }
            this.colaMaxima = lineaAnterior.colaMaxima;
        }
        public void calcularTiempoPromedioSistema()
        {
            this.tiempoPromedioSistema = lineaAnterior.tiempoPromedioSistema;
            if (lineaAnterior.clientesAtendidos != clientesAtendidos)
            {
                this.tiempoPromedioSistema = this.reloj / clientesAtendidos;
            }
        }
    }
}
