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
    public partial class Principal : Form
    {
        DataTable tabla_nro_obreros_ausentes = new DataTable();

        //Variables montecarlo
        long cantidad_iteraciones;
        int costo_produccion = 2400;
        int salario_diario = 30;
        int ganancias = 4000;
        int cant_empleados_nomina = 24;
        int cant_empleados_minima = 20;

        public Principal()
        {
            InitializeComponent();
            cargar_tabla_llegadas();
        }

        private void cargar_tabla_llegadas()
        {
            DataColumn nro_llegadas = new DataColumn("Numero de obreros ausentes");
            nro_llegadas.DataType = Type.GetType("System.Int32");

            DataColumn probabilidad = new DataColumn("Probabilidad");
            probabilidad.DataType = Type.GetType("System.Double");

            tabla_nro_obreros_ausentes.Columns.Add(nro_llegadas);
            tabla_nro_obreros_ausentes.Columns.Add(probabilidad);

            double[] probabilidades_array = new double[] { 0.36, 0.38, 0.19, 0.06, 0.01 };

            for (int i = 0; i < 5; i++)
            {
                tabla_nro_obreros_ausentes.Rows.Add();
                tabla_nro_obreros_ausentes.Rows[i]["Numero de obreros ausentes"] = i;
                tabla_nro_obreros_ausentes.Rows[i]["Probabilidad"] = probabilidades_array[i];
            }
            dg_nro_llegadas.DataSource = tabla_nro_obreros_ausentes;
        }

       
        private void cargar_tabla_distribucion_llegadas()
        {
            DataColumn titulo = new DataColumn("Numero de llegadas");
            tabla_nro_obreros_ausentes.Columns.Add(titulo);

            tabla_nro_obreros_ausentes.Rows.Add();
            tabla_nro_obreros_ausentes.Rows[0]["Numero de llegadas"] = "Distribucion Poisson";
            dg_nro_llegadas.DataSource = tabla_nro_obreros_ausentes;
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            //if(!long.TryParse(txt_cantidad_simulaciones.Text, out cantidad_iteraciones) || cantidad_iteraciones < 300)
            //{
            //    MessageBox.Show("Ingrese la cantidad de días a simular (mayor o igual a 300?)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //if (txt_costo_produccion.Text != "")
            //{
            //    int.TryParse(txt_costo_produccion.Text, out costo_produccion);
            //}
            //if (txt_ganancias.Text != "")
            //{
            //    int.TryParse(txt_ganancias.Text, out ganancias);
            //}
            //if (txt_salario_diario.Text != "")
            //{
            //    int.TryParse(txt_salario_diario.Text, out salario_diario);
            //}
            //if (txt_cant_empleados_nomina.Text != "")
            //{
            //    int.TryParse(txt_cant_empleados_nomina.Text, out cant_empleados_nomina);
            //}
            //if (txt_cant_empleados_minima.Text != "")
            //{
            //    int.TryParse(txt_cant_empleados_minima.Text, out cant_empleados_minima);
            //}

            // Si el usuario no escribe nada, se usa 300 como valor por defecto
            cantidad_iteraciones = string.IsNullOrWhiteSpace(txt_cantidad_simulaciones.Text) ? 300 : long.Parse(txt_cantidad_simulaciones.Text);

            // Usar valores predeterminados si los TextBox están vacíos
            costo_produccion = string.IsNullOrWhiteSpace(txt_costo_produccion.Text) ? 2400 : int.Parse(txt_costo_produccion.Text);
            ganancias = string.IsNullOrWhiteSpace(txt_ganancias.Text) ? 4000 : int.Parse(txt_ganancias.Text);
            salario_diario = string.IsNullOrWhiteSpace(txt_salario_diario.Text) ? 30 : int.Parse(txt_salario_diario.Text);
            cant_empleados_nomina = string.IsNullOrWhiteSpace(txt_cant_empleados_nomina.Text) ? 24 : int.Parse(txt_cant_empleados_nomina.Text);
            cant_empleados_minima = string.IsNullOrWhiteSpace(txt_cant_empleados_minima.Text) ? 20 : int.Parse(txt_cant_empleados_minima.Text);

            Tabla tabla = new Tabla(cantidad_iteraciones, costo_produccion, salario_diario, ganancias, cant_empleados_nomina, cant_empleados_minima, tabla_nro_obreros_ausentes);
            tabla.ShowDialog();
        }

    }
}
