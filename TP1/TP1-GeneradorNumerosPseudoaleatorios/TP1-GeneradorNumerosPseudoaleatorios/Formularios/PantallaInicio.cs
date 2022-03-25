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
using TP1_GeneradorNumerosPseudoaleatorios.Formularios;

namespace TP1_GeneradorNumerosPseudoaleatorios
{
    public partial class PantallaInicio : Form
    {
        //Valores
        private int modulo, multiplicador, semilla_casteada, c_casteada, cantidad_casteada, k_casteada, g_casteada;

        //Banderas de txt
        private bool flag_semilla, flag_k, flag_g, flag_a, flag_cantidad;
        private bool flag_c = true;

        //Banderas de radio button
        private bool habilitado, lineal, multiplicativo = false;

        NE_funcion funcion = new NE_funcion();

        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Deshabilito todo hasta que seleccione el método
            habilitar(habilitado);
            txt_c.Visible = false;
            lb_c.Visible = false;

        }

        private bool chequear_valores()
        {
            modulo = 0;

            //Si la cantidad, la semilla, g y k pueden castearse, no son un valor no entero ni letra
            flag_cantidad = Int32.TryParse(txt_cantidad.Text, out cantidad_casteada);
            flag_semilla = Int32.TryParse(txt_semilla.Text, out semilla_casteada);
            flag_k = Int32.TryParse(txt_k.Text, out k_casteada);
            flag_g = Int32.TryParse(txt_g.Text, out g_casteada);


            //Los valores menores a ceros los deja castear asi que compruebo que sean mayores a cero
            if (cantidad_casteada < 0) { flag_cantidad = false; }
            if (semilla_casteada < 0)  { flag_semilla = false;  }
            if (k_casteada < 0) { flag_k = false; }
            if (g_casteada < 0) { flag_g = false; }

            //si g cumple las condiciones, muestro el modulo
            if (flag_g)
            {
                //Calculo el modulo y la coloco en un txt para que la visualice el usuario
                modulo = (int)(Math.Pow((double)2, (double)g_casteada));
            }

            //Si el metodo es multiplicativo la semilla tiene que ser impar
            if (multiplicativo)
            {
                //compruebo si es impar
                if ((semilla_casteada % 2) == 0)
                {
                    flag_semilla = false;
                }
                flag_c = true;
            }

            //Si el metodo es lineal la constante aditiva debe ser entera, mayor a cero y relativamente prima del modulo
            if(lineal)
            {
                if((Int32.TryParse(txt_c.Text, out c_casteada)) && (c_casteada > 0) && flag_g)
                {
                    if (!(mcd(c_casteada, modulo) == 1))
                    {
                        flag_c = false;
                    }
                }
                else
                {
                    flag_c = false;
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
            if(flag_semilla && flag_k && flag_g && flag_a && flag_cantidad && flag_c)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (!chequear_valores())
            {
                //Conformo el mensaje de error
                String error_message = "";

                if (!flag_cantidad)
                {
                    error_message += "La cantidad de numeros a generar debe ser un entero positivo\n";
                }

                if (!flag_semilla && lineal)
                {
                    error_message += "El valor de la semilla debe ser entero positivo\n";
                }

                if (!flag_semilla && multiplicativo)
                {
                    error_message += "El valor de la semilla debe ser entero positivo e impar\n";
                }

                if (!flag_k)
                {
                    error_message += "El valor de k debe ser entero\n";
                }

                if (!flag_a)
                {
                    error_message += "Debe seleccionar una fórmula para aplicarle a la constante multiplicativa\n";
                }

                if (!flag_g)
                {
                    error_message += "El valor de g debe ser entero\n";
                }

                if (!flag_c)
                {
                    error_message += "La constante aditiva debe ser un entero positivo y relativamente prima del modulo";
                }

                MessageBox.Show(error_message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Consulto si es linea o multiplicativo y calculo el valor de la constante multiplicativa
            if (lineal)
            {
                multiplicador = 1 + 4 * k_casteada;
            }
            if (multiplicativo)
            {
                //Consulto que fórmula seleccionó
                if(cmb_a.SelectedIndex == 0)
                {
                    multiplicador = 3 + 8 * k_casteada;
                }
                if (cmb_a.SelectedIndex == 1)
                {
                    multiplicador = 5 + 8 * k_casteada;
                }
            }

            //Creo el formulario enviandole los valores de las variables por parametro
            Tabla tablita = new Tabla(cantidad_casteada, k_casteada, g_casteada, c_casteada, modulo, multiplicador, semilla_casteada);

            //Muestro el formulario
            tablita.ShowDialog();
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

        private void rb_lineal_CheckedChanged(object sender, EventArgs e)
        {
            //Habilito todo si es que no lo habilité antes (para ahorrar recursos) y cargo el combo box
            if (!habilitado) { habilitado = true; habilitar(habilitado); }
            cmb_a.CargarCombo(funcion.DatosLineal());

            //Cambio el valor de las banderas de tipo de metodo
            lineal = true;
            multiplicativo = false;

            //Habilito insertar el valor c al ser lineal
            txt_c.Visible = true;
            lb_c.Visible = true;
        }

        private void rb_multiplicativo_CheckedChanged(object sender, EventArgs e)
        {
            //Habilito todo si es que no lo habilité antes (para ahorrar recursos) y cargo el combo box
            if (!habilitado) { habilitado = true; habilitar(habilitado); }
            cmb_a.CargarCombo(funcion.DatosMultiplicativo());

            //Cambio el valor de las banderas de tipo de metodo
            multiplicativo = true;
            lineal = false;

            //Inhabilito insertar el valor c al ser multiplicativo
            txt_c.Visible = false;
            lb_c.Visible = false;
        }

        private void habilitar(bool a)
        {
            //Habilito o deshabilito los txt y cmb
            txt_cantidad.Enabled = a;
            txt_semilla.Enabled = a;
            txt_k.Enabled = a;
            txt_g.Enabled = a;
            cmb_a.Enabled = a;
            btn_calcular.Enabled = a;
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
