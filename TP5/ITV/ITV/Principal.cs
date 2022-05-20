using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITV
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            txt_cantidad_clientes_llegadas.Text = "57";
            txt_cantidad_clientes_caseta.Text = "1";
            txt_cantidad_clientes_nave.Text = "45";
            txt_cantidad_clientes_oficina.Text = "1";

            txt_minutos_llegadas.Text = "60";
            txt_minutos_caseta.Text = "1";
            txt_minutos_nave.Text = "60";
            txt_minutos_oficina.Text = "2";

            txt_cantidad_maxima_cola.Text = "15";
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            if(txt_cantidad_simulaciones.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad de minutos a simular", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_cantidad_clientes_llegadas.Text == "" || txt_cantidad_clientes_caseta.Text == "" || txt_cantidad_clientes_nave.Text == "" || txt_cantidad_clientes_oficina.Text == "" )
            {
                MessageBox.Show("Ingrese la cantidad de clientes que llegan al sistema y que son atendidos en cada servicio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_minutos_llegadas.Text == "" || txt_minutos_caseta.Text == "" || txt_minutos_nave.Text == "" || txt_minutos_oficina.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad de minutos en los que llegan los clientes al sistema y que tardan en la atención de cada servicio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(txt_cantidad_maxima_cola.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad máxima de clientes que puede haber en la cola de la caseta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Simulacion simulacion = new Simulacion(int.Parse(txt_cantidad_simulaciones.Text), int.Parse(txt_cantidad_clientes_llegadas.Text), int.Parse(txt_cantidad_clientes_caseta.Text), int.Parse(txt_cantidad_clientes_nave.Text), int.Parse(txt_cantidad_clientes_oficina.Text), int.Parse(txt_minutos_llegadas.Text), int.Parse(txt_minutos_caseta.Text), int.Parse(txt_minutos_nave.Text), int.Parse(txt_minutos_oficina.Text), int.Parse(txt_cantidad_maxima_cola.Text));
            simulacion.ShowDialog();
        }
    }
}
