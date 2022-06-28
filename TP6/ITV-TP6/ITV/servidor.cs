using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITV
{
    class servidor
    {
        public enum Estados { libre, ocupado, bloqueado };
        private Estados estado;
        private double fin_atencion;
        private double tiempo_remanente_atencion;
        private cliente cliente_atendido;
        public enum Tipos { caseta, nave, oficina };
        private Tipos tipo;
        public servidor(Tipos tipo)
        {
            this.estado = Estados.libre;
            this.tipo = tipo;
        }

        public Estados GetEstado()
        {
            return this.estado;
        }

        public void SetEstado(Estados estado)
        {
            this.estado = estado;
        }

        public double GetFinAtencion()
        {
            return this.fin_atencion;
        }
        public void SetFinAtencion (double fin_atencion)
        {
            this.fin_atencion = fin_atencion;
        }

        public cliente GetCliente()
        {
            return cliente_atendido;
        }

        public void SetCliente(cliente cliente_atendido)
        {
            this.cliente_atendido = cliente_atendido;
        }

        public Tipos GetTipo()
        {
            return this.tipo;
        }

        public void SetTiempoRemanenteAtencion(double tiempo_remanente_atencion)
        {
            this.tiempo_remanente_atencion = tiempo_remanente_atencion;
        }

        public double GetTiempoRemanenteAtencion()
        {
            return this.tiempo_remanente_atencion;
        }
        
    }
}
