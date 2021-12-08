using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria_Final.Soporte
{
    internal class GeneradorLenguaje
    {
        Random random;
        Truncador truncador;

        public GeneradorLenguaje(Truncador truncador)
        {
            this.truncador = truncador;
            this.random = new Random();
        }
        public double siguienteAleatorio()
        {
            return truncador.truncar(random.NextDouble());
        }
        public double siguienteAleatorio(double media,double desviacion)
        {
            double aleatorio1;
            double aleatorio2;
            double aleatorioNormal;
            aleatorio1 = random.NextDouble();
            aleatorio2 = random.NextDouble();

            aleatorioNormal = Math.Sqrt(-2 * Math.Log(aleatorio1)) * Math.Cos(2 * Math.PI * aleatorio2) * desviacion + media;
            while (double.IsInfinity(aleatorioNormal))
            {
                aleatorio1 = random.NextDouble();
                aleatorio2 = random.NextDouble();
                aleatorioNormal = Math.Sqrt(-2 * Math.Log(aleatorio1)) * Math.Cos(2 * Math.PI * aleatorio2) * desviacion + media;
                if (!double.IsInfinity(aleatorioNormal)) { break; }
            }
            if (aleatorioNormal < 0) { return Math.Abs(aleatorioNormal); }
            return aleatorioNormal;
        }
    }
}
