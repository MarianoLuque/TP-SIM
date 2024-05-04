using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Ejercicio222
{
    internal class Servidor
    {
        public enum Estados { libre, ocupado };
        private Estados estado;
        private double fin_procesamiento;
        private Cliente? cheque_procesado;

        public Servidor()
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

        public double GetFinAtencion()
        {
            return this.fin_procesamiento;
        }
        public void SetFinAtencion(double fin_atencion)
        {
            this.fin_procesamiento = fin_atencion;
        }

        public Cliente? GetCliente()
        {
            return cheque_procesado;
        }

        public void SetCliente(Cliente cheque_atendido)
        {
            this.cheque_procesado = cheque_atendido;
        }
    }
}
