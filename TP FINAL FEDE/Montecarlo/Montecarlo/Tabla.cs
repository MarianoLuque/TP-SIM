using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Montecarlo
{
    public partial class Tabla : Form
    {
        //Variables importadas

        long cantidad_iteraciones;
        int cant_empleados_nomina;
        int cant_empleados_minima;
        int costo_produccion;
        int salario_diario;
        int ganancias;

        DataTable tabla_nro_obreros_ausentes;

        //Variables creadas
        DataTable tabla = new DataTable();
        int simulacion_desde;
        bool flag_tabla_cargada = false;

        decimal beneficio_acumulado;
        double beneficio_diario;
        bool dia_operativo;  // Esto se asume como true por defecto
        
        double costos_mano_obra;
        double costos_produccion_venta;
        double ganancia_diaria;

        int j = 0;

        double rnd_empleados_ausentes;
        int nro_empleados_ausentes;
        int nro_empleados_presentes;

        //array llegadas
        double[] array_empleados_ausentes = new double[] { 0, 0.36, 0.74, 0.93, 0.99 };

        //Metricas
        //  int cantidad_dias_operativos;
        //  int cantidad_dias_no_operativos;
        //  long beneficios_por_dia_acumulado;


        public Tabla(long cantidad_iteraciones, int costo_produccion, int salario_diario, int ganancias, int cant_empleados_nomina, int cant_empleados_minima, DataTable tabla_nro_obreros_ausentes)
        {
            InitializeComponent();
            this.cantidad_iteraciones = cantidad_iteraciones;
            this.costo_produccion = costo_produccion;
            this.salario_diario = salario_diario;
            this.ganancias = ganancias;
            this.cant_empleados_nomina = cant_empleados_nomina;
            this.cant_empleados_minima = cant_empleados_minima;
            this.tabla_nro_obreros_ausentes = tabla_nro_obreros_ausentes;
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txt_desde.Text, out simulacion_desde) || simulacion_desde > (cantidad_iteraciones - 300))
            {
                MessageBox.Show("Ingrese desde que simulación se debe mostrar (valor mayor a 0 y menor a " + (cantidad_iteraciones - 300).ToString() + ")", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (flag_tabla_cargada)
            {
                //desligo la tabla del data source
                dg_montecarlo.DataSource = null;
                //limpiar las filas
                tabla.Rows.Clear();
            }
            else
            {
                cargar_tabla();
                flag_tabla_cargada = true;
            }

            //cargo los datos a la tabla
            cargar_datos();
            //ligo la tabla al data source
            dg_montecarlo.DataSource = tabla;
            //muestro las metricas
            //  mostrar_metricas();
        }

        //private void mostrar_metricas()
        //{
        //    lbl_m1.Text = "Máximo costo total: $" + max_beneficio_diario.ToString() + " - En la fila: " + fila_max_costo.ToString();
        //    lbl_m2.Text = "Cantidad de barcos con retraso: " + cantidad_barcos_retrasados.ToString();
        //    lbl_m3.Text = "Porcentaje de ocupación del muelle: " + (Math.Round(((double)cantidad_veces_muelle_no_vacio / (double)cantidad_iteraciones) * 100 , 10)).ToString() + "%";
        //    lbl_m4.Text = "Promedio de barcos que llegan por día: " + (Math.Round(((double)cantidad_barcos_llegados_total / (double)cantidad_iteraciones), 2)).ToString();
        //    lbl_m5.Text = "Promedio de barcos descargados por día: " + (Math.Round(((double)cantidad_barcos_descargados_total / (double)cantidad_iteraciones), 2)).ToString();
        //    lbl_m6.Text = "Porcentaje del costo por noche en el muelle sobre el costo acumulado: " + (Math.Round(((decimal)costo_por_noche_acumulado / beneficio_acumulado) * 100 , 4)).ToString() + "%";
        //}

        private void cargar_datos()
        {
            //instancio los randoms
            Random myObject = new Random();
            Thread.Sleep(40);
            Random myObject1 = new Random();

            //vuelvo variables a 0
            dia_operativo = true;  // Esto se asume como true por defecto
            beneficio_diario = 0;
            beneficio_acumulado = 0;
            j = 0;

            //vuelvo metricas a 0


            //Hago las N simulaciones
            for (int i = 0; i < cantidad_iteraciones; i++)
            {
                // Genero el número aleatorio
                rnd_empleados_ausentes = Math.Truncate(myObject.NextDouble() * 100) / 100;

                // Calculo el número de empleados ausentes
                for (int k = 0; k < array_empleados_ausentes.Length - 1; k++)
                {
                    if (rnd_empleados_ausentes >= array_empleados_ausentes[k] && rnd_empleados_ausentes < array_empleados_ausentes[k + 1])
                    {
                        nro_empleados_ausentes = k;
                        break;
                    }
                }

                // Manejar el último intervalo manualmente
                if (rnd_empleados_ausentes >= array_empleados_ausentes[array_empleados_ausentes.Length - 1])
                {
                    nro_empleados_ausentes = array_empleados_ausentes.Length - 1;
                }

                // Calcular el número de trabajadores presentados
                int nro_empleados_presentes = cant_empleados_nomina - nro_empleados_ausentes;

                // Verificar si los trabajadores presentados son suficientes
                if (nro_empleados_presentes < cant_empleados_minima)
                {
                    // Si no es suficiente, se establece la bandera DIA_OPERADO en FALSE
                    dia_operativo = false;

                    // Aquí, puedes calcular los costos de mano de obra incluso si no se opera
                    costos_mano_obra = cant_empleados_nomina * salario_diario;

                    // Los costos de producción y venta son cero porque no se opera
                    costos_produccion_venta = 0;
                    ganancia_diaria = 0;

                }
                else
                {
                    // Si los trabajadores presentados son suficientes, se establece la bandera en TRUE
                    dia_operativo = true;

                    // Calcular los costos de mano de obra (se paga igual aunque no haya operación)
                    costos_mano_obra = cant_empleados_nomina * salario_diario;

                    // Calcular los costos de producción y la ganancia de la venta
                    costos_produccion_venta = costo_produccion;
                    ganancia_diaria = ganancias;
                }

                //Calculo el costo total y el acumulado
                beneficio_diario = ganancia_diaria - costos_produccion_venta - costos_mano_obra;
                beneficio_acumulado += (decimal)beneficio_diario;

                //cargo los resultados en la tabla
                if (i >= simulacion_desde && i < simulacion_desde + 300)
                {
                    tabla.Rows.Add();
                    tabla.Rows[j]["Iteracion"] = i+1;
                    tabla.Rows[j]["RND obreros ausentes"] = rnd_empleados_ausentes;
                    tabla.Rows[j]["Cantidad obreros ausentes"] = nro_empleados_ausentes;
                    tabla.Rows[j]["Cantidad obreros nómina"] = cant_empleados_nomina;
                    tabla.Rows[j]["Cantidad obreros mínima necesaria"] = cant_empleados_minima;
                    tabla.Rows[j]["Cantidad obreros presentes"] = nro_empleados_presentes;
                    tabla.Rows[j]["Día operativo"] = dia_operativo? "Sí" : "No";
                    tabla.Rows[j]["Costo de producción y venta"] = costos_produccion_venta;
                    tabla.Rows[j]["Costo de mano de obra"] = costos_mano_obra;
                    tabla.Rows[j]["Ganancia de venta diaria"] = ganancia_diaria;
                    tabla.Rows[j]["Beneficio diario"] = beneficio_diario;
                    tabla.Rows[j]["Beneficio acumulado"] = beneficio_acumulado;

                    j++;
                }
                //cargo el resultado de la ultima iteracion en la tabla
                if (i == cantidad_iteraciones - 1)
                {
                    tabla.Rows.Add();
                    tabla.Rows[j]["Iteracion"] = i + 1;
                    tabla.Rows[j]["RND obreros ausentes"] = rnd_empleados_ausentes;
                    tabla.Rows[j]["Cantidad obreros ausentes"] = nro_empleados_ausentes;
                    tabla.Rows[j]["Cantidad obreros nómina"] = cant_empleados_nomina;
                    tabla.Rows[j]["Cantidad obreros mínima necesaria"] = cant_empleados_minima;
                    tabla.Rows[j]["Cantidad obreros presentes"] = nro_empleados_presentes;
                    tabla.Rows[j]["Día operativo"] = dia_operativo ? "Sí" : "No";
                    tabla.Rows[j]["Costo de producción y venta"] = costos_produccion_venta;
                    tabla.Rows[j]["Costo de mano de obra"] = costos_mano_obra;
                    tabla.Rows[j]["Ganancia de venta diaria"] = ganancia_diaria;
                    tabla.Rows[j]["Beneficio diario"] = beneficio_diario;
                    tabla.Rows[j]["Beneficio acumulado"] = beneficio_acumulado;

                }
            }
        }

        private void cargar_tabla()
        {
            // Creo las columnas
            DataColumn iteracion = new DataColumn("Iteracion");
            DataColumn rnd_empleados_ausentes = new DataColumn("RND obreros ausentes");
            DataColumn cantidad_ausentes = new DataColumn("Cantidad obreros ausentes");
            DataColumn cantidad_nomina = new DataColumn("Cantidad obreros nómina");
            DataColumn cantidad_minima = new DataColumn("Cantidad obreros mínima necesaria");
            DataColumn cantidad_presentes = new DataColumn("Cantidad obreros presentes");
            DataColumn dia_operativo = new DataColumn("Día operativo");
            DataColumn costo_produccion_venta = new DataColumn("Costo de producción y venta");
            DataColumn costo_mano_obra = new DataColumn("Costo de mano de obra");
            DataColumn ganancia_venta_diaria = new DataColumn("Ganancia de venta diaria");
            DataColumn beneficio_diario = new DataColumn("Beneficio diario");
            DataColumn beneficio_acumulado = new DataColumn("Beneficio acumulado");

            // Agrego las columnas a la tabla
            tabla.Columns.Add(iteracion);
            tabla.Columns.Add(rnd_empleados_ausentes);
            tabla.Columns.Add(cantidad_ausentes);
            tabla.Columns.Add(cantidad_nomina);
            tabla.Columns.Add(cantidad_minima);
            tabla.Columns.Add(cantidad_presentes);
            tabla.Columns.Add(dia_operativo);
            tabla.Columns.Add(costo_produccion_venta);
            tabla.Columns.Add(costo_mano_obra);
            tabla.Columns.Add(ganancia_venta_diaria);
            tabla.Columns.Add(beneficio_diario);
            tabla.Columns.Add(beneficio_acumulado);

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
            lbl_desde.Text = lbl_desde.Text + "(Desde 0 hasta " + (cantidad_iteraciones - 300).ToString() + ")";
        }
    }
}
