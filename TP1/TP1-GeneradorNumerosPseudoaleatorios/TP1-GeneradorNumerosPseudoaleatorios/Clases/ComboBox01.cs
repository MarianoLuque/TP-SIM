using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GeneradorNumerosPseudoaleatorios.Clases
{
    class ComboBox01 : ComboBox
    {
        public void CargarCombo(Estructura_ComboBox edc)
        {

            this.DisplayMember = edc.Display;
            this.ValueMember = edc.Value;
            this.DataSource = edc.Tabla;
            this.SelectedIndex = -1;
            this.Text = "Haga una selección";
        }
    }
}
