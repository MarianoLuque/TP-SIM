using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GeneradorNumerosPseudoaleatorios.Formularios
{
    public partial class Tabla : Form
    {
        private int m, a, semilla;
        public Tabla(int m, int a, int semilla)
        {
            InitializeComponent();
            this.m = m;
            this.a = a;
            this.semilla = semilla;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
