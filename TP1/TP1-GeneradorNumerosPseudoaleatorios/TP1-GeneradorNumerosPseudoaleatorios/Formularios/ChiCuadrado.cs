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
using TP1_GeneradorNumerosPseudoaleatorios.Formularios;

namespace TP1_GeneradorNumerosPseudoaleatorios.Formularios
{
    public partial class ChiCuadrado : Form
    {
        //Creo la tabla de las iteraciones
        double media = 0.0;
        double varianza;
        DataTable tabla_ajuste;
        private bool serie_propia;
        private Int64 cantidad_numeros;
        private DataTable tabla_iteracion;
        double valor_chi_tabulado = 0.0;
        double estadistico_de_prueba_acumulado = 0.0;
        string resultado;

        private double[] vp_chi = new double[] { 3.8415, 5.9915, 7.8147, 9.4877, 11.0705, 12.5916,
                                                 14.0671, 15.5073, 16.9190, 18.3070, 19.6752, 21,0261,
                                                 22.3620, 23.6848, 24.9958, 26.2962, 27.5871, 28.8693,
                                                 30.1435, 31.4104, 32.6706, 33.9245, 35.1725, 36.4150,
                                                 37.6525, 38.8851, 40.1133, 41.3372, 42.5569, 43.7730};

        public ChiCuadrado(DataTable tabla, Int64 cantidad_numeros, bool serie_propia)
        {
            InitializeComponent();
            this.cantidad_numeros = cantidad_numeros;
            this.tabla_iteracion = tabla;
            this.serie_propia = serie_propia;
        }

        private void ChiCuadrado_Load(object sender, EventArgs e)
        {
            int max_intervalo = (int)Math.Truncate(Math.Sqrt(cantidad_numeros));
            if(max_intervalo > 32)
            {
                lbl_intervalo.Text = "Ingrese la cantidad de intervalos (Debe ser como maximo 31)";
            }
            else
            {
                lbl_intervalo.Text = "Ingrese la cantidad de intervalos (Sugerimos " + max_intervalo.ToString() + ")";
            }
            
            this.reporte_chi_cuadrado.RefreshReport();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            ajuste();
            CargarReporte();
        }

        private void CargarReporte()
        {
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla_ajuste);

            reporte_chi_cuadrado.LocalReport.ReportEmbeddedResource = "TP1_GeneradorNumerosPseudoaleatorios.Formularios.ReporteChiCuadrado.rdlc";
            reporte_chi_cuadrado.LocalReport.DataSources.Clear();
            reporte_chi_cuadrado.LocalReport.DataSources.Add(datos);
            ReportParameter[] parametro = new ReportParameter[6];
            parametro[0] = new ReportParameter("RPMedia", media.ToString());
            parametro[1] = new ReportParameter("RPDesviacion", Math.Sqrt(varianza).ToString());
            parametro[2] = new ReportParameter("RPVarianza", varianza.ToString());
            parametro[3] = new ReportParameter("RPChiCalculado", estadistico_de_prueba_acumulado.ToString());
            parametro[4] = new ReportParameter("RPChiTabulado", valor_chi_tabulado.ToString());
            parametro[5] = new ReportParameter("RPResultado", resultado);
            reporte_chi_cuadrado.LocalReport.SetParameters(parametro);
            reporte_chi_cuadrado.RefreshReport();
        }

        private void ajuste()
        {
            //Creo la tabla de las iteraciones
            tabla_ajuste = new DataTable();

            //Creo las columnas de la tabla
            DataColumn intervalo = new DataColumn("Intervalo");
            DataColumn fo = new DataColumn("FO");
            DataColumn fe = new DataColumn("FE");
            DataColumn mc = new DataColumn("MC");
            DataColumn estadistico = new DataColumn("C");
            DataColumn estadistico_acumulado = new DataColumn("CA");


            //Agrego las columnas a la tabla
            tabla_ajuste.Columns.Add(intervalo);
            tabla_ajuste.Columns.Add(fo);
            tabla_ajuste.Columns.Add(fe);
            tabla_ajuste.Columns.Add(mc);
            tabla_ajuste.Columns.Add(estadistico);
            tabla_ajuste.Columns.Add(estadistico_acumulado);

            //Calculo la cantidad de intervalos que es la raiz de n
            double cantidad_intervalos = int.Parse(txt_intervalo.Text.Trim());

            //Defino un array para almacenar los limites de cada intervalo que al ser x intervalos necesitan x+1 limites
            double[] intervalos_array = new double[(int)(cantidad_intervalos + 1.0)];

            //Defino el primer limite que es cero
            intervalos_array[0] = 0.0;

            //valor esperado
            double valor_esperado = cantidad_numeros / cantidad_intervalos;
            if (valor_esperado < 5.0)
            {
                cantidad_intervalos = cantidad_numeros / 5;
                valor_esperado = cantidad_numeros / cantidad_intervalos;
            }

            //Por la cantidad de intervalos, calculo el primer limite distinto de cero, el resto de intervalos se ven multiplicados por i
            for (int i = 1; i < cantidad_intervalos + 1.0; i++)
            {
                intervalos_array[i] = Math.Round((1.0 / cantidad_intervalos) * i, 4);
            }           

            //Defino un array que contenga la cantidad de valores observados
            int[] valores_observados = new int[(int)cantidad_intervalos];

            int columna_de_rnd;
            if (serie_propia)
            {
                columna_de_rnd = 3;
            }
            else
            {
                columna_de_rnd = 1;
            }

            double sumador = 0.0;

            //Por cada fila de la tabla de iteraciones observo en que intervalo cae el valor observado
            for (int i = 0; i < tabla_iteracion.Rows.Count; i++)
            {
                //valor observado
                double random_observado = Convert.ToDouble(tabla_iteracion.Rows[i][columna_de_rnd].ToString());
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
            media = sumador / (double)cantidad_numeros;
            double sumatoria = 0;
            for (int i = 0; i < cantidad_numeros; i++)
            {
                double random_observado = Convert.ToDouble(tabla_iteracion.Rows[i][columna_de_rnd].ToString());
                double resta = Math.Pow((random_observado - media), 2.0);
                sumatoria += resta;
            }
            varianza = sumatoria / (double)cantidad_numeros;

            //defino el estadistico de prueba acumulado
            

            for (int i = 0; i < cantidad_intervalos; i++)
            {
                //Creo la fila
                tabla_ajuste.Rows.Add();

                //le agrego el intervalo
                tabla_ajuste.Rows[i]["Intervalo"] = intervalos_array[i].ToString() + " - " + intervalos_array[i + 1].ToString();

                //le agrego la frecuencia observada
                tabla_ajuste.Rows[i]["FO"] = valores_observados[i];

                //le agrego la frecuencia esperada
                tabla_ajuste.Rows[i]["FE"] = Math.Round(valor_esperado, 0);

                //Calculamos la marca de clase
                tabla_ajuste.Rows[i]["MC"] = ((intervalos_array[i + 1] + intervalos_array[i]) / 2);

                //le agrego el estadistico de prueba
                double resta_de_frecuencias = valor_esperado - valores_observados[i];
                double resta_al_cuadrado = (Math.Pow(2.0, resta_de_frecuencias));
                double estadistico_de_prueba = Math.Round(resta_al_cuadrado / valor_esperado, 4);
                tabla_ajuste.Rows[i]["C"] = estadistico_de_prueba;

                //le agrego el estadistico de prueba acumulado
                estadistico_de_prueba_acumulado += estadistico_de_prueba;
                tabla_ajuste.Rows[i]["CA"] = estadistico_de_prueba_acumulado;
            }

            if (cantidad_intervalos > 31)
            {
                MessageBox.Show("La cantidad de intervalos debe ser menor a 31", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            valor_chi_tabulado = vp_chi[(int)cantidad_intervalos - 1];

            if (estadistico_de_prueba_acumulado <= valor_chi_tabulado)
            {
                resultado = " No se puede rechazar la hipótesis";
            }
            else
            {
                resultado = " La hipótesis es rechazada ";
            }

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
