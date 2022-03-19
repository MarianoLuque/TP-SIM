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
        public Estructura_ComboBox DatosComboCliente()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            DataTable workTable = new DataTable("Funciones");
            DataColumn column1 = new DataColumn("nombre");
            workTable.Columns.Add(column1);
            DataRow row1 = workTable.NewRow();
            row1["nombre"] = "3 + 8 K";

            DataRow row2 = workTable.NewRow();
            row2["nombre"] = "5 + 8 K";

            DataRow row3 = workTable.NewRow();
            row3["nombre"] = "1 + 4 K";

            workTable.Rows.Add(row1);
            workTable.Rows.Add(row2);
            workTable.Rows.Add(row3);

            edc.Value = "nombre";
            edc.Display = "nombre";
            edc.Tabla = workTable;

            return edc;
        }
    }
}
