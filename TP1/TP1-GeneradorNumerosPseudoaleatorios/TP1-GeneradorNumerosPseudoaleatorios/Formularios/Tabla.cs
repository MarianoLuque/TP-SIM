using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GeneradorNumerosPseudoaleatorios.Formularios
{
    public partial class Tabla : Form
    {
        private int modulo, multiplicador, semilla, sumando, cantidad_nros, const_k, const_g;
        public Tabla(int cantidad, int k, int g, int c, int m, int a, int semilla)
        {
            InitializeComponent();
            this.cantidad_nros = cantidad;
            this.sumando = c;
            this.const_g = g;
            this.const_k = k;
            this.modulo = m;
            this.multiplicador = a;
            this.semilla = semilla;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataTable workTable = new DataTable("Valores");

            DataColumn columna_cantidad = new DataColumn("Cantidad de numeros");
            DataColumn columna_semilla = new DataColumn("Semilla");
            DataColumn k = new DataColumn("K");
            DataColumn a = new DataColumn("Constante Multiplicativa");
            DataColumn g = new DataColumn("G");
            DataColumn m = new DataColumn("Modulo");
            DataColumn c = new DataColumn("Constante Aditiva");

            workTable.Columns.Add(columna_cantidad);
            workTable.Columns.Add(columna_semilla);
            workTable.Columns.Add(k);
            workTable.Columns.Add(a);
            workTable.Columns.Add(g);
            workTable.Columns.Add(m);
            workTable.Columns.Add(c);

            DataRow row1= workTable.NewRow();

            row1["Cantidad de numeros"] = cantidad_nros;
            row1["Semilla"] = semilla;
            row1["K"] = const_k;
            row1["Constante Multiplicativa"] = multiplicador;
            row1["G"] = const_g;
            row1["Modulo"] = modulo;
            row1["Constante Aditiva"] = sumando;
            
            workTable.Rows.Add(row1);

            dg_datos.DataSource = workTable;
            dg_iteraciones.DataSource = calcularYCargar();

        }

        private DataTable calcularYCargar()
        {
            DataTable tabla_iteracion = new DataTable();

            DataColumn iteracion = new DataColumn("Iteracion");
            DataColumn termino1 = new DataColumn("a.Xi + c");
            DataColumn xi_mas_uno = new DataColumn("Xi + 1");
            DataColumn rnd = new DataColumn("RND");
            rnd.DataType = System.Type.GetType("System.Double");

            tabla_iteracion.Columns.Add(iteracion);
            tabla_iteracion.Columns.Add(termino1);
            tabla_iteracion.Columns.Add(xi_mas_uno);
            tabla_iteracion.Columns.Add(rnd);

            for (int i = 0; i < cantidad_nros; i++)
            {
                tabla_iteracion.Rows.Add();
                int equis_i = (multiplicador * semilla) + sumando;
                int equis_i_mas_uno = equis_i % modulo;
                tabla_iteracion.Rows[i]["Iteracion"] = i;
                tabla_iteracion.Rows[i]["a.Xi + c"] = equis_i;
                tabla_iteracion.Rows[i]["Xi + 1"] = equis_i % modulo;
                tabla_iteracion.Rows[i]["RND"] = (double)equis_i_mas_uno / (double)modulo;

                semilla = equis_i % modulo;
            }

            return tabla_iteracion;
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
