﻿using Boleteria_Final.Soporte;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boleteria_Final
{
    internal class GestorColas
    {
        DataTable resultados;
        private Form1 pantalla;
        private Linea lineaActual;
        private Truncador truncador;

        public GestorColas(Form1 pantalla)
        {
            this.pantalla = pantalla;
            resultados = new DataTable();
            crearTabla(resultados);
        }

        private void crearTabla(DataTable tabla)
        {
            tabla.Columns.Add("Iteración");//Linea 0
            tabla.Columns.Add("Evento");//Linea 1
            tabla.Columns.Add("Reloj");//Linea 2
            tabla.Columns.Add("Cliente");//Linea 3
            tabla.Columns.Add("Siguiente cliente");//Linea 4
            tabla.Columns.Add("Tiempo llegada");//Linea 5
            tabla.Columns.Add("Siguiente llegada");//Linea 6
            tabla.Columns.Add("Estado");//Linea 7
            tabla.Columns.Add("Cola");//Linea 8
            tabla.Columns.Add("RND atención rápida");//Linea 9
            tabla.Columns.Add("Atención rápida");//Linea 10
            tabla.Columns.Add("Tiempo atención");//Linea 11
            tabla.Columns.Add("Fin de atención");//Linea 12
            tabla.Columns.Add("Máxima cola");//Linea 13
            tabla.Columns.Add("Clientes atendidos");//Linea 14
            tabla.Columns.Add("Tiempo promedio de atención");//Linea 15

            truncador = new Truncador(2);
        }

        public void simular(double desde,double hasta,double limInferior,double limSuperior,
            double media1,double media2,double desviacion1,double desviacion2,
            double tiempo,double cantClientes,Boolean simulacionClientes)
        {
            Linea lineaAnterior = new Linea();
            double iteracion = 1;
            agregarLinea(lineaAnterior, 0);

            while (true)
            {
                lineaActual = new Linea(lineaAnterior, this, desde, hasta,iteracion);
                lineaActual.calcularEvento();

                if (!simulacionClientes && lineaActual.reloj > tiempo)
                {
                    break;
                }

                lineaActual.calcularSiguienteLlegada(limInferior,limSuperior);
                lineaActual.calcularFinAtencion(media1,desviacion1,media2,desviacion2);
                lineaActual.calcularColaMaxima();
                lineaActual.hayAtencionRapida();
                lineaActual.calcularTiempoPromedioSistema();

                lineaAnterior = lineaActual;

                if (iteracion >= desde && iteracion <= hasta)
                {
                    agregarLinea(lineaActual, iteracion);
                }

                if (simulacionClientes && lineaActual.clientesAtendidos == cantClientes)
                {
                    break;
                }

                iteracion++;
            }
            pantalla.mostrarResultados(resultados);
        }

        private void agregarLinea(Linea linea,double iteracion)
        {
            DataRow row = resultados.NewRow();
            row[0] = iteracion;
            row[1] = linea.evento;
            row[2] = truncador.truncar(linea.reloj);
            //row[3] = linea.cliente;
            //row[4] = linea.siguienteCliente;
            row[5] = truncador.truncar(linea.tiempoLlegada);
            row[6] = truncador.truncar(linea.siguienteLlegada);
            row[7] = linea.boleteria.estado;
            row[8] = linea.boleteria.cola.Count;
            row[9] = linea.rndAtencionRapida.ToString() != "-1" ? truncador.truncar(linea.rndAtencionRapida).ToString() : "";
            row[10] = linea.ATENCION_RAPIDA;
            row[11] = linea.tiempoAtencion.ToString() != "0" ? truncador.truncar(linea.tiempoAtencion).ToString() : "";
            row[12] = linea.boleteria.finAtencion.ToString() != "-1" ? truncador.truncar(linea.boleteria.finAtencion).ToString() : "";
            row[13] = linea.colaMaxima;
            row[14] = linea.clientesAtendidos;
            row[15] = truncador.truncar(linea.tiempoPromedioSistema);
            resultados.Rows.Add(row);

        }
    }
}