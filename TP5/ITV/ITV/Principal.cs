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
        string parametro_cantidad;
        public Principal()
        {
            InitializeComponent();
            txt_cantidad_minutos.Enabled = false;
            txt_cantidad_eventos.Enabled = false;
            
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

            txt_cantidad_casetas.Text = "1";
            txt_cantidad_naves.Text = "2";
            txt_cantidad_oficinas.Text = "1";
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            if(!rb_eventos.Checked && !rb_minutos.Checked)
            {
                MessageBox.Show("Seleccione un parámetro para la cantidad de eventos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(rb_minutos.Checked && txt_cantidad_minutos.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad de minutos a simular", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (rb_eventos.Checked && (txt_cantidad_eventos.Text == "" || int.Parse(txt_cantidad_eventos.Text) < 400))
            {
                MessageBox.Show("Ingrese la cantidad de eventos a simular (mayor o igual a 400)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            if (txt_cantidad_casetas.Text == "" || int.Parse(txt_cantidad_casetas.Text) == 0)
            {
                MessageBox.Show("Ingrese la cantidad de casetas (debe ser mayor a cero)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_cantidad_naves.Text == "" || int.Parse(txt_cantidad_naves.Text) == 0)
            {
                MessageBox.Show("Ingrese la cantidad de naves (debe ser mayor a cero) ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_cantidad_oficinas.Text == "" || int.Parse(txt_cantidad_oficinas.Text) == 0)
            {
                MessageBox.Show("Ingrese la cantidad de oficinas (debe ser mayor a cero) ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (rb_eventos.Checked)
            {
                parametro_cantidad = "eventos";
                Simulacion simulacion = new Simulacion(int.Parse(txt_cantidad_eventos.Text), int.Parse(txt_cantidad_clientes_llegadas.Text), int.Parse(txt_cantidad_clientes_caseta.Text), 
                                                       int.Parse(txt_cantidad_clientes_nave.Text), int.Parse(txt_cantidad_clientes_oficina.Text), int.Parse(txt_minutos_llegadas.Text), 
                                                       int.Parse(txt_minutos_caseta.Text), int.Parse(txt_minutos_nave.Text), int.Parse(txt_minutos_oficina.Text), int.Parse(txt_cantidad_maxima_cola.Text),
                                                       int.Parse(txt_cantidad_casetas.Text), int.Parse(txt_cantidad_naves.Text), int.Parse(txt_cantidad_oficinas.Text),
                                                       parametro_cantidad, cb_mostrar_clientes.Checked);
                simulacion.ShowDialog();

            }

            if (rb_minutos.Checked)
            {
                parametro_cantidad = "minutos";
                Simulacion simulacion = new Simulacion(int.Parse(txt_cantidad_minutos.Text), int.Parse(txt_cantidad_clientes_llegadas.Text), int.Parse(txt_cantidad_clientes_caseta.Text), 
                                                       int.Parse(txt_cantidad_clientes_nave.Text), int.Parse(txt_cantidad_clientes_oficina.Text), int.Parse(txt_minutos_llegadas.Text), 
                                                       int.Parse(txt_minutos_caseta.Text), int.Parse(txt_minutos_nave.Text), int.Parse(txt_minutos_oficina.Text), int.Parse(txt_cantidad_maxima_cola.Text),
                                                       int.Parse(txt_cantidad_casetas.Text), int.Parse(txt_cantidad_naves.Text), int.Parse(txt_cantidad_oficinas.Text),
                                                       parametro_cantidad, cb_mostrar_clientes.Checked);
                simulacion.ShowDialog();
            }

            
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (rb_eventos.Checked)
            {
                txt_cantidad_minutos.Enabled = false;
                txt_cantidad_eventos.Enabled = true;
                txt_cantidad_minutos.Text = "";
            }
            if (rb_minutos.Checked)
            {   
                txt_cantidad_minutos.Enabled = true;
                txt_cantidad_eventos.Enabled = false;
                txt_cantidad_eventos.Text = "";
            }
        }
    }
}
