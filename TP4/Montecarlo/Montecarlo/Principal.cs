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
        //Tablas para un muelle
        DataTable tabla_nro_llegadas = new DataTable();
        DataTable tabla_nro_descargas = new DataTable();
        //Tablas para dos muelles
        DataTable tabla_distribucion_llegadas = new DataTable();
        DataTable tabla_distribucion_descargas = new DataTable();
        //Banderas para saber si ya cargue las tablas para 1 o 2 muelles
        bool un_muelle_usado = true;
        bool dos_muelle_usado = true;

        //Variables montecarlo
        long cantidad_iteraciones;
        int cantidad_muelles;
        int media_costo_descarga = 800;
        int desviacion_costo_descarga = 120;
        int costo_por_noche = 1500;
        int costo_muelle_desocupado = 3200;
        int dist_uniforme_a = 0;
        int dist_uniforme_b = 9;
        int dist_poisson_barcos = 20;
        int dist_poisson_hs = 12;

        public Principal()
        {
            InitializeComponent();
        }

        private void rb_cantidad_muelles_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_un_muelle.Checked)
            {
                lbl_datos_simulacion.Text = "Para la cantidad de muelles seleccionados, la simulación se rige por las siguientes tablas de probabilidad:";
                habilitar_distribuciones(false);
                cargar_tablas();
                un_muelle_usado = false;
            }
            if (rb_dos_muelle.Checked)
            {
                lbl_datos_simulacion.Text = "Para la cantidad de muelles seleccionados, la simulación se rige por las siguientes distribuciones:";
                habilitar_distribuciones(true);
                cargar_tablas();
                dos_muelle_usado = false;
            }
        }

        private void habilitar_distribuciones(bool habilitar)
        {
            lbl_dist_uniforme.Visible = habilitar;
            lbl_dist_poisson.Visible = habilitar;
            lbl_a.Visible = habilitar;
            lbl_b.Visible = habilitar;
            lbl_barcos.Visible = habilitar;
            lbl_hs.Visible = habilitar;
            txt_dist_uniforme_a.Visible = habilitar;
            txt_dist_uniforme_b.Visible = habilitar;
            txt_dist_poisson_barcos.Visible = habilitar;
            txt_dist_poisson_hs.Visible = habilitar;
        }

        private void cargar_tablas()
        {
            if (rb_un_muelle.Checked)
            {
                if (un_muelle_usado)
                {
                    cargar_tabla_llegadas();
                    cargar_tabla_descargas();
                }
                else
                {
                    dg_nro_llegadas.DataSource = tabla_nro_llegadas;
                    dg_nro_descargas.DataSource = tabla_nro_descargas;
                }
                dg_nro_llegadas.Size = new Size(251, 170);
                dg_nro_descargas.Size = new Size(259, 150);
            }
            if (rb_dos_muelle.Checked)
            {
                if (dos_muelle_usado)
                {
                    cargar_tabla_distribucion_llegadas();
                    cargar_tabla_distribucion_descargas();
                }
                else
                {
                    dg_nro_llegadas.DataSource = tabla_distribucion_llegadas;
                    dg_nro_descargas.DataSource = tabla_distribucion_descargas;
                }
                dg_nro_llegadas.Size = new Size(160, 60);
                dg_nro_descargas.Size = new Size(170, 63);
            }
            
            
        }

        private void cargar_tabla_llegadas()
        {
            DataColumn nro_llegadas = new DataColumn("Numero de llegadas");
            nro_llegadas.DataType = Type.GetType("System.Int32");

            DataColumn probabilidad = new DataColumn("Probabilidad");
            probabilidad.DataType = Type.GetType("System.Double");

            tabla_nro_llegadas.Columns.Add(nro_llegadas);
            tabla_nro_llegadas.Columns.Add(probabilidad);

            double[] probabilidades_array = new double[] { 0.13, 0.17, 0.15, 0.25, 0.20, 0.10 };

            for (int i = 0; i < 6; i++)
            {
                tabla_nro_llegadas.Rows.Add();
                tabla_nro_llegadas.Rows[i]["Numero de llegadas"] = i;
                tabla_nro_llegadas.Rows[i]["Probabilidad"] = probabilidades_array[i];
            }
            dg_nro_llegadas.DataSource = tabla_nro_llegadas;
        }

        private void cargar_tabla_descargas()
        {
            DataColumn nro_descargas = new DataColumn("Numero de descargas");
            nro_descargas.DataType = Type.GetType("System.Int32");

            DataColumn probabilidad = new DataColumn("Probabilidad");
            probabilidad.DataType = Type.GetType("System.Double");

            tabla_nro_descargas.Columns.Add(nro_descargas);
            tabla_nro_descargas.Columns.Add(probabilidad);

            double[] probabilidades_array = new double[] { 0.05, 0.15, 0.50, 0.20, 0.10 };

            for (int i = 0; i < 5; i++)
            {
                tabla_nro_descargas.Rows.Add();
                tabla_nro_descargas.Rows[i]["Numero de descargas"] = i+1;
                tabla_nro_descargas.Rows[i]["Probabilidad"] = probabilidades_array[i];
            }
            dg_nro_descargas.DataSource = tabla_nro_descargas;
        }

        private void cargar_tabla_distribucion_llegadas()
        {
            DataColumn titulo = new DataColumn("Numero de llegadas");
            tabla_distribucion_llegadas.Columns.Add(titulo);

            tabla_distribucion_llegadas.Rows.Add();
            tabla_distribucion_llegadas.Rows[0]["Numero de llegadas"] = "Distribucion Poisson";
            dg_nro_llegadas.DataSource = tabla_distribucion_llegadas;
        }

        private void cargar_tabla_distribucion_descargas()
        {
            DataColumn titulo = new DataColumn("Numero de descargas");

            tabla_distribucion_descargas.Columns.Add(titulo);

            tabla_distribucion_descargas.Rows.Add();
            tabla_distribucion_descargas.Rows[0]["Numero de descargas"] = "Distribucion Uniforme";
            dg_nro_descargas.DataSource = tabla_distribucion_descargas;
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            if(!long.TryParse(txt_cantidad_simulaciones.Text, out cantidad_iteraciones) || cantidad_iteraciones < 400)
            {
                MessageBox.Show("Ingrese la cantidad de días a simular (mayor o igual a 400)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (rb_un_muelle.Checked)
            {
                cantidad_muelles = 1;
            }
            else if (rb_dos_muelle.Checked)
            {
                cantidad_muelles = 2;
                if(txt_dist_uniforme_a.Text != "")
                {
                    int.TryParse(txt_dist_uniforme_a.Text, out dist_uniforme_a);
                }
                if (txt_dist_uniforme_b.Text != "")
                {
                    int.TryParse(txt_dist_uniforme_b.Text, out dist_uniforme_b);
                }
                if(txt_dist_poisson_barcos.Text != "")
                {
                    int.TryParse(txt_dist_poisson_barcos.Text, out dist_poisson_barcos);
                }
                if(txt_dist_poisson_hs.Text != "")
                {
                    int.TryParse(txt_dist_poisson_hs.Text, out dist_poisson_hs);
                }
            }
            else
            {
                MessageBox.Show("Seleccione la cantidad de muelles a simular", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_costo_por_noche.Text != "")
            {
                int.TryParse(txt_costo_por_noche.Text, out costo_por_noche);
            }
            if (txt_media_normal.Text != "")
            {
                int.TryParse(txt_media_normal.Text, out media_costo_descarga);
            }
            if (txt_desviacion_normal.Text != "")
            {
                int.TryParse(txt_desviacion_normal.Text, out desviacion_costo_descarga);
                if(desviacion_costo_descarga >= media_costo_descarga)
                {
                    MessageBox.Show("Ingrese un valor de desviación menor a la media (<" + media_costo_descarga.ToString() + ")" , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (txt_costo_muelle_vacio.Text != "")
            {
                int.TryParse(txt_costo_muelle_vacio.Text, out costo_muelle_desocupado);
            }
            Tabla tabla = new Tabla(cantidad_iteraciones, cantidad_muelles, media_costo_descarga, desviacion_costo_descarga, costo_por_noche, costo_muelle_desocupado, dist_uniforme_a, dist_uniforme_b, dist_poisson_barcos, dist_poisson_hs, tabla_nro_llegadas, tabla_nro_descargas);
            tabla.ShowDialog();
        }
    }
}
