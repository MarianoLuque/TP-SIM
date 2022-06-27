using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITV
{
    class cliente
    {
        private double minuto_llegada_a_la_cola;
        private double minuto_llegada_al_sistema;

        public enum Estados { ESPERANDO_ATENCION_CASETA         = 0,
                              SIENDO_ATENDIDO_CASETA            = 1,
                              ESPERANDO_ATENCION_NAVE           = 2,
                              SIENDO_ATENDIDO_NAVE_1            = 3,
                              SIENDO_ATENDIDO_NAVE_2            = 4,
                              ESPERANDO_ATENCION_OFICINA        = 5,
                              SIENDO_ATENDIDO_OFICINA_1         = 6,
                              SIENDO_ATENDIDO_OFICINA_2         = 7,
                              SIN_LUGAR_EN_COLA_CASETA          = 8,
                              FUERA_DEL_SISTEMA                 = 9,
                              ESPERANDO_REANUDACION_ATENCION    = 10
        };
        private Estados estado;
        

        public cliente(double hora_actual, Estados estado)
        {
            this.minuto_llegada_a_la_cola = hora_actual;
            this.minuto_llegada_al_sistema = hora_actual;
            this.estado = estado;
        }

        public Estados GetEstado()
        {
            return this.estado;
        }

        public void SetEstadoYHoraLlegadaCola(double reloj, Estados estado)
        {
            this.minuto_llegada_a_la_cola = reloj;
            this.estado = estado;
        }

        public void SetEstado(Estados estado)
        {
            this.estado = estado;
        }

        public double GetMinutoLlegadaAlSistema()
        {
            return this.minuto_llegada_al_sistema;
        }

        public double GetMinutoLlegadaALaCola()
        {
            return this.minuto_llegada_a_la_cola;
        }



    }
}
