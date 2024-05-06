using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio222
{
    internal class Cliente
    {
        private double hora_llegada_al_sistema;

        public enum Estados
        {
            ESPERANDO_PROCESAMIENTO = 0,
            SIENDO_PROCESADO        = 1,
            FUERA_DEL_SISTEMA       = 2
        };
        private Estados estado;

        public Cliente(double hora_actual, Estados estado)
        {
            this.hora_llegada_al_sistema = hora_actual;
            this.estado = estado;
        }

        public Cliente(double hora_actual)
        {
            this.hora_llegada_al_sistema = hora_actual;
        }

        public Estados GetEstado()
        {
            return this.estado;
        }
        public void SetEstado(Estados estado)
        {
            this.estado = estado;
        }

        public double GetHoraLlegadaAlSistema()
        {
            return this.hora_llegada_al_sistema;
        }

    }
}
