﻿using System;
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
                rb_bm.Enabled = true;
                rb_con.Enabled = true;
            }
            if(rb_exponencial.Checked)
            {
                todo_des();
                rb_lambda_exp.Enabled = true;
                rb_media_exp.Enabled = true;
                

            }
            if (rb_poisson.Checked)
            {
                des(msk_lam_poi, msk_lam_poi);
            }
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt_cantidad.Text);
            double maximo = 0;
            double minimo = 0;

            if (txt_cantidad.Text == "" || !(n >= 500))
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
                maximo = b;
                minimo = a;

                //Por la cantidad de numeros a generar, crea una fila y le asigna los valores
                for (int i = 0; i < n; i++)
                {
                    //Creo la fila
                    tabla_iteracion.Rows.Add();

                    //Le asigno los valores
                    tabla_iteracion.Rows[i]["Iteracion"] = i+1;
                    double random_p = (Math.Truncate(myObject.NextDouble() * 10000)) / 10000;
                    double x = (a + (random_p * (b - a)));
                    tabla_iteracion.Rows[i]["RND"] = x;
                }
                Tabla_Datos td = new Tabla_Datos(tabla_iteracion, n, "U", maximo, minimo);
                td.ShowDialog();
            }

            if (rb_normal.Checked)
            {                

                if (!(rb_con.Checked) && !(rb_bm.Checked))
                {
                    MessageBox.Show("Seleccione un método de cálculo");
                    return;
                }

                tabla_iteracion.Rows.Clear();
                tabla_iteracion.Columns.Clear();
                //Creo las columnas de la tabla
                DataColumn iteracion = new DataColumn("Iteracion");
                DataColumn rnd = new DataColumn("RND");


                //Agrego las columnas a la tabla
                tabla_iteracion.Columns.Add(iteracion);
                tabla_iteracion.Columns.Add(rnd);

                double media = double.Parse(msk_media_normal.Text);
                double de = double.Parse(msk_de.Text);
                
                Random myObject = new Random();


                if (rb_con.Checked)
                {

                    //Por la cantidad de numeros a generar, crea una fila y le asigna los valores
                    for (int i = 0; i < n; i++)
                    {
                        //Creo la fila
                        tabla_iteracion.Rows.Add();

                        //Le asigno los valores
                        tabla_iteracion.Rows[i]["Iteracion"] = i + 1;
                        double x = 0;
                        for (int j = 0; j < 12; j++)
                        {
                            x += (Math.Truncate(myObject.NextDouble() * 10000)) / 10000;
                        }
                        x = ((x - 6) * de) + media;
                        if (i == 0)
                        {
                            maximo = x;
                            minimo = x;
                        }
                        else
                        {
                            if (x > maximo)
                            {
                                maximo = x;
                            }
                            if (x < minimo)
                            {
                                minimo = x;
                            }
                        }
                        tabla_iteracion.Rows[i]["RND"] = x;
                    }
                    Tabla_Datos td = new Tabla_Datos(tabla_iteracion, n, "N", maximo, minimo);
                    td.ShowDialog();
                }

                if (rb_bm.Checked)
                {
                    //Por la cantidad de numeros a generar, crea una fila y le asigna los valores
                    for (int i = 0; i < n; i+=2)
                    {
                        //Creo la fila
                        tabla_iteracion.Rows.Add();
                        tabla_iteracion.Rows.Add();

                        //Le asigno los valores
                        tabla_iteracion.Rows[i]["Iteracion"] = i + 1;
                        tabla_iteracion.Rows[i+1]["Iteracion"] = i + 2;
                        
                        double x1 = (Math.Truncate(myObject.NextDouble() * 10000)) / 10000;
                        double x2 = (Math.Truncate(myObject.NextDouble() * 10000)) / 10000;

                        double random_1 = ((Math.Sqrt(-2 * Math.Log(x1))) * Math.Cos(2 * Math.PI * x2)) * de + media;
                        double random_2 = ((Math.Sqrt(-2 * Math.Log(x1))) * Math.Sin(2 * Math.PI * x2)) * de + media;

                        tabla_iteracion.Rows[i]["RND"] = random_1;
                        if(!(n%2 == 0) && (n-1) == i)
                        {
                            tabla_iteracion.Rows.Remove(tabla_iteracion.Rows[i+1]);
                            break;
                        }
                        tabla_iteracion.Rows[i + 1]["RND"] = random_2;
                        if (i == 0)
                        {
                            if (random_1 < random_2)
                            {
                                maximo = random_2;
                                minimo = random_1;
                            }
                            else
                            {
                                maximo = random_1;
                                minimo = random_2;
                            }
                        }
                        else
                        {
                            if(random_1 < random_2)
                            {
                                if (random_2 > maximo)
                                {
                                    maximo = random_2;
                                }
                                if (random_1 < minimo)
                                {
                                    minimo = random_1;
                                }
                            }
                            else
                            {
                                if (random_1 > maximo)
                                {
                                    maximo = random_1;
                                }
                                if (random_2 < minimo)
                                {
                                    minimo = random_2;
                                }
                            }
                        }
                    }
                    Tabla_Datos td = new Tabla_Datos(tabla_iteracion, n, "N", maximo, minimo);
                    td.ShowDialog();
                }
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
                double lambda = 0;
                if (rb_media_exp.Checked)
                {
                    double media = Int64.Parse(msk_media_exp.Text);
                    lambda = 1 / media;
                }
                if (rb_lambda_exp.Checked)
                {
                    lambda = Int64.Parse(msk_lam_exp.Text);
                }

                //Por la cantidad de numeros a generar, crea una fila y le asigna los valores
                for (int i = 0; i < n; i++)
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
                    if (i == 0)
                    {
                        maximo = x;
                        minimo = x;
                    }
                    else
                    {
                        if (x > maximo)
                        {
                            maximo = x;
                        }
                        if (x < minimo)
                        {
                            minimo = x;
                        }
                    }

                }
                Tabla_Datos td = new Tabla_Datos(tabla_iteracion, n, "E", maximo, minimo);
                td.ShowDialog();
            }
            
            if (rb_poisson.Checked)
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
                Int64 lambda = Int64.Parse(msk_lam_poi.Text);
                
                

                //Por la cantidad de numeros a generar, crea una fila y le asigna los valores
                for (int i = 0; i < n; i++)
                {
                    //Creo la fila
                    tabla_iteracion.Rows.Add();

                    //Le asigno los valores
                    tabla_iteracion.Rows[i]["Iteracion"] = i + 1;
                    double p = 1;
                    double x = -1;
                    double A = Math.Exp(-lambda);
                    do
                    {
                        double random_p = (Math.Truncate(myObject.NextDouble() * 10000)) / 10000;
                        p = (p * random_p);
                        x = x + 1;
                    } while (p >= A);
                    //MessageBox.Show(x.ToString());
                    tabla_iteracion.Rows[i]["RND"] = x;
                    if (i == 0)
                    {
                        maximo = x;
                        minimo = x;
                    }
                    else
                    {
                        if (x > maximo)
                        {
                            maximo = x;
                        }
                        if (x < minimo)
                        {
                            minimo = x;
                        }
                    }
                }
                Tabla_Datos td = new Tabla_Datos(tabla_iteracion, n, "P", maximo, minimo);
                td.ShowDialog();
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
            rb_lambda_exp.Enabled = false;
            rb_media_exp.Enabled = false;
            rb_bm.Enabled = false;
            rb_con.Enabled = false;

            msk_A.Clear();
            msk_B.Clear();
            msk_de.Clear();
            msk_lam_exp.Clear();
            msk_lam_poi.Clear();
            msk_media_exp.Clear();
            msk_media_normal.Clear();
            rb_media_exp.Checked = false;
            rb_lambda_exp.Checked = false;
            rb_bm.Checked = false;
            rb_con.Checked = false;
        }

        private void media_lambda_changed(object sender, EventArgs e)
        {
            if (rb_lambda_exp.Checked)
            {
                msk_lam_exp.Enabled = true;
                msk_media_exp.Enabled = false;
            }
            if (rb_media_exp.Checked)
            {
                msk_lam_exp.Enabled = false;
                msk_media_exp.Enabled = true;
            }
        }

        private void box_con_changed(object sender, EventArgs e)
        {

        }
    }
}