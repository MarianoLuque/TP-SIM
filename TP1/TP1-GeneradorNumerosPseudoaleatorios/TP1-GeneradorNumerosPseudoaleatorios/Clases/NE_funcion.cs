using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_GeneradorNumerosPseudoaleatorios.Clases
{
    class NE_funcion
    {
        public Estructura_ComboBox DatosMultiplicativo()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            DataTable workTable = new DataTable("Funciones");
            DataColumn columna_nombre = new DataColumn("nombre");
            workTable.Columns.Add(columna_nombre);
            
            DataRow row1 = workTable.NewRow();
            DataRow row2 = workTable.NewRow();

            row1["nombre"] = "3 + 8 K";
            row2["nombre"] = "5 + 8 K";

            workTable.Rows.Add(row1);
            workTable.Rows.Add(row2);


            edc.Value = "nombre";
            edc.Display = "nombre";
            edc.Tabla = workTable;

            return edc;
        }

        public Estructura_ComboBox DatosLineal()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            DataTable workTable = new DataTable("Funciones");
            DataColumn columna_nombre = new DataColumn("nombre");
            workTable.Columns.Add(columna_nombre);

            DataRow row3 = workTable.NewRow();

            row3["nombre"] = "1 + 4 K";

            workTable.Rows.Add(row3);

            edc.Value = "nombre";
            edc.Display = "nombre";
            edc.Tabla = workTable;

            return edc;
        }

        public Estructura_ComboBox DatosGenerador()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            DataTable workTable = new DataTable("Intervalos");
            DataColumn columna_nombre = new DataColumn("cantidad");
            workTable.Columns.Add(columna_nombre);

            DataRow row1 = workTable.NewRow();
            DataRow row2 = workTable.NewRow();
            DataRow row3 = workTable.NewRow();
            DataRow row4 = workTable.NewRow();
            DataRow row5 = workTable.NewRow();

            row1["cantidad"] = "5";
            row2["cantidad"] = "8";
            row3["cantidad"] = "10";
            row4["cantidad"] = "12";
            row5["cantidad"] = "Raiz de n";

            workTable.Rows.Add(row1);
            workTable.Rows.Add(row2);
            workTable.Rows.Add(row3);
            workTable.Rows.Add(row4);
            workTable.Rows.Add(row5);

            edc.Value = "cantidad";
            edc.Display = "cantidad";
            edc.Tabla = workTable;

            return edc;
        }
    }
}
