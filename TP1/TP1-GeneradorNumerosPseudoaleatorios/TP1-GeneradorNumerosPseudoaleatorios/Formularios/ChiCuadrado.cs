﻿using Microsoft.Reporting.WinForms;
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
        DataTable tabla_ajuste = new DataTable();

        private int cantidad_numeros;
        private DataTable tabla_iteracion;
        public ChiCuadrado(DataTable tabla, int cantidad_numeros)
        {
            InitializeComponent();
            this.cantidad_numeros = cantidad_numeros;
            this.tabla_iteracion = tabla;
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChiCuadrado_Load(object sender, EventArgs e)
        {
            lbl_intervalo.Text = "Ingrese la cantidad de intervalos (Sugerimos " + Math.Truncate(Math.Sqrt(cantidad_numeros)).ToString() + ")";
            reporte_chi_cuadrado.RefreshReport();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void CargarReporte()
        {
            ReportDataSource datos = new ReportDataSource("DataSetCC", tabla_ajuste);

            reporte_chi_cuadrado.LocalReport.ReportEmbeddedResource = "TP1-GeneradorNumerosPseudoaleatorios.Formularios.ReporteChiCuadrado.rdlc";
            reporte_chi_cuadrado.LocalReport.DataSources.Clear();
            reporte_chi_cuadrado.LocalReport.DataSources.Add(datos);
            reporte_chi_cuadrado.RefreshReport();
        }

        private void btn_prueba_ajuste_Click(object sender, EventArgs e)
        {
            //Creo las columnas de la tabla
            DataColumn intervalo = new DataColumn("Intervalo");
            DataColumn fo = new DataColumn("FO");
            DataColumn fe = new DataColumn("FE");
            DataColumn estadistico = new DataColumn("C");
            DataColumn estadistico_acumulado = new DataColumn("CA");


            //Agrego las columnas a la tabla
            tabla_ajuste.Columns.Add(intervalo);
            tabla_ajuste.Columns.Add(fo);
            tabla_ajuste.Columns.Add(fe);
            tabla_ajuste.Columns.Add(estadistico);
            tabla_ajuste.Columns.Add(estadistico_acumulado);

            //Calculo la cantidad de intervalos que es la raiz de n
            double cantidad_intervalos = int.Parse(txt_intervalo.Text);

            //Defino un array para almacenar los limites de cada intervalo que al ser x intervalos necesitan x+1 limites
            double[] intervalos_array = new double[(int)(cantidad_intervalos + 1.0)];

            //Defino el primer limite que es cero
            intervalos_array[0] = 0.0;

            //Por la cantidad de intervalos, calculo el primer limite distinto de cero, el resto de intervalos se ven multiplicados por i
            for (int i = 1; i < cantidad_intervalos + 1.0; i++)
            {
                intervalos_array[i] = Math.Round((1.0 / cantidad_intervalos) * i, 4);
            }

            //valor esperado
            double valor_esperado = cantidad_numeros / cantidad_intervalos;

            //Defino un array que contenga la cantidad de valores observados
            int[] valores_observados = new int[(int)cantidad_intervalos];

            //Por cada fila de la tabla de iteraciones observo en que intervalo cae el valor observado
            for (int i = 0; i < tabla_iteracion.Rows.Count; i++)
            {
                //valor observado
                double random_observado = Convert.ToDouble(tabla_iteracion.Rows[i][3].ToString());

                //comparo los limites contra los random generados
                for (int j = 0; j < intervalos_array.Length - 1; j++)
                {
                    if (random_observado >= intervalos_array[j] && random_observado < intervalos_array[j + 1])
                    {
                        valores_observados[j] += 1;
                    }
                }
            }

            //defino el estadistico de prueba acumulado
            double estadistico_de_prueba_acumulado = 0.0;

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

                //le agrego el estadistico de prueba
                double resta_de_frecuencias = valor_esperado - valores_observados[i];
                double resta_al_cuadrado = (Math.Pow(2.0, resta_de_frecuencias));
                double estadistico_de_prueba = Math.Round(resta_al_cuadrado / valor_esperado, 4);
                tabla_ajuste.Rows[i]["C"] = estadistico_de_prueba;

                //le agrego el estadistico de prueba acumulado
                estadistico_de_prueba_acumulado += estadistico_de_prueba;
                tabla_ajuste.Rows[i]["CA"] = estadistico_de_prueba_acumulado;
            }

        }
    }
}
