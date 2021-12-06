using Boleteria_Final.Soporte;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            tabla.Columns.Add("Reloj");//Linea 1
            tabla.Columns.Add("Evento");//Linea 2
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

            truncador = new Truncador(2);
        }

        public void simular(double desde,double hasta,double limInferior,double limSuperior,double media1,double media2,double desviacion1,double desviacion2)
        {
            Linea lineaAnterior = new Linea();
            double iteracion = 1;
            agregarLinea(lineaAnterior, 0);

            while (true)
            {
                lineaActual = new Linea(lineaAnterior, this, desde, hasta);
                lineaActual.calcularEvento();
                lineaActual.calcularSiguienteLlegada();
                lineaActual.calcularFinAtencion();

                lineaActual.calcularColaMaxima();

                lineaAnterior = lineaActual;

                if (iteracion >= desde && iteracion <= hasta)
                {
                    agregarLinea(lineaActual, iteracion);
                }
            }
            pantalla.mostrarResultados(resultados);
        }

        private void agregarLinea(Linea linea,double iteracion)
        {
            DataRow row = resultados.NewRow();

        }
    }
}
