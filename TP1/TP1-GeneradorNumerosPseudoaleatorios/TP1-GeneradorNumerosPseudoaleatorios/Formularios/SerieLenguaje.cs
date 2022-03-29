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
    public partial class SerieLenguaje : Form
    {
        //Creo la tabla de las iteraciones
        DataTable tabla_iteracion = new DataTable();

        public SerieLenguaje()
        {
            InitializeComponent();
        }

        private void calcularYCargar()
        {
            tabla_iteracion.Rows.Clear();
            tabla_iteracion.Columns.Clear();
            //Creo las columnas de la tabla
            DataColumn iteracion = new DataColumn("Iteracion");
            DataColumn rnd = new DataColumn("RND");


            //Agrego las columnas a la tabla
            tabla_iteracion.Columns.Add(iteracion);
            tabla_iteracion.Columns.Add(rnd);

            Random myObject = new Random();

            //Por la cantidad de numeros a generar, crea una fila y le asigna los valores
            for (int i = 0; i < int.Parse(txt_cantidad.Text); i++)
            {
                //Creo la fila
                tabla_iteracion.Rows.Add();

                //Le asigno los valores
                tabla_iteracion.Rows[i]["Iteracion"] = i;
                tabla_iteracion.Rows[i]["RND"] = (Math.Truncate(myObject.NextDouble() * 10000)) / 10000;
            }
            dg_iteraciones.DataSource = tabla_iteracion;
            btn_cc.Enabled = true;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            calcularYCargar();
        }

        private void btn_cc_Click(object sender, EventArgs e)
        {
            ChiCuadrado chi_cuadrado = new ChiCuadrado(tabla_iteracion, int.Parse(txt_cantidad.Text), false);
            chi_cuadrado.ShowDialog();
        }

        private void SerieLenguaje_Load(object sender, EventArgs e)
        {

        }
    }
}
