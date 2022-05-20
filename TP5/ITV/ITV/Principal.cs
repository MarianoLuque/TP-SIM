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
        }
    }
}
