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
        int simulacion_hasta;
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
        int dias_operativos = 0;
        int dias_no_operativos = 0;
        double promedio_empleados_ausentes = 0;
        int total_empleados_ausentes = 0;

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
            if(!int.TryParse(txt_desde.Text, out simulacion_desde) || simulacion_desde > cantidad_iteraciones || simulacion_desde < 1)
            {
                MessageBox.Show("Ingrese desde que simulación se debe mostrar (valor mayor o igual a 1 y menor o igual a " + cantidad_iteraciones.ToString() + ")", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(!int.TryParse(txt_hasta.Text, out simulacion_hasta) || simulacion_hasta > cantidad_iteraciones || simulacion_hasta < simulacion_desde)
            {
                MessageBox.Show("El valor 'hasta' debe ser mayor o igual que 'desde' y menor o igual a " + cantidad_iteraciones.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (flag_tabla_cargada)
            {
                dg_montecarlo.DataSource = null;
                tabla.Rows.Clear();
            }
            else
            {
                cargar_tabla();
                flag_tabla_cargada = true;
            }

            cargar_datos();
            dg_montecarlo.DataSource = tabla;
        }

        private void mostrar_metricas()
        {
            double porcentaje_dias_operativos = (double)dias_operativos / cantidad_iteraciones * 100;
            promedio_empleados_ausentes = (double)total_empleados_ausentes / cantidad_iteraciones;
            decimal beneficio_promedio = beneficio_acumulado / cantidad_iteraciones;

            lbl_m1.Text = $"Días operativos: {dias_operativos} ({Math.Round(porcentaje_dias_operativos, 2)}%)";
            lbl_m2.Text = $"Días no operativos por falta de personal: {dias_no_operativos} ({Math.Round(100 - porcentaje_dias_operativos, 2)}%)";
            lbl_m3.Text = $"Promedio diario de empleados ausentes: {Math.Round(promedio_empleados_ausentes, 2)}";
            lbl_m4.Text = $"Beneficio total en {cantidad_iteraciones} días: ${beneficio_acumulado:N2}";
            lbl_m5.Text = $"Beneficio promedio diario: ${beneficio_promedio:N2}";
            lbl_m6.Text = $"Nómina: {cant_empleados_nomina} obreros (mínimo necesario: {cant_empleados_minima})";
        }

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

            // Reiniciar métricas
            dias_operativos = 0;
            dias_no_operativos = 0;
            total_empleados_ausentes = 0;

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
                if (i >= (simulacion_desde-1) && i < simulacion_hasta)
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

                // Actualizar métricas
                if (dia_operativo)
                    dias_operativos++;
                else
                    dias_no_operativos++;

                total_empleados_ausentes += nro_empleados_ausentes;
            }

            // Calcular métricas adicionales
            promedio_empleados_ausentes = (double)total_empleados_ausentes / cantidad_iteraciones;
            mostrar_metricas();
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
            txt_desde.Text = 1.ToString();
            txt_hasta.Text = cantidad_iteraciones.ToString();
        }
    }
}
