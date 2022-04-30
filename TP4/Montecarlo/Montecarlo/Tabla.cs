using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Montecarlo
{
    public partial class Tabla : Form
    {
        //Variables importadas
        long cantidad_iteraciones;
        int cantidad_muelles;
        int costo_media_descarga;
        int costo_desviacion_descarga;
        int costo_por_noche;
        int costo_muelle_desocupado;
        int dist_uniforme_a;
        int dist_uniforme_b;
        int dist_poisson_barcos;
        int dist_poisson_hs;
        DataTable tabla_nro_llegadas;
        DataTable tabla_nro_descargas;

        //Variables creadas
        DataTable tabla = new DataTable();
        int simulacion_desde;
        List<object> iteracion_anterior = new List<object> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        List<object> iteracion_actual = new List<object>();

        int barcos_no_descargados;
        decimal costo_acumulado;
        int costo_por_noche_por_barco;
        int costo_por_muelle_vacio;
        double costo_total;
        int j = 0;

        double rnd_llegadas;
        double rnd_descargas;
        double rnd_costo_descargas;

        int nro_llegadas;
        int nro_descargas;
        double costo_descarga;

        public Tabla(long cantidad_iteraciones, int cantidad_muelles, int costo_media_descarga, int costo_desviacion_descarga, int costo_por_noche, int costo_muelle_desocupado, int dist_uniforme_a, int dist_uniforme_b, int dist_poisson_barcos, int dist_poisson_hs, DataTable tabla_llegadas, DataTable tabla_descargas)
        {
            InitializeComponent();
            this.cantidad_iteraciones = cantidad_iteraciones;
            this.cantidad_muelles = cantidad_muelles;
            this.costo_media_descarga = costo_media_descarga;
            this.costo_desviacion_descarga = costo_desviacion_descarga;
            this.costo_por_noche = costo_por_noche;
            this.costo_muelle_desocupado = costo_muelle_desocupado;
            this.dist_uniforme_a = dist_uniforme_a;
            this.dist_uniforme_b = dist_uniforme_b;
            this.dist_poisson_barcos = dist_poisson_barcos;
            this.dist_poisson_hs = dist_poisson_hs;
            this.tabla_nro_llegadas = tabla_llegadas;
            this.tabla_nro_descargas = tabla_descargas;
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txt_desde.Text, out simulacion_desde))
            {
                MessageBox.Show("Ingrese desde que simulación se debe mostrar");
                return;
            }
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            cargar_tabla();
            cargar_datos();
            dg_montecarlo.DataSource = tabla;

        }

        //hacer calculos con iteracion_actual utilizando los valores que necesite de la anterior
        //iteracion_anterior = iteracion_actual
        private void cargar_datos()
        {
            for (int i = 0; i < cantidad_iteraciones; i++)
            {
                Random myObject = new Random(1);
                Random myObject1 = new Random(100);
                Random myObject2 = new Random(1000);
                rnd_llegadas = (Math.Truncate(myObject.NextDouble() * 100)) / 100;

                rnd_descargas = (Math.Truncate(myObject1.NextDouble() * 100)) / 100;
                rnd_costo_descargas = (Math.Truncate(myObject2.NextDouble() * 100)) / 100;
                if (cantidad_muelles == 1)
                {
                    //Veo en que intervalo cae el rnd de las llegadas
                    if(rnd_llegadas <= 0.12)
                    {
                        nro_llegadas = 0;
                    }
                    else if(rnd_llegadas <= 0.29)
                    {
                        nro_llegadas = 1;
                    }
                    else if (rnd_llegadas <= 0.44)
                    {
                        nro_llegadas = 2;
                    }
                    else if (rnd_llegadas <= 0.69)
                    {
                        nro_llegadas = 3;
                    }
                    else if (rnd_llegadas <= 0.89)
                    {
                        nro_llegadas = 4;
                    }
                    else if (rnd_llegadas <= 0.99)
                    {
                        nro_llegadas = 5;
                    }

                    //Veo en que intervalo cae el rnd de las descargas
                    if (rnd_descargas <= 0.04)
                    {
                        nro_descargas = 1;
                    }
                    else if (rnd_descargas <= 0.19)
                    {
                        nro_descargas = 2;
                    }
                    else if (rnd_descargas <= 0.69)
                    {
                        nro_descargas = 3;
                    }
                    else if (rnd_descargas <= 0.89)
                    {
                        nro_descargas = 4;
                    }
                    else if (rnd_descargas <= 0.99)
                    {
                        nro_descargas = 5;
                    }

                    for (int j = 0; j < 12; j++)
                    {
                        rnd_costo_descargas += (Math.Truncate(myObject.NextDouble() * 10000)) / 10000;
                    }
                    costo_descarga = Math.Truncate((((rnd_costo_descargas - 6) * costo_desviacion_descarga) + costo_media_descarga) * 100) / 100;
                    
                    if (barcos_no_descargados == 0 && nro_llegadas == 0) { costo_por_muelle_vacio = costo_muelle_desocupado; }
                    else { costo_por_muelle_vacio = 0; }

                    int cant_llegadas_menos_cant_descargas = barcos_no_descargados + nro_llegadas - nro_descargas;
                    if(cant_llegadas_menos_cant_descargas < 0){ barcos_no_descargados = 0;}
                    else { barcos_no_descargados = cant_llegadas_menos_cant_descargas; }

                    costo_por_noche_por_barco = barcos_no_descargados * costo_por_noche;

                    costo_total = costo_por_noche_por_barco + costo_por_muelle_vacio + costo_descarga;
                    costo_acumulado += (decimal)costo_total;

                    
                    if(i>= simulacion_desde && i <= simulacion_desde + 400)
                    {
                        tabla.Rows.Add();
                        tabla.Rows[j]["Iteracion"] = i;
                        tabla.Rows[j]["RND llegadas"] = rnd_llegadas;
                        tabla.Rows[j]["Cantidad llegadas"] = nro_llegadas;
                        tabla.Rows[j]["RND descargas"] = rnd_descargas;
                        tabla.Rows[j]["Cantidad descargas"] = nro_descargas;
                        tabla.Rows[j]["RND costo descarga"] = rnd_costo_descargas;
                        tabla.Rows[j]["Costo descarga"] = costo_descarga;
                        tabla.Rows[j]["Costo por noche"] = costo_por_noche_por_barco;
                        tabla.Rows[j]["Costo muelle desocupado"] = costo_por_muelle_vacio;
                        tabla.Rows[j]["Barcos no descargados"] = barcos_no_descargados;
                        tabla.Rows[j]["Costo total"] = costo_total;
                        tabla.Rows[j]["Costo acumulado"] = costo_acumulado;
                        j++;
                    }
                    
                }
            }
        }

        private void cargar_tabla()
        {
            DataColumn iteracion = new DataColumn("Iteracion");
            DataColumn rnd_llegadas = new DataColumn("RND llegadas");
            DataColumn cantidad_llegadas = new DataColumn("Cantidad llegadas");
            DataColumn rnd_descargas = new DataColumn("RND descargas");
            DataColumn cantidad_descargas = new DataColumn("Cantidad descargas");
            DataColumn rnd_costo_descarga = new DataColumn("RND costo descarga");
            DataColumn costo_descarga = new DataColumn("Costo descarga");
            DataColumn costo_por_noche = new DataColumn("Costo por noche");
            DataColumn costo_muelle_desocupado = new DataColumn("Costo muelle desocupado");
            DataColumn barcos_no_descargados = new DataColumn("Barcos no descargados");
            DataColumn costo_total = new DataColumn("Costo total");
            DataColumn costo_acumulado = new DataColumn("Costo acumulado");

            if(cantidad_muelles == 2)
            {
                cantidad_llegadas = new DataColumn("Cantidad llegadas uniforme(" + dist_uniforme_a + ";" + dist_uniforme_b + ")");
                cantidad_descargas = new DataColumn("Cantidad descargas poisson(" + dist_poisson_barcos + "/" + dist_poisson_hs + ")");
            }

            tabla.Columns.Add(iteracion);
            tabla.Columns.Add(rnd_llegadas);
            tabla.Columns.Add(cantidad_llegadas);
            tabla.Columns.Add(rnd_descargas);
            tabla.Columns.Add(cantidad_descargas);
            tabla.Columns.Add(barcos_no_descargados);
            tabla.Columns.Add(rnd_costo_descarga);
            tabla.Columns.Add(costo_descarga);
            tabla.Columns.Add(costo_por_noche);
            tabla.Columns.Add(costo_muelle_desocupado);
            tabla.Columns.Add(costo_total);
            tabla.Columns.Add(costo_acumulado);
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Tabla_Load(object sender, EventArgs e)
        {
            lbl_desde.Text = lbl_desde.Text + "(Desde 0 hasta " + (cantidad_iteraciones - 400).ToString() + ")";
        }
    }
}
