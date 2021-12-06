using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria_Final
{
    internal class Cliente
    {
        String SIENDO_ATENTDIDO = "SA";
        String ESPERANDO_ATENCION = "EA";

        public string estado;

        public Cliente()
        {
            this.estado = "";

        }
        public void esperarAtencion()
        {
            this.estado = ESPERANDO_ATENCION;
        }
        public void atender()
        {
            this.estado = SIENDO_ATENTDIDO;
        }
        public void limpiar()
        {
            estado = "";
        }
    }
}
