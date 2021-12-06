﻿using System;
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
    }
}
