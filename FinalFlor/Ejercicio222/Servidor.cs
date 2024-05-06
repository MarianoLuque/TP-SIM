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
        public enum Tipo { MAQUINA1 = 1, MAQUINA2 = 2, MAQUINA3 = 3, MAQUINA4 = 4 }
        private Tipo tipo;
        private double tiempo_procesamiento;
        private double fin_procesamiento;
        private Cliente? cheque_procesado;
        List<Cliente>? cola_cheques_maquina;
        Random objeto_rnd;
        double lambda;

        public Servidor(Tipo tipo, Random objeto_semilla, double lambda)
        {
            this.estado = Estados.libre;
            this.tipo = tipo;
            this.tiempo_procesamiento = 0.0;
            this.fin_procesamiento = 0.0;
            this.cola_cheques_maquina = new List<Cliente>();
            this.objeto_rnd = new Random(objeto_semilla.Next());
            this.lambda = lambda;
        }

        public double GetLambda()
        {
            return this.lambda;
        }

        public double GetTiempoProcesamiento()
        {
            return this.tiempo_procesamiento;
        }

        public void SetTiempoProcesamiento(double tiempo_procesamiento)
        {
            this.tiempo_procesamiento = tiempo_procesamiento;
        }

        public double GetRND()
        {
            return objeto_rnd.NextDouble();
        }

        public Tipo GetTipo()
        {
            return this.tipo;
        }

        public void SetTipo(Tipo tipo)
        {
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

        public double GetFinProcesamiento()
        {
            return this.fin_procesamiento;
        }
        public void SetFinProcesamiento(double fin_procesamiento)
        {
            this.fin_procesamiento = fin_procesamiento;
        }

        public Cliente? GetCliente()
        {
            return cheque_procesado;
        }

        public void SetCliente(Cliente? cheque_atendido)
        {
            this.cheque_procesado = cheque_atendido;
        }

        public List<Cliente>? GetColaCheques()
        {
            return cola_cheques_maquina;
        }

        public void AgregarClienteACola(Cliente cheque)
        {
            cola_cheques_maquina.Add(cheque);
        }

        public void EliminarClienteDeCola()
        {
            if(cola_cheques_maquina != null && cola_cheques_maquina.Count > 0)
            {
                cola_cheques_maquina.RemoveAt(0);
            }
        }

        public void LimpiarCola()
        {
            if(cola_cheques_maquina != null)
            {
                cola_cheques_maquina.Clear();
            }
        }
    }
}
