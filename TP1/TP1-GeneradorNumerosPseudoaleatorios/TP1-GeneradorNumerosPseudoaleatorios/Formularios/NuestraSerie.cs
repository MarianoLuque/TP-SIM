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
    public partial class NuestraSerie : Form
    {
        //Creo la tabla de las iteraciones
        DataTable tabla_iteracion = new DataTable();

        //Valores
        private int modulo, multiplicador, semilla_casteada, c_casteada, cantidad_casteada, k_casteada, g_casteada;

        //Banderas de txt
        private bool flag_semilla, flag_k, flag_g, flag_a, flag_cantidad;
        private bool flag_c = true;

        //Banderas de radio button
        private bool habilitado, lineal, multiplicativo = false;

        private void btn_cc_Click(object sender, EventArgs e)
        {
            ChiCuadrado chi_cuadrado = new ChiCuadrado(tabla_iteracion, cantidad_casteada, true);
            chi_cuadrado.ShowDialog();
        }

        NE_funcion funcion = new NE_funcion();

        public NuestraSerie()
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

        private void btn_generar_Click(object sender, EventArgs e)
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
            generarTabla();
            calcularYCargar();
            btn_cc.Enabled = true;
        }

        public void generarTabla()
        {
            //Creo la tabla que va a tener todas las variables
            DataTable workTable = new DataTable("Valores");

            //Creo las columnas que va a tener
            DataColumn columna_cantidad = new DataColumn("Cantidad de numeros");
            DataColumn columna_semilla = new DataColumn("Semilla");
            DataColumn k = new DataColumn("K");
            DataColumn a = new DataColumn("Constante Multiplicativa");
            DataColumn g = new DataColumn("G");
            DataColumn m = new DataColumn("Modulo");
            DataColumn c = new DataColumn("Constante Aditiva");

            //Agrego las columnas
            workTable.Columns.Add(columna_cantidad);
            workTable.Columns.Add(columna_semilla);
            workTable.Columns.Add(k);
            workTable.Columns.Add(a);
            workTable.Columns.Add(g);
            workTable.Columns.Add(m);
            workTable.Columns.Add(c);

            //Creo una fila
            DataRow row1 = workTable.NewRow();

            //Le asigno valores a la fila
            row1["Cantidad de numeros"] = cantidad_casteada;
            row1["Semilla"] = semilla_casteada;
            row1["K"] = k_casteada;
            row1["Constante Multiplicativa"] = multiplicador;
            row1["G"] = g_casteada;
            row1["Modulo"] = modulo;
            row1["Constante Aditiva"] = c_casteada;

            //Agrego la fila a la tabla
            workTable.Rows.Add(row1);

            //Asigno el data table al data grid view de las variables
            dg_datos.DataSource = workTable;
        }

        private void calcularYCargar()
        {
            tabla_iteracion.Clear();
            //Creo las columnas de la tabla
            DataColumn iteracion = new DataColumn("Iteracion");
            DataColumn termino1 = new DataColumn("a.Xi + c");
            DataColumn xi_mas_uno = new DataColumn("Xi + 1");
            DataColumn rnd = new DataColumn("RND");
            rnd.DataType = System.Type.GetType("System.Double");

            //Agrego las columnas a la tabla
            tabla_iteracion.Columns.Add(iteracion);
            tabla_iteracion.Columns.Add(termino1);
            tabla_iteracion.Columns.Add(xi_mas_uno);
            tabla_iteracion.Columns.Add(rnd);

            //Por la cantidad de numeros a generar, crea una fila y le asigna los valores
            for (int i = 0; i < cantidad_casteada; i++)
            {
                //Creo la fila
                tabla_iteracion.Rows.Add();

                //Calculos
                int equis_i = (multiplicador * semilla_casteada) + c_casteada;
                int equis_i_mas_uno = equis_i % modulo;

                //Le asigno los valores
                tabla_iteracion.Rows[i]["Iteracion"] = i;
                tabla_iteracion.Rows[i]["a.Xi + c"] = equis_i;
                tabla_iteracion.Rows[i]["Xi + 1"] = equis_i % modulo;
                tabla_iteracion.Rows[i]["RND"] = (double)equis_i_mas_uno / (double)modulo;

                //Calculo el Xi + 1
                semilla_casteada = equis_i % modulo;
            }
            dg_iteraciones.DataSource = tabla_iteracion;
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
            //Habilito todo si es que no lo habilité antes y cargo el combo box
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
            btn_generar.Enabled = a;
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
