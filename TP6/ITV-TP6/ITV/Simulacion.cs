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
        Random objeto_rnd_atentados_tipo;
        Random objeto_rnd_atentados_beta;

        //Número entre 0 y 1 para calcular los tiempo según corresponda
        double rnd_llegadas, rnd_atencion_caseta, rnd_atencion_nave, rnd_atencion_oficina, rnd_atentado_tipo, rnd_beta;

        //tiempos de llegada y atencion
        double tiempo_entre_llegadas = 0.0;
        double tiempo_atencion_caseta = 0.0;
        double tiempo_atencion_nave = 0.0;
        double tiempo_atencion_oficina = 0.0;

        //tiempos de proxima llegada y fin atencion
        double tiempo_proxima_llegada = 0.0;

        string tipo_de_atentado;
        double tiempo_entre_bloqueos = 0.0;
        double tiempo_proximo_bloqueo = 0.0;
        double tiempo_entre_bloqueos_ingreso = 0.0;
        double tiempo_fin_bloqueo_ingreso = 0.0;
        double tiempo_entre_bloqueos_servicio = 0.0;
        double tiempo_fin_bloqueo_servicio = 0.0;
        double h;
        double A;
        int cantidad_iteraciones_rk_atentado;
        int cantidad_iteraciones_rk_bloqueo_ingreso;
        int cantidad_iteraciones_rk_bloqueo_servicio;

        //datatable RungeKutta
        DataTable tabla_rk_atentado;
        DataTable tabla_rk_atentado2;
        DataTable tabla_rk_atentado3;
        DataTable tabla_rk_bloqueo_ingreso;
        DataTable tabla_rk_bloqueo_ingreso2;
        DataTable tabla_rk_bloqueo_servicio;
        DataTable tabla_rk_bloqueo_servicio2;

        //bandera llegadas
        bool bandera_llegadas;
        
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
        bool bandera_nro_cliente;

        //metrica 1
        double longitud_media_de_la_cola_de_la_nave;

        //metrica 2
        double tiempo_permanencia_caseta = 0.0;
        double tiempo_medio_cliente_caseta = 0.0;
        int cantidad_clientes_atencion_finalizada_caseta;

        //metrica 3
        double tiempo_permanencia_nave = 0.0;
        double tiempo_medio_cliente_nave = 0.0;
        int cantidad_clientes_atencion_finalizada_nave;

        //metrica 4
        double tiempo_permanencia_oficina = 0.0;
        double tiempo_medio_cliente_oficina = 0.0;
        int cantidad_clientes_atencion_finalizada_oficina;

        //metrica 5
        double tiempo_permanencia_itv = 0.0;
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
        int cantidad_clientes_ingresan_al_sistema = 0;
        int cantidad_clientes_que_se_van_por_bloqueo = 0;

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

        int tipo_menor_tiempo;

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

        public void calcularProximoAtentado()
        {
            tiempo_entre_bloqueos = Math.Truncate(rungeKutta(0) * 100) / 100;
            tiempo_proximo_bloqueo = Math.Truncate((reloj + tiempo_entre_bloqueos) * 100) / 100;
        }

        //Obtiene el random y el correspondiente tiempo según el parametro que se le pasa
        private void calcularFinAtencion(servidor servidor_calcular)
        {
            if (servidor_calcular.GetTipo() == servidor.Tipos.caseta)
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
            if (nro_cliente_desde_que_se_muestra == 0 && bandera_nro_cliente)
            {
                nro_cliente_desde_que_se_muestra = nro_cliente;
                bandera_nro_cliente = false;
            }
        }

        private void EventoDeLlegada()
        {
            cliente Nuevo_Cliente = null;

            if (!bandera_llegadas)
            {
                Nuevo_Cliente = new cliente(reloj, cliente.Estados.INGRESO_BLOQUEADO);
                cantidad_clientes_que_se_van_por_bloqueo += 1;
            }
            else
            {
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

                    if (cantidad_recorrida == cantidad_de_casetas)
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
                if (i_nave.GetEstado() == servidor.Estados.libre)
                {
                    caseta_fin_atencion.GetCliente().SetEstadoYHoraLlegadaCola(reloj, cliente.Estados.SIENDO_ATENDIDO_NAVE);
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
                if (i_oficina.GetEstado() == servidor.Estados.libre)
                {
                    nave_fin_atencion.GetCliente().SetEstadoYHoraLlegadaCola(reloj, cliente.Estados.SIENDO_ATENDIDO_OFICINA);
                    i_oficina.SetEstado(servidor.Estados.ocupado);
                    i_oficina.SetCliente(nave_fin_atencion.GetCliente());

                    calcularFinAtencion(i_oficina);

                    break;
                }

                if (cantidad_recorrida == cantidad_de_oficinas)
                {
                    nave_fin_atencion.GetCliente().SetEstadoYHoraLlegadaCola(reloj, cliente.Estados.ESPERANDO_ATENCION_OFICINA);
                    cola_clientes_oficina.Add(nave_fin_atencion.GetCliente());
                }
            }

            //Paso un cliente que estaba en la cola a ser atendido
            if (cola_clientes_nave.Count > 0)
            {
                Metrica7(cola_clientes_nave.ElementAt(0));

                nave_fin_atencion.SetCliente(cola_clientes_nave.ElementAt(0));
                nave_fin_atencion.GetCliente().SetEstado(cliente.Estados.SIENDO_ATENDIDO_NAVE);
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
                oficina_fin_atencion.GetCliente().SetEstadoYHoraLlegadaCola(reloj, cliente.Estados.SIENDO_ATENDIDO_OFICINA);
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
            longitud_media_de_la_cola_de_la_nave = Math.Round(tiempo_permanencia_cola_nave / reloj, 2);
        }

        private void Metrica2(cliente cliente)
        {
            tiempo_permanencia_caseta += Math.Round((reloj - cliente.GetMinutoLlegadaALaCola()), 2);
            tiempo_medio_cliente_caseta = Math.Round(tiempo_permanencia_caseta / (double)cantidad_clientes_atencion_finalizada_caseta, 2);
        }

        private void Metrica3(cliente cliente)
        {
            tiempo_permanencia_nave += Math.Round((reloj - cliente.GetMinutoLlegadaALaCola()), 2);
            tiempo_medio_cliente_nave = Math.Round(tiempo_permanencia_nave / (double)cantidad_clientes_atencion_finalizada_nave, 2);
        }

        private void Metrica4(cliente cliente)
        {
            tiempo_permanencia_oficina = Math.Round((reloj - cliente.GetMinutoLlegadaALaCola()), 2);
            tiempo_medio_cliente_oficina = Math.Round(tiempo_permanencia_oficina / (double)cantidad_clientes_atencion_finalizada_oficina, 2);
        }

        private void Metrica5(cliente cliente)
        {
            tiempo_permanencia_itv += Math.Round((reloj - cliente.GetMinutoLlegadaAlSistema()), 2);
            tiempo_medio_cliente_itv = Math.Round(tiempo_permanencia_itv / (double)cantidad_clientes_atencion_finalizada_oficina, 2);
        }

        private void Metrica6(cliente cliente)
        {
            tiempo_permanencia_cola_caseta += Math.Round((reloj - cliente.GetMinutoLlegadaALaCola()), 2);
            tiempo_medio_cliente_cola_caseta = Math.Round(tiempo_permanencia_cola_caseta / (double)cantidad_clientes_atencion_finalizada_caseta, 2);
        }

        private void Metrica7(cliente cliente)
        {
            tiempo_permanencia_cola_nave += Math.Round((reloj - cliente.GetMinutoLlegadaALaCola()), 2);
            tiempo_medio_cliente_cola_nave = Math.Round(tiempo_permanencia_cola_nave / (double)cantidad_clientes_atencion_finalizada_nave, 2);
        }

        private void Metrica8()
        {
            if (tiempo_maximo_entre_llegadas < tiempo_entre_llegadas) { tiempo_maximo_entre_llegadas = tiempo_entre_llegadas; }
        }

        private void Metrica9()
        {
            cantidad_clientes_que_se_van_por_cola_llena += 1;
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
                lbl_desde.Location = new Point(lbl_desde.Location.X + 95, lbl_desde.Location.Y);
            }
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void EventoAtentado()
        {
            rnd_atentado_tipo = Math.Truncate(objeto_rnd_atentados_tipo.NextDouble() * 100) / 100;
            if (rnd_atentado_tipo <= 0.69)
            {
                tipo_de_atentado = "Bloqueo de llegadas";

                tiempo_entre_bloqueos_ingreso = rungeKutta(1);
                tiempo_fin_bloqueo_ingreso = tiempo_entre_bloqueos_ingreso + reloj;
                bandera_llegadas = false;
            }
            else
            {
                tipo_de_atentado = "Bloqueo de caseta";

                tiempo_entre_bloqueos_servicio = rungeKutta(2);
                tiempo_fin_bloqueo_servicio = tiempo_entre_bloqueos_servicio + reloj;
                foreach (servidor serv in lista_casetas)
                {
                    if(serv.GetEstado() == servidor.Estados.ocupado)
                    {
                        serv.SetTiempoRemanenteAtencion(Math.Truncate((serv.GetFinAtencion() - reloj) * 100) / 100);
                        serv.SetFinAtencion(0.0);
                        serv.GetCliente().SetEstado(cliente.Estados.ESPERANDO_REANUDACION_ATENCION);
                    }
                    serv.SetEstado(servidor.Estados.bloqueado);
                    
                }
            }
        }

        public void EventoFinBloqueoLlegadas()
        {
            bandera_llegadas = true;
            tiempo_fin_bloqueo_ingreso = 0;
        }

        public void EventoFinBloqueoServicio()
        {
            tiempo_fin_bloqueo_servicio = 0;
            foreach (servidor serv in lista_casetas)
            {
                if(serv.GetCliente() == null)
                {
                    serv.SetEstado(servidor.Estados.libre);
                }
                else
                {
                    serv.SetEstado(servidor.Estados.ocupado);
                    serv.SetFinAtencion(reloj + serv.GetTiempoRemanenteAtencion());
                    serv.SetTiempoRemanenteAtencion(0.0);
                    serv.GetCliente().SetEstado(cliente.Estados.SIENDO_ATENDIDO_CASETA);
                }
            }
        }

        /* 0 atentado, 1 llegada y 2 servicio */
        public double rungeKutta(int atentado_llegada_o_servicio)
        {
            double x0 = 0;
            double y0 = reloj;
            double h_2 = (h / 2);
            int maximo = 72;

            double x1 = 0;
            double y1 = 0;

            double k1 = 0.0;
            double k2 = 0.0;
            double k3 = 0.0;
            double k4 = 0.0;
            int iteracion = 0;

            if (atentado_llegada_o_servicio == 0)
            {
                if (parametro_cantidad == "eventos")
                {
                    if (cantidad_iteraciones >= simulacion_desde && cantidad_iteraciones < simulacion_desde + 400)
                    {
                        if(cantidad_iteraciones_rk_atentado <= maximo)
                        {
                            cargarTablaRKAtentado(cantidad_iteraciones_rk_atentado);
                        }
                        else if(cantidad_iteraciones_rk_atentado <= 2 * maximo)
                        {
                            cargarTablaRKAtentado2(cantidad_iteraciones_rk_atentado);
                        }
                        else if (cantidad_iteraciones_rk_atentado <= 3 * maximo)
                        {
                            cargarTablaRKAtentado3(cantidad_iteraciones_rk_atentado);
                        }
                    }
                }
                else
                {
                    if (reloj >= simulacion_desde && cantidad_a_mostrar < 400)
                    {
                        if (cantidad_iteraciones_rk_atentado <= maximo)
                        {
                            cargarTablaRKAtentado(cantidad_iteraciones_rk_atentado);
                        }
                        else if (cantidad_iteraciones_rk_atentado <= 2 * maximo)
                        {
                            cargarTablaRKAtentado2(cantidad_iteraciones_rk_atentado);
                        }
                        else if (cantidad_iteraciones_rk_atentado <= 3 * maximo)
                        {
                            cargarTablaRKAtentado3(cantidad_iteraciones_rk_atentado);
                        }
                    }
                }
                
                do
                {
                    rnd_beta = Math.Truncate((objeto_rnd_atentados_beta.NextDouble() * 100)) / 100;
                }
                while (rnd_beta < 0.01);

                double inicial = A * 2;
                bool flag_primera = false;
                do
                {
                    
                    if (!flag_primera)
                    {
                        flag_primera = true;
                    }
                    else
                    {
                        x0 = x1;
                        y0 = y1;
                    }

                    // A = y0 - T = x0
                    k1 = (rnd_beta * y0);
                    k2 = (rnd_beta * (y0 + (h_2 * k1)));
                    k3 = (rnd_beta * (y0 + (h_2 * k2)));
                    k4 = (rnd_beta * (y0 + (h * k3)));

                    x1 = x0 + h;
                    y1 = y0 + (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4);


                    if (parametro_cantidad == "eventos")
                    {
                        if (cantidad_iteraciones >= simulacion_desde && cantidad_iteraciones < simulacion_desde + 400)
                        {
                            if(cantidad_iteraciones_rk_atentado <= maximo)
                            {
                                if (iteracion >= tabla_rk_atentado.Rows.Count)
                                {
                                    tabla_rk_atentado.Rows.Add();
                                }

                                tabla_rk_atentado.Rows[iteracion]["t-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(x0 * 1000) / 1000;
                                tabla_rk_atentado.Rows[iteracion]["A-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(y0 * 1000) / 1000;
                                tabla_rk_atentado.Rows[iteracion]["β-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(rnd_beta * 1000) / 1000;
                                tabla_rk_atentado.Rows[iteracion]["K1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k1 * 1000) / 1000;
                                tabla_rk_atentado.Rows[iteracion]["K2-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k2 * 1000) / 1000;
                                tabla_rk_atentado.Rows[iteracion]["K3-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k3 * 1000) / 1000;
                                tabla_rk_atentado.Rows[iteracion]["K4-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k4 * 1000) / 1000;
                                tabla_rk_atentado.Rows[iteracion]["t1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(x1 * 1000) / 1000;
                                tabla_rk_atentado.Rows[iteracion]["A1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(y1 * 1000) / 1000;
                                iteracion += 1;
                            }
                            else if(cantidad_iteraciones_rk_atentado <= 2*maximo)
                            {
                                if (iteracion >= tabla_rk_atentado2.Rows.Count)
                                {
                                    tabla_rk_atentado2.Rows.Add();
                                }

                                tabla_rk_atentado2.Rows[iteracion]["t-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(x0 * 1000) / 1000;
                                tabla_rk_atentado2.Rows[iteracion]["A-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(y0 * 1000) / 1000;
                                tabla_rk_atentado2.Rows[iteracion]["β-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(rnd_beta * 1000) / 1000;
                                tabla_rk_atentado2.Rows[iteracion]["K1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k1 * 1000) / 1000;
                                tabla_rk_atentado2.Rows[iteracion]["K2-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k2 * 1000) / 1000;
                                tabla_rk_atentado2.Rows[iteracion]["K3-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k3 * 1000) / 1000;
                                tabla_rk_atentado2.Rows[iteracion]["K4-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k4 * 1000) / 1000;
                                tabla_rk_atentado2.Rows[iteracion]["t1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(x1 * 1000) / 1000;
                                tabla_rk_atentado2.Rows[iteracion]["A1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(y1 * 1000) / 1000;
                                iteracion += 1;
                            }
                            else if(cantidad_iteraciones_rk_atentado <= 3 * maximo)
                            {
                                if (iteracion >= tabla_rk_atentado3.Rows.Count)
                                {
                                    tabla_rk_atentado3.Rows.Add();
                                }

                                tabla_rk_atentado3.Rows[iteracion]["t-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(x0 * 1000) / 1000;
                                tabla_rk_atentado3.Rows[iteracion]["A-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(y0 * 1000) / 1000;
                                tabla_rk_atentado3.Rows[iteracion]["β-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(rnd_beta * 1000) / 1000;
                                tabla_rk_atentado3.Rows[iteracion]["K1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k1 * 1000) / 1000;
                                tabla_rk_atentado3.Rows[iteracion]["K2-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k2 * 1000) / 1000;
                                tabla_rk_atentado3.Rows[iteracion]["K3-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k3 * 1000) / 1000;
                                tabla_rk_atentado3.Rows[iteracion]["K4-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k4 * 1000) / 1000;
                                tabla_rk_atentado3.Rows[iteracion]["t1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(x1 * 1000) / 1000;
                                tabla_rk_atentado3.Rows[iteracion]["A1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(y1 * 1000) / 1000;
                                iteracion += 1;
                            }
                            
                        }
                    }
                    else
                    {
                        if (reloj >= simulacion_desde && cantidad_a_mostrar < 400)
                        {
                            if (cantidad_iteraciones_rk_atentado <= maximo)
                            {
                                if (iteracion >= tabla_rk_atentado.Rows.Count)
                                {
                                    tabla_rk_atentado.Rows.Add();
                                }

                                tabla_rk_atentado.Rows[iteracion]["t-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(x0 * 1000) / 1000;
                                tabla_rk_atentado.Rows[iteracion]["A-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(y0 * 1000) / 1000;
                                tabla_rk_atentado.Rows[iteracion]["β-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(rnd_beta * 1000) / 1000;
                                tabla_rk_atentado.Rows[iteracion]["K1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k1 * 1000) / 1000;
                                tabla_rk_atentado.Rows[iteracion]["K2-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k2 * 1000) / 1000;
                                tabla_rk_atentado.Rows[iteracion]["K3-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k3 * 1000) / 1000;
                                tabla_rk_atentado.Rows[iteracion]["K4-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k4 * 1000) / 1000;
                                tabla_rk_atentado.Rows[iteracion]["t1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(x1 * 1000) / 1000;
                                tabla_rk_atentado.Rows[iteracion]["A1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(y1 * 1000) / 1000;
                                iteracion += 1;
                            }
                            else if (cantidad_iteraciones_rk_atentado <= 2 * maximo)
                            {
                                if (iteracion >= tabla_rk_atentado2.Rows.Count)
                                {
                                    tabla_rk_atentado2.Rows.Add();
                                }

                                tabla_rk_atentado2.Rows[iteracion]["t-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(x0 * 1000) / 1000;
                                tabla_rk_atentado2.Rows[iteracion]["A-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(y0 * 1000) / 1000;
                                tabla_rk_atentado2.Rows[iteracion]["β-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(rnd_beta * 1000) / 1000;
                                tabla_rk_atentado2.Rows[iteracion]["K1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k1 * 1000) / 1000;
                                tabla_rk_atentado2.Rows[iteracion]["K2-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k2 * 1000) / 1000;
                                tabla_rk_atentado2.Rows[iteracion]["K3-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k3 * 1000) / 1000;
                                tabla_rk_atentado2.Rows[iteracion]["K4-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k4 * 1000) / 1000;
                                tabla_rk_atentado2.Rows[iteracion]["t1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(x1 * 1000) / 1000;
                                tabla_rk_atentado2.Rows[iteracion]["A1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(y1 * 1000) / 1000;
                                iteracion += 1;
                            }
                            else if (cantidad_iteraciones_rk_atentado <= 3 * maximo)
                            {
                                if (iteracion >= tabla_rk_atentado3.Rows.Count)
                                {
                                    tabla_rk_atentado3.Rows.Add();
                                }

                                tabla_rk_atentado3.Rows[iteracion]["t-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(x0 * 1000) / 1000;
                                tabla_rk_atentado3.Rows[iteracion]["A-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(y0 * 1000) / 1000;
                                tabla_rk_atentado3.Rows[iteracion]["β-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(rnd_beta * 1000) / 1000;
                                tabla_rk_atentado3.Rows[iteracion]["K1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k1 * 1000) / 1000;
                                tabla_rk_atentado3.Rows[iteracion]["K2-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k2 * 1000) / 1000;
                                tabla_rk_atentado3.Rows[iteracion]["K3-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k3 * 1000) / 1000;
                                tabla_rk_atentado3.Rows[iteracion]["K4-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(k4 * 1000) / 1000;
                                tabla_rk_atentado3.Rows[iteracion]["t1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(x1 * 1000) / 1000;
                                tabla_rk_atentado3.Rows[iteracion]["A1-" + cantidad_iteraciones_rk_atentado.ToString()] = Math.Truncate(y1 * 1000) / 1000;
                                iteracion += 1;
                            }
                        }
                    }
                }
                while (y1 <= inicial);
                cantidad_iteraciones_rk_atentado += 1;
                return (x1 * 9);
            }

            else if (atentado_llegada_o_servicio == 1)
            {
                if (parametro_cantidad == "eventos")
                {
                    
                    if (cantidad_iteraciones >= simulacion_desde && cantidad_iteraciones < simulacion_desde + 400)
                    {
                        if (cantidad_iteraciones_rk_bloqueo_ingreso <= maximo)
                        {
                            cargarTablaRKBloqueoIngreso(cantidad_iteraciones_rk_bloqueo_ingreso);
                        }
                        else if (cantidad_iteraciones_rk_bloqueo_ingreso <= 2 * maximo)
                        {
                            cargarTablaRKBloqueoIngreso2(cantidad_iteraciones_rk_bloqueo_ingreso);
                        }
                    }
                }
                else
                {
                    if (reloj >= simulacion_desde && cantidad_a_mostrar < 400)
                    {
                        if (cantidad_iteraciones_rk_bloqueo_ingreso <= maximo)
                        {
                            cargarTablaRKBloqueoIngreso(cantidad_iteraciones_rk_bloqueo_ingreso);
                        }
                        else if (cantidad_iteraciones_rk_bloqueo_ingreso <= 2 * maximo)
                        {
                            cargarTablaRKBloqueoIngreso2(cantidad_iteraciones_rk_bloqueo_ingreso);
                        }
                    }
                }
                

                bool flag_primera = false;
                do
                {
                    
                    if (!flag_primera)
                    {
                        flag_primera = true;
                    }
                    else
                    {
                        x0 = x1;
                        y0 = y1;
                    }

                    // L = y0 - T = x0
                    k1 = -((y0 / 0.8) * (x0 * x0)) - y0;
                    k2 = -(((y0 + (h_2 * k1)) / 0.8) * ((x0 + h_2) * (x0 + h_2))) - (y0 + (h_2 * k1));
                    k3 = -(((y0 + (h_2 * k2)) / 0.8) * ((x0 + h_2) * (x0 + h_2))) - (y0 + (h_2 * k2));
                    k4 = -(((y0 + (h * k3)) / 0.8) * ((x0 + h) * (x0 + h))) - (y0 + (h * k3));

                    x1 = x0 + h;
                    y1 = y0 + (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4);

                    if (parametro_cantidad == "eventos")
                    {
                        if (cantidad_iteraciones >= simulacion_desde && cantidad_iteraciones < simulacion_desde + 400)
                        {
                            if (cantidad_iteraciones_rk_bloqueo_ingreso <= maximo)
                            {
                                if (iteracion >= tabla_rk_bloqueo_ingreso.Rows.Count)
                                {
                                    tabla_rk_bloqueo_ingreso.Rows.Add();
                                }
                                tabla_rk_bloqueo_ingreso.Rows[iteracion]["t-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = x0;
                                tabla_rk_bloqueo_ingreso.Rows[iteracion]["L-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = y0;
                                tabla_rk_bloqueo_ingreso.Rows[iteracion]["K1-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = k1;
                                tabla_rk_bloqueo_ingreso.Rows[iteracion]["K2-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = k2;
                                tabla_rk_bloqueo_ingreso.Rows[iteracion]["K3-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = k3;
                                tabla_rk_bloqueo_ingreso.Rows[iteracion]["K4-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = k4;
                                tabla_rk_bloqueo_ingreso.Rows[iteracion]["t1-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = x1;
                                tabla_rk_bloqueo_ingreso.Rows[iteracion]["L1-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = y1;
                                iteracion += 1;
                            }
                            else if (cantidad_iteraciones_rk_bloqueo_ingreso <= 2 * maximo)
                            {
                                if (iteracion >= tabla_rk_bloqueo_ingreso2.Rows.Count)
                                {
                                    tabla_rk_bloqueo_ingreso2.Rows.Add();
                                }
                                tabla_rk_bloqueo_ingreso2.Rows[iteracion]["t-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = x0;
                                tabla_rk_bloqueo_ingreso2.Rows[iteracion]["L-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = y0;
                                tabla_rk_bloqueo_ingreso2.Rows[iteracion]["K1-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = k1;
                                tabla_rk_bloqueo_ingreso2.Rows[iteracion]["K2-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = k2;
                                tabla_rk_bloqueo_ingreso2.Rows[iteracion]["K3-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = k3;
                                tabla_rk_bloqueo_ingreso2.Rows[iteracion]["K4-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = k4;
                                tabla_rk_bloqueo_ingreso2.Rows[iteracion]["t1-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = x1;
                                tabla_rk_bloqueo_ingreso2.Rows[iteracion]["L1-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = y1;
                                iteracion += 1;
                            }

                        }
                    }
                    else
                    {
                        if (reloj >= simulacion_desde && cantidad_a_mostrar < 400)
                        {
                            if (cantidad_iteraciones_rk_bloqueo_ingreso <= maximo)
                            {
                                if (iteracion >= tabla_rk_bloqueo_ingreso.Rows.Count)
                                {
                                    tabla_rk_bloqueo_ingreso.Rows.Add();
                                }
                                tabla_rk_bloqueo_ingreso.Rows[iteracion]["t-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = x0;
                                tabla_rk_bloqueo_ingreso.Rows[iteracion]["L-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = y0;
                                tabla_rk_bloqueo_ingreso.Rows[iteracion]["K1-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = k1;
                                tabla_rk_bloqueo_ingreso.Rows[iteracion]["K2-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = k2;
                                tabla_rk_bloqueo_ingreso.Rows[iteracion]["K3-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = k3;
                                tabla_rk_bloqueo_ingreso.Rows[iteracion]["K4-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = k4;
                                tabla_rk_bloqueo_ingreso.Rows[iteracion]["t1-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = x1;
                                tabla_rk_bloqueo_ingreso.Rows[iteracion]["L1-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = y1;
                                iteracion += 1;
                            }
                            else if (cantidad_iteraciones_rk_bloqueo_ingreso <= 2 * maximo)
                            {
                                if (iteracion >= tabla_rk_bloqueo_ingreso2.Rows.Count)
                                {
                                    tabla_rk_bloqueo_ingreso2.Rows.Add();
                                }
                                tabla_rk_bloqueo_ingreso2.Rows[iteracion]["t-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = x0;
                                tabla_rk_bloqueo_ingreso2.Rows[iteracion]["L-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = y0;
                                tabla_rk_bloqueo_ingreso2.Rows[iteracion]["K1-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = k1;
                                tabla_rk_bloqueo_ingreso2.Rows[iteracion]["K2-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = k2;
                                tabla_rk_bloqueo_ingreso2.Rows[iteracion]["K3-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = k3;
                                tabla_rk_bloqueo_ingreso2.Rows[iteracion]["K4-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = k4;
                                tabla_rk_bloqueo_ingreso2.Rows[iteracion]["t1-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = x1;
                                tabla_rk_bloqueo_ingreso2.Rows[iteracion]["L1-" + cantidad_iteraciones_rk_bloqueo_ingreso.ToString()] = y1;
                                iteracion += 1;
                            }
                        }
                    }

                    
                }
                while (Math.Abs(y0 - y1) > 1);
                cantidad_iteraciones_rk_bloqueo_ingreso += 1;
                return (x1 * 5);
            }

            else
            {
                if (parametro_cantidad == "eventos")
                {
                    if (cantidad_iteraciones >= simulacion_desde && cantidad_iteraciones < simulacion_desde + 400)
                    {
                        if(cantidad_iteraciones_rk_bloqueo_servicio <= maximo)
                        {
                            cargarTablaRKBloqueoCaseta(cantidad_iteraciones_rk_bloqueo_servicio);
                        }
                        else if(cantidad_iteraciones_rk_bloqueo_servicio <= 2 * maximo)
                        {
                            cargarTablaRKBloqueoCaseta2(cantidad_iteraciones_rk_bloqueo_servicio);
                        }
                        
                    }
                }
                else
                {
                    if (reloj >= simulacion_desde && cantidad_a_mostrar < 400)
                    {
                        if (cantidad_iteraciones_rk_bloqueo_servicio <= maximo)
                        {
                            cargarTablaRKBloqueoCaseta(cantidad_iteraciones_rk_bloqueo_servicio);
                        }
                        else if (cantidad_iteraciones_rk_bloqueo_servicio <= 2 * maximo)
                        {
                            cargarTablaRKBloqueoCaseta2(cantidad_iteraciones_rk_bloqueo_servicio);
                        }
                    }
                }

                double inicial = reloj * 1.35;
                bool flag_primera = false;
                do
                {
                    if (!flag_primera)
                    {
                        flag_primera = true;
                    }
                    else
                    {
                        x0 = x1;
                        y0 = y1;
                    }

                    // S = y0 - T = x0
                    k1 = (y0 * 0.2) + 3 - x0;
                    k2 = ((y0 + (h_2 * k1)) * 0.2) + 3 - (x0 + h_2);
                    k3 = ((y0 + (h_2 * k2)) * 0.2) + 3 - (x0 + h_2);
                    k4 = ((y0 + (h * k3)) * 0.2) + 3 - (x0 + h);

                    x1 = x0 + h;
                    y1 = y0 + (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4);

                    if (parametro_cantidad == "eventos")
                    {
                        if (cantidad_iteraciones >= simulacion_desde && cantidad_iteraciones < simulacion_desde + 400)
                        {
                            if(cantidad_iteraciones_rk_bloqueo_servicio <= maximo)
                            {
                                if (iteracion >= tabla_rk_bloqueo_servicio.Rows.Count)
                                {
                                    tabla_rk_bloqueo_servicio.Rows.Add();
                                }

                                tabla_rk_bloqueo_servicio.Rows[iteracion]["t-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = x0;
                                tabla_rk_bloqueo_servicio.Rows[iteracion]["S-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = y0;
                                tabla_rk_bloqueo_servicio.Rows[iteracion]["K1-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = k1;
                                tabla_rk_bloqueo_servicio.Rows[iteracion]["K2-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = k2;
                                tabla_rk_bloqueo_servicio.Rows[iteracion]["K3-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = k3;
                                tabla_rk_bloqueo_servicio.Rows[iteracion]["K4-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = k4;
                                tabla_rk_bloqueo_servicio.Rows[iteracion]["t1-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = x1;
                                tabla_rk_bloqueo_servicio.Rows[iteracion]["S1-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = y1;
                                iteracion += 1;
                            }
                            else if(cantidad_iteraciones_rk_bloqueo_servicio <= 2 * maximo)
                            {
                                if (iteracion >= tabla_rk_bloqueo_servicio2.Rows.Count)
                                {
                                    tabla_rk_bloqueo_servicio2.Rows.Add();
                                }

                                tabla_rk_bloqueo_servicio2.Rows[iteracion]["t-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = x0;
                                tabla_rk_bloqueo_servicio2.Rows[iteracion]["S-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = y0;
                                tabla_rk_bloqueo_servicio2.Rows[iteracion]["K1-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = k1;
                                tabla_rk_bloqueo_servicio2.Rows[iteracion]["K2-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = k2;
                                tabla_rk_bloqueo_servicio2.Rows[iteracion]["K3-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = k3;
                                tabla_rk_bloqueo_servicio2.Rows[iteracion]["K4-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = k4;
                                tabla_rk_bloqueo_servicio2.Rows[iteracion]["t1-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = x1;
                                tabla_rk_bloqueo_servicio2.Rows[iteracion]["S1-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = y1;
                                iteracion += 1;
                            }
                        }
                    }
                    else
                    {
                        if (reloj >= simulacion_desde && cantidad_a_mostrar < 400)
                        {
                            if (cantidad_iteraciones_rk_bloqueo_servicio <= maximo)
                            {
                                if (iteracion >= tabla_rk_bloqueo_servicio.Rows.Count)
                                {
                                    tabla_rk_bloqueo_servicio.Rows.Add();
                                }

                                tabla_rk_bloqueo_servicio.Rows[iteracion]["t-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = x0;
                                tabla_rk_bloqueo_servicio.Rows[iteracion]["S-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = y0;
                                tabla_rk_bloqueo_servicio.Rows[iteracion]["K1-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = k1;
                                tabla_rk_bloqueo_servicio.Rows[iteracion]["K2-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = k2;
                                tabla_rk_bloqueo_servicio.Rows[iteracion]["K3-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = k3;
                                tabla_rk_bloqueo_servicio.Rows[iteracion]["K4-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = k4;
                                tabla_rk_bloqueo_servicio.Rows[iteracion]["t1-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = x1;
                                tabla_rk_bloqueo_servicio.Rows[iteracion]["S1-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = y1;
                                iteracion += 1;
                            }
                            else if (cantidad_iteraciones_rk_bloqueo_servicio <= 2 * maximo)
                            {
                                if (iteracion >= tabla_rk_bloqueo_servicio2.Rows.Count)
                                {
                                    tabla_rk_bloqueo_servicio2.Rows.Add();
                                }

                                tabla_rk_bloqueo_servicio2.Rows[iteracion]["t-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = x0;
                                tabla_rk_bloqueo_servicio2.Rows[iteracion]["S-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = y0;
                                tabla_rk_bloqueo_servicio2.Rows[iteracion]["K1-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = k1;
                                tabla_rk_bloqueo_servicio2.Rows[iteracion]["K2-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = k2;
                                tabla_rk_bloqueo_servicio2.Rows[iteracion]["K3-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = k3;
                                tabla_rk_bloqueo_servicio2.Rows[iteracion]["K4-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = k4;
                                tabla_rk_bloqueo_servicio2.Rows[iteracion]["t1-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = x1;
                                tabla_rk_bloqueo_servicio2.Rows[iteracion]["S1-" + cantidad_iteraciones_rk_bloqueo_servicio.ToString()] = y1;
                                iteracion += 1;
                            }
                        }
                    }

                    
                }
                while (y1 < inicial);
                cantidad_iteraciones_rk_bloqueo_servicio += 1;
                return (x1 * 2);
            }

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
                double temp_fin_atencion_caseta = caseta.GetFinAtencion();
                
                if (temp_fin_atencion_caseta != 0.0 && temp_fin_atencion_caseta < temp_menor_caseta.GetFinAtencion())
                {
                    temp_menor_caseta = caseta;
                }
            }

            foreach (servidor nave in lista_naves)
            {
                double temp_fin_atencion_nave = nave.GetFinAtencion();

                if (temp_fin_atencion_nave != 0.0 && temp_fin_atencion_nave < temp_menor_nave.GetFinAtencion())
                {
                    temp_menor_nave = nave;
                }
            }

            foreach (servidor oficina in lista_oficinas)
            {
                double temp_fin_atencion_nave = oficina.GetFinAtencion();

                if (temp_fin_atencion_nave != 0.0 && temp_fin_atencion_nave < temp_menor_oficina.GetFinAtencion())
                {
                    temp_menor_oficina = oficina;
                }
            }

            if ((tiempo_proxima_llegada <= temp_menor_caseta.GetFinAtencion() || temp_menor_caseta.GetFinAtencion() == 0.0) &&
                (tiempo_proxima_llegada <= temp_menor_nave.GetFinAtencion() || temp_menor_nave.GetFinAtencion() == 0.0) &&
                (tiempo_proxima_llegada <= temp_menor_oficina.GetFinAtencion() || temp_menor_oficina.GetFinAtencion() == 0.0) &&
                (tiempo_proxima_llegada <= tiempo_fin_bloqueo_ingreso || tiempo_fin_bloqueo_ingreso == 0.0) &&
                (tiempo_proxima_llegada <= tiempo_proximo_bloqueo || tiempo_proximo_bloqueo == 0.0) &&
                (tiempo_proxima_llegada <= tiempo_fin_bloqueo_servicio || tiempo_fin_bloqueo_servicio == 0.0))
            {
                reloj = tiempo_proxima_llegada;
                tipo_menor_tiempo = 0;
                return null;
            }

            else if ((temp_menor_caseta.GetFinAtencion() != 0.0) &&
                (temp_menor_caseta.GetFinAtencion() <= temp_menor_nave.GetFinAtencion() || temp_menor_nave.GetFinAtencion() == 0.0) &&
                (temp_menor_caseta.GetFinAtencion() <= temp_menor_oficina.GetFinAtencion() || temp_menor_oficina.GetFinAtencion() == 0.0) &&
                (temp_menor_caseta.GetFinAtencion() <= tiempo_proximo_bloqueo || tiempo_proximo_bloqueo == 0.0) &&
                (temp_menor_caseta.GetFinAtencion() <= tiempo_fin_bloqueo_ingreso || tiempo_fin_bloqueo_ingreso == 0.0) &&
                (temp_menor_caseta.GetFinAtencion() <= tiempo_fin_bloqueo_servicio || tiempo_fin_bloqueo_servicio == 0.0))
            {
                reloj = temp_menor_caseta.GetFinAtencion();
                return temp_menor_caseta;
            }

            else if ((temp_menor_nave.GetFinAtencion() != 0.0) &&
                (temp_menor_nave.GetFinAtencion() <= temp_menor_oficina.GetFinAtencion() || temp_menor_oficina.GetFinAtencion() == 0.0) &&
                (temp_menor_nave.GetFinAtencion() <= tiempo_proximo_bloqueo || tiempo_proximo_bloqueo == 0.0) &&
                (temp_menor_nave.GetFinAtencion() <= tiempo_fin_bloqueo_ingreso || tiempo_fin_bloqueo_ingreso == 0.0) &&
                (temp_menor_nave.GetFinAtencion() <= tiempo_fin_bloqueo_servicio || tiempo_fin_bloqueo_servicio == 0.0))
            {
                reloj = temp_menor_nave.GetFinAtencion();
                return temp_menor_nave;
            }

            else if ((temp_menor_oficina.GetFinAtencion() != 0.0) &&
                (temp_menor_oficina.GetFinAtencion() <= tiempo_proximo_bloqueo || tiempo_proximo_bloqueo == 0.0) &&
                (temp_menor_oficina.GetFinAtencion() <= tiempo_fin_bloqueo_ingreso || tiempo_fin_bloqueo_ingreso == 0.0) &&
                (temp_menor_oficina.GetFinAtencion() <= tiempo_fin_bloqueo_servicio || tiempo_fin_bloqueo_servicio == 0.0))
            {
                reloj = temp_menor_oficina.GetFinAtencion();
                return temp_menor_oficina;
            }

            else if ((tiempo_proximo_bloqueo != 0.0) &&
                (tiempo_proximo_bloqueo <= tiempo_fin_bloqueo_ingreso || tiempo_fin_bloqueo_ingreso == 0.0) &&
                (tiempo_proximo_bloqueo <= tiempo_fin_bloqueo_servicio || tiempo_fin_bloqueo_servicio == 0.0))
            {
                reloj = tiempo_proximo_bloqueo;
                tipo_menor_tiempo = 1;
                return null;
            }

            else if ((tiempo_fin_bloqueo_ingreso != 0.0) &&
                (tiempo_fin_bloqueo_ingreso <= tiempo_fin_bloqueo_servicio || tiempo_fin_bloqueo_servicio == 0.0))
            {
                reloj = tiempo_fin_bloqueo_ingreso;
                tipo_menor_tiempo = 2;
                return null;
            }

            else if (tiempo_fin_bloqueo_servicio != 0.0)
            {
                reloj = tiempo_fin_bloqueo_servicio;
                tipo_menor_tiempo = 3;
                return null;
            }

            else
            {
                return null;
            }

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
                if (reloj > cantidad)
                {
                    reloj = cantidad;
                    Evento_lanzado = "Fin de simulación";
                }
                else
                {

                    if (servidor_menor_tiempo == null)
                    {
                        if (tipo_menor_tiempo == 0)
                        {
                            Evento_lanzado = "LLegada de un auto";

                            EventoDeLlegada();
                            if ((cantidad_clientes_que_se_van_por_cola_llena + cantidad_clientes_ingresan_al_sistema) == 80)
                            {
                                A = reloj;
                                calcularProximoAtentado();
                            }
                            calcularProximaLlegada();
                            Metrica8();

                        }
                        else if (tipo_menor_tiempo == 1)
                        {
                            Evento_lanzado = "Atentado";
                            EventoAtentado();
                            calcularProximoAtentado();
                        }
                        else if (tipo_menor_tiempo == 2)
                        {
                            Evento_lanzado = "Fin bloqueo de ingreso";
                            EventoFinBloqueoLlegadas();
                        }
                        else if (tipo_menor_tiempo == 3)
                        {
                            Evento_lanzado = "Fin bloqueo de servicio";
                            EventoFinBloqueoServicio();
                        }

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
                foreach (servidor i_caseta in lista_casetas)
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

                if (tiempo_entre_bloqueos_ingreso.ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Tiempo entre bloqueos de llegadas"].ToString())
                {
                    tiempo_entre_bloqueos_ingreso = 0;
                }
                
                if (tiempo_entre_bloqueos_servicio.ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Tiempo entre bloqueos de caseta"].ToString())
                {
                    tiempo_entre_bloqueos_servicio = 0;
                }
                
                if (rnd_atentado_tipo.ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["RND atentados"].ToString())
                {
                    rnd_atentado_tipo = 0;
                }

                if (tipo_de_atentado == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Tipo de atentado"].ToString())
                {
                    tipo_de_atentado = "";
                }

                if (rnd_beta.ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Beta"].ToString())
                {
                    rnd_beta = 0;
                }

                if (tiempo_entre_bloqueos.ToString() == tabla_iteraciones.Rows[cantidad_iteraciones - 1]["Tiempo entre atentados"].ToString())
                {
                    tiempo_entre_bloqueos = 0;
                }



            }

            tabla_iteraciones.Rows[cantidad_iteraciones]["RND llegada cliente"] = rnd_llegadas.ToString() == "0" ? "" : rnd_llegadas.ToString();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo entre llegadas"] = tiempo_entre_llegadas.ToString() == "0" ? "" : tiempo_entre_llegadas.ToString();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Proxima llegada"] = tiempo_proxima_llegada.ToString() == "0" ? "" : tiempo_proxima_llegada.ToString();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Cantidad de llegadas"] = (cantidad_clientes_ingresan_al_sistema + cantidad_clientes_que_se_van_por_cola_llena + cantidad_clientes_que_se_van_por_bloqueo).ToString();


            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo entre bloqueos de llegadas"] = tiempo_entre_bloqueos_ingreso.ToString() == "0" ? "" : tiempo_entre_bloqueos_ingreso.ToString();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Fin bloqueo de llegadas"] = tiempo_fin_bloqueo_ingreso.ToString() == "0" ? "" : tiempo_fin_bloqueo_ingreso.ToString();


            tabla_iteraciones.Rows[cantidad_iteraciones]["RND atencion caseta"] = rnd_atencion_caseta.ToString() == "0" ? "" : rnd_atencion_caseta.ToString();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo atencion caseta"] = tiempo_atencion_caseta.ToString() == "0" ? "" : tiempo_atencion_caseta.ToString();
            int temp_iteracion_c = 0;
            foreach (servidor i_caseta in lista_casetas)
            {
                temp_iteracion_c += 1;
                tabla_iteraciones.Rows[cantidad_iteraciones]["Fin atencion caseta " + temp_iteracion_c.ToString()] = i_caseta.GetFinAtencion().ToString() == "0" ? "" : i_caseta.GetFinAtencion().ToString();
                tabla_iteraciones.Rows[cantidad_iteraciones]["Estado caseta " + temp_iteracion_c.ToString()] = i_caseta.GetEstado();
                tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo remanente de atencion caseta " + temp_iteracion_c.ToString()] = i_caseta.GetTiempoRemanenteAtencion().ToString() == "0" ? "" : i_caseta.GetTiempoRemanenteAtencion().ToString();

            }

            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo entre bloqueos de caseta"] = tiempo_entre_bloqueos_servicio.ToString() == "0" ? "" : tiempo_entre_bloqueos_servicio.ToString();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Fin bloqueo de caseta"] = tiempo_fin_bloqueo_servicio.ToString() == "0" ? "" : tiempo_fin_bloqueo_servicio.ToString();

            tabla_iteraciones.Rows[cantidad_iteraciones]["RND atentados"] = rnd_atentado_tipo.ToString() == "0" ? "" : rnd_atentado_tipo.ToString();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tipo de atentado"] = tipo_de_atentado == "" ? "" : tipo_de_atentado;
            tabla_iteraciones.Rows[cantidad_iteraciones]["Beta"] = rnd_beta.ToString() == "0" ? "" : rnd_beta.ToString();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Tiempo entre atentados"] = tiempo_entre_bloqueos.ToString() == "0" ? "" : tiempo_entre_bloqueos.ToString();
            tabla_iteraciones.Rows[cantidad_iteraciones]["Proximo atentado"] = tiempo_proximo_bloqueo.ToString() == "0" ? "" : tiempo_proximo_bloqueo.ToString();

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
                    if (estado_cliente == 0) { estado_cliente_string = "EAC"; }
                    else if (estado_cliente == 1) { estado_cliente_string = "SAC"; }
                    else if (estado_cliente == 2) { estado_cliente_string = "EAN"; }
                    else if (estado_cliente == 3) { estado_cliente_string = "SAN"; }
                    else if (estado_cliente == 4) { estado_cliente_string = "EAO"; }
                    else if (estado_cliente == 5) { estado_cliente_string = "SAO"; }
                    else if (estado_cliente == 6) { estado_cliente_string = "SLCC"; }
                    else if (estado_cliente == 7) { estado_cliente_string = "FDS"; }
                    else if (estado_cliente == 8) { estado_cliente_string = "ERA"; }
                    else { estado_cliente_string = "IB"; }
                    

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
            objeto_rnd_atentados_tipo = new Random(objeto_semilla.Next());
            objeto_rnd_atentados_beta = new Random(objeto_semilla.Next());

            if(txt_h.Text == "" || !double.TryParse(txt_h.Text, out h) || h < 0.01)
            {
                MessageBox.Show("Ingrese el paso de integracion (h) mayor o igual a 0.01", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //pregunto si el programa ya se ejecuto
            if (flag_tabla_cargada)
            {
                //desligo la tabla del data source
                dg_colas.DataSource = null;
                dg_atentados.DataSource = null;
                dg_atentados2.DataSource = null;
                dg_bloqueo_llegadas.DataSource = null;
                dg_bloqueo_servidor.DataSource = null;
                //limpiar las filas
                tabla_iteraciones.Rows.Clear();
                tabla_rk_atentado.Rows.Clear();
                tabla_rk_atentado2.Rows.Clear();
                tabla_rk_atentado3.Rows.Clear();
                tabla_rk_bloqueo_ingreso.Rows.Clear();
                tabla_rk_bloqueo_ingreso2.Rows.Clear();
                tabla_rk_bloqueo_servicio.Rows.Clear();
                tabla_rk_bloqueo_servicio2.Rows.Clear();
                tabla_rk_atentado.Columns.Clear();
                tabla_rk_atentado2.Columns.Clear();
                tabla_rk_atentado3.Columns.Clear();
                tabla_rk_bloqueo_ingreso.Columns.Clear();
                tabla_rk_bloqueo_ingreso2.Columns.Clear();
                tabla_rk_bloqueo_servicio.Columns.Clear();
                tabla_rk_bloqueo_servicio2.Columns.Clear();

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

            dg_colas.DataSource = tabla_iteraciones;
            dg_atentados.DataSource = tabla_rk_atentado;
            dg_atentados2.DataSource = tabla_rk_atentado2;
            dg_atentados3.DataSource = tabla_rk_atentado3;
            dg_bloqueo_llegadas.DataSource = tabla_rk_bloqueo_ingreso;
            dg_bloqueo_llegadas2.DataSource = tabla_rk_bloqueo_ingreso2;
            dg_bloqueo_servidor.DataSource = tabla_rk_bloqueo_servicio;
            dg_bloqueo_servidor2.DataSource = tabla_rk_bloqueo_servicio2;

            ModificarColumnas();

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
            dg_colas.Columns["Proxima llegada"].DefaultCellStyle.BackColor = Color.LightSkyBlue;

            for (int i = 0; i < cantidad_de_casetas; i++)
            {
                dg_colas.Columns["Fin atencion caseta " + (i + 1).ToString()].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            }

            for (int i = 0; i < cantidad_de_naves; i++)
            {
                dg_colas.Columns["Fin atencion nave " + (i + 1).ToString()].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            }

            for (int i = 0; i < cantidad_de_oficinas; i++)
            {
                dg_colas.Columns["Fin atencion oficina " + (i + 1).ToString()].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            }

            //metrica 1
            dg_colas.Columns["Tiempo de permanencia en cola de la nave"].DefaultCellStyle.BackColor = Color.LightSeaGreen;
            dg_colas.Columns["Longitud media de la cola de la nave"].DefaultCellStyle.BackColor = Color.LightSeaGreen;

            //metrica 2
            dg_colas.Columns["Tiempo de permanencia en la caseta"].DefaultCellStyle.BackColor = Color.DarkGray;
            dg_colas.Columns["Cantidad clientes con atencion caseta finalizada"].DefaultCellStyle.BackColor = Color.DarkGray;
            dg_colas.Columns["Tiempo medio del cliente en la caseta"].DefaultCellStyle.BackColor = Color.DarkGray;

            //metrica 3
            dg_colas.Columns["Tiempo de permanencia en la nave"].DefaultCellStyle.BackColor = Color.LightSeaGreen;
            dg_colas.Columns["Cantidad clientes con atencion nave finalizada"].DefaultCellStyle.BackColor = Color.LightSeaGreen;
            dg_colas.Columns["Tiempo medio del cliente en la nave"].DefaultCellStyle.BackColor = Color.LightSeaGreen;

            //metrica 4
            dg_colas.Columns["Tiempo de permanencia en la oficina"].DefaultCellStyle.BackColor = Color.DarkGray;
            dg_colas.Columns["Cantidad clientes con atencion oficina finalizada"].DefaultCellStyle.BackColor = Color.DarkGray;
            dg_colas.Columns["Tiempo medio del cliente en la oficina"].DefaultCellStyle.BackColor = Color.DarkGray;

            //metrica 5
            dg_colas.Columns["Tiempo de permanencia en el sistema"].DefaultCellStyle.BackColor = Color.LightSeaGreen;
            dg_colas.Columns["Tiempo medio del cliente en el ITV"].DefaultCellStyle.BackColor = Color.LightSeaGreen;

            //metrica 6
            dg_colas.Columns["Tiempo de permanencia en la cola de la caseta"].DefaultCellStyle.BackColor = Color.DarkGray;
            dg_colas.Columns["Tiempo medio del cliente en la cola de la caseta"].DefaultCellStyle.BackColor = Color.DarkGray;

            //metrica 7
            dg_colas.Columns["Tiempo de permanencia en la cola de la nave"].DefaultCellStyle.BackColor = Color.LightSeaGreen;
            dg_colas.Columns["Tiempo medio del cliente en la cola de nave"].DefaultCellStyle.BackColor = Color.LightSeaGreen;

            //metrica 8
            dg_colas.Columns["Maximo tiempo entre llegadas"].DefaultCellStyle.BackColor = Color.DarkGray;

            //metrica 9
            dg_colas.Columns["Cantidad de clientes que no entran a la cola porque esta llena"].DefaultCellStyle.BackColor = Color.LightSeaGreen;

            //tamaños
            int comienzo_de_metricas = dg_colas.Columns["Tiempo de permanencia en cola de la nave"].Index;
            int ultima_metrica = comienzo_de_metricas + 19;
            dg_colas.Columns[0].Width = 160;
            for (int i = 1; i <= comienzo_de_metricas; i++)
            {
                dg_colas.Columns[i].Width = 60;
            }
            for (int i = comienzo_de_metricas; i < ultima_metrica; i++)
            {
                dg_colas.Columns[i].Width = 100;
            }

            dg_colas.Columns["Fin bloqueo de llegadas"].DefaultCellStyle.BackColor = Color.IndianRed;
            dg_colas.Columns["Fin bloqueo de caseta"].DefaultCellStyle.BackColor = Color.IndianRed;
            dg_colas.Columns["Tipo de atentado"].DefaultCellStyle.BackColor = Color.IndianRed;
            dg_colas.Columns["Proximo atentado"].DefaultCellStyle.BackColor = Color.IndianRed;

            int h = 0;
            int j = 0;
            for (int i = 0; i < (dg_atentados.Columns.Count/9); i++)
            {
                if(i%2 == 0)
                {
                    for (; j < 9+h; j++)
                    {
                        dg_atentados.Columns[j+h].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                    h += 9;
                }
            }
            h = 0;
            j = 0;
            for (int i = 0; i < (dg_atentados2.Columns.Count / 9); i++)
            {
                if (i % 2 == 0)
                {
                    for (; j < 9 + h; j++)
                    {
                        dg_atentados2.Columns[j + h].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                    h += 9;
                }
            }
            h = 0;
            j = 0;
            for (int i = 0; i < (dg_atentados3.Columns.Count / 9); i++)
            {
                if (i % 2 == 0)
                {
                    for (; j < 9 + h; j++)
                    {
                        dg_atentados3.Columns[j + h].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                    h += 9;
                }
            }
            h = 0;
            j = 0;
            for (int i = 0; i < (dg_bloqueo_llegadas.Columns.Count/8); i++)
            {
                if (i % 2 == 0)
                {
                    for (; j < 8 + h; j++)
                    {
                        dg_bloqueo_llegadas.Columns[j + h].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                    h += 8;
                }
            }
            h = 0;
            j = 0;
            for (int i = 0; i < (dg_bloqueo_llegadas2.Columns.Count/8); i++)
            {
                if (i % 2 == 0)
                {
                    for (; j < 8 + h; j++)
                    {
                        dg_bloqueo_llegadas2.Columns[j + h].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                    h += 8;
                }
            }
            h = 0;
            j = 0;
            for (int i = 0; i < (dg_bloqueo_servidor.Columns.Count/8); i++)
            {
                if (i % 2 == 0)
                {
                    for (; j < 8 + h; j++)
                    {
                        dg_bloqueo_servidor.Columns[j + h].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                    h += 8;
                }
            }
            h = 0;
            j = 0;
            for (int i = 0; i < (dg_bloqueo_servidor2.Columns.Count/8); i++)
            {
                if (i % 2 == 0)
                {
                    for (; j < 8 + h; j++)
                    {
                        dg_bloqueo_servidor2.Columns[j + h].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                    h += 8;
                }
            }
        }

        private void cargarTabla()
        {
            DataColumn evento = new DataColumn("Evento");
            tabla_iteraciones.Columns.Add(evento);

            //asigno las columnas a la tabla
            DataColumn columna_reloj = new DataColumn("Reloj (min)");
            tabla_iteraciones.Columns.Add(columna_reloj);

            //Llegada cliente
            DataColumn columna_rnd_llegada = new DataColumn("RND llegada cliente");
            tabla_iteraciones.Columns.Add(columna_rnd_llegada);
            DataColumn columna_tiempo_entre_llegadas = new DataColumn("Tiempo entre llegadas");
            tabla_iteraciones.Columns.Add(columna_tiempo_entre_llegadas);
            DataColumn columna_proxima_llegada = new DataColumn("Proxima llegada");
            tabla_iteraciones.Columns.Add(columna_proxima_llegada);
            DataColumn columna_cantidad_llegadas = new DataColumn("Cantidad de llegadas");
            tabla_iteraciones.Columns.Add(columna_cantidad_llegadas);

            //Atencion caseta
            DataColumn columna_rnd_atencion_caseta = new DataColumn("RND atencion caseta");
            tabla_iteraciones.Columns.Add(columna_rnd_atencion_caseta);
            DataColumn columna_tiempo_atencion_caseta = new DataColumn("Tiempo atencion caseta");
            tabla_iteraciones.Columns.Add(columna_tiempo_atencion_caseta);

            for (int i = 0; i < cantidad_de_casetas; i++)
            {
                DataColumn columna_fin_atencion_caseta = new DataColumn("Fin atencion caseta " + (i + 1).ToString());
                tabla_iteraciones.Columns.Add(columna_fin_atencion_caseta);
                DataColumn columna_estado_caseta = new DataColumn("Estado caseta " + (i + 1).ToString());
                tabla_iteraciones.Columns.Add(columna_estado_caseta);
                DataColumn columna_tiempo_remanente_atencion = new DataColumn("Tiempo remanente de atencion caseta " + (i + 1).ToString());
                tabla_iteraciones.Columns.Add(columna_tiempo_remanente_atencion);
            }

            //Atentados
            DataColumn columna_beta = new DataColumn("Beta");
            tabla_iteraciones.Columns.Add(columna_beta);
            DataColumn columna_tiempo_entre_atentados = new DataColumn("Tiempo entre atentados");
            tabla_iteraciones.Columns.Add(columna_tiempo_entre_atentados);
            DataColumn columna_tiempo_proximo_atentado = new DataColumn("Proximo atentado");
            tabla_iteraciones.Columns.Add(columna_tiempo_proximo_atentado);
            DataColumn columna_rnd_atentados = new DataColumn("RND atentados");
            tabla_iteraciones.Columns.Add(columna_rnd_atentados);
            DataColumn columna_tipo_atentado = new DataColumn("Tipo de atentado");
            tabla_iteraciones.Columns.Add(columna_tipo_atentado);
            

            //Bloqueo llegadas
            DataColumn columna_tiempo_bloqueo_ingreso = new DataColumn("Tiempo entre bloqueos de llegadas");
            tabla_iteraciones.Columns.Add(columna_tiempo_bloqueo_ingreso);
            DataColumn columna_fin_bloqueo_ingreso = new DataColumn("Fin bloqueo de llegadas");
            tabla_iteraciones.Columns.Add(columna_fin_bloqueo_ingreso);

            //Bloqueo caseta
            DataColumn columna_tiempo_bloqueo_caseta = new DataColumn("Tiempo entre bloqueos de caseta");
            tabla_iteraciones.Columns.Add(columna_tiempo_bloqueo_caseta);
            DataColumn columna_fin_bloqueo_caseta = new DataColumn("Fin bloqueo de caseta");
            tabla_iteraciones.Columns.Add(columna_fin_bloqueo_caseta);

            //Atencion nave
            DataColumn columna_rnd_atencion_nave = new DataColumn("RND atencion nave");
            tabla_iteraciones.Columns.Add(columna_rnd_atencion_nave);
            DataColumn columna_tiempo_atencion_nave = new DataColumn("Tiempo atencion nave");
            tabla_iteraciones.Columns.Add(columna_tiempo_atencion_nave);

            for (int i = 0; i < cantidad_de_naves; i++)
            {
                DataColumn columna_fin_atencion_nave = new DataColumn("Fin atencion nave " + (i + 1).ToString());
                tabla_iteraciones.Columns.Add(columna_fin_atencion_nave);
                DataColumn columna_estado_nave = new DataColumn("Estado nave " + (i + 1).ToString());
                tabla_iteraciones.Columns.Add(columna_estado_nave);
            }


            //Atencion oficina
            DataColumn columna_rnd_atencion_oficina = new DataColumn("RND atencion oficina");
            tabla_iteraciones.Columns.Add(columna_rnd_atencion_oficina);
            DataColumn columna_tiempo_atencion_oficina = new DataColumn("Tiempo atencion oficina");
            tabla_iteraciones.Columns.Add(columna_tiempo_atencion_oficina);

            for (int i = 0; i < cantidad_de_oficinas; i++)
            {
                DataColumn columna_fin_atencion_oficina = new DataColumn("Fin atencion oficina " + (i + 1).ToString());
                tabla_iteraciones.Columns.Add(columna_fin_atencion_oficina);
                DataColumn columna_estado_oficina = new DataColumn("Estado oficina " + (i + 1).ToString());
                tabla_iteraciones.Columns.Add(columna_estado_oficina);
            }

            //Colas servidores
            DataColumn columna_cola_caseta = new DataColumn("Cola caseta");
            DataColumn columna_cola_nave = new DataColumn("Cola nave");
            DataColumn columna_cola_oficina = new DataColumn("Cola oficina");

            //Metrica 1
            DataColumn columna_tiempo_permanencia_cola_nave_metrica1 = new DataColumn("Tiempo de permanencia en cola de la nave");
            DataColumn columna_longitud_media_de_la_cola_de_la_nave = new DataColumn("Longitud media de la cola de la nave");

            //Metrica 2
            DataColumn columna_tiempo_permanencia_caseta = new DataColumn("Tiempo de permanencia en la caseta");
            DataColumn columna_cantidad_clientes_atencion_finalizada_caseta = new DataColumn("Cantidad clientes con atencion caseta finalizada");
            DataColumn columna_tiempo_medio_cliente_en_caseta = new DataColumn("Tiempo medio del cliente en la caseta");

            //Metrica 3                                               
            DataColumn columna_tiempo_permanencia_nave = new DataColumn("Tiempo de permanencia en la nave");
            DataColumn columna_cantidad_clientes_atencion_finalizada_nave = new DataColumn("Cantidad clientes con atencion nave finalizada");
            DataColumn columna_tiempo_medio_cliente_en_nave = new DataColumn("Tiempo medio del cliente en la nave");

            //Metrica 4                                              
            DataColumn columna_tiempo_permanencia_oficina = new DataColumn("Tiempo de permanencia en la oficina");
            DataColumn columna_cantidad_clientes_atencion_finalizada_oficina = new DataColumn("Cantidad clientes con atencion oficina finalizada");
            DataColumn columna_tiempo_medio_cliente_en_oficina = new DataColumn("Tiempo medio del cliente en la oficina");

            //Metrica 5                                              
            DataColumn columna_tiempo_permanencia_itv = new DataColumn("Tiempo de permanencia en el sistema");
            DataColumn columna_tiempo_medio_cliente_en_itv = new DataColumn("Tiempo medio del cliente en el ITV");

            //Metrica 6                                               
            DataColumn columna_tiempo_permanencia_cola_caseta = new DataColumn("Tiempo de permanencia en la cola de la caseta");
            DataColumn columna_tiempo_medio_cliente_en_cola_caseta = new DataColumn("Tiempo medio del cliente en la cola de la caseta");

            //Metrica 7                                              
            DataColumn columna_tiempo_permanencia_cola_nave = new DataColumn("Tiempo de permanencia en la cola de la nave");
            DataColumn columna_tiempo_medio_cliente_en_cola_nave = new DataColumn("Tiempo medio del cliente en la cola de nave");

            //Metrica 8                                              
            DataColumn columna_maximo_tiempo_entre_llegadas = new DataColumn("Maximo tiempo entre llegadas");

            //Metrica 9
            DataColumn columna_cantidad_clientes_que_se_fueron_por_cola_llena = new DataColumn("Cantidad de clientes que no entran a la cola porque esta llena");

            //Colas servidores            
            tabla_iteraciones.Columns.Add(columna_cola_caseta);
            tabla_iteraciones.Columns.Add(columna_cola_nave);
            tabla_iteraciones.Columns.Add(columna_cola_oficina);

            //Metrica 1   
            tabla_iteraciones.Columns.Add(columna_tiempo_permanencia_cola_nave_metrica1);
            tabla_iteraciones.Columns.Add(columna_longitud_media_de_la_cola_de_la_nave);

            //Metrica 2                   
            tabla_iteraciones.Columns.Add(columna_tiempo_permanencia_caseta);
            tabla_iteraciones.Columns.Add(columna_cantidad_clientes_atencion_finalizada_caseta);
            tabla_iteraciones.Columns.Add(columna_tiempo_medio_cliente_en_caseta);

            //Metrica 3                   
            tabla_iteraciones.Columns.Add(columna_tiempo_permanencia_nave);
            tabla_iteraciones.Columns.Add(columna_cantidad_clientes_atencion_finalizada_nave);
            tabla_iteraciones.Columns.Add(columna_tiempo_medio_cliente_en_nave);

            //Metrica 4                   
            tabla_iteraciones.Columns.Add(columna_tiempo_permanencia_oficina);
            tabla_iteraciones.Columns.Add(columna_cantidad_clientes_atencion_finalizada_oficina);
            tabla_iteraciones.Columns.Add(columna_tiempo_medio_cliente_en_oficina);

            //Metrica 5                   
            tabla_iteraciones.Columns.Add(columna_tiempo_permanencia_itv);
            tabla_iteraciones.Columns.Add(columna_tiempo_medio_cliente_en_itv);

            //Metrica 6                   
            tabla_iteraciones.Columns.Add(columna_tiempo_permanencia_cola_caseta);
            tabla_iteraciones.Columns.Add(columna_tiempo_medio_cliente_en_cola_caseta);

            //Metrica 7                   
            tabla_iteraciones.Columns.Add(columna_tiempo_permanencia_cola_nave);
            tabla_iteraciones.Columns.Add(columna_tiempo_medio_cliente_en_cola_nave);

            //Metrica 8                   
            tabla_iteraciones.Columns.Add(columna_maximo_tiempo_entre_llegadas);

            //Metrica 9                   
            tabla_iteraciones.Columns.Add(columna_cantidad_clientes_que_se_fueron_por_cola_llena);

        }

        private void cargarTablaRKAtentado(int iteracion)
        {
            DataColumn columna_X0 = new DataColumn("t-" + iteracion.ToString());
            tabla_rk_atentado.Columns.Add(columna_X0);
            DataColumn columna_Y0 = new DataColumn("A-" + iteracion.ToString());
            tabla_rk_atentado.Columns.Add(columna_Y0);
            DataColumn columna_beta = new DataColumn("β-" + iteracion.ToString());
            tabla_rk_atentado.Columns.Add(columna_beta);
            DataColumn columna_K1 = new DataColumn("K1-" + iteracion.ToString());
            tabla_rk_atentado.Columns.Add(columna_K1);
            DataColumn columna_K2 = new DataColumn("K2-" + iteracion.ToString());
            tabla_rk_atentado.Columns.Add(columna_K2);
            DataColumn columna_K3 = new DataColumn("K3-" + iteracion.ToString());
            tabla_rk_atentado.Columns.Add(columna_K3);
            DataColumn columna_K4 = new DataColumn("K4-" + iteracion.ToString());
            tabla_rk_atentado.Columns.Add(columna_K4);
            DataColumn columna_X1 = new DataColumn("t1-" + iteracion.ToString());
            tabla_rk_atentado.Columns.Add(columna_X1);
            DataColumn columna_Y1 = new DataColumn("A1-" + iteracion.ToString());
            tabla_rk_atentado.Columns.Add(columna_Y1);
        }

        private void cargarTablaRKAtentado2(int iteracion)
        {
            DataColumn columna_X0 = new DataColumn("t-" + iteracion.ToString());
            tabla_rk_atentado2.Columns.Add(columna_X0);
            DataColumn columna_Y0 = new DataColumn("A-" + iteracion.ToString());
            tabla_rk_atentado2.Columns.Add(columna_Y0);
            DataColumn columna_beta = new DataColumn("β-" + iteracion.ToString());
            tabla_rk_atentado2.Columns.Add(columna_beta);
            DataColumn columna_K1 = new DataColumn("K1-" + iteracion.ToString());
            tabla_rk_atentado2.Columns.Add(columna_K1);
            DataColumn columna_K2 = new DataColumn("K2-" + iteracion.ToString());
            tabla_rk_atentado2.Columns.Add(columna_K2);
            DataColumn columna_K3 = new DataColumn("K3-" + iteracion.ToString());
            tabla_rk_atentado2.Columns.Add(columna_K3);
            DataColumn columna_K4 = new DataColumn("K4-" + iteracion.ToString());
            tabla_rk_atentado2.Columns.Add(columna_K4);
            DataColumn columna_X1 = new DataColumn("t1-" + iteracion.ToString());
            tabla_rk_atentado2.Columns.Add(columna_X1);
            DataColumn columna_Y1 = new DataColumn("A1-" + iteracion.ToString());
            tabla_rk_atentado2.Columns.Add(columna_Y1);
        }

        private void cargarTablaRKAtentado3(int iteracion)
        {
            DataColumn columna_X0 = new DataColumn("t-" + iteracion.ToString());
            tabla_rk_atentado3.Columns.Add(columna_X0);
            DataColumn columna_Y0 = new DataColumn("A-" + iteracion.ToString());
            tabla_rk_atentado3.Columns.Add(columna_Y0);
            DataColumn columna_beta = new DataColumn("β-" + iteracion.ToString());
            tabla_rk_atentado3.Columns.Add(columna_beta);
            DataColumn columna_K1 = new DataColumn("K1-" + iteracion.ToString());
            tabla_rk_atentado3.Columns.Add(columna_K1);
            DataColumn columna_K2 = new DataColumn("K2-" + iteracion.ToString());
            tabla_rk_atentado3.Columns.Add(columna_K2);
            DataColumn columna_K3 = new DataColumn("K3-" + iteracion.ToString());
            tabla_rk_atentado3.Columns.Add(columna_K3);
            DataColumn columna_K4 = new DataColumn("K4-" + iteracion.ToString());
            tabla_rk_atentado3.Columns.Add(columna_K4);
            DataColumn columna_X1 = new DataColumn("t1-" + iteracion.ToString());
            tabla_rk_atentado3.Columns.Add(columna_X1);
            DataColumn columna_Y1 = new DataColumn("A1-" + iteracion.ToString());
            tabla_rk_atentado3.Columns.Add(columna_Y1);
        }

        private void cargarTablaRKBloqueoIngreso(int iteracion)
        {
            DataColumn columna_X0 = new DataColumn("t-" + iteracion.ToString());
            tabla_rk_bloqueo_ingreso.Columns.Add(columna_X0);
            DataColumn columna_Y0 = new DataColumn("L-" + iteracion.ToString());
            tabla_rk_bloqueo_ingreso.Columns.Add(columna_Y0);
            DataColumn columna_K1 = new DataColumn("K1-" + iteracion.ToString());
            tabla_rk_bloqueo_ingreso.Columns.Add(columna_K1);
            DataColumn columna_K2 = new DataColumn("K2-" + iteracion.ToString());
            tabla_rk_bloqueo_ingreso.Columns.Add(columna_K2);
            DataColumn columna_K3 = new DataColumn("K3-" + iteracion.ToString());
            tabla_rk_bloqueo_ingreso.Columns.Add(columna_K3);
            DataColumn columna_K4 = new DataColumn("K4-" + iteracion.ToString());
            tabla_rk_bloqueo_ingreso.Columns.Add(columna_K4);
            DataColumn columna_X1 = new DataColumn("t1-" + iteracion.ToString());
            tabla_rk_bloqueo_ingreso.Columns.Add(columna_X1);
            DataColumn columna_Y1 = new DataColumn("L1-" + iteracion.ToString());
            tabla_rk_bloqueo_ingreso.Columns.Add(columna_Y1);
        }

        private void cargarTablaRKBloqueoIngreso2(int iteracion)
        {
            DataColumn columna_X0 = new DataColumn("t-" + iteracion.ToString());
            tabla_rk_bloqueo_ingreso2.Columns.Add(columna_X0);
            DataColumn columna_Y0 = new DataColumn("L-" + iteracion.ToString());
            tabla_rk_bloqueo_ingreso2.Columns.Add(columna_Y0);
            DataColumn columna_K1 = new DataColumn("K1-" + iteracion.ToString());
            tabla_rk_bloqueo_ingreso2.Columns.Add(columna_K1);
            DataColumn columna_K2 = new DataColumn("K2-" + iteracion.ToString());
            tabla_rk_bloqueo_ingreso2.Columns.Add(columna_K2);
            DataColumn columna_K3 = new DataColumn("K3-" + iteracion.ToString());
            tabla_rk_bloqueo_ingreso2.Columns.Add(columna_K3);
            DataColumn columna_K4 = new DataColumn("K4-" + iteracion.ToString());
            tabla_rk_bloqueo_ingreso2.Columns.Add(columna_K4);
            DataColumn columna_X1 = new DataColumn("t1-" + iteracion.ToString());
            tabla_rk_bloqueo_ingreso2.Columns.Add(columna_X1);
            DataColumn columna_Y1 = new DataColumn("L1-" + iteracion.ToString());
            tabla_rk_bloqueo_ingreso2.Columns.Add(columna_Y1);
        }

        private void cargarTablaRKBloqueoCaseta(int iteracion)
        {
            DataColumn columna_X0 = new DataColumn("t-" + iteracion.ToString());
            tabla_rk_bloqueo_servicio.Columns.Add(columna_X0);
            DataColumn columna_Y0 = new DataColumn("S-" + iteracion.ToString());
            tabla_rk_bloqueo_servicio.Columns.Add(columna_Y0);
            DataColumn columna_K1 = new DataColumn("K1-" + iteracion.ToString());
            tabla_rk_bloqueo_servicio.Columns.Add(columna_K1);
            DataColumn columna_K2 = new DataColumn("K2-" + iteracion.ToString());
            tabla_rk_bloqueo_servicio.Columns.Add(columna_K2);
            DataColumn columna_K3 = new DataColumn("K3-" + iteracion.ToString());
            tabla_rk_bloqueo_servicio.Columns.Add(columna_K3);
            DataColumn columna_K4 = new DataColumn("K4-" + iteracion.ToString());
            tabla_rk_bloqueo_servicio.Columns.Add(columna_K4);
            DataColumn columna_X1 = new DataColumn("t1-" + iteracion.ToString());
            tabla_rk_bloqueo_servicio.Columns.Add(columna_X1);
            DataColumn columna_Y1 = new DataColumn("S1-" + iteracion.ToString());
            tabla_rk_bloqueo_servicio.Columns.Add(columna_Y1);
        }

        private void cargarTablaRKBloqueoCaseta2(int iteracion)
        {
            DataColumn columna_X0 = new DataColumn("t-" + iteracion.ToString());
            tabla_rk_bloqueo_servicio2.Columns.Add(columna_X0);
            DataColumn columna_Y0 = new DataColumn("S-" + iteracion.ToString());
            tabla_rk_bloqueo_servicio2.Columns.Add(columna_Y0);
            DataColumn columna_K1 = new DataColumn("K1-" + iteracion.ToString());
            tabla_rk_bloqueo_servicio2.Columns.Add(columna_K1);
            DataColumn columna_K2 = new DataColumn("K2-" + iteracion.ToString());
            tabla_rk_bloqueo_servicio2.Columns.Add(columna_K2);
            DataColumn columna_K3 = new DataColumn("K3-" + iteracion.ToString());
            tabla_rk_bloqueo_servicio2.Columns.Add(columna_K3);
            DataColumn columna_K4 = new DataColumn("K4-" + iteracion.ToString());
            tabla_rk_bloqueo_servicio2.Columns.Add(columna_K4);
            DataColumn columna_X1 = new DataColumn("t1-" + iteracion.ToString());
            tabla_rk_bloqueo_servicio2.Columns.Add(columna_X1);
            DataColumn columna_Y1 = new DataColumn("S1-" + iteracion.ToString());
            tabla_rk_bloqueo_servicio2.Columns.Add(columna_Y1);
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
            rnd_atentado_tipo = 0;
            rnd_beta = 0;

            //Cola para los servidores
            cola_clientes_caseta = new List<cliente>();
            cola_clientes_nave = new List<cliente>();
            cola_clientes_oficina = new List<cliente>();

            //reloj
            reloj = 0;

            flag_primera_vuelta = false;
            bandera_llegadas = true;

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

            tiempo_proximo_bloqueo = 0.0;
            tiempo_fin_bloqueo_ingreso = 0.0;
            tiempo_fin_bloqueo_servicio = 0.0;
            tiempo_entre_bloqueos = 0.0;
            tipo_de_atentado = "";
            tiempo_entre_bloqueos_ingreso = 0.0;
            tiempo_entre_bloqueos_servicio = 0.0;
            A = 0;
            cantidad_iteraciones_rk_atentado = 0;
            cantidad_iteraciones_rk_bloqueo_ingreso = 0;
            cantidad_iteraciones_rk_bloqueo_servicio = 0;

            tabla_rk_atentado = new DataTable();
            tabla_rk_atentado2 = new DataTable();
            tabla_rk_atentado3 = new DataTable();
            tabla_rk_bloqueo_ingreso = new DataTable();
            tabla_rk_bloqueo_ingreso2 = new DataTable();
            tabla_rk_bloqueo_servicio = new DataTable();
            tabla_rk_bloqueo_servicio2 = new DataTable();

            cantidad_clientes_que_se_van_por_cola_llena = 0;
            cantidad_clientes_ingresan_al_sistema = 0;
            cantidad_clientes_que_se_van_por_bloqueo = 0;
            cantidad_iteraciones = 0;
            nro_cliente_desde_que_se_muestra = 0;
            bandera_nro_cliente = true;

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
