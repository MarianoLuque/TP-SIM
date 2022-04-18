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
            todo_des();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            btn_continuar.Enabled = true;
            if (rb_uniforme.Checked)
            {
                des(msk_A, msk_B);
            }
            if (rb_normal.Checked)
            {
                des(msk_de, msk_media_normal);
            }
            if(rb_exponencial.Checked)
            {
                des(msk_lam_exp, msk_media_exp);
            }
            if (rb_poisson.Checked)
            {
                des(msk_lam_poi, msk_media_poi);
            }
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if(!(int.Parse(txt_cantidad.Text) >= 500))
            {
                MessageBox.Show("La cantidad de números debe ser superior a 500");
                return;
            }
            
            
            DataTable tabla_iteracion = new DataTable();
            if (rb_uniforme.Checked)
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
                Int64 a = Int64.Parse(msk_A.Text);
                Int64 b = Int64.Parse(msk_B.Text);

                //Por la cantidad de numeros a generar, crea una fila y le asigna los valores
                for (int i = 0; i < int.Parse(txt_cantidad.Text); i++)
                {
                    //Creo la fila
                    tabla_iteracion.Rows.Add();

                    //Le asigno los valores
                    tabla_iteracion.Rows[i]["Iteracion"] = i+1;
                    double random_p = (Math.Truncate(myObject.NextDouble() * 10000)) / 10000;
                    double x = (a + (random_p * (b - a)));
                    tabla_iteracion.Rows[i]["RND"] = x;
                }
                Tabla_Datos td = new Tabla_Datos(tabla_iteracion);
                td.ShowDialog();
            }
            if (rb_exponencial.Checked)
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
                Int64 lambda = Int64.Parse(msk_lam_exp.Text);

                //Por la cantidad de numeros a generar, crea una fila y le asigna los valores
                for (int i = 0; i < int.Parse(txt_cantidad.Text); i++)
                {
                    //Creo la fila
                    tabla_iteracion.Rows.Add();

                    //Le asigno los valores
                    tabla_iteracion.Rows[i]["Iteracion"] = i + 1;
                    double random_p = (Math.Truncate(myObject.NextDouble() * 10000)) / 10000;
                    double asd = -1 / lambda;
                    //MessageBox.Show(random_p.ToString());
                    double x = (-1/lambda)*(Math.Log(1-random_p));
                    //MessageBox.Show(x.ToString());
                    tabla_iteracion.Rows[i]["RND"] = x;
                }
                Tabla_Datos td = new Tabla_Datos(tabla_iteracion);
                td.ShowDialog();
            }
            if (rb_exponencial.Checked)
            {
                des(msk_lam_exp, msk_media_exp);
            }
            if (rb_poisson.Checked)
            {
                des(msk_lam_poi, msk_media_poi);
            }

        }

        private void des(MaskedTextBox a, MaskedTextBox b)
        {
            todo_des();
            a.Enabled = true;
            b.Enabled = true;
        }

        private void todo_des()
        {
            msk_A.Enabled = false;
            msk_B.Enabled = false;
            msk_de.Enabled = false;
            msk_lam_exp.Enabled = false;
            msk_lam_poi.Enabled = false;
            msk_media_exp.Enabled = false;
            msk_media_normal.Enabled = false;
            msk_media_poi.Enabled = false;

            msk_A.Clear();
            msk_B.Clear();
            msk_de.Clear();
            msk_lam_exp.Clear();
            msk_lam_poi.Clear();
            msk_media_exp.Clear();
            msk_media_poi.Clear();
            msk_media_normal.Clear();
        }
    }
}
