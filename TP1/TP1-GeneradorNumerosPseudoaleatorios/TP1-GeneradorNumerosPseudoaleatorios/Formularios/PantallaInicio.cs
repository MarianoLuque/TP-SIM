using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_GeneradorNumerosPseudoaleatorios.Clases;

namespace TP1_GeneradorNumerosPseudoaleatorios
{
    public partial class PantallaInicio : Form
    {
        private bool flag_semilla, flag_k, flag_g, flag_a;

        NE_funcion funcion = new NE_funcion();

        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_a.CargarCombo(funcion.DatosComboCliente());
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool chequear_valores()
        {
            
            int m = 0;

            //Si g y k pueden castearse, no son un valor no entero ni letra
            flag_k = Int32.TryParse(txt_k.Text, out int k_casteada);
            flag_g = Int32.TryParse(txt_g.Text, out int g_casteada);
            if (flag_g && flag_k)
            {
                //Calculo m y la coloco en un txt para que la visualice el usuario
                m = (int)(Math.Pow((double)2, (double)g_casteada));
                txt_m.Text = m.ToString();
            }


            //Compruebo si la semilla es texto o no entero
            flag_semilla = Int32.TryParse(txt_semilla.Text, out int semilla_casteada);
            if (flag_semilla)
            {
                //compruebo si es impar
                if((semilla_casteada%2) == 0)
                {
                    flag_semilla = false;
                }

                //compruebo si g se pudo castear
                if (flag_g)
                {
                    //compruebo si la semilla es coprimo de m
                    if (!(mcd(semilla_casteada, m) == 1))
                    {
                        MessageBox.Show(mcd(semilla_casteada, m).ToString());
                        flag_semilla = false;
                    }
                }
            }

            //Compruebo si se seleccionó la formula para la variable a
            if(cmb_a.SelectedIndex == -1)
            {
                flag_a = false;
            }
            else
            {
                flag_a = true;
            }

            //Si todas las condiciones se cumplen, retorno verdadero, si alguna no se cumple retorno falso para mostrar el mensaje de error
            if(flag_semilla && flag_k && flag_g && flag_a)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private int mcd(int numero1, int numero2)
        {
            int resultado, a = numero1, b = numero2;
            do
            {
                resultado = b;  // Guardamos el divisor en el resultado
                b = a % b;      //Guardamos el resto en el divisor
                a = resultado;  //El divisor para al dividendo
            }
            while
            (b != 0);
            return resultado;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (!chequear_valores())
            {
                //Conformo el mensaje de error
                String error_message = "";

                if (!flag_semilla)
                {
                    error_message += "El valor de la semilla debe ser impar y coprimo de m\n";
                }

                if (!flag_g)
                {
                    error_message += "El valor de g debe ser entero\n";
                }

                if (!flag_k)
                {
                    error_message += "El valor de k debe ser entero\n";
                }

                if (!flag_a)
                {
                    error_message += "Debe seleccionar una fórmula para aplicarle a la variable a";
                }

                MessageBox.Show(error_message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }


    }
}
