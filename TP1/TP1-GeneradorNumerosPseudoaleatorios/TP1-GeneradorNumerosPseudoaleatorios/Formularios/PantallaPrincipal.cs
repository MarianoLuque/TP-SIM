using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_GeneradorNumerosPseudoaleatorios.Formularios;

namespace TP1_GeneradorNumerosPseudoaleatorios.Formularios
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if(rb_lenguaje.Checked)
            {
                SerieLenguaje frm_lenguaje = new SerieLenguaje();
                frm_lenguaje.ShowDialog();
            }
            else if (rb_propio.Checked)
            {
                NuestraSerie frm_nuestro = new NuestraSerie();
                frm_nuestro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione si la serie debe ser generada por el lenguaje o por un generador propio");
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
