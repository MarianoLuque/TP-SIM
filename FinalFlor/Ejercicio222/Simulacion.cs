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

        //cantidad de cheques que llegan
        int cantidad_llegadas;
        int cantidad_cheques_maquina1;
        int cantidad_cheques_maquina2;

        //horas en los que llegan los cheques
        int horas_llegadas;
        int horas_maquina1;
        int horas_maquina2;

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
        double tiempo_proxima_llegada_con_porcentaje = 0.0;
        double tiempo_fin_atencion_maquina1 = 0.0;
        double tiempo_fin_atencion_maquina2 = 0.0;
        double tiempo_fin_atencion_maquina3 = 0.0;
        double tiempo_fin_atencion_maquina4 = 0.0;

        //Medias de proximas llegadas y fin tiempo de atencion
        double media_llegadas;
        double media_llegadas_con_porcentaje;
        double media_maquina1;
        double media_maquina2;
        double media_maquina3;
        double media_maquina4;

        //Cola para los servidores
        List<Cliente> cola_cheques_maquina1;
        List<Cliente> cola_cheques_maquina2;
        List<Cliente> cola_cheques_maquina3;
        List<Cliente> cola_cheques_maquina4;

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
        double rnd_llegadas_con_porcentaje; 
        double rnd_maquina1;
        double rnd_maquina2;
        double rnd_maquina3;
        double rnd_maquina4;

        //Evento lanzado
        string Evento_lanzado;

        //Bandera para comprobar si es la primera vuelta
        bool flag_primera_vuelta;

#pragma warning disable CS8618
        public Simulacion(int cantidad, int cantidad_llegadas, int cantidad_cheques_maquina1, int cantidad_cheques_maquina2, int horas_llegadas, int horas_maquina1, int horas_maquina2, string parametro_cantidad, bool mostrar_clientes)
        {
            InitializeComponent();
            this.cantidad = cantidad;
            
            this.cantidad_llegadas = cantidad_llegadas;
            this.cantidad_cheques_maquina1 = cantidad_cheques_maquina1;
            this.cantidad_cheques_maquina2 = cantidad_cheques_maquina2;

            this.horas_llegadas = horas_llegadas;
            this.horas_maquina1 = horas_maquina1;
            this.horas_maquina2 = horas_maquina2;

            this.parametro_cantidad = parametro_cantidad;
            this.mostrar_clientes = mostrar_clientes;

            this.media_llegadas = (double)horas_llegadas / cantidad_llegadas;
            this.media_llegadas_con_porcentaje = (double)horas_llegadas / ((double)cantidad_llegadas*1.2);
            this.media_maquina1 = (double)horas_maquina1 / cantidad_cheques_maquina1;
            this.media_maquina2 = (double)horas_maquina2 / cantidad_cheques_maquina2;
            this.media_maquina3 = (double)horas_maquina1 / cantidad_cheques_maquina1;
            this.media_maquina4 = (double)horas_maquina2 / cantidad_cheques_maquina2;

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

            Servidor maquina1 = new Servidor();
            Servidor maquina2 = new Servidor();
            Servidor maquina3 = new Servidor();
            Servidor maquina4 = new Servidor();

            if (parametro_cantidad == "minutos")
            {
                if (!int.TryParse(txt_desde.Text, out simulacion_desde) || simulacion_desde >= (cantidad))
                {
                    MessageBox.Show("Ingrese desde que simulación se debe mostrar (valor mayor a 0 y menor a " + (cantidad).ToString() + ")", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                while (reloj < cantidad)
                {
                    siguiente_secuencia();

                    if (reloj >= simulacion_desde && cantidad_a_mostrar < 400)
                    {
                        cargar_datos_tabla(cantidad_a_mostrar);
                        cantidad_a_mostrar += 1;
                    }

                    if (cantidad_a_mostrar >= 400 && reloj >= cantidad)
                    {
                        cargar_datos_tabla(400);
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


                while (cantidad_iteraciones < cantidad)
                {
                    siguiente_secuencia();

                    if (cantidad_iteraciones >= simulacion_desde && cantidad_iteraciones < simulacion_desde + 400)
                    {
                        cargar_datos_tabla(cantidad_iteraciones - simulacion_desde);
                    }
                    cantidad_iteraciones += 1;

                    if (cantidad_iteraciones == cantidad && cantidad_iteraciones != (simulacion_desde + 400))
                    {
                        cargar_datos_tabla(400);
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

        private void cargarTabla()
        {
            //Evento y reloj
            DataColumn evento = new DataColumn("Evento");
            DataColumn columna_reloj = new DataColumn("Reloj (min)");
            
            //Llegada cheque
            DataColumn columna_rnd_llegada = new DataColumn("RND llegada cheque");
            DataColumn columna_tiempo_entre_llegadas = new DataColumn("Tiempo entre llegadas");
            DataColumn columna_proxima_llegada = new DataColumn("Proxima llegada");
            
            //Atencion maquina 1
            DataColumn columna_rnd_procesamiento_maquina_1 = new DataColumn("RND procesamiento maquina 1");
            DataColumn columna_tiempo_procesamiento_maquina_1 = new DataColumn("Tiempo procesamiento maquina 1");
            DataColumn columna_fin_procesamiento_maquina_1 = new DataColumn("Fin procesamiento maquina 1");

            //Estado y cola maquina 1
            DataColumn columna_estado_maquina_1 = new DataColumn("Estado maquina 1");
            DataColumn columna_cola_maquina_1 = new DataColumn("Cola maquina 1");

            //Metrica 1
            DataColumn columna_maxima_espera_de_cheque = new DataColumn("Tiempo de espera máximo de un cheque");

            //Atencion maquina 2
            DataColumn columna_rnd_procesamiento_maquina_2 = new DataColumn("RND procesamiento maquina 2");
            DataColumn columna_tiempo_procesamiento_maquina_2 = new DataColumn("Tiempo procesamiento maquina 2");
            DataColumn columna_fin_procesamiento_maquina_2 = new DataColumn("Fin procesamiento maquina 2");

            //Estado y cola maquina 2
            DataColumn columna_estado_maquina_2 = new DataColumn("Estado maquina 2");
            DataColumn columna_cola_maquina_2 = new DataColumn("Cola maquina 2");

            //Primer data grid
            tabla_iteraciones_1.Columns.Add(evento);
            tabla_iteraciones_1.Columns.Add(columna_reloj);
            tabla_iteraciones_1.Columns.Add(columna_rnd_llegada);
            tabla_iteraciones_1.Columns.Add(columna_tiempo_entre_llegadas);
            tabla_iteraciones_1.Columns.Add(columna_proxima_llegada);
            tabla_iteraciones_1.Columns.Add(columna_rnd_procesamiento_maquina_1);
            tabla_iteraciones_1.Columns.Add(columna_tiempo_procesamiento_maquina_1);
            tabla_iteraciones_1.Columns.Add(columna_fin_procesamiento_maquina_1);
            tabla_iteraciones_1.Columns.Add(columna_estado_maquina_1);
            tabla_iteraciones_1.Columns.Add(columna_cola_maquina_1);
            tabla_iteraciones_1.Columns.Add(columna_maxima_espera_de_cheque);

            //Segundo data grid
            tabla_iteraciones_2.Columns.Add(evento);
            tabla_iteraciones_2.Columns.Add(columna_reloj);
            tabla_iteraciones_2.Columns.Add(columna_rnd_llegada);
            tabla_iteraciones_2.Columns.Add(columna_tiempo_entre_llegadas);
            tabla_iteraciones_2.Columns.Add(columna_proxima_llegada);
            tabla_iteraciones_2.Columns.Add(columna_rnd_procesamiento_maquina_2);
            tabla_iteraciones_2.Columns.Add(columna_tiempo_procesamiento_maquina_2);
            tabla_iteraciones_2.Columns.Add(columna_fin_procesamiento_maquina_2);
            tabla_iteraciones_2.Columns.Add(columna_estado_maquina_2);
            tabla_iteraciones_2.Columns.Add(columna_cola_maquina_2);
            tabla_iteraciones_2.Columns.Add(columna_maxima_espera_de_cheque);

            //Tercer data grid
            tabla_iteraciones_3.Columns.Add(evento);
            tabla_iteraciones_3.Columns.Add(columna_reloj);
            tabla_iteraciones_3.Columns.Add(columna_rnd_llegada);
            tabla_iteraciones_3.Columns.Add(columna_tiempo_entre_llegadas);
            tabla_iteraciones_3.Columns.Add(columna_proxima_llegada);
            tabla_iteraciones_3.Columns.Add(columna_rnd_procesamiento_maquina_1);
            tabla_iteraciones_3.Columns.Add(columna_tiempo_procesamiento_maquina_1);
            tabla_iteraciones_3.Columns.Add(columna_fin_procesamiento_maquina_1);
            tabla_iteraciones_3.Columns.Add(columna_estado_maquina_1);
            tabla_iteraciones_3.Columns.Add(columna_cola_maquina_1);
            tabla_iteraciones_3.Columns.Add(columna_maxima_espera_de_cheque);

            //Cuarto data grid
            tabla_iteraciones_4.Columns.Add(evento);
            tabla_iteraciones_4.Columns.Add(columna_reloj);
            tabla_iteraciones_4.Columns.Add(columna_rnd_llegada);
            tabla_iteraciones_4.Columns.Add(columna_tiempo_entre_llegadas);
            tabla_iteraciones_4.Columns.Add(columna_proxima_llegada);
            tabla_iteraciones_4.Columns.Add(columna_rnd_procesamiento_maquina_2);
            tabla_iteraciones_4.Columns.Add(columna_tiempo_procesamiento_maquina_2);
            tabla_iteraciones_4.Columns.Add(columna_fin_procesamiento_maquina_2);
            tabla_iteraciones_4.Columns.Add(columna_estado_maquina_2);
            tabla_iteraciones_4.Columns.Add(columna_cola_maquina_2);
            tabla_iteraciones_4.Columns.Add(columna_maxima_espera_de_cheque);
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
            tiempo_proxima_llegada_con_porcentaje = 0.0;
            tiempo_fin_atencion_maquina1 = 0.0;
            tiempo_fin_atencion_maquina2 = 0.0;
            tiempo_fin_atencion_maquina3 = 0.0;
            tiempo_fin_atencion_maquina4 = 0.0;

            //Cola para los servidores
            cola_cheques_maquina1 = new List<Cliente>();
            cola_cheques_maquina2 = new List<Cliente>();
            cola_cheques_maquina3 = new List<Cliente>();
            cola_cheques_maquina4 = new List<Cliente>();

            //array clientes
            cheques_a_mostrar1 = new List<Cliente>();
            cheques_a_mostrar2 = new List<Cliente>();
            cheques_a_mostrar3 = new List<Cliente>();
            cheques_a_mostrar4 = new List<Cliente>();

            //randoms 
            rnd_llegadas = 0.0;
            rnd_llegadas_con_porcentaje = 0.0;
            rnd_maquina1 = 0.0;
            rnd_maquina2 = 0.0;
            rnd_maquina3 = 0.0;
            rnd_maquina4 = 0.0;

            //limpiar labels de resultados


            bandera_nro_cliente = false;
            nro_cliente = 0;
            nro_cliente_desde_que_se_muestra = 0;

        }

        private void siguiente_secuencia(Servidor maquina)
        {
            //En la primera vuelta solo va a calcular la proxima llegada
            if (!flag_primera_vuelta)
            {
                flag_primera_vuelta = true;
                calcularProximaLlegada();
            }
            else
            {
                if (reloj > cantidad)
                {
                    reloj = cantidad;
                    Evento_lanzado = "Fin de simulación";
                }
                else
                {
                    if(maquina.GetEstado() == Servidor.Estados.libre)
                    {
                        maquina.SetEstado(Servidor.Estados.ocupado);

                    }
                    else
                    {
                        maquina.SetEstado(Servidor.Estados.ocupado);
                    }
                }
            }
        }

        private void EventoFinProcesamiento()
        {

        }

        private void EventoLlegadaCheque()
        {
            Cliente nuevo_cheque = new Cliente(reloj, Cliente.Estados.SIENDO_PROCESADO);
            nuevo_cheque.SetHoraLlegada(reloj);
            nro_cliente += 1;
            nuevo_cheque.SetNumero(nro_cliente);
            cheques_a_mostrar1.Add(nuevo_cheque);
            cheques_a_mostrar2.Add(nuevo_cheque);
            cheques_a_mostrar3.Add(nuevo_cheque);
            cheques_a_mostrar4.Add(nuevo_cheque);

            if (cola_cheques_maquina1.Count == 0)
            {
                tiempo_fin_atencion_maquina1 = reloj + tiempo_procesamiento_maquina1;
                nuevo_cheque.SetHoraInicioAtencion(reloj);
            }

            calcularProximaLlegada();
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
