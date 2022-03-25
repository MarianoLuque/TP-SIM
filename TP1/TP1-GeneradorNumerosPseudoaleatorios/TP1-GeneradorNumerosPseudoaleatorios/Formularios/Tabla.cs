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
        //Creo la tabla de las iteraciones
        DataTable tabla_iteracion = new DataTable();


        //declaro las variables que voy a traer del otro formulario
        private int modulo, multiplicador, semilla, sumando, cantidad_nros, const_k, const_g;

        public Tabla(int cantidad, int k, int g, int c, int m, int a, int semilla)
        {
            InitializeComponent();
            //asigno los valores que traje del otro formulario
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
            DataRow row1= workTable.NewRow();

            //Le asigno valores a la fila
            row1["Cantidad de numeros"] = cantidad_nros;
            row1["Semilla"] = semilla;
            row1["K"] = const_k;
            row1["Constante Multiplicativa"] = multiplicador;
            row1["G"] = const_g;
            row1["Modulo"] = modulo;
            row1["Constante Aditiva"] = sumando;
            
            //Agrego la fila a la tabla
            workTable.Rows.Add(row1);

            //Asigno el data table al data grid view de las variables
            dg_datos.DataSource = workTable;

            //llamo a la funcion que carga los datos en la tabla de iteracion
            calcularYCargar();

            //Asigno el data table al data grid view de las iteraciones
            dg_iteraciones.DataSource = tabla_iteracion;

        }

        private void calcularYCargar()
        {
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
            for (int i = 0; i < cantidad_nros; i++)
            {
                //Creo la fila
                tabla_iteracion.Rows.Add();

                //Calculos
                int equis_i = (multiplicador * semilla) + sumando;
                int equis_i_mas_uno = equis_i % modulo;

                //Le asigno los valores
                tabla_iteracion.Rows[i]["Iteracion"] = i;
                tabla_iteracion.Rows[i]["a.Xi + c"] = equis_i;
                tabla_iteracion.Rows[i]["Xi + 1"] = equis_i % modulo;
                tabla_iteracion.Rows[i]["RND"] = (double)equis_i_mas_uno / (double)modulo;

                //Calculo el Xi + 1
                semilla = equis_i % modulo;
            }
        }

        private void btn_prueba_ajuste_Click(object sender, EventArgs e)
        {
            //Creo la tabla de las iteraciones
            DataTable tabla_ajuste = new DataTable();

            //Creo las columnas de la tabla
            DataColumn intervalo = new DataColumn("Intervalo");
            DataColumn fo = new DataColumn("Frecuencia observada (FO)");
            DataColumn fe = new DataColumn("Frecuencia esperada (FE)");
            DataColumn estadistico = new DataColumn("Estadístico de prueba (C)");
            DataColumn estadistico_acumulado = new DataColumn("Estadístico de prueba acumulado (CA)");

            //Agrego las columnas a la tabla
            tabla_ajuste.Columns.Add(intervalo);
            tabla_ajuste.Columns.Add(fo);
            tabla_ajuste.Columns.Add(fe);
            tabla_ajuste.Columns.Add(estadistico);
            tabla_ajuste.Columns.Add(estadistico_acumulado);

            //Calculo la cantidad de intervalos que es la raiz de n
            double cantidad_intervalos = Math.Truncate(Math.Sqrt(cantidad_nros));

            //Defino un array para almacenar los limites de cada intervalo que al ser x intervalos necesitan x+1 limites
            double[] intervalos_array = new double[(int)(cantidad_intervalos+1.0)];

            //Defino el primer limite que es cero
            intervalos_array[0] = 0.0;

            //Por la cantidad de intervalos, calculo el primer limite distinto de cero, el resto de intervalos se ven multiplicados por i
            for (int i = 1; i < cantidad_intervalos+1.0; i++)
            {
                intervalos_array[i] = Math.Round((1.0 / cantidad_intervalos) * i, 4);
            }

            //valor esperado
            double valor_esperado = cantidad_nros / cantidad_intervalos;

            //Defino un array que contenga la cantidad de valores observados
            int[] valores_observados = new int[(int)cantidad_intervalos];

            //Por cada fila de la tabla de iteraciones observo en que intervalo cae el valor observado
            for (int i = 0; i < tabla_iteracion.Rows.Count; i++)
            {
                //valor observado
                double random_observado = Convert.ToDouble(tabla_iteracion.Rows[i][3].ToString());

                //comparo los limites contra los random generados
                for (int j = 0; j < intervalos_array.Length-1; j++)
                {
                    if (random_observado >= intervalos_array[j] && random_observado < intervalos_array[j + 1])
                    {
                        valores_observados[j] += 1;
                    }
                }

            }

            //defino el estadistico de prueba acumulado
            double estadistico_de_prueba_acumulado = 0.0;

            for (int i = 0; i < cantidad_intervalos; i++)
            {
                //Creo la fila
                tabla_ajuste.Rows.Add();

                //le agrego el intervalo
                tabla_ajuste.Rows[i]["Intervalo"] = intervalos_array[i].ToString() + " - " + intervalos_array[i+1].ToString();

                //le agrego la frecuencia observada
                tabla_ajuste.Rows[i]["Frecuencia observada (FO)"] = valores_observados[i];

                //le agrego la frecuencia esperada
                tabla_ajuste.Rows[i]["Frecuencia esperada (FE)"] = Math.Round(valor_esperado, 0);

                //le agrego el estadistico de prueba
                double resta_de_frecuencias = valor_esperado - valores_observados[i];
                double resta_al_cuadrado = (Math.Pow(2.0, resta_de_frecuencias));
                double estadistico_de_prueba = Math.Round(resta_al_cuadrado / valor_esperado, 4);
                tabla_ajuste.Rows[i]["Estadístico de prueba (C)"] = estadistico_de_prueba;

                //le agrego el estadistico de prueba acumulado
                estadistico_de_prueba_acumulado += estadistico_de_prueba;
                tabla_ajuste.Rows[i]["Estadístico de prueba acumulado (CA)"] = estadistico_de_prueba_acumulado;
            }

            dg_prueba_ajuste.DataSource = tabla_ajuste;

        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
