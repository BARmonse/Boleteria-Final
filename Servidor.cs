﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria_Final
{
    internal class Servidor : ICloneable
    {
        String LIBRE = "LIBRE";
        String OCUPADO = "OCUPADO";
        public string estado { get; set; }
        public double finAtencion { get; set; }
        public Queue<Cliente> cola;
        public Cliente clienteActual;

        public Servidor()
        {
            this.estado = LIBRE;
            this.finAtencion = -1;
            this.cola = new Queue<Cliente>();
        }

        public Boolean tieneCola()
        {
            return cola.Count > 0;
        }
        public void agregarFinAtencion(double tiempo)
        {
            this.finAtencion = tiempo;
            this.estado = OCUPADO;
        }
        public Boolean tieneFinAtencion()
        {
            return this.finAtencion > 0;
        }
        public double obtenerFinAtencion()
        {
            return finAtencion;
        }
        public void liberar()
        {
            this.estado = LIBRE;
            this.finAtencion = -1;
        }
        public Boolean estaOcupado()
        {
            return this.estado.Equals(OCUPADO);
        }
        public Boolean estaLibre()
        {
            return this.estado.Equals(LIBRE);
        }
        public Cliente siguienteCliente()
        {
            return cola.Dequeue();
        }
        public void agregarACola(Cliente cliente)
        {
            cola.Enqueue(cliente);
        }
        public Cliente obtenerClienteActual(){
            return this.clienteActual;
        }
        public object Clone()
        {
            Servidor res = new Servidor();
            res.estado = this.estado;
            res.finAtencion = this.finAtencion;
            res.clienteActual = this.clienteActual;
            Cliente[] temp = new Cliente[cola.Count];
            cola.CopyTo(temp, 0);
            res.cola = new Queue<Cliente>(temp);

            return res;
        }
    }
}