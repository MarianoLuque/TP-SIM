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
    public partial class Tabla_Datos : Form
    {
        public Tabla_Datos(DataTable tabla)
        {
            InitializeComponent();
            dg_rnd.DataSource = tabla;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
