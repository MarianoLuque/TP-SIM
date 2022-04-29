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

        public Principal()
        {
            InitializeComponent();
        }

        private void rb_cantidad_muelles_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_un_muelle.Checked)
            {
                lbl_datos_simulacion.Text = "Para la cantidad de muelles seleccionados, la simulación se rige por las siguientes tablas:";
                cargar_tablas();
                un_muelle_usado = false;
            }
            if (rb_dos_muelle.Checked)
            {
                lbl_datos_simulacion.Text = "Para la cantidad de muelles seleccionados, la simulación se rige por las siguientes distribuciones:";
                cargar_tablas();
                dos_muelle_usado = false;
            }
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
                dg_nro_llegadas.Size = new Size(185, 50);
                dg_nro_descargas.Size = new Size(175, 63);
            }
            
            
        }

        private void cargar_tabla_llegadas()
        {
            DataColumn nro_llegadas = new DataColumn("Numero de llegadas");
            DataColumn probabilidad = new DataColumn("Probabilidad");
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
            DataColumn probabilidad = new DataColumn("Probabilidad");
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
            tabla_distribucion_llegadas.Rows[0]["Numero de llegadas"] = "Distribucion Poisson(20/12)";
            dg_nro_llegadas.DataSource = tabla_distribucion_llegadas;
        }

        private void cargar_tabla_distribucion_descargas()
        {
            DataColumn titulo = new DataColumn("Numero de descargas");

            tabla_distribucion_descargas.Columns.Add(titulo);

            tabla_distribucion_descargas.Rows.Add();
            tabla_distribucion_descargas.Rows[0]["Numero de descargas"] = "Distribucion Uniforme(0;9)";
            dg_nro_descargas.DataSource = tabla_distribucion_descargas;
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
