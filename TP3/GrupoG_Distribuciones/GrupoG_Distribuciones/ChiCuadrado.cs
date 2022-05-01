using Accord.Statistics.Testing;
using MathNet.Numerics.Distributions;
using Microsoft.Reporting.WinForms;
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
    public partial class ChiCuadrado : Form
    {
        //Creo la tabla que contiene los valores observados
        private DataTable tabla_randoms_observados;

        //Creo la tabla que contiene los valores de la prueba de bondad de ajuste
        private DataTable tabla_ajuste = new DataTable();

        //Desviacion estandar ingresada por teclado de la distribucion normal
        double desviacion_estandar_dist_normal;

        //media y varianza de los valores observados
        double media;
        double varianza;

        // Cantidad de numeros ingresados, tipo de distribucion elegida y valores maximo y minimo de la muestra
        private int cantidad_numeros;
        private string tipo_distribucion;
        double maximo, minimo;

        // cantidad de datos empiricos (m) de cada distribucion 
        // uniforme = 0, normal = 2 (media y desviacion), exponencial = 1 (media o lambda), poisson = 1 (media o lambda)
        static private int cantidad_datos_empiricos;

        // Valores tabulados de chi y KS
        double valor_chi_tabulado = 0.0;
        double valor_ks_tabulado = 0.0;

        double valor_chi_tabulado_libreria = 0.0;

        // Valores calculados de chi y KS
        double valor_max_ks;
        double estadistico_de_prueba_acumulado;

        //Resultado de chi y KS
        string resultado;
        string resultado_ks;

        // Cantidad de intervalos maximos (por chi) y cantidad de intervalos ingresados
        int maximo_valor_intervalos = 550000;
        static double cantidad_intervalos = 0;


       private double[] vp_chi = new double[] { 3.8415, 5.9915, 7.8147, 9.4877, 11.0705, 12.5916,
                                                 14.0671, 15.5073, 16.9190, 18.3070, 19.6752, 21.0261,
                                                 22.3620, 23.6848, 24.9958, 26.2962, 27.5871, 28.8693,
                                                 30.1435, 31.4104, 32.6706, 33.9245, 35.1725, 36.4150,
                                                 37.6525, 38.8851, 40.1133, 41.3372, 42.5569, 43.7730,
                                                 44.985,46.194, 47.400, 48.602, 49.802, 50.998, 52.192,
                                                 53.384,54.572,55.758, 56.942, 58.124, 59.304, 60.481,
                                                 61.656,62.830, 64.001, 65.171, 66.339, 67.505, 68.669,
                                                 69.832, 70.993 , 72.153, 73.311 };

        public ChiCuadrado(DataTable tabla, int cantidad_numeros, string tipo_distribucion, double maximo, double minimo, double media, double desviacion_estandar_normal)
        {
            InitializeComponent();
            this.cantidad_numeros = cantidad_numeros;
            this.tabla_randoms_observados = tabla;
            this.tipo_distribucion = tipo_distribucion;
            this.maximo = maximo;
            this.minimo = minimo;
            this.media = media;
            this.desviacion_estandar_dist_normal = desviacion_estandar_normal;
        }

        private void ChiCuadrado_Load(object sender, EventArgs e)
        {
            if (tipo_distribucion != "P")
            {
                // Si no es poisson debe ingresar la cantidad de intervalos
                int max_intervalo = (int)Math.Truncate(Math.Sqrt(cantidad_numeros));
                if (max_intervalo > 55000)
                {
                    lbl_intervalo.Text = "Ingrese la cantidad de intervalos (Debe ser como maximo 55)";
                }
                else
                {
                    lbl_intervalo.Text = "Ingrese la cantidad de intervalos (Sugerimos " + max_intervalo.ToString() + ")";
                }
            }
            else
            {
                // Deshabilito la cantidad de intervalos al ser poisson y muevo los controles mas arriba para que queden alineados
                lbl_nivel_significancia.Location = new Point(lbl_nivel_significancia.Location.X, lbl_nivel_significancia.Location.Y - 30);
                btn_generar.Location = new Point(btn_generar.Location.X, btn_generar.Location.Y - 30);
                lbl_intervalo.Visible = false;
                txt_intervalo.Visible = false;
            }

            this.reporte_chi_cuadrado.RefreshReport();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (tipo_distribucion != "P") 
            { 
                if(!double.TryParse(txt_intervalo.Text.Trim(), out cantidad_intervalos))
                {
                    MessageBox.Show("Ingrese el valor numerico de la cantidad de intervalos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (cantidad_intervalos > maximo_valor_intervalos || cantidad_intervalos < 4)
                {
                    MessageBox.Show("La cantidad de intervalos debe ser menor o igual a " + maximo_valor_intervalos.ToString() + " y mayor a 3", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                cantidad_intervalos = maximo - minimo;
                
            }
            ajuste();
            CargarReporte();
        }

        private void CargarReporte()
        {
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla_ajuste);

            reporte_chi_cuadrado.LocalReport.ReportEmbeddedResource = "GrupoG_Distribuciones.ReporteChiCuadrado.rdlc";
            reporte_chi_cuadrado.LocalReport.DataSources.Clear();
            reporte_chi_cuadrado.LocalReport.DataSources.Add(datos);
            ReportParameter[] parametro = new ReportParameter[9];
            parametro[0] = new ReportParameter("RPMedia", media.ToString());
            parametro[1] = new ReportParameter("RPDesviacion", Math.Sqrt(varianza).ToString());
            parametro[2] = new ReportParameter("RPVarianza", varianza.ToString());
            parametro[3] = new ReportParameter("RPChiCalculado", estadistico_de_prueba_acumulado.ToString());
            parametro[4] = new ReportParameter("RPChiTabulado", valor_chi_tabulado_libreria.ToString());
            parametro[5] = new ReportParameter("RPResultado", resultado);
            parametro[6] = new ReportParameter("RPResultadoKS", resultado_ks);
            parametro[7] = new ReportParameter("RPKSTabulado", valor_ks_tabulado.ToString());
            parametro[8] = new ReportParameter("RPKSCalculado", valor_max_ks.ToString());
            reporte_chi_cuadrado.LocalReport.SetParameters(parametro);
            reporte_chi_cuadrado.RefreshReport();
        }

        private void limpiar_tabla_y_crear_columnas()
        {
            //Limpio las filas y columnas
            tabla_ajuste.Rows.Clear();
            tabla_ajuste.Columns.Clear();

            //Creo las columnas de la tabla
            DataColumn intervalo = new DataColumn("Intervalo");
            DataColumn fo = new DataColumn("FO");
            DataColumn fe = new DataColumn("FE");
            DataColumn mc = new DataColumn("MC");
            DataColumn estadistico = new DataColumn("C");
            DataColumn estadistico_acumulado = new DataColumn("CA");
            DataColumn ks = new DataColumn("KS");
            DataColumn max_ks = new DataColumn("MKS");

            //Agrego las columnas a la tabla
            tabla_ajuste.Columns.Add(intervalo);
            tabla_ajuste.Columns.Add(fo);
            tabla_ajuste.Columns.Add(fe);
            tabla_ajuste.Columns.Add(mc);
            tabla_ajuste.Columns.Add(estadistico);
            tabla_ajuste.Columns.Add(estadistico_acumulado);
            tabla_ajuste.Columns.Add(ks);
            tabla_ajuste.Columns.Add(max_ks);
        }

        private void ajuste()
        {

            limpiar_tabla_y_crear_columnas();

            //Defino un array para almacenar los limites de cada intervalo que al ser x intervalos necesitan x+1 limites
            double[] intervalos_array = new double[(int)(cantidad_intervalos + 1.0)];

            //Defino un array para almacenar la frecuencia esperada de cada intervalo
            double[] fe_array = new double[(int)(cantidad_intervalos)];

            double[] pe_array = new double[(int)(cantidad_intervalos)];
            double po_acumulado = 0.0;
            double pe_acumulado = 0.0;



            //Defino el primer limite que es el mínimo o A en caso de ser uniforme
            if (tipo_distribucion != "P") { 
                intervalos_array[0] = Math.Round(minimo,2);
                intervalos_array[1] = Math.Round((intervalos_array[0] + (maximo - minimo) / cantidad_intervalos) + 0.1, 2);
            

                //Por la cantidad de intervalos, calculo el primer limite distinto de cero, el resto de intervalos se ven multiplicados por i
                for (int i = 2; i < cantidad_intervalos + 1.0; i++)
                {
                    intervalos_array[i] = Math.Round(intervalos_array[i-1] + (maximo-minimo)/cantidad_intervalos, 2) ;
                }
            }


            //Calculo de la Frecuencia Esperada según cada distribución
            if (tipo_distribucion == "U")
            {
                cantidad_datos_empiricos = 0;
                for (int i = 0; i < cantidad_intervalos; i++)
                {
                    pe_array[i] = (cantidad_numeros / cantidad_intervalos) / cantidad_numeros;
                    fe_array[i] = cantidad_numeros / cantidad_intervalos;

                    
                }
            }

            if (tipo_distribucion == "N")
            {
                cantidad_datos_empiricos = 2;
                for (int i = 0; i < cantidad_intervalos; i++)
                {
                    double marca_clase = ((intervalos_array[i + 1] + intervalos_array[i]) / 2);
                    double resta = ((intervalos_array[i + 1] - intervalos_array[i]));
                    double primer_termino = 1 / (desviacion_estandar_dist_normal * (Math.Sqrt(2 * Math.PI)));
                    double segundo_termino = Math.Exp(-0.5 * Math.Pow(((marca_clase - media) / desviacion_estandar_dist_normal), 2));

                    pe_array[i] = ((primer_termino * segundo_termino) * resta);
                    fe_array[i] = ((primer_termino * segundo_termino) * resta) * cantidad_numeros;
                }
            }

            if(tipo_distribucion == "E")
            {
                cantidad_datos_empiricos = 1;
                //=(1-EXP(-Lambda*hasta))-(1-EXP(-Lambda*desde)) * N              

                for (int i = 0; i < cantidad_intervalos; i++)
                {
                    double lambda = 1 / media;
                    double primer_termino = 1 - Math.Exp(-lambda * (intervalos_array[i + 1]));
                    double segundo_termino = 1 - Math.Exp(-lambda * (intervalos_array[i]));

                    pe_array[i] = (primer_termino - segundo_termino);
                    fe_array[i] = (primer_termino - segundo_termino) * cantidad_numeros;
                }
            }


            if(tipo_distribucion == "P")
            {
                cantidad_datos_empiricos = 1;
                fe_array = new double[(int)(maximo - minimo)];
                intervalos_array[0] = Math.Round(minimo, 0);

                //Por la cantidad de intervalos, calculo el primer limite distinto de cero, el resto de intervalos se ven multiplicados por i
                for (int i = 1; i < (maximo - minimo) + 1.0; i++)
                {
                    intervalos_array[i] = Math.Round(minimo + i);
                }

                cantidad_intervalos = (maximo - minimo);
                for (int i = 0; i < (maximo-minimo); i++)
                {
                    double dividendo_pe = ((Math.Pow(media, (i + minimo))) * Math.Exp(-media));
                    pe_array[i] = division_por_factorial(dividendo_pe, i+(int)minimo);

                    double dividendo_fe = ((Math.Pow(media, (i + minimo))) * Math.Exp(-media));
                    fe_array[i] = Math.Round(((division_por_factorial(dividendo_fe, i+(int)minimo)))*cantidad_numeros, 0);
                }
            }

            //Defino un array que contenga la cantidad de valores observados
            int[] valores_observados = new int[(int)cantidad_intervalos];

            int columna_de_rnd = 1;

            double sumador = 0.0;

            //Por cada fila de la tabla de iteraciones observo en que intervalo cae el valor observado
            for (int i = 0; i < tabla_randoms_observados.Rows.Count; i++)
            {
                //valor observado
                double random_observado = Convert.ToDouble(tabla_randoms_observados.Rows[i][columna_de_rnd].ToString());
                sumador += random_observado;
                //comparo los limites contra los random generados
                for (int j = 0; j < intervalos_array.Length - 1; j++)
                {
                    if (random_observado >= intervalos_array[j] && random_observado < intervalos_array[j + 1])
                    {
                        valores_observados[j] += 1;
                        break;
                    }
                }
            }

            double sumatoria = 0;
            for (int i = 0; i < cantidad_numeros; i++)
            {
                double random_observado = Convert.ToDouble(tabla_randoms_observados.Rows[i][columna_de_rnd].ToString());
                double resta = Math.Pow((random_observado - media), 2.0);
                sumatoria += resta;
            }
            varianza = sumatoria / (double)cantidad_numeros;

            //defino el estadistico de prueba acumulado

            valor_max_ks = 0.0;
            estadistico_de_prueba_acumulado = 0.0;

            //Lista que contiene los valores observados y esperados agrupados para que la fe sea mayor a 5
            List<double[]> valores_chi_frecuencia = new List<double[]>();

            for (int i = 0; i < cantidad_intervalos; i++)
            {
                //Creo la fila
                tabla_ajuste.Rows.Add();

                //le agrego el intervalo
                if (tipo_distribucion != "P")
                    tabla_ajuste.Rows[i]["Intervalo"] = intervalos_array[i].ToString() + " - " + intervalos_array[i + 1].ToString();
                else
                    tabla_ajuste.Rows[i]["Intervalo"] = intervalos_array[i];

                //le agrego la frecuencia observada
                tabla_ajuste.Rows[i]["FO"] = valores_observados[i];

                //le agrego la frecuencia esperada
                tabla_ajuste.Rows[i]["FE"] = fe_array[i];

                //Calculamos la marca de clase
                tabla_ajuste.Rows[i]["MC"] = ((intervalos_array[i + 1] + intervalos_array[i]) / 2);

                //le agrego el estadistico de prueba
                double resta_de_frecuencias = fe_array[i] - (double)valores_observados[i];
                double resta_al_cuadrado = (Math.Pow(resta_de_frecuencias, 2.0));
                double estadistico_de_prueba;
                if (!(fe_array[i] == 0.0))
                {
                    estadistico_de_prueba = Math.Round(resta_al_cuadrado / fe_array[i], 4);
                }
                else
                {
                    estadistico_de_prueba = 0.0;
                }
                tabla_ajuste.Rows[i]["C"] = estadistico_de_prueba;

                //le agrego el estadistico de prueba acumulado
                estadistico_de_prueba_acumulado += estadistico_de_prueba;
                tabla_ajuste.Rows[i]["CA"] = estadistico_de_prueba_acumulado;

                //Calculo de KS
                po_acumulado += ((double)valores_observados[i] / (double)cantidad_numeros);
                pe_acumulado += pe_array[i];
                double valor_ks = Math.Abs(po_acumulado - pe_acumulado);

                tabla_ajuste.Rows[i]["KS"] = valor_ks;

                if (valor_ks > valor_max_ks)
                {
                    valor_max_ks = valor_ks;
                }
                tabla_ajuste.Rows[i]["MKS"] = valor_max_ks;



                if (valores_chi_frecuencia.Count == 0)
                {
                    double[] array_auxiliar = new double[2] {valores_observados[i] , fe_array[i] };
                    valores_chi_frecuencia.Add(array_auxiliar);
                }
                else
                {
                    int tamaño_lista = valores_chi_frecuencia.Count - 1;
                    if (valores_chi_frecuencia.ElementAt(tamaño_lista)[1] < 5)
                    {
                        //valores_chi_frecuencia.ElementAt(tamaño_lista)[0] += valores_observados[i];
                        //valores_chi_frecuencia.ElementAt(tamaño_lista)[1] += fe_array[i];
                        valores_chi_frecuencia.Last()[0] += valores_observados[i];
                        valores_chi_frecuencia.Last()[1] += fe_array[i];

                    }
                    else
                    {
                        double[] array_auxiliar_2 = new double[2] { (double)valores_observados[i], fe_array[i] };
                        valores_chi_frecuencia.Add(array_auxiliar_2);
                    }
                }                
            }

            if (valores_chi_frecuencia.Last()[1] < 5)
            {
                int penultimo_valor = valores_chi_frecuencia.Count - 2;
                valores_chi_frecuencia.ElementAt(penultimo_valor)[0] += valores_chi_frecuencia.Last()[0];
                valores_chi_frecuencia.ElementAt(penultimo_valor)[1] += valores_chi_frecuencia.Last()[1];
                valores_chi_frecuencia.RemoveAt(valores_chi_frecuencia.Count - 1);
            }

            int cantidad_intervalos_agr = valores_chi_frecuencia.Count;
            double[] array_valores_esperados_agrupados = new double[cantidad_intervalos_agr];
            double[] array_valores_observados_agrupados = new double[cantidad_intervalos_agr];
            estadistico_de_prueba_acumulado = 0.0;
            for (int i = 0; i < cantidad_intervalos_agr; i++)
            {
                double resta_de_frecuencias = valores_chi_frecuencia.ElementAt(i)[1] - valores_chi_frecuencia.ElementAt(i)[0];
                double resta_al_cuadrado = (Math.Pow(resta_de_frecuencias, 2.0));
                estadistico_de_prueba_acumulado += Math.Round(resta_al_cuadrado / valores_chi_frecuencia.ElementAt(i)[1], 4);
                array_valores_observados_agrupados[i] = valores_chi_frecuencia.ElementAt(i)[0];
                array_valores_esperados_agrupados[i] = valores_chi_frecuencia.ElementAt(i)[1];
            }

            double grados_de_libertad_libreria = (double)(cantidad_intervalos_agr - 1 - cantidad_datos_empiricos);
            valor_chi_tabulado_libreria = ChiSquared.InvCDF(grados_de_libertad_libreria, 0.95);
            if (estadistico_de_prueba_acumulado <= valor_chi_tabulado_libreria)
            {
                resultado = " No se puede rechazar la hipótesis";
            }
            else
            {
                resultado = " La hipótesis es rechazada ";
            }
            
            /*
            if (significant)
            {
                resultado = " No se puede rechazar la hipótesis";
            }
            else
            {
                resultado = " La hipótesis es rechazada ";
            }
            */


            //Resultado KS
            valor_ks_tabulado = 1.36 / Math.Sqrt(cantidad_numeros);
            if (valor_max_ks <= valor_ks_tabulado)
            {
                resultado_ks = " No se puede rechazar la hipótesis";
            }
            else
            {
                resultado_ks = " La hipótesis es rechazada ";
            }
        }

        private double division_por_factorial(double dividendo, int n)
        {
            for (int i = 1; i <= n; i++) {
                {
                    dividendo = dividendo / (double)i;
                }
            }

            return dividendo;
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
