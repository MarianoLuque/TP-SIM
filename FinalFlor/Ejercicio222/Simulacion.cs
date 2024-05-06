using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio222
{
    public partial class Simulacion : Form
    {
        //cantidad de eventos o minutos de simulacion 
        int cantidad;

        //Parametro para saber si el usuario eligió por cantidad de eventos o por cantidad de minutos
        string? parametro_cantidad;

        //Bandera para saber si se muestran los cheques
        bool mostrar_clientes;

        //reloj
        double reloj = 0;

        //numero de iteracion
        int cantidad_iteraciones = 0;

        //tiempos de llegada y atencion
        double tiempo_entre_llegadas = 0.0;
        double tiempo_entre_llegadas_con_porcentaje = 0.0;
        double tiempo_procesamiento_maquina1 = 0.0;
        double tiempo_procesamiento_maquina2 = 0.0;
        double tiempo_procesamiento_maquina3 = 0.0;
        double tiempo_procesamiento_maquina4 = 0.0;

        //tiempos de proxima llegada y fin atencion
        double tiempo_proxima_llegada = 0.0;

        //Medias de proximas llegadas y fin tiempo de atencion
        double media_llegadas;
        double media_llegadas_con_porcentaje;
        double media_maquina1;
        double media_maquina2;

        //array clientes
        List<Cliente> cheques_a_mostrar1;
        List<Cliente> cheques_a_mostrar2;
        List<Cliente> cheques_a_mostrar3;
        List<Cliente> cheques_a_mostrar4;
        int nro_cliente;
        int nro_cliente_desde_que_se_muestra;
        bool bandera_nro_cliente;

        //tablas con iteraciones
        DataTable tabla_iteraciones_1 = new DataTable();
        DataTable tabla_iteraciones_2 = new DataTable();
        DataTable tabla_iteraciones_3 = new DataTable();
        DataTable tabla_iteraciones_4 = new DataTable();
        int simulacion_desde;
        bool flag_tabla_cargada = false;
        int cantidad_a_mostrar;

        //randoms para los diferentes eventos (llegadas y atenciones)
        Random objeto_rnd_llegadas;
        Random objeto_rnd_llegadas_con_porcentaje;
        Random objeto_rnd_maquina1;
        Random objeto_rnd_maquina2;
        Random objeto_rnd_maquina3;
        Random objeto_rnd_maquina4;
        Random objeto_semilla;

        //Número entre 0 y 1 para calcular los tiempo según corresponda
        double rnd_llegadas;

        //Evento lanzado
        string Evento_lanzado;

        //Bandera para comprobar si es la primera vuelta
        bool flag_primera_vuelta;

        //Metrica máxima espera
        double maxima_espera_de_cheque;

#pragma warning disable CS8618
        public Simulacion(int cantidad, int cantidad_llegadas, int cantidad_cheques_maquina1, int cantidad_cheques_maquina2, int horas_llegadas, int horas_maquina1, int horas_maquina2, string parametro_cantidad, bool mostrar_clientes)
        {
            InitializeComponent();
            this.cantidad = cantidad;

            horas_llegadas = horas_llegadas/60;
            horas_maquina1 = horas_maquina1/60;
            horas_maquina2 = horas_maquina2/60;

            this.parametro_cantidad = parametro_cantidad;
            this.mostrar_clientes = mostrar_clientes;

            this.media_llegadas = (double)horas_llegadas / cantidad_llegadas;
            this.media_llegadas_con_porcentaje = (double)horas_llegadas / ((double)cantidad_llegadas*1.2);
            this.media_maquina1 = (double)horas_maquina1 / cantidad_cheques_maquina1;
            this.media_maquina2 = (double)horas_maquina2 / cantidad_cheques_maquina2;

            if (parametro_cantidad == "minutos")
            {
                lbl_desde.Text = "Ingrese desde que hora mostrar";
            }
        }
        private void Simulacion_Load(object sender, EventArgs e)
        {
            if (parametro_cantidad == "minutos")
            {
                lbl_desde.Text = lbl_desde.Text + " (Desde 0 hasta un valor menor a " + (cantidad.ToString()) + ")";
            }
            else
            {
                lbl_desde.Text = lbl_desde.Text + "(Desde 0 hasta " + (cantidad - 400).ToString() + ")";
            }
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            objeto_semilla = new Random();
            objeto_rnd_llegadas = new Random(objeto_semilla.Next());
            objeto_rnd_llegadas_con_porcentaje = new Random(objeto_semilla.Next());
            objeto_rnd_maquina1 = new Random(objeto_semilla.Next());
            objeto_rnd_maquina2 = new Random(objeto_semilla.Next());
            objeto_rnd_maquina3 = new Random(objeto_semilla.Next());
            objeto_rnd_maquina4 = new Random(objeto_semilla.Next());


            //pregunto si el programa ya se ejecuto
            if (flag_tabla_cargada)
            {
                //desligo la tabla del data source
                dg_colas_1.DataSource = null;
                dg_colas_2.DataSource = null;
                dg_colas_3.DataSource = null;
                dg_colas_4.DataSource = null;
                //limpiar las filas
                tabla_iteraciones_1.Rows.Clear();
                tabla_iteraciones_2.Rows.Clear();
                tabla_iteraciones_3.Rows.Clear();
                tabla_iteraciones_4.Rows.Clear();
                for (int i = nro_cliente_desde_que_se_muestra; i < (cheques_a_mostrar1.Count + nro_cliente_desde_que_se_muestra); i++)
                {
                    tabla_iteraciones_1.Columns.Remove("Estado cheque" + i.ToString());
                    tabla_iteraciones_1.Columns.Remove("Hora llegada cheque" + i.ToString());
                }
                for (int i = nro_cliente_desde_que_se_muestra; i < (cheques_a_mostrar2.Count + nro_cliente_desde_que_se_muestra); i++)
                {
                    tabla_iteraciones_2.Columns.Remove("Estado cheque" + i.ToString());
                    tabla_iteraciones_2.Columns.Remove("Hora llegada cheque" + i.ToString());
                }
                for (int i = nro_cliente_desde_que_se_muestra; i < (cheques_a_mostrar3.Count + nro_cliente_desde_que_se_muestra); i++)
                {
                    tabla_iteraciones_3.Columns.Remove("Estado cheque" + i.ToString());
                    tabla_iteraciones_3.Columns.Remove("Hora llegada cheque" + i.ToString());
                }
                for (int i = nro_cliente_desde_que_se_muestra; i < (cheques_a_mostrar4.Count + nro_cliente_desde_que_se_muestra); i++)
                {
                    tabla_iteraciones_4.Columns.Remove("Estado cheque" + i.ToString());
                    tabla_iteraciones_4.Columns.Remove("Hora llegada cheque" + i.ToString());
                }

            }
            else
            {
                //si no se ejecuto cargo las columnas de la tabla
                cargarTabla();
                flag_tabla_cargada = true;
            }

            volverACero();

            Servidor maquina1 = new Servidor(Servidor.Tipo.MAQUINA1);
            Servidor maquina2 = new Servidor(Servidor.Tipo.MAQUINA2);
            Servidor maquina3 = new Servidor(Servidor.Tipo.MAQUINA3);
            Servidor maquina4 = new Servidor(Servidor.Tipo.MAQUINA4);
            List<Servidor> maquinas = new List<Servidor> { maquina1, maquina2, maquina3, maquina4 };
            int maquinaIndex = 0;

            if (parametro_cantidad == "minutos")
            {
                if (!int.TryParse(txt_desde.Text, out simulacion_desde) || simulacion_desde >= (cantidad))
                {
                    MessageBox.Show("Ingrese desde que simulación se debe mostrar (valor mayor a 0 y menor a " + (cantidad).ToString() + ")", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                //recorro la lista maquinas para armar cada tabla
                foreach(Servidor maquina in maquinas)
                {
                    // Determinar la tabla y los cheques a mostrar correspondientes según el índice de la máquina
                    DataTable tablaIteraciones;
                    List<Cliente> cheques;
                    switch (maquinaIndex)
                    {
                        case 0:
                            tablaIteraciones = tabla_iteraciones_1;
                            cheques = cheques_a_mostrar1;
                            break;
                        case 1:
                            tablaIteraciones = tabla_iteraciones_2;
                            cheques = cheques_a_mostrar2;
                            break;
                        case 2:
                            tablaIteraciones = tabla_iteraciones_3;
                            cheques = cheques_a_mostrar3;
                            break;
                        case 3:
                            tablaIteraciones = tabla_iteraciones_4;
                            cheques = cheques_a_mostrar4;
                            break;
                        default:
                            tablaIteraciones = tabla_iteraciones_1;
                            cheques = cheques_a_mostrar1;
                            break;
                    }
                    while (reloj < cantidad)
                    {
                        siguiente_secuencia(maquina);

                        if (reloj >= simulacion_desde && cantidad_a_mostrar < 400)
                        {
                            cargar_datos_tabla(cantidad_a_mostrar, maquina, tablaIteraciones, cheques);
                            cantidad_a_mostrar += 1;
                        }

                        if (cantidad_a_mostrar >= 400 && reloj >= cantidad)
                        {
                            cargar_datos_tabla(400, maquina, tablaIteraciones, cheques);
                        }
                    }
                }
            }

            if (parametro_cantidad == "eventos")
            {
                if (!int.TryParse(txt_desde.Text, out simulacion_desde) || simulacion_desde > (cantidad - 400))
                {
                    MessageBox.Show("Ingrese desde que simulación se debe mostrar (valor mayor a 0 y menor a " + (cantidad - 400).ToString() + ")", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //recorro la lista maquinas para armar cada tabla
                foreach (Servidor maquina in maquinas)
                {
                    // Determinar la tabla y los cheques a mostrar correspondientes según el índice de la máquina
                    DataTable tablaIteraciones;
                    List<Cliente> cheques;
                    switch (maquinaIndex)
                    {
                        case 0:
                            tablaIteraciones = tabla_iteraciones_1;
                            cheques = cheques_a_mostrar1;
                            break;
                        case 1:
                            tablaIteraciones = tabla_iteraciones_2;
                            cheques = cheques_a_mostrar2;
                            break;
                        case 2:
                            tablaIteraciones = tabla_iteraciones_3;
                            cheques = cheques_a_mostrar3;
                            break;
                        case 3:
                            tablaIteraciones = tabla_iteraciones_4;
                            cheques = cheques_a_mostrar4;
                            break;
                        default:
                            tablaIteraciones = tabla_iteraciones_1;
                            cheques = cheques_a_mostrar1;
                            break;
                    }
                    while (cantidad_iteraciones < cantidad)
                    {
                        siguiente_secuencia(maquina);

                        if (cantidad_iteraciones >= simulacion_desde && cantidad_iteraciones < simulacion_desde + 400)
                        {
                            cargar_datos_tabla(cantidad_iteraciones - simulacion_desde, maquina, tablaIteraciones, cheques);
                        }
                        cantidad_iteraciones += 1;

                        if (cantidad_iteraciones == cantidad && cantidad_iteraciones != (simulacion_desde + 400))
                        {
                            cargar_datos_tabla(400, maquina, tablaIteraciones, cheques);
                        }
                    }
                }
            }

            dg_colas_1.DataSource = tabla_iteraciones_1;
            dg_colas_2.DataSource = tabla_iteraciones_2;
            dg_colas_3.DataSource = tabla_iteraciones_3;
            dg_colas_4.DataSource = tabla_iteraciones_4;

            //Modificaciones esteticas
            //ModificarColumnas();

            //Mostrar resultados

        }

        private void cargar_datos_tabla(int cantidad_iteraciones, Servidor maquina, DataTable tabla_iteraciones, List<Cliente> cheques)
        {
            tabla_iteraciones.Rows.Add();
            //Cargar columnas y mostrarlas
            tabla_iteraciones.Rows[cantidad_iteraciones]["Evento"] = Evento_lanzado;
            tabla_iteraciones.Rows[cantidad_iteraciones]["Reloj (hs)"] = reloj;

            if (cantidad_iteraciones != 0)
            {
                if (tiempo_proxima_llegada.ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Proxima llegada"].ToString())
                { 
                    rnd_llegadas = 0;
                    tiempo_entre_llegadas = 0;
                }

                switch (maquina.GetTipo())
                {
                    case Servidor.Tipo.MAQUINA1:
                        if (maquina.GetFinProcesamiento().ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Tiempo procesamiento maquina"].ToString())
                        {  
                            tiempo_procesamiento_maquina1 = 0;
                        }
                        break;
                    case Servidor.Tipo.MAQUINA2:
                        if (maquina.GetFinProcesamiento().ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Tiempo procesamiento maquina"].ToString())
                        { 
                            tiempo_procesamiento_maquina2 = 0;
                        }
                        break;
                    case Servidor.Tipo.MAQUINA3:
                        if (maquina.GetFinProcesamiento().ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Tiempo procesamiento maquina"].ToString())
                        { 
                            tiempo_procesamiento_maquina3 = 0;
                        }
                        break;
                    case Servidor.Tipo.MAQUINA4:
                        if (maquina.GetFinProcesamiento().ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Tiempo procesamiento maquina"].ToString())
                        { 
                            tiempo_procesamiento_maquina4 = 0;
                        }
                        break;
                    default:
                        break;
                }
            }

            tabla_iteraciones.Rows[cantidad_iteraciones]["RND llegada cheque"] = rnd_llegadas.ToString() == "0" ? "" : rnd_llegadas.ToString();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo entre llegadas"] = tiempo_entre_llegadas.ToString() == "0" ? "" : tiempo_entre_llegadas.ToString();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Proxima llegada"] = tiempo_proxima_llegada.ToString() == "0" ? "" : tiempo_proxima_llegada.ToString();

            

            switch (maquina.GetTipo())
            {
                case Servidor.Tipo.MAQUINA1:
                    tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo procesamiento maquina"] = tiempo_procesamiento_maquina1.ToString() == "0" ? "" : tiempo_procesamiento_maquina1.ToString();
                    tabla_iteraciones.Rows[cantidad_iteraciones]["Fin procesamiento maquina"] = maquina.GetFinProcesamiento().ToString() == "0" ? "" : maquina.GetFinProcesamiento().ToString();
                    break;
                case Servidor.Tipo.MAQUINA2:
                    tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo procesamiento maquina"] = tiempo_procesamiento_maquina2.ToString() == "0" ? "" : tiempo_procesamiento_maquina2.ToString();
                    tabla_iteraciones.Rows[cantidad_iteraciones]["Fin procesamiento maquina"] = maquina.GetFinProcesamiento().ToString() == "0" ? "" : maquina.GetFinProcesamiento().ToString();
                    break;
                case Servidor.Tipo.MAQUINA3:
                    tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo procesamiento maquina"] = tiempo_procesamiento_maquina3.ToString() == "0" ? "" : tiempo_procesamiento_maquina3.ToString();
                    tabla_iteraciones.Rows[cantidad_iteraciones]["Fin procesamiento maquina"] = maquina.GetFinProcesamiento().ToString() == "0" ? "" : maquina.GetFinProcesamiento().ToString();
                    break;
                case Servidor.Tipo.MAQUINA4:
                    tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo procesamiento maquina"] = tiempo_procesamiento_maquina4.ToString() == "0" ? "" : tiempo_procesamiento_maquina4.ToString();
                    tabla_iteraciones.Rows[cantidad_iteraciones]["Fin procesamiento maquina"] = maquina.GetFinProcesamiento().ToString() == "0" ? "" : maquina.GetFinProcesamiento().ToString();
                    break;
                default:
                    break;
            }

            tabla_iteraciones.Rows[cantidad_iteraciones]["Estado maquina"] = maquina.GetEstado();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Cola maquina"] = maquina.GetColaCheques().Count;

            //Metrica 
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo de espera maximo de un cheque"] = maxima_espera_de_cheque;
            
            //Clientes
            if (mostrar_clientes)
            {
                string estado_cliente_nro = "Estado cliente" + nro_cliente.ToString();
                string hora_llegada_cliente_nro = "Hora llegada cliente" + nro_cliente.ToString();
                int estado_cliente;
                string estado_cliente_string;
                for (int i = 0; i < cheques.Count; i++)
                {
                    estado_cliente = (int)cheques[i].GetEstado();
                    if (estado_cliente == 0) { estado_cliente_string = "EP"; }
                    else if (estado_cliente == 1) { estado_cliente_string = "SP"; }
                    else { estado_cliente_string = "FDS"; }

                    tabla_iteraciones.Rows[cantidad_iteraciones]["Estado cliente" + (i + nro_cliente_desde_que_se_muestra).ToString()] = estado_cliente_string;
                    tabla_iteraciones.Rows[cantidad_iteraciones]["Hora llegada cliente" + (i + nro_cliente_desde_que_se_muestra).ToString()] = cheques[i].GetHoraLlegadaAlSistema();
                }
            }
        }

        private void cargarTabla()
        {
            // Primer data grid
            DataColumn evento_1 = new DataColumn("Evento");
            DataColumn columna_reloj_1 = new DataColumn("Reloj (hs)");
            DataColumn columna_rnd_llegada_1 = new DataColumn("RND llegada cheque");
            DataColumn columna_tiempo_entre_llegadas_1 = new DataColumn("Tiempo entre llegadas");
            DataColumn columna_proxima_llegada_1 = new DataColumn("Proxima llegada");
            DataColumn columna_tiempo_procesamiento_maquina_1 = new DataColumn("Tiempo procesamiento maquina");
            DataColumn columna_fin_procesamiento_maquina_1 = new DataColumn("Fin procesamiento maquina");
            DataColumn columna_estado_maquina_1 = new DataColumn("Estado maquina");
            DataColumn columna_cola_maquina_1 = new DataColumn("Cola maquina");
            DataColumn columna_maxima_espera_de_cheque_1 = new DataColumn("Tiempo de espera maximo de un cheque");

            tabla_iteraciones_1.Columns.Add(evento_1);
            tabla_iteraciones_1.Columns.Add(columna_reloj_1);
            tabla_iteraciones_1.Columns.Add(columna_rnd_llegada_1);
            tabla_iteraciones_1.Columns.Add(columna_tiempo_entre_llegadas_1);
            tabla_iteraciones_1.Columns.Add(columna_proxima_llegada_1);
            tabla_iteraciones_1.Columns.Add(columna_tiempo_procesamiento_maquina_1);
            tabla_iteraciones_1.Columns.Add(columna_fin_procesamiento_maquina_1);
            tabla_iteraciones_1.Columns.Add(columna_estado_maquina_1);
            tabla_iteraciones_1.Columns.Add(columna_cola_maquina_1);
            tabla_iteraciones_1.Columns.Add(columna_maxima_espera_de_cheque_1);

            // Segundo data grid
            DataColumn evento_2 = new DataColumn("Evento");
            DataColumn columna_reloj_2 = new DataColumn("Reloj (hs)");
            DataColumn columna_rnd_llegada_2 = new DataColumn("RND llegada cheque");
            DataColumn columna_tiempo_entre_llegadas_2 = new DataColumn("Tiempo entre llegadas");
            DataColumn columna_proxima_llegada_2 = new DataColumn("Proxima llegada");
            DataColumn columna_tiempo_procesamiento_maquina_2 = new DataColumn("Tiempo procesamiento maquina");
            DataColumn columna_fin_procesamiento_maquina_2 = new DataColumn("Fin procesamiento maquina");
            DataColumn columna_estado_maquina_2 = new DataColumn("Estado maquina");
            DataColumn columna_cola_maquina_2 = new DataColumn("Cola maquina");
            DataColumn columna_maxima_espera_de_cheque_2 = new DataColumn("Tiempo de espera maximo de un cheque");

            tabla_iteraciones_2.Columns.Add(evento_2);
            tabla_iteraciones_2.Columns.Add(columna_reloj_2);
            tabla_iteraciones_2.Columns.Add(columna_rnd_llegada_2);
            tabla_iteraciones_2.Columns.Add(columna_tiempo_entre_llegadas_2);
            tabla_iteraciones_2.Columns.Add(columna_proxima_llegada_2);
            tabla_iteraciones_2.Columns.Add(columna_tiempo_procesamiento_maquina_2);
            tabla_iteraciones_2.Columns.Add(columna_fin_procesamiento_maquina_2);
            tabla_iteraciones_2.Columns.Add(columna_estado_maquina_2);
            tabla_iteraciones_2.Columns.Add(columna_cola_maquina_2);
            tabla_iteraciones_2.Columns.Add(columna_maxima_espera_de_cheque_2);

            // Tercer data grid
            DataColumn evento_3 = new DataColumn("Evento");
            DataColumn columna_reloj_3 = new DataColumn("Reloj (hs)");
            DataColumn columna_rnd_llegada_3 = new DataColumn("RND llegada cheque");
            DataColumn columna_tiempo_entre_llegadas_3 = new DataColumn("Tiempo entre llegadas");
            DataColumn columna_proxima_llegada_3 = new DataColumn("Proxima llegada");
            DataColumn columna_tiempo_procesamiento_maquina_3 = new DataColumn("Tiempo procesamiento maquina");
            DataColumn columna_fin_procesamiento_maquina_3 = new DataColumn("Fin procesamiento maquina");
            DataColumn columna_estado_maquina_3 = new DataColumn("Estado maquina");
            DataColumn columna_cola_maquina_3 = new DataColumn("Cola maquina");
            DataColumn columna_maxima_espera_de_cheque_3 = new DataColumn("Tiempo de espera maximo de un cheque");

            tabla_iteraciones_3.Columns.Add(evento_3);
            tabla_iteraciones_3.Columns.Add(columna_reloj_3);
            tabla_iteraciones_3.Columns.Add(columna_rnd_llegada_3);
            tabla_iteraciones_3.Columns.Add(columna_tiempo_entre_llegadas_3);
            tabla_iteraciones_3.Columns.Add(columna_proxima_llegada_3);
            tabla_iteraciones_3.Columns.Add(columna_tiempo_procesamiento_maquina_3);
            tabla_iteraciones_3.Columns.Add(columna_fin_procesamiento_maquina_3);
            tabla_iteraciones_3.Columns.Add(columna_estado_maquina_3);
            tabla_iteraciones_3.Columns.Add(columna_cola_maquina_3);
            tabla_iteraciones_3.Columns.Add(columna_maxima_espera_de_cheque_3);

            // Cuarto data grid
            DataColumn evento_4 = new DataColumn("Evento");
            DataColumn columna_reloj_4 = new DataColumn("Reloj (hs)");
            DataColumn columna_rnd_llegada_4 = new DataColumn("RND llegada cheque");
            DataColumn columna_tiempo_entre_llegadas_4 = new DataColumn("Tiempo entre llegadas");
            DataColumn columna_proxima_llegada_4 = new DataColumn("Proxima llegada");
            DataColumn columna_tiempo_procesamiento_maquina_4 = new DataColumn("Tiempo procesamiento maquina");
            DataColumn columna_fin_procesamiento_maquina_4 = new DataColumn("Fin procesamiento maquina");
            DataColumn columna_estado_maquina_4 = new DataColumn("Estado maquina");
            DataColumn columna_cola_maquina_4 = new DataColumn("Cola maquina");
            DataColumn columna_maxima_espera_de_cheque_4 = new DataColumn("Tiempo de espera maximo de un cheque");

            tabla_iteraciones_4.Columns.Add(evento_4);
            tabla_iteraciones_4.Columns.Add(columna_reloj_4);
            tabla_iteraciones_4.Columns.Add(columna_rnd_llegada_4);
            tabla_iteraciones_4.Columns.Add(columna_tiempo_entre_llegadas_4);
            tabla_iteraciones_4.Columns.Add(columna_proxima_llegada_4);
            tabla_iteraciones_4.Columns.Add(columna_tiempo_procesamiento_maquina_4);
            tabla_iteraciones_4.Columns.Add(columna_fin_procesamiento_maquina_4);
            tabla_iteraciones_4.Columns.Add(columna_estado_maquina_4);
            tabla_iteraciones_4.Columns.Add(columna_cola_maquina_4);
            tabla_iteraciones_4.Columns.Add(columna_maxima_espera_de_cheque_4);
        }

        private void volverACero()
        {
            //reloj
            reloj = 0;

            Evento_lanzado = "";

            //numero de iteracion
            cantidad_iteraciones = 0;

            //tiempos de llegada y atencion
            tiempo_entre_llegadas = 0.0;
            tiempo_entre_llegadas_con_porcentaje = 0.0;
            tiempo_procesamiento_maquina1 = 0.0;
            tiempo_procesamiento_maquina2 = 0.0;
            tiempo_procesamiento_maquina3 = 0.0;
            tiempo_procesamiento_maquina4 = 0.0;

            //tiempos de proxima llegada y fin atencion
            tiempo_proxima_llegada = 0.0;

            //array clientes
            cheques_a_mostrar1 = new List<Cliente>();
            cheques_a_mostrar2 = new List<Cliente>();
            cheques_a_mostrar3 = new List<Cliente>();
            cheques_a_mostrar4 = new List<Cliente>();

            //randoms 
            rnd_llegadas = 0.0;

            //limpiar labels de resultados


            bandera_nro_cliente = true;
            nro_cliente = 0;
            nro_cliente_desde_que_se_muestra = 0;

        }

        private void calcularProximaLlegada(Servidor maquina)
        {
            double media;
            Random random;
            //si la maquina es 1 o 2 se calcula con la media de llegadas sin el 20 porciento extra
            if(maquina.GetTipo() == Servidor.Tipo.MAQUINA1 | maquina.GetTipo() == Servidor.Tipo.MAQUINA2)
            {
                media = media_llegadas;
                random = objeto_rnd_llegadas;
            }
            else
            {
                media = media_llegadas_con_porcentaje;
                random = objeto_rnd_llegadas_con_porcentaje;
            }
            rnd_llegadas = (Math.Truncate(random.NextDouble() * 100)) / 100;
            //calculo el tiempo entre llegadas para la distribución exponencial
            tiempo_entre_llegadas = Math.Truncate(((-media) * (Math.Log(1 - rnd_llegadas))) * 100) / 100;
            //registro la proxima llegada
            tiempo_proxima_llegada = Math.Truncate((reloj + tiempo_entre_llegadas) * 100) / 100;
        }

        private void siguiente_secuencia(Servidor maquina)
        {
            //En la primera vuelta solo va a calcular la proxima llegada
            if (!flag_primera_vuelta)
            {
                flag_primera_vuelta = true;
                calcularProximaLlegada(maquina);
            }
            //Sino se va a producir una llegada, un fin de procesamiento o un fin de simulación
            else
            {
                if (reloj > cantidad)
                {
                    reloj = cantidad;
                    Evento_lanzado = "Fin de simulación";
                }
                else
                {
                    //Si el tiempo de proxima llegada es menor al tiempo de fin de procesamiento se da una llegada
                    if(maquina.GetFinProcesamiento() > tiempo_proxima_llegada)
                    {
                        EventoLlegadaCheque(maquina);
                    }
                    //Sino se da un fin de procesamiento
                    else
                    {
                        EventoFinProcesamiento(maquina);
                    }
                }
            }
        }

        private void metricaMaximaEspera(Cliente cheque_procesado)
        {
            double espera_cheque = reloj - cheque_procesado.GetHoraLlegadaAlSistema();
            if(espera_cheque > maxima_espera_de_cheque)
            {
                maxima_espera_de_cheque = espera_cheque;
            }
        }

        private void EventoFinProcesamiento(Servidor maquina)
        {
            if(maquina.GetColaCheques() != null && maquina.GetColaCheques().Count > 0)
            {
                Cliente? cheque_procesado = maquina.GetCliente();
                cheque_procesado.SetEstado(Cliente.Estados.FUERA_DEL_SISTEMA);
                metricaMaximaEspera(cheque_procesado);
                Cliente cheque_a_procesar = maquina.GetColaCheques()[0];
                cheque_a_procesar.SetEstado(Cliente.Estados.SIENDO_PROCESADO);
                maquina.SetCliente(cheque_a_procesar);
                maquina.EliminarClienteDeCola();
                calcularFinProcesamiento(maquina);
            }
            else
            {
                maquina.SetEstado(Servidor.Estados.libre);
                maquina.SetCliente(null);
                maquina.SetFinProcesamiento(0.0);
            }
        }

        private void EventoLlegadaCheque(Servidor maquina)
        {
            Cliente nuevo_cheque = new Cliente(reloj);

            if (maquina.GetEstado() == Servidor.Estados.libre)
            {
                nuevo_cheque.SetEstado(Cliente.Estados.SIENDO_PROCESADO);
                maquina.SetCliente(nuevo_cheque);
                maquina.SetEstado(Servidor.Estados.ocupado);
                calcularFinProcesamiento(maquina);
            }
            else
            {
                nuevo_cheque.SetEstado(Cliente.Estados.ESPERANDO_PROCESAMIENTO);
                maquina.AgregarClienteACola(nuevo_cheque);
            }
            calcularProximaLlegada(maquina);

            if (mostrar_clientes)
            {
                if (parametro_cantidad == "eventos")
                {
                    if (cantidad_iteraciones >= simulacion_desde && cantidad_iteraciones < simulacion_desde + 400)
                    {
                        switch (maquina.GetTipo())
                        {
                            case Servidor.Tipo.MAQUINA1:
                                cheques_a_mostrar1.Add(nuevo_cheque);
                                agregar_cliente(tabla_iteraciones_1);
                                break;
                            case Servidor.Tipo.MAQUINA2:
                                cheques_a_mostrar2.Add(nuevo_cheque);
                                agregar_cliente(tabla_iteraciones_2);
                                break;
                            case Servidor.Tipo.MAQUINA3:
                                cheques_a_mostrar3.Add(nuevo_cheque);
                                agregar_cliente(tabla_iteraciones_3);
                                break;
                            case Servidor.Tipo.MAQUINA4:
                                cheques_a_mostrar4.Add(nuevo_cheque);
                                agregar_cliente(tabla_iteraciones_4);
                                break;
                            default:
                                throw new ArgumentException("Tipo de máquina no válido.");
                        }
                    }
                }
                else
                {
                    if (reloj >= simulacion_desde && cantidad_a_mostrar < 400)
                    {
                        switch (maquina.GetTipo())
                        {
                            case Servidor.Tipo.MAQUINA1:
                                cheques_a_mostrar1.Add(nuevo_cheque);
                                agregar_cliente(tabla_iteraciones_1);
                                break;
                            case Servidor.Tipo.MAQUINA2:
                                cheques_a_mostrar2.Add(nuevo_cheque);
                                agregar_cliente(tabla_iteraciones_2);
                                break;
                            case Servidor.Tipo.MAQUINA3:
                                cheques_a_mostrar3.Add(nuevo_cheque);
                                agregar_cliente(tabla_iteraciones_3);
                                break;
                            case Servidor.Tipo.MAQUINA4:
                                cheques_a_mostrar4.Add(nuevo_cheque);
                                agregar_cliente(tabla_iteraciones_4);
                                break;
                            default:
                                throw new ArgumentException("Tipo de máquina no válido.");
                        }
                    }
                }
                nro_cliente += 1;
            }
        }

        private void agregar_cliente(DataTable tabla_iteraciones)
        {
            string estado_cliente_nro = "Estado cliente" + nro_cliente.ToString();
            string hora_llegada_cliente_nro = "Hora llegada cliente" + nro_cliente.ToString();
            DataColumn columna_estado_cliente = new DataColumn(estado_cliente_nro);
            DataColumn columna_hora_llegada_cliente = new DataColumn(hora_llegada_cliente_nro);
            tabla_iteraciones.Columns.Add(columna_estado_cliente);
            tabla_iteraciones.Columns.Add(columna_hora_llegada_cliente);
            if (nro_cliente_desde_que_se_muestra == 0 && bandera_nro_cliente)
            {
                nro_cliente_desde_que_se_muestra = nro_cliente;
                bandera_nro_cliente = false;
            }
        }

        private void calcularFinProcesamiento(Servidor maquina)
        {
            //hacer referencia desde myObject a un objeto de la clase random de los definidos como objeto_rnd_maquina1, objeto_rnd_maquina2, objeto_rnd_maquina3, objeto_rnd_maquina4 dependiendo si el servidor es del tipo 1, 2, 3 o 4

            // Obtener el objeto Random correspondiente
            (Random myObject, double lambda) = ObtenerRandomYLambdaSegunTipoMaquina(maquina);
            double p = 1;
            double x = -1;
            double A = Math.Exp(-lambda);
            do
            {
                double random_p = (Math.Truncate(myObject.NextDouble() * 10000)) / 10000;
                p = (p * random_p);
                x = x + 1;
            } while (p >= A);
            x = Math.Truncate(x * 100) / 100;
            maquina.SetFinProcesamiento(reloj + x);
        }

        private (Random, double) ObtenerRandomYLambdaSegunTipoMaquina(Servidor maquina)
        {
            switch (maquina.GetTipo())
            {
                case Servidor.Tipo.MAQUINA1:
                    return (objeto_rnd_maquina1, this.media_maquina1);
                case Servidor.Tipo.MAQUINA2:
                    return (objeto_rnd_maquina2, this.media_maquina2);
                case Servidor.Tipo.MAQUINA3:
                    return (objeto_rnd_maquina3, this.media_maquina1);
                case Servidor.Tipo.MAQUINA4:
                    return (objeto_rnd_maquina4, this.media_maquina2);
                default:
                    throw new ArgumentException("Tipo de máquina no válido.");
            }
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
