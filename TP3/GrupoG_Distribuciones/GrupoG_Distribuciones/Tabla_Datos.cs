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
        DataTable tabla;
        int cantidad_numeros;
        string tipo_distribucion;
        double maximo, minimo;
        public Tabla_Datos(DataTable tabla, int cantidad_numeros, string tipo_distribucion, double maximo, double minimo)
        {
            InitializeComponent();
            this.tabla = tabla;
            this.cantidad_numeros = cantidad_numeros;
            this.tipo_distribucion = tipo_distribucion;
            this.maximo = maximo;
            this.minimo = minimo;
            dg_rnd.DataSource = tabla;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            ChiCuadrado chiCuadrado = new ChiCuadrado(tabla, cantidad_numeros, tipo_distribucion, maximo, minimo);
            chiCuadrado.ShowDialog();
        }
    }
}
