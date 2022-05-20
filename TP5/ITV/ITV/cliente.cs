using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITV
{
    class cliente
    {
        private DateTime hora_llegada_a_la_cola;
        private DateTime hora_llegada_al_sistema;

        public enum Estados { ESPERANDO_ATENCION_CASETA     = 0,
                              SIENDO_ATENDIDO_CASETA        = 1,
                              ESPERANDO_ATENCION_NAVE       = 2,
                              SIENDO_ATENDIDO_NAVE          = 3,
                              ESPERANDO_ATENCION_OFICINA    = 4,
                              SIENDO_ATENDIDO_OFICINA       = 5,
                              SIN_LUGAR_EN_COLA_CASETA      = 6,
                              FUERA_DEL_SISTEMA             = 7
        };
        private Estados estado;
        

        public cliente(DateTime hora_actual, Estados estado)
        {
            this.hora_llegada_a_la_cola = hora_actual;
            this.hora_llegada_al_sistema = hora_actual;
            this.estado = estado;
        }

        public Estados GetEstado()
        {
            return this.estado;
        }

        public void SetEstadoYHoraLlegadaCola(DateTime reloj, Estados estado)
        {
            this.hora_llegada_a_la_cola = reloj;
            this.estado = estado;
        }

        public void SetEstado(Estados estado)
        {
            this.estado = estado;
        }



    }
}
