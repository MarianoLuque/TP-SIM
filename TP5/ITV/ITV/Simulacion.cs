using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITV
{
    public partial class Simulacion : Form
    {
        //cantidad de eventos o minutos de simulacion 
        int cantidad;

        //cantidad de clientes que llegan
        int cantidad_llegadas;
        int cantidad_caseta;
        int cantidad_nave;
        int cantidad_oficina;

        //minutos en los que llegan los clientes
        int minutos_llegadas;
        int minutos_caseta;
        int minutos_nave;
        int minutos_oficina;

        //Parametro para saber si el usuario eligió por cantidad de eventos o por cantidad de minutos
        string parametro_cantidad;

        //cantidad maxima de clientes que pueden estar en la cola de la caseta
        int cantidad_maxima_cola_caseta;

        //reloj
        //int[] reloj = new int[] { 0, 0, 0 };
        double reloj = 0; 

        //randoms para los diferentes eventos (llegadas y atenciones)
        Random objeto_rnd_llegadas = new Random();
        Random objeto_rnd_atencion_caseta = new Random();
        Random objeto_rnd_atencion_nave = new Random();
        Random objeto_rnd_atencion_oficina = new Random();

        //Número entre 0 y 1 para calcular los tiempo según corresponda
        double rnd_llegadas, rnd_atencion_caseta, rnd_atencion_nave, rnd_atencion_oficina;

        //tiempos de llegada y atencion
        double tiempo_entre_llegadas = 0.0;
        double tiempo_atencion_caseta  = 0.0;
        double tiempo_atencion_nave    = 0.0;
        double tiempo_atencion_oficina = 0.0;

        //tiempos de proxima llegada y fin atencion
        double tiempo_proxima_llegada        = -0.1;
        double tiempo_fin_atencion_caseta    = 0.0;
        double tiempo_fin_atencion_nave_1      = 0.0;
        double tiempo_fin_atencion_nave_2 = 0.0;
        double tiempo_fin_atencion_oficina_1 = 0.0;
        double tiempo_fin_atencion_oficina_2 = 0.0;

        //servidores
        servidor caseta = new servidor();
        servidor nave_1 = new servidor();
        servidor nave_2 = new servidor();
        servidor oficina_1 = new servidor();
        servidor oficina_2 = new servidor();

        //Cola para los servidores
        List<cliente> cola_clientes_caseta= new List<cliente>();
        List<cliente> cola_clientes_nave = new List<cliente>();
        List<cliente> cola_clientes_oficina = new List<cliente>();

        //metrica 1
        int longitud_media_de_la_cola_de_la_nave;

        //metrica 2
        double tiempo_permanencia_caseta   = 0.0;
        double tiempo_medio_cliente_caseta = 0.0;
        int cantidad_clientes_atencion_finalizada_caseta;

        //metrica 3
        double tiempo_permanencia_nave   = 0.0;
        double tiempo_medio_cliente_nave = 0.0;
        int cantidad_clientes_atencion_finalizada_nave;

        //metrica 4
        double tiempo_permanencia_oficina   = 0.0;
        double tiempo_medio_cliente_oficina = 0.0;
        int cantidad_clientes_atencion_finalizada_oficina;

        //metrica 5
        double tiempo_permanencia_itv   = 0.0;
        double tiempo_medio_cliente_itv = 0.0;

        //metrica 6
        double tiempo_permanencia_cola_caseta = 0.0;
        double tiempo_medio_cliente_cola_caseta = 0.0;

        //metrica 7
        double tiempo_permanencia_cola_nave = 0.0;
        double tiempo_medio_cliente_cola_nave = 0.0;

        //metrica 8
        double tiempo_maximo_entre_llegadas = 0.0;

        //metrica 9
        int cantidad_clientes_que_se_van_por_cola_llena = 0;

        //
        int cantidad_clientes_ingresan_al_sistema = 0;

        //tabla con iteraciones
        DataTable tabla_iteraciones = new DataTable();
        int simulacion_desde;
        bool flag_tabla_cargada = false;

        //Bandera para comprobar si es la primera vuelta
        bool flag_primera_vuelta = false;

        //Objeto que representa el cliente atendido en la caseta
        cliente Cliente_atendido_caseta;
        cliente Cliente_atendido_nave_1;
        cliente Cliente_atendido_nave_2;
        cliente Cliente_atendifo_oficina_1;
        cliente Cliente_atendifo_oficina_2;
        public Simulacion(int cantidad, int cantidad_llegadas, int cantidad_caseta, int cantidad_nave, int cantidad_oficina, int minutos_llegadas, int minutos_caseta, int minutos_nave, int minutos_oficina, int cantidad_maxima_cola_caseta, string parametro_cantidad)
        {
            InitializeComponent();
            this.cantidad = cantidad;

            this.cantidad_llegadas = cantidad_llegadas;
            this.cantidad_caseta = cantidad_caseta;
            this.cantidad_nave = cantidad_nave;
            this.cantidad_oficina = cantidad_oficina;

            this.minutos_llegadas = minutos_llegadas;
            this.minutos_caseta = minutos_caseta;
            this.minutos_nave = minutos_nave;
            this.minutos_oficina = minutos_oficina;

            this.cantidad_maxima_cola_caseta = cantidad_maxima_cola_caseta;

            this.parametro_cantidad = parametro_cantidad;

            if(parametro_cantidad == "minutos")
            {
                lbl_desde.Visible = false;
                txt_desde.Visible = false;
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void calcularProximaLlegada()
        {
            double media = minutos_llegadas / cantidad_llegadas;
            rnd_llegadas = objeto_rnd_llegadas.NextDouble();
            
            double random_p = (Math.Truncate(rnd_llegadas * 10000)) / 10000;
            tiempo_entre_llegadas = Math.Truncate(((-media) * (Math.Log(1 - random_p))) * 100) / 100;
            tiempo_proxima_llegada = reloj + tiempo_entre_llegadas;

        }

        //Obtiene el random y el correspondiente tiempo según el parametro que se le pasa
        private void calcularFinAtencion(int tipo /*caseta = 1, nave 1 = 2, nave 2 = 3, oficina 1 = 4, oficina 2 = 5*/)
        {
            if(tipo == 1)
            {
                double media = minutos_caseta / cantidad_caseta;
                rnd_atencion_caseta = objeto_rnd_atencion_caseta.NextDouble();

                double random_p = (Math.Truncate(rnd_atencion_caseta * 10000)) / 10000;
                tiempo_atencion_caseta = Math.Truncate(((-media) * (Math.Log(1 - random_p))) * 100) / 100;
                tiempo_fin_atencion_caseta = reloj + tiempo_atencion_caseta;
            }
            else if (tipo == 2)
            {
                double media = minutos_nave / cantidad_nave;
                rnd_atencion_nave = objeto_rnd_atencion_nave.NextDouble();

                double random_p = (Math.Truncate(rnd_atencion_nave * 10000)) / 10000;
                tiempo_atencion_nave = Math.Truncate(((-media) * (Math.Log(1 - random_p))) * 100) / 100;
                tiempo_fin_atencion_nave_1 = reloj + tiempo_atencion_nave;

            }
            else if (tipo == 3)
            {
                double media = minutos_nave / cantidad_nave;
                rnd_atencion_nave = objeto_rnd_atencion_nave.NextDouble();

                double random_p = (Math.Truncate(rnd_atencion_nave * 10000)) / 10000;
                tiempo_atencion_nave = Math.Truncate(((-media) * (Math.Log(1 - random_p))) * 100) / 100;
                tiempo_fin_atencion_nave_2 = reloj + tiempo_atencion_nave;

            }
            else if (tipo == 4)
            {
                double media = minutos_oficina / cantidad_oficina;
                rnd_atencion_oficina = objeto_rnd_atencion_oficina.NextDouble();

                double random_p = (Math.Truncate(rnd_atencion_oficina * 10000)) / 10000;
                tiempo_atencion_oficina = Math.Truncate(((-media) * (Math.Log(1 - random_p))) * 100) / 100;
                tiempo_fin_atencion_oficina_1 = reloj + tiempo_atencion_oficina;

            }
            else
            {
                double media = minutos_oficina / cantidad_oficina;
                rnd_atencion_oficina = objeto_rnd_atencion_oficina.NextDouble();

                double random_p = (Math.Truncate(rnd_atencion_oficina * 10000)) / 10000;
                tiempo_atencion_oficina = Math.Truncate(((-media) * (Math.Log(1 - random_p))) * 100) / 100;
                tiempo_fin_atencion_oficina_2 = reloj + tiempo_atencion_oficina;
            }

        }

        private void EventoDeLlegada()
        {
            cliente Nuevo_Cliente;

            if (caseta.GetEstado() == servidor.Estados.ocupado)
            {
                if(cola_clientes_caseta.Count >= cantidad_maxima_cola_caseta)
                {
                    Nuevo_Cliente = new cliente(reloj, cliente.Estados.SIN_LUGAR_EN_COLA_CASETA);
                    cantidad_clientes_que_se_van_por_cola_llena += 1;
                }
                else
                {
                    Nuevo_Cliente = new cliente(reloj, cliente.Estados.ESPERANDO_ATENCION_CASETA);
                    Nuevo_Cliente.SetEstadoYHoraLlegadaCola(reloj, cliente.Estados.ESPERANDO_ATENCION_CASETA);
                    cola_clientes_caseta.Add(Nuevo_Cliente);
                    cantidad_clientes_ingresan_al_sistema += 1;
                    
                    //DataColumn nuevo_cliente = new DataColumn($"Cliente {cantidad_clientes_ingresan_al_sistema}");
                    // Esta parte va en el if de simulacion_desde...
                    // tabla_iteraciones.Columns.Add(nuevo_cliente);

                }
            }
            else
            {
                caseta.SetEstado(servidor.Estados.ocupado);
                Cliente_atendido_caseta = new cliente(reloj, cliente.Estados.SIENDO_ATENDIDO_CASETA);
                
                
                //Si no pasa a la cola nunca, el tiempo en cola es 0. Esta bien poner el reloj aca?
                
                
                Cliente_atendido_caseta.SetEstadoYHoraLlegadaCola(reloj, cliente.Estados.SIENDO_ATENDIDO_CASETA);
                tiempo_permanencia_cola_caseta += 0;
                cantidad_clientes_ingresan_al_sistema += 1;
                calcularFinAtencion(1);
                
                //DataColumn nuevo_cliente = new DataColumn($"Cliente {cantidad_clientes_ingresan_al_sistema}");
                // Esta parte va en el if de simulacion_desde...
                //tabla_iteraciones.Columns.Add(nuevo_cliente);
            }
        }

        private void EventoFinAtencionCaseta()
        {
            

            //VERFICIAR EL TEMA DE HORA DE SISTEMA Y HORA DE COLA
            //VERFICIAR EL TEMA DE HORA DE SISTEMA Y HORA DE COLA
            //VERFICIAR EL TEMA DE HORA DE SISTEMA Y HORA DE COLA
            //VERFICIAR EL TEMA DE HORA DE SISTEMA Y HORA DE COLA
            //VERFICIAR EL TEMA DE HORA DE SISTEMA Y HORA DE COLA
            //VERFICIAR EL TEMA DE HORA DE SISTEMA Y HORA DE COLA

            tiempo_permanencia_caseta += (reloj - Cliente_atendido_caseta.GetMinutoLlegadaALaCola());


            //Primero verifico si alguna nave esta libre para atender
            if (nave_1.GetEstado() == servidor.Estados.libre)
            {
                Cliente_atendido_caseta.SetEstado(cliente.Estados.SIENDO_ATENDIDO_NAVE);
                Cliente_atendido_nave_1 = Cliente_atendido_caseta;
                calcularFinAtencion(2);

            }
            else if(nave_2.GetEstado() == servidor.Estados.libre)
            {
                Cliente_atendido_caseta.SetEstado(cliente.Estados.SIENDO_ATENDIDO_NAVE);
                Cliente_atendido_nave_2 = Cliente_atendido_caseta;
                calcularFinAtencion(3);
            }
            //Si ninguna nave esta libre, lo agrego a la cola de las nave
            else
            {
                Cliente_atendido_caseta.SetEstado(cliente.Estados.ESPERANDO_ATENCION_NAVE);
                cola_clientes_nave.Add(Cliente_atendido_caseta);
            }

            //Si cuando llega el cliente la cola esta vacia pasa a ser directamente atendido y no esta en el vector de la cola
            //Por lo que va a ser el cliente directamente atendido en la caseta. Si no es el último de la cola
            //Si no lo hago así, no puedo conocer a quien voy a atender en la caseta cuando no hay nadie en cola pero si alguien por atender
            if (cola_clientes_caseta.Count > 0)
            {
                Cliente_atendido_caseta = cola_clientes_caseta.ElementAt(0);
            }
            cantidad_clientes_atencion_finalizada_caseta += 1;

            //Si no hay nadie en la cola de la caseta, este servidor pasa a estar libre
            if (cola_clientes_caseta.Count == 0)
            {
                caseta.SetEstado(servidor.Estados.libre);
            }
            //Si hay alguien en la cola lo va a pasar a atender y lo va a sacar de la cola 
            //Cliente_atendido_caseta se convirtió en el útlimo de la cola al principio de la funcion
            else
            {
                Cliente_atendido_caseta.SetEstado(cliente.Estados.SIENDO_ATENDIDO_CASETA);
                cola_clientes_caseta.RemoveAt(0);
                calcularFinAtencion(1);
            }   
            
        }

        private void EventoFinAtencionNave(int nave)
        {
            
            if(oficina_1.GetEstado() == servidor.Estados.libre)
            {
                if(nave == 1)
                {
                    Cliente_atendido_nave_1.SetEstado(cliente.Estados.SIENDO_ATENDIDO_OFICINA);
                    Cliente_atendifo_oficina_1 = Cliente_atendido_nave_1;
                    calcularFinAtencion(4);
                }
                else
                {
                    Cliente_atendido_nave_2.SetEstado(cliente.Estados.SIENDO_ATENDIDO_OFICINA);
                    Cliente_atendifo_oficina_1 = Cliente_atendido_nave_2;
                    calcularFinAtencion(4);

                }
            }
            else if (oficina_2.GetEstado() == servidor.Estados.libre) 
            {
                if (nave == 1)
                {
                    Cliente_atendido_nave_1.SetEstado(cliente.Estados.SIENDO_ATENDIDO_OFICINA);
                    Cliente_atendifo_oficina_2 = Cliente_atendido_nave_1;
                    calcularFinAtencion(5);
                }
                else
                {
                    Cliente_atendido_nave_2.SetEstado(cliente.Estados.SIENDO_ATENDIDO_OFICINA);
                    Cliente_atendifo_oficina_2 = Cliente_atendido_nave_2;
                    calcularFinAtencion(5);

                }

            }
            else
            {
                if(nave == 1)
                {
                    Cliente_atendido_nave_1.SetEstado(cliente.Estados.ESPERANDO_ATENCION_OFICINA);
                    cola_clientes_oficina.Add(Cliente_atendido_nave_1);
                }
                else
                {
                    Cliente_atendido_nave_2.SetEstado(cliente.Estados.ESPERANDO_ATENCION_OFICINA);
                    cola_clientes_oficina.Add(Cliente_atendido_nave_2);
                }

            }

            if(cola_clientes_nave.Count > 0)
            {
                if(nave == 1)
                {
                    Cliente_atendido_nave_1 = cola_clientes_nave.ElementAt(0);
                    Cliente_atendido_nave_1.SetEstado(cliente.Estados.SIENDO_ATENDIDO_NAVE);
                    cola_clientes_nave.RemoveAt(0);
                    calcularFinAtencion(2);
                }
                else
                {
                    Cliente_atendido_nave_2 = cola_clientes_nave.ElementAt(0);
                    Cliente_atendido_nave_2.SetEstado(cliente.Estados.SIENDO_ATENDIDO_NAVE);
                    cola_clientes_nave.RemoveAt(0);
                    calcularFinAtencion(3);
                }
            }
            else
            {
                if(nave == 1)
                {
                    nave_1.SetEstado(servidor.Estados.libre);
                }
                else
                {
                    nave_2.SetEstado(servidor.Estados.libre);
                }
            }
    

        }

        private void EventoFinAtencionOficina()
        {

        }

        private void Simulacion_Load(object sender, EventArgs e)
        {
            lbl_desde.Text = lbl_desde.Text + "(Desde 0 hasta " + (cantidad - 400).ToString() + ")";
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Comprueba cual es el menor tiempo entre Proxima LLegada, Fin de Atencion de la caseta, Fin de Atención de cada nave
        // y el Fin de Atención de cada oficina. Aquel tiempo que sea el menor, será el tiempo del reloj.
        private string calcular_menor()
        {
            //Compara si es menor un tiempo con respecto al resto de tiempos, siempre y cuando estos sean distinto de cero

            //
            //
            // ¿Cuando uno de los servidores queda libre, el tiempo se pone en null? Ver bien que pasaría con eso
            //
            //

            if ((tiempo_proxima_llegada <= tiempo_fin_atencion_caseta || tiempo_fin_atencion_caseta == 0) &&
                (tiempo_proxima_llegada <= tiempo_fin_atencion_nave_1 || tiempo_fin_atencion_nave_1 == 0) &&
                (tiempo_proxima_llegada <= tiempo_fin_atencion_nave_2 || tiempo_fin_atencion_nave_2 == 0) &&
                (tiempo_proxima_llegada <= tiempo_fin_atencion_oficina_1 || tiempo_fin_atencion_oficina_1 == 0) &&
                (tiempo_proxima_llegada <= tiempo_fin_atencion_oficina_2 || tiempo_fin_atencion_oficina_2 == 0))
            {
                reloj = tiempo_proxima_llegada;
                return "tiempo_proxima_llegada";
            }
            else if(
                (tiempo_fin_atencion_caseta <= tiempo_proxima_llegada) &&
                (tiempo_fin_atencion_caseta <= tiempo_fin_atencion_nave_1|| tiempo_fin_atencion_nave_1 == 0) &&
                (tiempo_fin_atencion_caseta <= tiempo_fin_atencion_nave_2|| tiempo_fin_atencion_nave_2 == 0) &&
                (tiempo_fin_atencion_caseta <= tiempo_fin_atencion_oficina_1 || tiempo_fin_atencion_oficina_1 == 0) &&
                (tiempo_fin_atencion_caseta <= tiempo_fin_atencion_oficina_2 || tiempo_fin_atencion_oficina_2 == 0))
            {
                reloj = tiempo_fin_atencion_caseta;
                return "tiempo_fin_atencion_caseta";
            }
            else if(
                (tiempo_fin_atencion_nave_1 <= tiempo_proxima_llegada) &&
                (tiempo_fin_atencion_nave_1 <= tiempo_fin_atencion_caseta || tiempo_fin_atencion_caseta == 0) &&
                (tiempo_fin_atencion_nave_1 <= tiempo_fin_atencion_nave_2 || tiempo_fin_atencion_nave_2 == 0) &&
                (tiempo_fin_atencion_nave_1 <= tiempo_fin_atencion_oficina_1 || tiempo_fin_atencion_oficina_1 == 0) &&
                (tiempo_fin_atencion_nave_1 <= tiempo_fin_atencion_oficina_2|| tiempo_fin_atencion_oficina_2 == 0))
            {
                reloj = tiempo_fin_atencion_nave_1;
                return "tiempo_fin_atencion_nave_1";
            }
            else if (
                tiempo_fin_atencion_nave_2 <= tiempo_proxima_llegada &&
                (tiempo_fin_atencion_nave_2 <= tiempo_fin_atencion_caseta || tiempo_fin_atencion_caseta == 0 ) && 
                (tiempo_fin_atencion_nave_2 <= tiempo_fin_atencion_nave_1 || tiempo_fin_atencion_nave_1 == 0) &&
                (tiempo_fin_atencion_nave_2 <= tiempo_fin_atencion_oficina_1 || tiempo_fin_atencion_oficina_1 == 0)&&
                (tiempo_fin_atencion_nave_2 <= tiempo_fin_atencion_oficina_2 || tiempo_fin_atencion_oficina_2 == 0))
            {
                reloj = tiempo_fin_atencion_nave_2;
                return "tiempo_fin_atencion_nave_2";
            }
            else if (
                tiempo_fin_atencion_oficina_1 <= tiempo_proxima_llegada &&
                (tiempo_fin_atencion_oficina_1 <= tiempo_fin_atencion_caseta || tiempo_fin_atencion_caseta == 0) && 
                (tiempo_fin_atencion_oficina_1 <= tiempo_fin_atencion_nave_1 || tiempo_fin_atencion_nave_1 == 0)  &&
                (tiempo_fin_atencion_oficina_1 <= tiempo_fin_atencion_nave_2 || tiempo_fin_atencion_nave_2 == 0) &&
                (tiempo_fin_atencion_oficina_1 <= tiempo_fin_atencion_oficina_2 || tiempo_fin_atencion_oficina_2 == 0))
            {
                reloj = tiempo_fin_atencion_oficina_1;
                return "tiempo_fin_atencion_oficina_1";
            }
            else 
            {
                reloj = tiempo_fin_atencion_oficina_2;
                return "tiempo_fin_atencion_oficina_2";
            }
            
        }
        
        private void btn_simular_Click(object sender, EventArgs e)
        {
            if(parametro_cantidad == "minutos")
            {
                while (reloj < cantidad)
                {
                    /*Para calcular el tiempo de atención según corresponda:
                    caseta = 1, nave 1 = 2, nave 2 = 3, oficina 1 = 4, oficina 2 = 5*/

                    //En la primera vuelta solo va a calcular la proxima llegada
                    if (!flag_primera_vuelta)
                    {
                        flag_primera_vuelta = true;
                        tiempo_proxima_llegada = 0;
                        calcularProximaLlegada();
                    }
                    else
                    {
                        string menor_tiempo = calcular_menor();
                        if (menor_tiempo == "tiempo_proxima_llegada")
                        {
                            EventoDeLlegada(); 
                            calcularProximaLlegada();

                        }
                        else if (menor_tiempo == "tiempo_fin_atencion_caseta")
                        {
                            EventoFinAtencionCaseta();
                            
                        }
                        else if (menor_tiempo == "tiempo_fin_atencion_nave_1")
                        {
                            EventoFinAtencionNave(1);
                        }
                        else if (menor_tiempo == "tiempo_fin_atencion_nave_2")
                        {
                            EventoFinAtencionNave(2);
                        }
                        else if (menor_tiempo == "tiempo_fin_atencion_oficina_1")
                        {
                            EventoFinAtencionOficina();
                            calcularFinAtencion(4);
                        }
                        else
                        {
                            EventoFinAtencionOficina();
                            calcularFinAtencion(5);
                        }

                            ////if (i >= simulacion_desde && i < simulacion_desde + 400)
                            //{

                            //}

                    }
                }
                if (reloj == cantidad)
                {
                    //Última fila
                }

            }
            if(parametro_cantidad == "eventos")
            {
                if (!int.TryParse(txt_desde.Text, out simulacion_desde) || simulacion_desde > (cantidad - 400))
                {
                    MessageBox.Show("Ingrese desde que simulación se debe mostrar (valor mayor a 0 y menor a " + (cantidad - 400).ToString() + ")", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                int cantidad_iteraciones = 0;
                while (cantidad_iteraciones < cantidad)
                {
                    /*Para calcular el tiempo de atención según corresponda:
                    caseta = 1, nave 1 = 2, nave 2 = 3, oficina 1 = 4, oficina 2 = 5*/

                    if (calcular_menor() == "tiempo_proxima_llegada")
                    {
                        if (!flag_primera_vuelta)
                        {
                            flag_primera_vuelta = true;
                            tiempo_proxima_llegada = 0;
                        }
                        calcularProximaLlegada();
                        EventoDeLlegada();

                    }
                    else if (calcular_menor() == "tiempo_fin_atencion_caseta")
                    {
                        calcularFinAtencion(1);
                    }
                    else if (calcular_menor() == "tiempo_fin_atencion_nave_1")
                    {
                        calcularFinAtencion(2);
                    }
                    else if (calcular_menor() == "tiempo_fin_atencion_nave_2")
                    {
                        calcularFinAtencion(3);
                    }
                    else if (calcular_menor() == "tiempo_fin_atencion_oficina_1")
                    {
                        calcularFinAtencion(4);
                    }
                    else
                    {
                        calcularFinAtencion(5);
                    }

                    if (cantidad_iteraciones >= simulacion_desde && cantidad_iteraciones < simulacion_desde + 400)
                    {
                        //tabla_iteraciones.Rows[cantidad_iteraciones]["Reloj (min)"] = reloj;
                        //tabla_iteraciones.Rows[cantidad_iteraciones]["RND llegada cliente"] = ;
                        //tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo entre llegadas"] = ;
                    }
                    cantidad_iteraciones += 1;
                }

            }

            

            /*
            preguntar si la tabla esta asociada al dataSource
                Si esta, desligarlo, limpiar las filas y cargar la tabla
                Si no esta (es la primera vez) cargarTabla()
            
            Iteracion 0: calcularProximaLlegada()

            Para las colas usar listas de <cliente> y no arrays, para saber quien es el que sigue en la cola y porque las listas
            pueden cambiar de tamaño
            List<cliente> cola_clientes_caseta/nave/oficina = new List<cliente>();

            While( tiempos de proxima llegada y fin atencion < minutos de simulacion)
            {
                EventoDeLlegada(){
                    calcularProximaLlegada()
                    chequeo el estado del servidor
                        libre --> cliente a SIENDO_ATENDIDO_CASETA y servidor a ocupado
                        ocupado --> pregunto por la cola < 15
                            es < 15 --> cliente a ESPERANDO_ATENCION_CASETA
                            es > 15 --> cliente a FUERA_DEL_SISTEMA
                }


                EventoFinAtencionCaseta/Nave/Oficina (dividan en 3 funciones porfi){
                    pregunto por la cola
                        hay gente --> calcularFinAtencion() y cliente a SIENDO_ATENDIDO_CASETA/NAVE/OFICINA
                        no hay gente --> servidor a libre
                }
            }

            Asociar la tabla al dataSource
            */

            if (flag_tabla_cargada)
            {
                //desligo la tabla del data source
                dg_colas.DataSource = null;
                //limpiar las filas
                tabla_iteraciones.Rows.Clear();
            }
            else
            {
                cargarTabla();
                flag_tabla_cargada = true;
            }

            //cargo los datos a la tabla
            //cargar_datos();
        }

        private void cargarTabla()
        {
            //creo las columnas
            DataColumn columna_reloj            = new DataColumn("Reloj (min)");

            //Llegada cliente
            DataColumn columna_rnd_llegada              = new DataColumn("RND llegada cliente");
            DataColumn columna_tiempo_entre_llegadas    = new DataColumn("Tiempo entre llegadas");
            DataColumn columna_proxima_llegada          = new DataColumn("Proxima llegada");
                       
            //Atencion caseta
            DataColumn columna_rnd_atencion_caseta      = new DataColumn("RND atencion caseta");
            DataColumn columna_tiempo_atencion_caseta   = new DataColumn("Tiempo atencion caseta");
            DataColumn columna_fin_atencion_caseta      = new DataColumn("Fin atencion caseta");
                       
            //Atencion nave
            DataColumn columna_rnd_atencion_nave        = new DataColumn("RND atencion nave");
            DataColumn columna_tiempo_atencion_nave     = new DataColumn("Tiempo atencion nave");
            DataColumn columna_fin_atencion_nave_1        = new DataColumn("Fin atencion nave 1");
            DataColumn columna_fin_atencion_nave_2        = new DataColumn("Fin atencion nave 2");

            //Atencion oficina
            DataColumn columna_rnd_atencion_oficina     = new DataColumn("RND atencion oficina");
            DataColumn columna_tiempo_atencion_oficina  = new DataColumn("Tiempo atencion oficina");
            DataColumn columna_fin_atencion_oficina1    = new DataColumn("Fin atencion oficina 1");
            DataColumn columna_fin_atencion_oficina2    = new DataColumn("Fin atencion oficina 2");
                       
            //Estados servidores
            DataColumn columna_estado_caseta            = new DataColumn("Estado caseta");
            DataColumn columna_estado_nave              = new DataColumn("Estado nave");
            DataColumn columna_estado_oficina1          = new DataColumn("Estado oficina 1");
            DataColumn columna_estado_oficina2          = new DataColumn("Estado oficina 2");
                       
            //Colas servidores
            DataColumn columna_cola_caseta              = new DataColumn("Cola caseta");
            DataColumn columna_cola_nave                = new DataColumn("Cola nave");
            DataColumn columna_cola_oficina             = new DataColumn("Cola oficina");

            //Metrica 1
            //HABRIA QUE AGREGAR DE NUEVO EL TIEMPO DE PERMANENCIA EN LA COLA DE LA NAVE? 
            DataColumn columna_longitud_media_de_la_cola_de_la_nave           = new DataColumn("Longitud media de la cola de la nave");

            //Metrica 2
            DataColumn columna_tiempo_permanencia_caseta                      = new DataColumn("Tiempo de permanencia en la caseta");
            DataColumn columna_cantidad_clientes_atencion_finalizada_caseta   = new DataColumn("Cantidad clientes con atencion caseta finalizada");
            DataColumn columna_tiempo_medio_cliente_en_caseta                 = new DataColumn("Tiempo medio del cliente en la caseta");
                                                                     
            //Metrica 3                                               
            DataColumn columna_tiempo_permanencia_nave                        = new DataColumn("Tiempo de permanencia en la nave");
            DataColumn columna_cantidad_clientes_atencion_finalizada_nave     = new DataColumn("Cantidad clientes con atencion nave finalizada");
            DataColumn columna_tiempo_medio_cliente_en_nave                   = new DataColumn("Tiempo medio del cliente en la nave");
                                                                   
            //Metrica 4                                              
            DataColumn columna_tiempo_permanencia_oficina                     = new DataColumn("Tiempo de permanencia en la oficina");
            DataColumn columna_cantidad_clientes_atencion_finalizada_oficina  = new DataColumn("Cantidad clientes con atencion oficina finalizada");
            DataColumn columna_tiempo_medio_cliente_en_oficina                = new DataColumn("Tiempo medio del cliente en la oficina");
                                                                     
            //Metrica 5                                              
            DataColumn columna_tiempo_permanencia_itv                         = new DataColumn("Tiempo de permanencia en el sistema");
            DataColumn columna_tiempo_medio_cliente_en_itv                    = new DataColumn("Tiempo medio del cliente en el ITV");
                                                                      
            //Metrica 6                                               
            DataColumn columna_tiempo_permanencia_cola_caseta                 = new DataColumn("Tiempo de permanencia en la cola de la caseta");
            DataColumn columna_tiempo_medio_cliente_en_cola_caseta            = new DataColumn("Tiempo medio del cliente en la cola de la caseta");
                                                                     
            //Metrica 7                                              
            DataColumn columna_tiempo_permanencia_cola_nave                   = new DataColumn("Tiempo de permanencia en la cola de la nave");
            DataColumn columna_tiempo_medio_cliente_en_cola_nave              = new DataColumn("Tiempo medio del cliente en la cola de nave");
                                                                     
            //Metrica 8                                              
            DataColumn columna_maximo_tiempo_entre_llegadas                   = new DataColumn("Maximo tiempo entre llegadas");

            //Metrica 9
            DataColumn columna_cantidad_clientes_que_se_fueron_por_cola_llena = new DataColumn("Cantidad de clientes que no entran a la cola porque esta llena");
            
            
            //asigno las columnas a la tabla
            tabla_iteraciones.Columns.Add(columna_reloj);

            //Llegada cliente
            tabla_iteraciones.Columns.Add(columna_rnd_llegada          );
            tabla_iteraciones.Columns.Add(columna_tiempo_entre_llegadas);
            tabla_iteraciones.Columns.Add(columna_proxima_llegada      );
                                          
            //Atencion caseta             
            tabla_iteraciones.Columns.Add(columna_rnd_atencion_caseta   );
            tabla_iteraciones.Columns.Add(columna_tiempo_atencion_caseta);
            tabla_iteraciones.Columns.Add(columna_fin_atencion_caseta   );
                                          
            //Atencion nave               
            tabla_iteraciones.Columns.Add(columna_rnd_atencion_nave   );
            tabla_iteraciones.Columns.Add(columna_tiempo_atencion_nave);
            tabla_iteraciones.Columns.Add(columna_fin_atencion_nave_1   );
            tabla_iteraciones.Columns.Add(columna_fin_atencion_nave_2);
                                          
            //Atencion oficina            
            tabla_iteraciones.Columns.Add(columna_rnd_atencion_oficina   );
            tabla_iteraciones.Columns.Add(columna_tiempo_atencion_oficina);
            tabla_iteraciones.Columns.Add(columna_fin_atencion_oficina1  );
            tabla_iteraciones.Columns.Add(columna_fin_atencion_oficina2  );
                                          
            //Estados servidores          
            tabla_iteraciones.Columns.Add(columna_estado_caseta  );
            tabla_iteraciones.Columns.Add(columna_estado_nave    );
            tabla_iteraciones.Columns.Add(columna_estado_oficina1);
            tabla_iteraciones.Columns.Add(columna_estado_oficina2);
                                          
            //Colas servidores            
            tabla_iteraciones.Columns.Add(columna_cola_caseta );
            tabla_iteraciones.Columns.Add(columna_cola_nave   );
            tabla_iteraciones.Columns.Add(columna_cola_oficina);

            //Metrica 1       
            tabla_iteraciones.Columns.Add(columna_longitud_media_de_la_cola_de_la_nave);

            //Metrica 2                   
            tabla_iteraciones.Columns.Add(columna_tiempo_permanencia_caseta                     );
            tabla_iteraciones.Columns.Add(columna_cantidad_clientes_atencion_finalizada_caseta  );
            tabla_iteraciones.Columns.Add(columna_tiempo_medio_cliente_en_caseta                );
                                          
            //Metrica 3                   
            tabla_iteraciones.Columns.Add(columna_tiempo_permanencia_nave                       );
            tabla_iteraciones.Columns.Add(columna_cantidad_clientes_atencion_finalizada_nave    );
            tabla_iteraciones.Columns.Add(columna_tiempo_medio_cliente_en_nave                  );
                                          
            //Metrica 4                   
            tabla_iteraciones.Columns.Add(columna_tiempo_permanencia_oficina                    );
            tabla_iteraciones.Columns.Add(columna_cantidad_clientes_atencion_finalizada_oficina );
            tabla_iteraciones.Columns.Add(columna_tiempo_medio_cliente_en_oficina               );
                                          
            //Metrica 5                   
            tabla_iteraciones.Columns.Add(columna_tiempo_permanencia_itv                        );
            tabla_iteraciones.Columns.Add(columna_tiempo_medio_cliente_en_itv                   );
                                          
            //Metrica 6                   
            tabla_iteraciones.Columns.Add(columna_tiempo_permanencia_cola_caseta                );
            tabla_iteraciones.Columns.Add(columna_tiempo_medio_cliente_en_cola_caseta           );
                                          
            //Metrica 7                   
            tabla_iteraciones.Columns.Add(columna_tiempo_permanencia_cola_nave                  );
            tabla_iteraciones.Columns.Add(columna_tiempo_medio_cliente_en_cola_nave             );
                                          
            //Metrica 8                   
            tabla_iteraciones.Columns.Add(columna_maximo_tiempo_entre_llegadas                  );
                                          
            //Metrica 9                   
            tabla_iteraciones.Columns.Add(columna_cantidad_clientes_que_se_fueron_por_cola_llena);

        }
    }
}
