using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoG_Distribuciones
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            btn_continuar.Enabled = true;
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if(!(int.Parse(txt_cantidad.Text) >= 500))
            {
                MessageBox.Show("La cantidad de números debe ser superior a 500");
                return;
            }
        }
    }
}
