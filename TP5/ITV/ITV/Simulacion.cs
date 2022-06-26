using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        double reloj = 0;

        //numero de iteracion
        int cantidad_iteraciones = 0;

        //randoms para los diferentes eventos (llegadas y atenciones)
        Random objeto_rnd_llegadas;
        Random objeto_rnd_atencion_caseta;
        Random objeto_rnd_atencion_nave;
        Random objeto_rnd_atencion_oficina;
        Random objeto_semilla;

        //Número entre 0 y 1 para calcular los tiempo según corresponda
        double rnd_llegadas, rnd_atencion_caseta, rnd_atencion_nave, rnd_atencion_oficina;

        //tiempos de llegada y atencion
        double tiempo_entre_llegadas = 0.0;
        double tiempo_atencion_caseta  = 0.0;
        double tiempo_atencion_nave    = 0.0;
        double tiempo_atencion_oficina = 0.0;

        //tiempos de proxima llegada y fin atencion
        double tiempo_proxima_llegada        = 0.0;

        //Cola para los servidores
        List<cliente> cola_clientes_caseta;
        List<cliente> cola_clientes_nave;
        List<cliente> cola_clientes_oficina;

        //Medias de proximas llegadas y fin tiempo de atencion
        double media_0;
        double media_1;
        double media_2;
        double media_3;

        //array clientes
        List<cliente> clientes_a_mostrar;
        int nro_cliente;
        int nro_cliente_desde_que_se_muestra;

        //metrica 1
        double longitud_media_de_la_cola_de_la_nave;

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
        int cantidad_a_mostrar;

        //Bandera para comprobar si es la primera vuelta
        bool flag_primera_vuelta;

        //Bandera para saber si se muestran los clientes
        bool mostrar_clientes;

        int cantidad_de_casetas;
        int cantidad_de_naves;
        int cantidad_de_oficinas;

        List<servidor> lista_casetas;
        List<servidor> lista_naves;
        List<servidor> lista_oficinas;

        string Evento_lanzado;
        public Simulacion(int cantidad, int cantidad_llegadas, int cantidad_caseta, int cantidad_nave, int cantidad_oficina, int minutos_llegadas, int minutos_caseta, int minutos_nave, int minutos_oficina, int cantidad_maxima_cola_caseta, int cantidad_de_casetas, int cantidad_de_naves, int cantidad_de_oficinas, string parametro_cantidad, bool mostrar_clientes)
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

            this.mostrar_clientes = mostrar_clientes;

            media_0 = (double)minutos_llegadas / (double)cantidad_llegadas;
            media_1 = minutos_caseta / cantidad_caseta;
            media_2 = (double)minutos_nave / (double)cantidad_nave;
            media_3 = (double)minutos_oficina / (double)cantidad_oficina;

            this.cantidad_de_casetas = cantidad_de_casetas;
            this.cantidad_de_naves = cantidad_de_naves;
            this.cantidad_de_oficinas = cantidad_de_oficinas;

            if (parametro_cantidad == "minutos")
            {
                lbl_desde.Text = "Ingrese desde que minuto mostrar";
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void calcularProximaLlegada()
        {
            rnd_llegadas = (Math.Truncate(objeto_rnd_llegadas.NextDouble() * 100)) / 100;
            tiempo_entre_llegadas = Math.Truncate(((-media_0) * (Math.Log(1 - rnd_llegadas))) * 100) / 100;
            tiempo_proxima_llegada = Math.Truncate((reloj + tiempo_entre_llegadas) * 100) / 100;
        }

        //Obtiene el random y el correspondiente tiempo según el parametro que se le pasa
        private void calcularFinAtencion(servidor servidor_calcular)
        {
            if(servidor_calcular.GetTipo() == servidor.Tipos.caseta)
            {
                rnd_atencion_caseta = (Math.Truncate(objeto_rnd_atencion_caseta.NextDouble() * 100)) / 100;
                tiempo_atencion_caseta = Math.Truncate(((-media_1) * (Math.Log(1 - rnd_atencion_caseta))) * 100) / 100;
                servidor_calcular.SetFinAtencion((Math.Truncate((reloj + tiempo_atencion_caseta) * 100)) / 100);
            }
            else if (servidor_calcular.GetTipo() == servidor.Tipos.nave)
            {
                rnd_atencion_nave = (Math.Truncate(objeto_rnd_atencion_nave.NextDouble() * 100)) / 100;
                tiempo_atencion_nave = Math.Truncate(((-media_2) * (Math.Log(1 - rnd_atencion_nave))) * 100) / 100;
                servidor_calcular.SetFinAtencion((Math.Truncate((reloj + tiempo_atencion_nave) * 100)) / 100);

            }
            else if (servidor_calcular.GetTipo() == servidor.Tipos.oficina)
            {
                rnd_atencion_oficina = (Math.Truncate(objeto_rnd_atencion_oficina.NextDouble() * 100)) / 100;
                tiempo_atencion_oficina = Math.Truncate(((-media_3) * (Math.Log(1 - rnd_atencion_oficina))) * 100) / 100;
                servidor_calcular.SetFinAtencion(((Math.Truncate((reloj + tiempo_atencion_oficina) * 100)) / 100));

            }
           
        }

        private void agregar_cliente()
        {
            string estado_cliente_nro = "Estado cliente" + nro_cliente.ToString();
            string hora_llegada_cliente_nro = "Hora llegada cliente" + nro_cliente.ToString();
            DataColumn columna_estado_cliente = new DataColumn(estado_cliente_nro);
            DataColumn columna_hora_llegada_cliente = new DataColumn(hora_llegada_cliente_nro);
            tabla_iteraciones.Columns.Add(columna_estado_cliente);
            tabla_iteraciones.Columns.Add(columna_hora_llegada_cliente);
            if (nro_cliente_desde_que_se_muestra == 0)
            {
                nro_cliente_desde_que_se_muestra = nro_cliente;
            }
        }

        private void EventoDeLlegada()
        {
            cliente Nuevo_Cliente = null;
            
            int cantidad_recorrida = 0;
            foreach (servidor i_caseta in lista_casetas)
            {
                cantidad_recorrida += 1;

                if (i_caseta.GetEstado() == servidor.Estados.libre)
                {
                    i_caseta.SetEstado(servidor.Estados.ocupado);
                    Nuevo_Cliente = new cliente(reloj, cliente.Estados.SIENDO_ATENDIDO_CASETA);
                    i_caseta.SetCliente(Nuevo_Cliente);
                    cantidad_clientes_ingresan_al_sistema += 1;

                    tiempo_permanencia_cola_caseta += 0;
                    calcularFinAtencion(i_caseta);

                    break;
                }

                if(cantidad_recorrida == cantidad_de_casetas)
                {
                    if (cola_clientes_caseta.Count >= cantidad_maxima_cola_caseta)
                    {
                        Nuevo_Cliente = new cliente(reloj, cliente.Estados.SIN_LUGAR_EN_COLA_CASETA);
                        Metrica9();
                    }
                    else
                    {
                        Nuevo_Cliente = new cliente(reloj, cliente.Estados.ESPERANDO_ATENCION_CASETA);
                        cola_clientes_caseta.Add(Nuevo_Cliente);
                        cantidad_clientes_ingresan_al_sistema += 1;
                    }
                }
            }
            if (mostrar_clientes)
            {
                if (parametro_cantidad == "eventos")
                {
                    if (cantidad_iteraciones >= simulacion_desde && cantidad_iteraciones < simulacion_desde + 400)
                    {
                        clientes_a_mostrar.Add(Nuevo_Cliente);
                        agregar_cliente();
                    }
                }
                else
                {
                    if (reloj >= simulacion_desde && cantidad_a_mostrar < 400)
                    {
                        clientes_a_mostrar.Add(Nuevo_Cliente);
                        agregar_cliente();
                    }
                }
                nro_cliente += 1;
            }

        }

        private void EventoFinAtencionCaseta(servidor caseta_fin_atencion)
        {
            cantidad_clientes_atencion_finalizada_caseta += 1;
            Metrica2(caseta_fin_atencion.GetCliente());
            //Primero verifico si alguna nave esta libre para atender

            int cantidad_recorrida = 0;
            foreach (servidor i_nave in lista_naves)
            {
                cantidad_recorrida += 1;
                if(i_nave.GetEstado() == servidor.Estados.libre)
                {
                    caseta_fin_atencion.GetCliente().SetEstadoYHoraLlegadaCola(reloj, cliente.Estados.SIENDO_ATENDIDO_NAVE_1);
                    i_nave.SetEstado(servidor.Estados.ocupado);
                    i_nave.SetCliente(caseta_fin_atencion.GetCliente());

                    calcularFinAtencion(i_nave);

                    break;
                }

                if (cantidad_recorrida == cantidad_nave)
                {
                    caseta_fin_atencion.GetCliente().SetEstadoYHoraLlegadaCola(reloj, cliente.Estados.ESPERANDO_ATENCION_NAVE);
                    cola_clientes_nave.Add(caseta_fin_atencion.GetCliente());
                }
            }
            
            //Si cuando llega el cliente la cola esta vacia pasa a ser directamente atendido y no esta en el vector de la cola
            //Por lo que va a ser el cliente directamente atendido en la caseta. Si no es el último de la cola
            //Si no lo hago así, no puedo conocer a quien voy a atender en la caseta cuando no hay nadie en cola pero si alguien por atender

            //Si no hay nadie en la cola de la caseta, este servidor pasa a estar libre
            if (cola_clientes_caseta.Count == 0)
            {
                caseta_fin_atencion.SetEstado(servidor.Estados.libre);
                rnd_atencion_caseta = 0;
                tiempo_atencion_caseta = 0;
                caseta_fin_atencion.SetFinAtencion(0);
                caseta_fin_atencion.SetCliente(null);
            }
            //Si hay alguien en la cola lo va a pasar a atender y lo va a sacar de la cola 
            //Cliente_atendido_caseta se convirtió en el útlimo de la cola al principio de la funcion
            else
            {
                //ver
                Metrica6(cola_clientes_caseta.ElementAt(0));

                caseta_fin_atencion.SetCliente(cola_clientes_caseta.ElementAt(0));

                tiempo_medio_cliente_cola_caseta += (reloj - caseta_fin_atencion.GetCliente().GetMinutoLlegadaALaCola());

                caseta_fin_atencion.GetCliente().SetEstado(cliente.Estados.SIENDO_ATENDIDO_CASETA);
                cola_clientes_caseta.RemoveAt(0);
                calcularFinAtencion(caseta_fin_atencion);
            }   
            
        }

        private void EventoFinAtencionNave(servidor nave_fin_atencion)
        {
                     
            //ver

            cantidad_clientes_atencion_finalizada_nave += 1;
            Metrica3(nave_fin_atencion.GetCliente());

            int cantidad_recorrida = 0;
            foreach (servidor i_oficina in lista_oficinas)
            {
                cantidad_recorrida += 1;
                if(i_oficina.GetEstado() == servidor.Estados.libre)
                {
                    nave_fin_atencion.GetCliente().SetEstadoYHoraLlegadaCola(reloj, cliente.Estados.SIENDO_ATENDIDO_OFICINA_1);
                    i_oficina.SetEstado(servidor.Estados.ocupado);
                    i_oficina.SetCliente(nave_fin_atencion.GetCliente());

                    calcularFinAtencion(i_oficina);

                    break;
                }

                if(cantidad_recorrida == cantidad_de_oficinas)
                {
                    nave_fin_atencion.GetCliente().SetEstadoYHoraLlegadaCola(reloj, cliente.Estados.ESPERANDO_ATENCION_OFICINA);
                    cola_clientes_oficina.Add(nave_fin_atencion.GetCliente());
                }
            }

            //Paso un cliente que estaba en la cola a ser atendido
            if(cola_clientes_nave.Count > 0)
            {
                Metrica7(cola_clientes_nave.ElementAt(0));
                
                nave_fin_atencion.SetCliente(cola_clientes_nave.ElementAt(0));
                nave_fin_atencion.GetCliente().SetEstado(cliente.Estados.SIENDO_ATENDIDO_NAVE_1);
                cola_clientes_nave.RemoveAt(0);
                calcularFinAtencion(nave_fin_atencion);

            }
            else
            {
                nave_fin_atencion.SetEstado(servidor.Estados.libre);
                rnd_atencion_nave = 0.0;
                tiempo_atencion_nave = 0.0;
                nave_fin_atencion.SetFinAtencion(0);
                nave_fin_atencion.SetCliente(null);

            }
            Metrica1();
        }

        private void EventoFinAtencionOficina(servidor oficina_fin_atencion)
        {
            cantidad_clientes_atencion_finalizada_oficina += 1;

            foreach (servidor i_oficina in lista_oficinas)
            {
                Metrica4(oficina_fin_atencion.GetCliente());
                Metrica5(oficina_fin_atencion.GetCliente());

                oficina_fin_atencion.GetCliente().SetEstado(cliente.Estados.FUERA_DEL_SISTEMA);
            }

            if (cola_clientes_oficina.Count > 0)
            {
                oficina_fin_atencion.SetCliente(cola_clientes_oficina.ElementAt(0));
                oficina_fin_atencion.GetCliente().SetEstadoYHoraLlegadaCola(reloj, cliente.Estados.SIENDO_ATENDIDO_OFICINA_1);
                cola_clientes_oficina.RemoveAt(0);
                calcularFinAtencion(oficina_fin_atencion);
            }
            else
            {
                oficina_fin_atencion.SetEstado(servidor.Estados.libre);
                rnd_atencion_oficina = 0.0;
                tiempo_atencion_oficina = 0.0;
                oficina_fin_atencion.SetFinAtencion(0);
                oficina_fin_atencion.SetCliente(null);
            }
        }

        private void Metrica1()
        {
            longitud_media_de_la_cola_de_la_nave = Math.Round( tiempo_permanencia_cola_nave / reloj , 2);
        }

        private void Metrica2(cliente cliente)
        {
            tiempo_permanencia_caseta += Math.Round((reloj - cliente.GetMinutoLlegadaALaCola()), 2);
            tiempo_medio_cliente_caseta = Math.Round( tiempo_permanencia_caseta / (double)cantidad_clientes_atencion_finalizada_caseta, 2);
        }

        private void Metrica3(cliente cliente)
        {
            tiempo_permanencia_nave += Math.Round((reloj - cliente.GetMinutoLlegadaALaCola()), 2);
            tiempo_medio_cliente_nave = Math.Round( tiempo_permanencia_nave / (double)cantidad_clientes_atencion_finalizada_nave, 2);
        }

        private void Metrica4(cliente cliente)
        {
            tiempo_permanencia_oficina = Math.Round((reloj - cliente.GetMinutoLlegadaALaCola()), 2);
            tiempo_medio_cliente_oficina = Math.Round( tiempo_permanencia_oficina / (double)cantidad_clientes_atencion_finalizada_oficina, 2);
        }

        private void Metrica5(cliente cliente)
        {
            tiempo_permanencia_itv += Math.Round((reloj - cliente.GetMinutoLlegadaAlSistema()), 2);
            tiempo_medio_cliente_itv = Math.Round( tiempo_permanencia_itv / (double)cantidad_clientes_atencion_finalizada_oficina, 2);
        }

        private void Metrica6(cliente cliente)
        {
            tiempo_permanencia_cola_caseta += Math.Round((reloj - cliente.GetMinutoLlegadaALaCola()), 2);
            tiempo_medio_cliente_cola_caseta = Math.Round( tiempo_permanencia_cola_caseta / (double)cantidad_clientes_atencion_finalizada_caseta, 2);
        }

        private void Metrica7(cliente cliente)
        {
            tiempo_permanencia_cola_nave += Math.Round((reloj - cliente.GetMinutoLlegadaALaCola()), 2);
            tiempo_medio_cliente_cola_nave = Math.Round( tiempo_permanencia_cola_nave / (double)cantidad_clientes_atencion_finalizada_nave, 2);
        }

        private void Metrica8()
        {
            if(tiempo_maximo_entre_llegadas < tiempo_entre_llegadas) { tiempo_maximo_entre_llegadas = tiempo_entre_llegadas; }
        }

        private void Metrica9()
        {
            cantidad_clientes_que_se_van_por_cola_llena += 1;
        }

        private void Simulacion_Load(object sender, EventArgs e)
        {
            if(parametro_cantidad == "minutos")
            {
                lbl_desde.Text = lbl_desde.Text + " (Desde 0 hasta un valor menor a " + (cantidad.ToString()) + ")";
            }
            else
            {
                lbl_desde.Text = lbl_desde.Text + "(Desde 0 hasta " + (cantidad - 400).ToString() + ")";
            }
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Comprueba cual es el menor tiempo entre Proxima LLegada, Fin de Atencion de la caseta, Fin de Atención de cada nave
        // y el Fin de Atención de cada oficina. Aquel tiempo que sea el menor, será el tiempo del reloj.
        private servidor calcular_menor()
        {
            //Compara si es menor un tiempo con respecto al resto de tiempos, siempre y cuando estos sean distinto de cero
            servidor temp_menor_caseta = lista_casetas.First();
            servidor temp_menor_nave = lista_naves.First();
            servidor temp_menor_oficina = lista_oficinas.First();


            foreach (servidor caseta in lista_casetas)
            {
                if (caseta.GetFinAtencion() < temp_menor_caseta.GetFinAtencion())
                {
                    temp_menor_caseta = caseta;
                }
            }

            foreach (servidor nave in lista_naves)
            {
                if (nave.GetFinAtencion() < temp_menor_nave.GetFinAtencion())
                {
                    temp_menor_nave = nave;
                }
            }

            foreach (servidor oficina in lista_oficinas)
            {
                if (oficina.GetFinAtencion() < temp_menor_oficina.GetFinAtencion())
                {
                    temp_menor_oficina = oficina;
                }
            }

            if ((tiempo_proxima_llegada <= temp_menor_caseta.GetFinAtencion() || temp_menor_caseta.GetFinAtencion() == 0.0) &&
                (tiempo_proxima_llegada <= temp_menor_nave.GetFinAtencion() || temp_menor_nave.GetFinAtencion() == 0.0) &&
                (tiempo_proxima_llegada <= temp_menor_oficina.GetFinAtencion() || temp_menor_oficina.GetFinAtencion() == 0.0))
            {
                reloj = tiempo_proxima_llegada;
                return null;
            }

            else if ((temp_menor_caseta.GetFinAtencion() != 0.0) &&
                (temp_menor_caseta.GetFinAtencion() < tiempo_proxima_llegada) &&
                (temp_menor_caseta.GetFinAtencion() <= temp_menor_nave.GetFinAtencion() || temp_menor_nave.GetFinAtencion() == 0.0) &&
                (temp_menor_caseta.GetFinAtencion() <= temp_menor_oficina.GetFinAtencion() || temp_menor_oficina.GetFinAtencion() == 0.0))
            {
                reloj = temp_menor_caseta.GetFinAtencion();
                return temp_menor_caseta;
            }

            else if ((temp_menor_nave.GetFinAtencion() != 0.0) &&
                (temp_menor_nave.GetFinAtencion() <= tiempo_proxima_llegada) &&
                (temp_menor_nave.GetFinAtencion() <= temp_menor_caseta.GetFinAtencion() || temp_menor_caseta.GetFinAtencion() == 0.0) &&
                (temp_menor_nave.GetFinAtencion() <= temp_menor_oficina.GetFinAtencion() || temp_menor_oficina.GetFinAtencion() == 0.0))
            {
                reloj = temp_menor_nave.GetFinAtencion();
                return temp_menor_nave;
            }

            else if ((temp_menor_oficina.GetFinAtencion() != 0.0) &&
                (temp_menor_oficina.GetFinAtencion() <= tiempo_proxima_llegada) &&
                (temp_menor_oficina.GetFinAtencion() <= temp_menor_caseta.GetFinAtencion() || temp_menor_caseta.GetFinAtencion() == 0.0) &&
                (temp_menor_oficina.GetFinAtencion() <= temp_menor_nave.GetFinAtencion() || temp_menor_nave.GetFinAtencion() == 0.0))
            {
                reloj = temp_menor_oficina.GetFinAtencion();
                return temp_menor_oficina;
            }

            else
            {
                return null;
            }

            //if ((tiempo_proxima_llegada <= tiempo_fin_atencion_caseta || tiempo_fin_atencion_caseta == 0.0) &&
            //    (tiempo_proxima_llegada <= tiempo_fin_atencion_nave_1 || tiempo_fin_atencion_nave_1 == 0.0) &&
            //    (tiempo_proxima_llegada <= tiempo_fin_atencion_nave_2 || tiempo_fin_atencion_nave_2 == 0.0) &&
            //    (tiempo_proxima_llegada <= tiempo_fin_atencion_oficina_1 || tiempo_fin_atencion_oficina_1 == 0.0) &&
            //    (tiempo_proxima_llegada <= tiempo_fin_atencion_oficina_2 || tiempo_fin_atencion_oficina_2 == 0.0))
            //{
            //    reloj = tiempo_proxima_llegada;
            //    return "tiempo_proxima_llegada";
            //}
            //else if( (tiempo_fin_atencion_caseta != 0) &&
            //    (tiempo_fin_atencion_caseta <= tiempo_proxima_llegada) &&
            //    (tiempo_fin_atencion_caseta <= tiempo_fin_atencion_nave_1|| tiempo_fin_atencion_nave_1 == 0.0) &&
            //    (tiempo_fin_atencion_caseta <= tiempo_fin_atencion_nave_2|| tiempo_fin_atencion_nave_2 == 0.0) &&
            //    (tiempo_fin_atencion_caseta <= tiempo_fin_atencion_oficina_1 || tiempo_fin_atencion_oficina_1 == 0.0) &&
            //    (tiempo_fin_atencion_caseta <= tiempo_fin_atencion_oficina_2 || tiempo_fin_atencion_oficina_2 == 0.0))
            //{
            //    //MessageBox.Show("Tiempo fin caseta: " + tiempo_fin_atencion_caseta.ToString() + " | tiempo proxima llegada: " + tiempo_proxima_llegada.ToString());
            //    reloj = tiempo_fin_atencion_caseta;
            //    return "tiempo_fin_atencion_caseta";
            //}
            //else if(
            //    (tiempo_fin_atencion_nave_1 != 0) &&
            //    (tiempo_fin_atencion_nave_1 <= tiempo_proxima_llegada) &&
            //    (tiempo_fin_atencion_nave_1 <= tiempo_fin_atencion_caseta || tiempo_fin_atencion_caseta == 0.0) &&
            //    (tiempo_fin_atencion_nave_1 <= tiempo_fin_atencion_nave_2 || tiempo_fin_atencion_nave_2 == 0.0) &&
            //    (tiempo_fin_atencion_nave_1 <= tiempo_fin_atencion_oficina_1 || tiempo_fin_atencion_oficina_1 == 0.0) &&
            //    (tiempo_fin_atencion_nave_1 <= tiempo_fin_atencion_oficina_2|| tiempo_fin_atencion_oficina_2 == 0.0))
            //{
            //    reloj = tiempo_fin_atencion_nave_1;
            //    return "tiempo_fin_atencion_nave_1";
            //}
            //else if (
            //    (tiempo_fin_atencion_nave_2 != 0) &&
            //    tiempo_fin_atencion_nave_2 <= tiempo_proxima_llegada &&
            //    (tiempo_fin_atencion_nave_2 <= tiempo_fin_atencion_caseta || tiempo_fin_atencion_caseta == 0.0) && 
            //    (tiempo_fin_atencion_nave_2 <= tiempo_fin_atencion_nave_1 || tiempo_fin_atencion_nave_1 == 0.0) &&
            //    (tiempo_fin_atencion_nave_2 <= tiempo_fin_atencion_oficina_1 || tiempo_fin_atencion_oficina_1 == 0.0) &&
            //    (tiempo_fin_atencion_nave_2 <= tiempo_fin_atencion_oficina_2 || tiempo_fin_atencion_oficina_2 == 0.0))
            //{
            //    reloj = tiempo_fin_atencion_nave_2;
            //    return "tiempo_fin_atencion_nave_2";
            //}
            //else if (
            //    (tiempo_fin_atencion_oficina_1 != 0) &&
            //    tiempo_fin_atencion_oficina_1 <= tiempo_proxima_llegada &&
            //    (tiempo_fin_atencion_oficina_1 <= tiempo_fin_atencion_caseta || tiempo_fin_atencion_caseta == 0.0) && 
            //    (tiempo_fin_atencion_oficina_1 <= tiempo_fin_atencion_nave_1 || tiempo_fin_atencion_nave_1 == 0.0) &&
            //    (tiempo_fin_atencion_oficina_1 <= tiempo_fin_atencion_nave_2 || tiempo_fin_atencion_nave_2 == 0.0) &&
            //    (tiempo_fin_atencion_oficina_1 <= tiempo_fin_atencion_oficina_2 || tiempo_fin_atencion_oficina_2 == 0.0))
            //{
            //    reloj = tiempo_fin_atencion_oficina_1;
            //    return "tiempo_fin_atencion_oficina_1";
            //}
            //else 
            //{
            //    reloj = tiempo_fin_atencion_oficina_2;
            //    return "tiempo_fin_atencion_oficina_2";
            //}

        }

        //Función que se encarga de verificar cual es el siguiente evento y apartir de eso ejecutar lo que corresponda
        private void siguiente_secuencia()
        {
            /*Para calcular el tiempo de atención según corresponda:
                    caseta = 1, nave 1 = 2, nave 2 = 3, oficina 1 = 4, oficina 2 = 5*/

            //En la primera vuelta solo va a calcular la proxima llegada
            if (!flag_primera_vuelta)
            {
                flag_primera_vuelta = true;
                calcularProximaLlegada();
                tiempo_maximo_entre_llegadas = tiempo_entre_llegadas;
            }
            else
            {
                servidor servidor_menor_tiempo = calcular_menor();
                if(reloj > cantidad)
                {
                    reloj = cantidad;
                    Evento_lanzado = "Fin de simulación";
                }
                else { 

                    if (servidor_menor_tiempo == null)
                    {
                        Evento_lanzado = "LLegada de un auto";
                        EventoDeLlegada();
                        calcularProximaLlegada();
                        Metrica8();
                    }
                    else if (servidor_menor_tiempo.GetTipo() == servidor.Tipos.caseta)
                    {
                        Evento_lanzado = "Fin de atención en caseta";

                        EventoFinAtencionCaseta(servidor_menor_tiempo);

                    }
                    else if (servidor_menor_tiempo.GetTipo() == servidor.Tipos.nave)
                    {
                        Evento_lanzado = "Fin de atención en la nave";

                        EventoFinAtencionNave(servidor_menor_tiempo);
                    }
                    else if (servidor_menor_tiempo.GetTipo() == servidor.Tipos.oficina)
                    {
                        Evento_lanzado = "Fin de atención en la oficina";

                        EventoFinAtencionOficina(servidor_menor_tiempo);
                    }
                   
                }
            }
        }

        private void cargar_datos_tabla(int cantidad_iteraciones)
        {
            tabla_iteraciones.Rows.Add();
            //Cargar columnas y mostrarlas
            tabla_iteraciones.Rows[cantidad_iteraciones]["Evento"] = Evento_lanzado;
            tabla_iteraciones.Rows[cantidad_iteraciones]["Reloj (min)"] = reloj;

            if (cantidad_iteraciones != 0)
            {
                if (tiempo_proxima_llegada.ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Proxima llegada"].ToString())
                { rnd_llegadas = 0; }
                if (tiempo_entre_llegadas.ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Tiempo entre llegadas"].ToString())
                { tiempo_entre_llegadas = 0; }

                if (tiempo_atencion_caseta.ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Tiempo atencion caseta"].ToString())
                { tiempo_atencion_caseta = 0; }

                int temp_iteracion_cc = 0;
                foreach(servidor i_caseta in lista_casetas)
                {
                    temp_iteracion_cc += 1;
                    if (i_caseta.GetFinAtencion().ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Fin atencion caseta " + temp_iteracion_cc.ToString()].ToString())
                    { rnd_atencion_caseta = 0; }
                }

                int temp_iteracion_nn = 0;
                foreach (servidor i_nave in lista_naves)
                {
                    temp_iteracion_nn += 1;
                    if (i_nave.GetFinAtencion().ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Fin atencion nave " + temp_iteracion_nn.ToString()].ToString())
                    { rnd_atencion_nave = 0; }
                }
                
                if (tiempo_atencion_nave.ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Tiempo atencion nave"].ToString())
                { tiempo_atencion_nave = 0; }
                int temp_iteracion_oo = 0;
                foreach (servidor i_oficina in lista_oficinas)
                {
                    temp_iteracion_oo += 1;
                    if (i_oficina.GetFinAtencion().ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Fin atencion oficina " + temp_iteracion_oo.ToString()].ToString())
                    { rnd_atencion_nave = 0; }
                }
                
                if (tiempo_atencion_oficina.ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Tiempo atencion oficina"].ToString())
                { tiempo_atencion_oficina = 0; }
            }
            
            tabla_iteraciones.Rows[cantidad_iteraciones]["RND llegada cliente"] = rnd_llegadas.ToString() == "0"? "" : rnd_llegadas.ToString();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo entre llegadas"] = tiempo_entre_llegadas.ToString() == "0" ? "" : tiempo_entre_llegadas.ToString();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Proxima llegada"] = tiempo_proxima_llegada.ToString() == "0" ? "" : tiempo_proxima_llegada.ToString();

            tabla_iteraciones.Rows[cantidad_iteraciones]["RND atencion caseta"] = rnd_atencion_caseta.ToString() == "0" ? "" : rnd_atencion_caseta.ToString();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo atencion caseta"] = tiempo_atencion_caseta.ToString() == "0" ? "" : tiempo_atencion_caseta.ToString();
            int temp_iteracion_c = 0;
            foreach (servidor i_caseta in lista_casetas)
            {
                temp_iteracion_c += 1;
                tabla_iteraciones.Rows[cantidad_iteraciones]["Fin atencion caseta " + temp_iteracion_c.ToString()] = i_caseta.GetFinAtencion().ToString() == "0" ? "" : i_caseta.GetFinAtencion().ToString();
                tabla_iteraciones.Rows[cantidad_iteraciones]["Estado caseta " + temp_iteracion_c.ToString()] = i_caseta.GetEstado();
                
            }

            tabla_iteraciones.Rows[cantidad_iteraciones]["RND atencion nave"] = rnd_atencion_nave.ToString() == "0" ? "" : rnd_atencion_nave.ToString();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo atencion nave"] = tiempo_atencion_nave.ToString() == "0" ? "" : tiempo_atencion_nave.ToString();

            int temp_iteracion_n = 0;
            foreach (servidor i_nave in lista_naves)
            {
                temp_iteracion_n += 1;
                tabla_iteraciones.Rows[cantidad_iteraciones]["Fin atencion nave " + temp_iteracion_n.ToString()] = i_nave.GetFinAtencion().ToString() == "0" ? "" : i_nave.GetFinAtencion().ToString();
                tabla_iteraciones.Rows[cantidad_iteraciones]["Estado nave " + temp_iteracion_n.ToString()] = i_nave.GetEstado();
            }

            tabla_iteraciones.Rows[cantidad_iteraciones]["RND atencion oficina"] = rnd_atencion_oficina.ToString() == "0" ? "" : rnd_atencion_oficina.ToString();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo atencion oficina"] = tiempo_atencion_oficina.ToString() == "0" ? "" : tiempo_atencion_oficina.ToString();

            int temp_iteracion_o = 0;
            foreach (servidor i_oficina in lista_oficinas)
            {
                temp_iteracion_o += 1;
                tabla_iteraciones.Rows[cantidad_iteraciones]["Fin atencion oficina " + temp_iteracion_o.ToString()] = i_oficina.GetFinAtencion().ToString() == "0" ? "" : i_oficina.GetFinAtencion().ToString();
                tabla_iteraciones.Rows[cantidad_iteraciones]["Estado oficina " + temp_iteracion_o.ToString()] = i_oficina.GetEstado();
            }


            tabla_iteraciones.Rows[cantidad_iteraciones]["Cola caseta"] = cola_clientes_caseta.Count();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Cola nave"] = cola_clientes_nave.Count();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Cola oficina"] = cola_clientes_oficina.Count();

            //Metricas
            //1
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo de permanencia en cola de la nave"] = tiempo_permanencia_cola_nave;
            tabla_iteraciones.Rows[cantidad_iteraciones]["Longitud media de la cola de la nave"] = longitud_media_de_la_cola_de_la_nave;
            //2
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo de permanencia en la caseta"] = tiempo_permanencia_caseta;
            tabla_iteraciones.Rows[cantidad_iteraciones]["Cantidad clientes con atencion caseta finalizada"] = cantidad_clientes_atencion_finalizada_caseta;
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo medio del cliente en la caseta"] = tiempo_medio_cliente_caseta;
            //3
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo de permanencia en la nave"] = tiempo_permanencia_nave;
            tabla_iteraciones.Rows[cantidad_iteraciones]["Cantidad clientes con atencion nave finalizada"] = cantidad_clientes_atencion_finalizada_nave;
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo medio del cliente en la nave"] = tiempo_medio_cliente_nave;
            //4
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo de permanencia en la oficina"] = tiempo_permanencia_oficina;
            tabla_iteraciones.Rows[cantidad_iteraciones]["Cantidad clientes con atencion oficina finalizada"] = cantidad_clientes_atencion_finalizada_oficina;
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo medio del cliente en la oficina"] = tiempo_medio_cliente_oficina;
            //5
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo de permanencia en el sistema"] = tiempo_permanencia_itv;
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo medio del cliente en el ITV"] = tiempo_medio_cliente_itv;
            //6
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo de permanencia en la cola de la caseta"] = tiempo_permanencia_cola_caseta;
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo medio del cliente en la cola de la caseta"] = tiempo_medio_cliente_cola_caseta;
            //7
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo de permanencia en la cola de la nave"] = tiempo_permanencia_cola_nave;
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo medio del cliente en la cola de nave"] = tiempo_medio_cliente_cola_nave;
            //8
            tabla_iteraciones.Rows[cantidad_iteraciones]["Maximo tiempo entre llegadas"] = tiempo_maximo_entre_llegadas;

            tabla_iteraciones.Rows[cantidad_iteraciones]["Cantidad de clientes que no entran a la cola porque esta llena"] = cantidad_clientes_que_se_van_por_cola_llena;

            //Clientes
            if (mostrar_clientes)
            {
                string estado_cliente_nro = "Estado cliente" + nro_cliente.ToString();
                string hora_llegada_cliente_nro = "Hora llegada cliente" + nro_cliente.ToString();
                int estado_cliente;
                string estado_cliente_string;
                for (int i = 0; i < clientes_a_mostrar.Count; i++)
                {
                    estado_cliente = (int)clientes_a_mostrar[i].GetEstado();
                    if      (estado_cliente == 0) { estado_cliente_string = "EAC";      }
                    else if (estado_cliente == 1) { estado_cliente_string = "SAC";      }
                    else if (estado_cliente == 2) { estado_cliente_string = "EAN";      }
                    else if (estado_cliente == 3) { estado_cliente_string = "SAN(1)";   }
                    else if (estado_cliente == 4) { estado_cliente_string = "SAN(2)";   }
                    else if (estado_cliente == 5) { estado_cliente_string = "EAO";      }
                    else if (estado_cliente == 6) { estado_cliente_string = "SAO(1)";   }
                    else if (estado_cliente == 7) { estado_cliente_string = "SAO(2)";   }
                    else if (estado_cliente == 8) { estado_cliente_string = "SLCC";     }
                    else                          { estado_cliente_string = "FDS";      }

                    tabla_iteraciones.Rows[cantidad_iteraciones]["Estado cliente" + (i + nro_cliente_desde_que_se_muestra).ToString()] = estado_cliente_string;
                    tabla_iteraciones.Rows[cantidad_iteraciones]["Hora llegada cliente" + (i + nro_cliente_desde_que_se_muestra).ToString()] = clientes_a_mostrar[i].GetMinutoLlegadaAlSistema();
                }
            }
        }
        
        private void btn_simular_Click(object sender, EventArgs e)
        {
            objeto_semilla = new Random();
            objeto_rnd_llegadas = new Random(objeto_semilla.Next());
            objeto_rnd_atencion_caseta = new Random(objeto_semilla.Next());
            objeto_rnd_atencion_nave = new Random(objeto_semilla.Next());
            objeto_rnd_atencion_oficina = new Random(objeto_semilla.Next());

            //pregunto si el programa ya se ejecuto
            if (flag_tabla_cargada)
            {
                //desligo la tabla del data source
                dg_colas.DataSource = null;
                //limpiar las filas
                tabla_iteraciones.Rows.Clear();
                for (int i = nro_cliente_desde_que_se_muestra; i < (clientes_a_mostrar.Count + nro_cliente_desde_que_se_muestra); i++)
                {
                    tabla_iteraciones.Columns.Remove("Estado cliente" + i.ToString());
                    tabla_iteraciones.Columns.Remove("Hora llegada cliente" + i.ToString());
                }

            }
            else
            {
                //si no se ejecuto cargo las columnas de la tabla
                cargarTabla();
                flag_tabla_cargada = true;
            }

            volverACero();

            //se crean los n servidores del tipo caseta
            for (int i = 0; i < cantidad_de_casetas; i++)
            {
                servidor nueva_caseta = new servidor(servidor.Tipos.caseta);
                lista_casetas.Add(nueva_caseta);
            }

            //se crean los n servidores del tipo nave
            for (int i = 0; i < cantidad_de_naves; i++)
            {
                servidor nueva_nave = new servidor(servidor.Tipos.nave);
                lista_naves.Add(nueva_nave);

            }

            //se crean los n servidores del tipo oficina
            for (int i = 0; i < cantidad_de_oficinas; i++)
            {
                servidor nueva_oficina = new servidor(servidor.Tipos.oficina);
                lista_oficinas.Add(nueva_oficina);
            }

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

            if(parametro_cantidad == "eventos")
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
                        cargar_datos_tabla(cantidad_iteraciones-simulacion_desde);
                    }
                    cantidad_iteraciones += 1;

                    if (cantidad_iteraciones == cantidad && cantidad_iteraciones != (simulacion_desde + 400))
                    {
                        cargar_datos_tabla(400);
                    }
                }
            }

            dg_colas.DataSource = tabla_iteraciones;
            //ModificarColumnas();

            lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Text += tiempo_medio_cliente_oficina.ToString();
            lbl_tiempo_medio_cliente_ITV.Text += tiempo_medio_cliente_itv.ToString();
            lbl_longitud_media_cola_nave.Text += longitud_media_de_la_cola_de_la_nave.ToString();
            lbl_tiempo_medio_cliente_nave.Text += tiempo_medio_cliente_nave.ToString();
            lbl_tiempo_medio_cola_nave.Text += tiempo_medio_cliente_cola_nave.ToString();
            lbl_tiempo_medio_cliente_caseta.Text += tiempo_medio_cliente_caseta.ToString();
            lbl_tiempo_medio_cliente_cola_caseta.Text += tiempo_medio_cliente_cola_caseta.ToString();
            lbl_maximo_tiempo_entre_llegadas.Text += tiempo_maximo_entre_llegadas.ToString();
            lbl_clientes_se_van_cola_llena.Text += cantidad_clientes_que_se_van_por_cola_llena.ToString();

        }

        private void ModificarColumnas()
        {
            //colores
            dg_colas.Columns[4].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            dg_colas.Columns[7].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            dg_colas.Columns[10].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            dg_colas.Columns[11].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            dg_colas.Columns[14].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            dg_colas.Columns[15].DefaultCellStyle.BackColor = Color.LightSkyBlue;

            //metrica 1
            dg_colas.Columns[23].DefaultCellStyle.BackColor = Color.LightSeaGreen;
            dg_colas.Columns[24].DefaultCellStyle.BackColor = Color.LightSeaGreen;

            //metrica 2
            dg_colas.Columns[25].DefaultCellStyle.BackColor = Color.DarkGray;
            dg_colas.Columns[26].DefaultCellStyle.BackColor = Color.DarkGray;
            dg_colas.Columns[27].DefaultCellStyle.BackColor = Color.DarkGray;

            //metrica 3
            dg_colas.Columns[28].DefaultCellStyle.BackColor = Color.LightSeaGreen;
            dg_colas.Columns[29].DefaultCellStyle.BackColor = Color.LightSeaGreen;
            dg_colas.Columns[30].DefaultCellStyle.BackColor = Color.LightSeaGreen;

            //metrica 4
            dg_colas.Columns[31].DefaultCellStyle.BackColor = Color.DarkGray;
            dg_colas.Columns[32].DefaultCellStyle.BackColor = Color.DarkGray;
            dg_colas.Columns[33].DefaultCellStyle.BackColor = Color.DarkGray;

            //metrica 5
            dg_colas.Columns[34].DefaultCellStyle.BackColor = Color.LightSeaGreen;
            dg_colas.Columns[35].DefaultCellStyle.BackColor = Color.LightSeaGreen;

            //metrica 6
            dg_colas.Columns[36].DefaultCellStyle.BackColor = Color.DarkGray;
            dg_colas.Columns[37].DefaultCellStyle.BackColor = Color.DarkGray;

            //metrica 7
            dg_colas.Columns[38].DefaultCellStyle.BackColor = Color.LightSeaGreen;
            dg_colas.Columns[39].DefaultCellStyle.BackColor = Color.LightSeaGreen;

            //metrica 8
            dg_colas.Columns[40].DefaultCellStyle.BackColor = Color.DarkGray;

            //metrica 9
            dg_colas.Columns[41].DefaultCellStyle.BackColor = Color.LightSeaGreen;

            //tamaños
            dg_colas.Columns[0].Width = 160;
            for (int i = 1; i <= 22; i++)
            {
                dg_colas.Columns[i].Width = 60;
            }
            for (int i = 23; i < 41; i++)
            {
                dg_colas.Columns[i].Width = 100;
            }
        }

        private void cargarTabla()
        {
            DataColumn evento                   =new DataColumn("Evento"); 
            tabla_iteraciones.Columns.Add(evento);

            //asigno las columnas a la tabla
            DataColumn columna_reloj            = new DataColumn("Reloj (min)");
            tabla_iteraciones.Columns.Add(columna_reloj);

            //Llegada cliente
            DataColumn columna_rnd_llegada              = new DataColumn("RND llegada cliente");
            tabla_iteraciones.Columns.Add(columna_rnd_llegada);
            DataColumn columna_tiempo_entre_llegadas    = new DataColumn("Tiempo entre llegadas");
            tabla_iteraciones.Columns.Add(columna_tiempo_entre_llegadas);
            DataColumn columna_proxima_llegada          = new DataColumn("Proxima llegada");
            tabla_iteraciones.Columns.Add(columna_proxima_llegada);
            
                       
            //Atencion caseta
            DataColumn columna_rnd_atencion_caseta      = new DataColumn("RND atencion caseta");
            tabla_iteraciones.Columns.Add(columna_rnd_atencion_caseta);
            DataColumn columna_tiempo_atencion_caseta   = new DataColumn("Tiempo atencion caseta");
            tabla_iteraciones.Columns.Add(columna_tiempo_atencion_caseta);

            for (int i = 0; i < cantidad_de_casetas; i++)
            {
                DataColumn columna_fin_atencion_caseta = new DataColumn("Fin atencion caseta " + (i+1).ToString());
                tabla_iteraciones.Columns.Add(columna_fin_atencion_caseta   );
                DataColumn columna_estado_caseta = new DataColumn("Estado caseta " + (i + 1).ToString());
                tabla_iteraciones.Columns.Add(columna_estado_caseta);
            }
            
                       
            //Atencion nave
            DataColumn columna_rnd_atencion_nave        = new DataColumn("RND atencion nave");
            tabla_iteraciones.Columns.Add(columna_rnd_atencion_nave);
            DataColumn columna_tiempo_atencion_nave     = new DataColumn("Tiempo atencion nave");
            tabla_iteraciones.Columns.Add(columna_tiempo_atencion_nave);

            for (int i = 0; i < cantidad_de_naves; i++)
            {
                DataColumn columna_fin_atencion_nave = new DataColumn("Fin atencion nave " + (i+1).ToString());
                tabla_iteraciones.Columns.Add(columna_fin_atencion_nave);
                DataColumn columna_estado_nave = new DataColumn("Estado nave " + (i + 1).ToString());
                tabla_iteraciones.Columns.Add(columna_estado_nave );
            }
            

            //Atencion oficina
            DataColumn columna_rnd_atencion_oficina     = new DataColumn("RND atencion oficina");
            tabla_iteraciones.Columns.Add(columna_rnd_atencion_oficina);
            DataColumn columna_tiempo_atencion_oficina  = new DataColumn("Tiempo atencion oficina");
            tabla_iteraciones.Columns.Add(columna_tiempo_atencion_oficina);

            for (int i = 0; i < cantidad_de_oficinas; i++)
            {
                DataColumn columna_fin_atencion_oficina = new DataColumn("Fin atencion oficina " + (i+1).ToString());
                tabla_iteraciones.Columns.Add(columna_fin_atencion_oficina);
                DataColumn columna_estado_oficina = new DataColumn("Estado oficina " + (i + 1).ToString());
                tabla_iteraciones.Columns.Add(columna_estado_oficina);
            }

                       
            //Colas servidores
            DataColumn columna_cola_caseta              = new DataColumn("Cola caseta");
            DataColumn columna_cola_nave                = new DataColumn("Cola nave");
            DataColumn columna_cola_oficina             = new DataColumn("Cola oficina");

            //Metrica 1
            DataColumn columna_tiempo_permanencia_cola_nave_metrica1          = new DataColumn("Tiempo de permanencia en cola de la nave");
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

            
                                          
            //Colas servidores            
            tabla_iteraciones.Columns.Add(columna_cola_caseta );
            tabla_iteraciones.Columns.Add(columna_cola_nave   );
            tabla_iteraciones.Columns.Add(columna_cola_oficina);

            //Metrica 1   
            tabla_iteraciones.Columns.Add(columna_tiempo_permanencia_cola_nave_metrica1);
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

        private void volverACero()
        {
            //cantidad de clientes que llegan
            cantidad_llegadas = 0;
            cantidad_caseta = 0;
            cantidad_nave = 0;
            cantidad_oficina = 0;

            //minutos en los que llegan los clientes
            minutos_llegadas = 0;
            minutos_caseta = 0;
            minutos_nave = 0;
            minutos_oficina = 0;

            tiempo_entre_llegadas = 0.0;
            tiempo_atencion_caseta = 0.0;
            tiempo_atencion_nave = 0.0;
            tiempo_atencion_oficina = 0.0;

            //tiempos de proxima llegada y fin atencion
            tiempo_proxima_llegada = 0.0;


            rnd_llegadas = 0;
            rnd_atencion_caseta = 0;
            rnd_atencion_nave = 0;
            rnd_atencion_oficina = 0;

            //Cola para los servidores
            cola_clientes_caseta = new List<cliente>();
            cola_clientes_nave = new List<cliente>();
            cola_clientes_oficina = new List<cliente>();

            //reloj
            reloj = 0;

            flag_primera_vuelta = false;

            Evento_lanzado = "";

            longitud_media_de_la_cola_de_la_nave = 0;
            tiempo_permanencia_caseta = 0.0;
            tiempo_medio_cliente_caseta = 0.0;
            cantidad_clientes_atencion_finalizada_caseta = 0;
            tiempo_permanencia_nave = 0.0;
            tiempo_medio_cliente_nave = 0.0;
            cantidad_clientes_atencion_finalizada_nave = 0;
            tiempo_permanencia_oficina = 0.0;
            tiempo_medio_cliente_oficina = 0.0;
            cantidad_clientes_atencion_finalizada_oficina = 0;
            tiempo_permanencia_itv = 0.0;
            tiempo_medio_cliente_itv = 0.0;
            tiempo_permanencia_cola_caseta = 0.0;
            tiempo_medio_cliente_cola_caseta = 0.0;
            tiempo_permanencia_cola_nave = 0.0;
            tiempo_medio_cliente_cola_nave = 0.0;
            tiempo_maximo_entre_llegadas = 0.0;
            cantidad_clientes_que_se_van_por_cola_llena = 0;
            cantidad_clientes_ingresan_al_sistema = 0;
            cantidad_iteraciones = 0;
            nro_cliente_desde_que_se_muestra = 0;

            cantidad_a_mostrar = 0;

            nro_cliente = 0;
            clientes_a_mostrar = new List<cliente>();

            lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Text = "Tiempo medio que un cliente pasa en la oficina (incluye cola): ";
            lbl_tiempo_medio_cliente_ITV.Text = "Tiempo medio que un cliente se encuentra en la ITV: ";
            lbl_longitud_media_cola_nave.Text = "Longitud media de la cola de la nave: ";
            lbl_tiempo_medio_cliente_nave.Text = "Tiempo medio que un cliente pasa en la nave (incluye cola): ";
            lbl_tiempo_medio_cola_nave.Text = "Tiempo medio que un cliente pasa en la cola de la nave: ";
            lbl_tiempo_medio_cliente_caseta.Text = "Tiempo medio que un cliente pasa en la caseta (incluye cola): ";
            lbl_tiempo_medio_cliente_cola_caseta.Text = "Tiempo medio que un cliente pasa en la cola de la caseta: ";
            lbl_maximo_tiempo_entre_llegadas.Text = "Máximo tiempo entre llegadas de clientes al sistema: ";
            lbl_clientes_se_van_cola_llena.Text = "Cantidad de clientes que se van del sistema porque no hay lugar en la cola: ";

            lista_casetas = new List<servidor>();
            lista_naves = new List<servidor>();
            lista_oficinas = new List<servidor>();
        }
    }
}
