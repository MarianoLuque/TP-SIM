using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITV
{
    class servidor
    {
        public enum Estados { libre, ocupado };
        private Estados estado;

        public servidor()
        {
            this.estado = Estados.libre;
        }

        public Estados GetEstado()
        {
            return this.estado;
        }

        public void SetEstado(Estados estado)
        {
            this.estado = estado;
        }
    }
}
