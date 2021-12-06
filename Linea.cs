using Boleteria_Final.Soporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria_Final
{
    internal class Linea
    {
        public string LLEGADA_CLIENTE = "Llegada cliente";
        public string FIN_ATENCION = "Fin atencion";

        public double desde;
        public double hasta;

        public GeneradorLenguaje aleatorios;
        public Truncador truncador;
        public string evento { get; set; }
        public double reloj { get; set; }
        public double tiempoLlegada { get; set; }
        public double siguienteLlegada { get; set; }
        public Linea lineaAnterior { get; set; }
        public GestorColas colas;
        public Servidor boleteria { get; set; }
        public double colaMaxima { get; set; }
        

        public Linea()
        {
            this.siguienteLlegada = 0;
            this.aleatorios = new GeneradorLenguaje(truncador);
        }

        public Linea(Linea lineaAnterior, GestorColas colas, double desde, double hasta)
        {
            this.lineaAnterior = lineaAnterior;
            this.truncador = new Truncador(4);
            this.colas = colas;
            this.desde = desde;
            this.hasta = hasta;
            this.boleteria = lineaAnterior.boleteria;
            this.colaMaxima = lineaAnterior.colaMaxima;

        }
    }
}
