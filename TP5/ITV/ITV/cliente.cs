using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITV
{
    class cliente
    {
        private DateTime hora_llegada;
        private enum Estados { EAC, SAC, EAN, SAN, EAO, SAO };
        private Estados estado;

        public cliente()
        {
            this.hora_llegada = DateTime.Now;
            this.estado = Estados.EAC;
        }

    }
}
