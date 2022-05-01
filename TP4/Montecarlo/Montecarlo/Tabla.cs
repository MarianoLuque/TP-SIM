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

        int barcos_no_descargados;
        decimal costo_acumulado;
        int costo_por_noche_por_barco;
        int costo_por_muelle_vacio;
        double costo_total;
        int j = 0;

        double rnd_llegadas;
        double? rnd_descargas;
        double rnd_costo_descargas;

        int nro_llegadas;
        int? nro_descargas;
        double costo_descarga;

        bool bandera_sacar_random_descarga = true;

        //Metricas
        double max_costo_total = 0;
        int fila_max_costo = 0;
        int cantidad_barcos_retrasados = 0;
        int cantidad_veces_muelle_no_vacio = 0;
        int cantidad_barcos_llegados_total = 0;
        int cantidad_barcos_descargados_total = 0;
        int costo_por_noche_acumulado = 0;

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
            if(!int.TryParse(txt_desde.Text, out simulacion_desde) || simulacion_desde > (cantidad_iteraciones - 400))
            {
                MessageBox.Show("Ingrese desde que simulación se debe mostrar (valor mayor a 0 y menor a " + (cantidad_iteraciones - 400).ToString() + ")", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            cargar_tabla();
            cargar_datos();
            dg_montecarlo.DataSource = tabla;
            mostrar_metricas();
        }

        private void mostrar_metricas()
        {
            lbl_m1.Text = "Máximo costo total: " + max_costo_total.ToString() + " en la fila: " + fila_max_costo.ToString();
            lbl_m2.Text = "Cantidad de barcos con retraso: " + cantidad_barcos_retrasados.ToString();
            lbl_m3.Text = "Porcentaje de ocupación del muelle: " + (Math.Round((double)(cantidad_veces_muelle_no_vacio / cantidad_iteraciones) * 100 , 2)).ToString();
            lbl_m4.Text = "Promedio de barcos que llegan por día: " + (cantidad_barcos_llegados_total / cantidad_iteraciones).ToString();
            lbl_m5.Text = "Promedio de barcos descargados por día: " + (cantidad_barcos_descargados_total / cantidad_iteraciones).ToString();
            lbl_m6.Text = "Porcentaje del costo por noche en el muelle sobre el costo total: " + (Math.Round(((decimal)costo_por_noche_acumulado / costo_acumulado) * 100 , 2)).ToString();
        }

        private void cargar_datos()
        {
            //instancio los randoms
            Random myObject = new Random();
            Random myObject1 = new Random(myObject.Next());
            Random myObject2 = new Random(myObject1.Next());
            Random myObject3 = new Random(myObject2.Next());
            Random myObject4 = new Random(myObject3.Next());

            //vuelvo variables a 0
            barcos_no_descargados = 0;
            costo_acumulado = 0;
            j = 0;

            //vuelvo metricas a 0
            max_costo_total = 0;
            fila_max_costo = 0;
            cantidad_barcos_retrasados = 0;
            cantidad_veces_muelle_no_vacio = 0;
            cantidad_barcos_llegados_total = 0;
            cantidad_barcos_descargados_total = 0;
            costo_por_noche_acumulado = 0;

            //Hago las N simulaciones
            for (int i = 0; i < cantidad_iteraciones; i++)
            {
                //genero los randoms
                rnd_llegadas = (Math.Truncate(myObject.NextDouble() * 100)) / 100;
                rnd_descargas = (Math.Truncate(myObject1.NextDouble() * 100)) / 100;
                rnd_costo_descargas = 0;

                //calculo el nro de llegadas y descargas y el costo por muelle vacío
                if (cantidad_muelles == 1)
                {
                    //Veo en que intervalo cae el rnd de las llegadas
                    if(rnd_llegadas <= 0.12)        { nro_llegadas = 0;}
                    else if (rnd_llegadas <= 0.29)  { nro_llegadas = 1;}
                    else if (rnd_llegadas <= 0.44)  { nro_llegadas = 2;}
                    else if (rnd_llegadas <= 0.69)  { nro_llegadas = 3;}
                    else if (rnd_llegadas <= 0.89)  { nro_llegadas = 4;}
                    else if (rnd_llegadas <= 0.99)  { nro_llegadas = 5;}

                    //Veo si tengo que sacar un random
                    if (nro_llegadas == 0 && barcos_no_descargados == 0)
                    {
                        //si no llegan barcos y no tengo de la noche anterior no voy a hacer descargas
                        nro_descargas = null;
                        rnd_descargas = null;

                        //En este caso hay costo por muelle vacío
                        costo_por_muelle_vacio = costo_muelle_desocupado;
                    }
                    else
                    {
                        //Veo en que intervalo cae el rnd de las descargas
                        if (rnd_descargas <= 0.04)        { nro_descargas = 1;}
                        else if (rnd_descargas <= 0.19)   { nro_descargas = 2;}
                        else if (rnd_descargas <= 0.69)   { nro_descargas = 3;}
                        else if (rnd_descargas <= 0.89)   { nro_descargas = 4;}
                        else if (rnd_descargas <= 0.99)   { nro_descargas = 5;}

                        //Si llegaron barcos o había de la noche anterior, no hay costo por muelle vacío
                        costo_por_muelle_vacio = 0;
                        //metrica porcentaje de ocupacion muelle (FALTA DIVIDIR POR LA CANTIDAD DE ITERACIONES)
                        cantidad_veces_muelle_no_vacio += 1;
                    }
                }
                if(cantidad_muelles == 2)
                {
                    //Calculo de nro de llegadas para distribucion poisson
                    double p = 1.0;
                    int x = -1;
                    double A = Math.Exp(-((double)dist_poisson_barcos/(double)dist_poisson_hs));
                    do
                    {
                        double random_p = rnd_llegadas;
                        p = (p * random_p);
                        x = x + 1;
                    } while (p >= A);
                    nro_llegadas = x;

                    //Veo si tengo que sacar un random
                    if (nro_llegadas == 0 && barcos_no_descargados == 0)
                    {
                        //si no llegan barcos y no tengo de la noche anterior no voy a hacer descargas
                        nro_descargas = null;
                        rnd_descargas = null;

                        //En este caso hay costo por muelle vacío
                        costo_por_muelle_vacio = costo_muelle_desocupado;
                    }
                    else
                    {
                        //calculo de nro de descargas para distribucion uniforme
                        nro_descargas = (dist_uniforme_a + ((int)(rnd_descargas * 100) * (dist_uniforme_b - dist_uniforme_a)) / 100);

                        //Si llegaron barcos o había de la noche anterior, no hay costo por muelle vacío
                        costo_por_muelle_vacio = 0;
                        //metrica porcentaje de ocupacion muelle (FALTA DIVIDIR POR LA CANTIDAD DE ITERACIONES)
                        cantidad_veces_muelle_no_vacio += 1;
                    }
                }

                //Calculo el costo de descarga con metodo de convolución
                for (int j = 0; j < 12; j++)
                {
                    rnd_costo_descargas += (Math.Truncate(myObject.NextDouble() * 100)) / 100;
                }
                costo_descarga = Math.Truncate((((rnd_costo_descargas - 6.00) * costo_desviacion_descarga) + costo_media_descarga) * 100) / 100;
                if(costo_descarga < 0) { costo_descarga = 0; }

                //intento:
                    //calcular la suma de las llegadas y los barcos no descargados menos el numero de descargas si es que hubiera
                    //sumar los barcos con retraso que es el numero de llegadas menos el numero de descargas
                    //sumar los barcos descargados
                int cant_llegadas_menos_cant_descargas;
                try
                {
                    cant_llegadas_menos_cant_descargas = barcos_no_descargados + nro_llegadas - (int)nro_descargas;

                    //metrica cantidad de barcos con retraso
                    int aux = nro_llegadas - (int)nro_descargas;
                    if (aux > 0)
                    {
                        cantidad_barcos_retrasados += aux;
                    }

                    //metrica promedio de barcos que se descargan (FALTA DIVIDIR POR LA CANTIDAD DE ITERACIONES)
                    cantidad_barcos_descargados_total += (int)nro_descargas;
                }
                //esto no estaría al pedo? si llega al catch es porque no hay llegadas y no hay barcos no descargados (por eso es null las descargas)
                catch
                {
                    // o sea aca sería 0 + 0 !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    cant_llegadas_menos_cant_descargas = barcos_no_descargados + nro_llegadas;

                    //y aca sería += 0 !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    //metrica cantidad de barcos con retraso
                    cantidad_barcos_retrasados += nro_llegadas;
                }
                
                //si hay mas descargas que llegadas los barcos no descargados son 0, sino es la diferencia
                if (cant_llegadas_menos_cant_descargas < 0) { barcos_no_descargados = 0; }
                else                                        { barcos_no_descargados = cant_llegadas_menos_cant_descargas; }

                //Calculo el costo por pasar la noche por barco
                costo_por_noche_por_barco = barcos_no_descargados * costo_por_noche;

                //Calculo el costo total y el acumulado
                costo_total = costo_por_noche_por_barco + costo_por_muelle_vacio + costo_descarga;
                costo_acumulado += (decimal)costo_total;

                
                //metrica maximo costo total
                if(costo_total > max_costo_total)
                {
                    max_costo_total = costo_total;
                    fila_max_costo = i;
                }

                //metrica promedio de barcos que llegan (FALTA DIVIDIR POR LA CANTIDAD DE ITERACIONES)
                cantidad_barcos_llegados_total += nro_llegadas;

                //metrica porcentaje del costo por noche en el muelle sobre el costo total (FALTA DIVIDIR POR EL COSTO TOTAL ACUMULADO)
                costo_por_noche_acumulado += costo_por_noche_por_barco;

                //cargo los resultados en la tabla
                if (i >= simulacion_desde && i < simulacion_desde + 400)
                {
                    tabla.Rows.Add();
                    tabla.Rows[j]["Iteracion"] = i+1;
                    tabla.Rows[j]["RND llegadas"] = rnd_llegadas;
                    tabla.Rows[j]["RND descargas"] = rnd_descargas;
                    tabla.Rows[j]["RND costo descarga"] = rnd_costo_descargas;
                    tabla.Rows[j]["Costo descarga"] = costo_descarga;
                    tabla.Rows[j]["Costo por noche"] = costo_por_noche_por_barco;
                    tabla.Rows[j]["Costo muelle desocupado"] = costo_por_muelle_vacio;
                    tabla.Rows[j]["Barcos no descargados"] = barcos_no_descargados;
                    tabla.Rows[j]["Costo total"] = costo_total;
                    tabla.Rows[j]["Costo acumulado"] = costo_acumulado;

                    if (cantidad_muelles == 1)
                    {
                        tabla.Rows[j]["Cantidad llegadas"] = nro_llegadas;
                        tabla.Rows[j]["Cantidad descargas"] = nro_descargas;
                    }
                    if (cantidad_muelles == 2)
                    {
                        tabla.Rows[j]["Cantidad descargas uniforme(" + dist_uniforme_a + ";" + dist_uniforme_b + ")"] = nro_descargas;
                        tabla.Rows[j]["Cantidad llegadas poisson(" + dist_poisson_barcos + "/" + dist_poisson_hs + ")"] = nro_llegadas;
                    }

                    j++;
                }
                //cargo el resultado de la ultima iteracion en la tabla
                if (i == cantidad_iteraciones - 1)
                {
                    tabla.Rows.Add();
                    tabla.Rows[j]["Iteracion"] = i+1;
                    tabla.Rows[j]["RND llegadas"] = rnd_llegadas;
                    tabla.Rows[j]["RND descargas"] = rnd_descargas;
                    tabla.Rows[j]["RND costo descarga"] = rnd_costo_descargas;
                    tabla.Rows[j]["Costo descarga"] = costo_descarga;
                    tabla.Rows[j]["Costo por noche"] = costo_por_noche_por_barco;
                    tabla.Rows[j]["Costo muelle desocupado"] = costo_por_muelle_vacio;
                    tabla.Rows[j]["Barcos no descargados"] = barcos_no_descargados;
                    tabla.Rows[j]["Costo total"] = costo_total;
                    tabla.Rows[j]["Costo acumulado"] = costo_acumulado;

                    if(cantidad_muelles == 1)
                    {
                        tabla.Rows[j]["Cantidad llegadas"] = nro_llegadas;
                        tabla.Rows[j]["Cantidad descargas"] = nro_descargas;
                    }
                    if(cantidad_muelles == 2)
                    {
                        tabla.Rows[j][("Cantidad descargas uniforme(" + dist_uniforme_a + ";" + dist_uniforme_b + ")")] = nro_descargas;
                        tabla.Rows[j][("Cantidad llegadas poisson(" + dist_poisson_barcos + "/" + dist_poisson_hs + ")")] = nro_llegadas;
                    }
                }
            }
        }

        private void cargar_tabla()
        {
            //creo las columnas
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
                cantidad_descargas = new DataColumn("Cantidad descargas uniforme(" + dist_uniforme_a + ";" + dist_uniforme_b + ")");
                cantidad_llegadas = new DataColumn("Cantidad llegadas poisson(" + dist_poisson_barcos + "/" + dist_poisson_hs + ")");
            }

            //asigno las columnas a la tabla
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
            //informo al usuario desde que iteracion puede elegir ver
            lbl_desde.Text = lbl_desde.Text + "(Desde 0 hasta " + (cantidad_iteraciones - 400).ToString() + ")";
        }
    }
}
