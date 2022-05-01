using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoG_Distribuciones
{
    public partial class Principal : Form
    {

        int n;
        //Tabla con los randoms generados
        DataTable tabla_iteracion = new DataTable();

        public Principal()
        {
            InitializeComponent();
            //Deshabilita todos los textBox
            deshabilitar_todo();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Habilita los cuadros de textos según la selección del usuario
        private void CheckedChanged(object sender, EventArgs e)
        {
            btn_continuar.Enabled = true;
            if (rb_uniforme.Checked)
            {
                deshabilitar_todo_menos_a_y_b(msk_A, msk_B);
            }
            if (rb_normal.Checked)
            {
                deshabilitar_todo_menos_a_y_b(msk_de, msk_media_normal);
                rb_bm.Enabled = true;
                rb_con.Enabled = true;
            }
            if(rb_exponencial.Checked)
            {
                deshabilitar_todo();
                rb_lambda_exp.Enabled = true;
                rb_media_exp.Enabled = true;
                

            }
            if (rb_poisson.Checked)
            {
                deshabilitar_todo_menos_a_y_b(msk_lam_poi, msk_lam_poi);
            }
        }

        private void limpiar_tabla_y_crear_columnas()
        {
            tabla_iteracion.Rows.Clear();
            tabla_iteracion.Columns.Clear();
            //Creo las columnas de la tabla
            DataColumn iteracion = new DataColumn("Iteracion");
            DataColumn rnd = new DataColumn("RND");


            //Agrego las columnas a la tabla
            tabla_iteracion.Columns.Add(iteracion);
            tabla_iteracion.Columns.Add(rnd);
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_cantidad.Text, out n))
            {
                MessageBox.Show("Ingrese un valor numerico entero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if (!(n >= 500 ))
            {
                MessageBox.Show("La cantidad de números debe ser superior a 500 e inferior a 3000", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            //A medida que se calculan los números randoms se determina cual es el valor maximo y minimo
            //de estos, evitando hacer un nuevo recorrido luego
            double maximo = 0;
            double minimo = 0;

            //Calculo UNIFORME
            if (rb_uniforme.Checked)
            {
                double a, b = 0;
                if (!(double.TryParse(msk_A.Text, out a) && (double.TryParse(msk_B.Text, out b))))
                {
                    MessageBox.Show("Ingrese los valores de A y B para la distribución uniforme", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (b < a)
                {
                    MessageBox.Show("Ingrese un valor de B mayor que el valor de A", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                maximo = b;
                minimo = a;

                //Para calcular la media
                double sumador = 0;

                limpiar_tabla_y_crear_columnas();

                Random myObject = new Random();

                //Por la cantidad de numeros a generar, crea una fila y le asigna los valores
                for (int i = 0; i < n; i++)
                {
                    //Creo la fila
                    tabla_iteracion.Rows.Add();

                    //Le asigno los valores
                    tabla_iteracion.Rows[i]["Iteracion"] = i+1;

                    //double random_p = (Math.Truncate(myObject.NextDouble() * 10000)) / 10000;
                    //double x = Math.Truncate((a + (random_p * (b - a))*100)) / 100;

                    double random_p = (myObject.NextDouble());
                    double x = (a + (random_p * (b - a)));

                    sumador += x;

                    tabla_iteracion.Rows[i]["RND"] = x;
                }
                double media = sumador / n;
                Tabla_Datos td = new Tabla_Datos(tabla_iteracion, n, "U", maximo, minimo, media, 0);
                td.ShowDialog();
            }

            if (rb_normal.Checked)
            {                

                if (!(rb_con.Checked) && !(rb_bm.Checked))
                {
                    MessageBox.Show("Seleccione un método de cálculo para la distribución normal", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if(!(double.TryParse(msk_media_normal.Text, out double media) && double.TryParse(msk_de.Text, out double de)))
                {
                    MessageBox.Show("Cargue los valores de media y desviación para la distribución normal", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (de < 0 && de < 100000)
                {
                    MessageBox.Show("La desviación estandar en la distribución normal debe ser positiva y menor a 100000", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                limpiar_tabla_y_crear_columnas();

                double sumador = 0;

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
                        x = Math.Truncate((((x - 6) * de) + media)*100) / 100 ;
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
                        
                        sumador += x;
                        
                        tabla_iteracion.Rows[i]["RND"] = x;
                    }
                    Tabla_Datos td = new Tabla_Datos(tabla_iteracion, n, "N", maximo, minimo, media, de);
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

                        double random_1 = Math.Truncate((((Math.Sqrt(-2 * Math.Log(x1))) * Math.Cos(2 * Math.PI * x2)) * de + media)*100) / 100;
                        double random_2 = Math.Truncate((((Math.Sqrt(-2 * Math.Log(x1))) * Math.Sin(2 * Math.PI * x2)) * de + media)*100) / 100;

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
                    Tabla_Datos td = new Tabla_Datos(tabla_iteracion, n, "N", maximo, minimo, media, de);
                    td.ShowDialog();
                }
            }

            if (rb_exponencial.Checked)
            {
                if (!(rb_media_exp.Checked) && !(rb_lambda_exp.Checked))
                {
                    MessageBox.Show("Seleccione un método de cálculo para la distribución exponencial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                limpiar_tabla_y_crear_columnas();

                Random myObject = new Random();
                double lambda = 0;
                if (rb_media_exp.Checked)
                {
                    if (!double.TryParse(msk_media_exp.Text, out double media))
                    {
                        MessageBox.Show("Ingrese un valor numerico de media para la distribución exponencial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    } 
                    if(media <= 0)
                    {
                        MessageBox.Show("Ingrese un valor positivo para la media de la distribución exponencial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    lambda = 1 / media;
                }
                if (rb_lambda_exp.Checked)
                {
                    if (!double.TryParse(msk_lam_exp.Text, out lambda))
                    {
                        MessageBox.Show("Ingrese un valor numerico de lambda para la distribución exponencial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (lambda <= 0)
                    {
                        MessageBox.Show("Ingrese un valor positivo para el lambda de la distribución exponencial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                //Por la cantidad de numeros a generar, crea una fila y le asigna los valores
                for (int i = 0; i < n; i++)
                {
                    //Creo la fila
                    tabla_iteracion.Rows.Add();

                    //Le asigno los valores
                    tabla_iteracion.Rows[i]["Iteracion"] = i + 1;
                    double random_p = (Math.Truncate(myObject.NextDouble() * 10000)) / 10000;

                    double x = Math.Truncate(((-1/lambda)*(Math.Log(1-random_p)))*100) /100;

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
                Tabla_Datos td = new Tabla_Datos(tabla_iteracion, n, "E", maximo, minimo, (1/lambda), 0);
                td.ShowDialog();
            }
            
            if (rb_poisson.Checked)
            {
                if(!double.TryParse(msk_lam_poi.Text, out double lambda))
                {
                    MessageBox.Show("Ingrese un valor numerico de lambda para la distribución de poisson", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if(lambda <= 0)
                {
                    MessageBox.Show("Ingrese un valor positivo de lambda para la distribución de poisson, menor a 1000", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                limpiar_tabla_y_crear_columnas();

                Random myObject = new Random();

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
                    x = Math.Truncate(x * 100) / 100;


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
                Tabla_Datos td = new Tabla_Datos(tabla_iteracion, n, "P", maximo, minimo, lambda, 0);
                td.ShowDialog();
            }
            
        }

        private void deshabilitar_todo_menos_a_y_b(TextBox a, TextBox b)
        {
            deshabilitar_todo();
            a.Enabled = true;
            b.Enabled = true;
        }

        private void deshabilitar_todo()
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

        private void exponencial_parametro_changed(object sender, EventArgs e)
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
