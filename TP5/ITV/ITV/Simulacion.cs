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
        //minutos de simulacion
        int minutos;

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

        //cantidad maxima de clientes que pueden estar en la cola de la caseta
        int cantidad_maxima_cola_caseta;

        //reloj
        int[] reloj = new int[] { 0, 0, 0 };

        //randoms para los diferentes eventos (llegadas y atenciones)
        Random rnd_llegadas = new Random();
        Random rnd_atencion_caseta = new Random();
        Random rnd_atencion_nave = new Random();
        Random rnd_atencion_oficina = new Random();

        //tiempos de llegada y atencion
        int[] tiempo_entre_llegadas   = new int[] { 0, 0, 0 };
        int[] tiempo_atencion_caseta  = new int[] { 0, 0, 0 };
        int[] tiempo_atencion_nave    = new int[] { 0, 0, 0 };
        int[] tiempo_atencion_oficina = new int[] { 0, 0, 0 };

        //tiempos de proxima llegada y fin atencion
        int[] tiempo_proxima_llegada        = new int[] { 0, 0, 0 };
        int[] tiempo_fin_atencion_caseta    = new int[] { 0, 0, 0 };
        int[] tiempo_fin_atencion_nave      = new int[] { 0, 0, 0 };
        int[] tiempo_fin_atencion_oficina_1 = new int[] { 0, 0, 0 };
        int[] tiempo_fin_atencion_oficina_2 = new int[] { 0, 0, 0 };

        //servidores
        servidor caseta = new servidor();
        servidor nave = new servidor();
        servidor oficina = new servidor();

        //metrica 1

        //metrica 2
        int[] tiempo_permanencia_caseta   = new int[] { 0, 0, 0 };
        int[] tiempo_medio_cliente_caseta = new int[] { 0, 0, 0 };
        int cantidad_clientes_atencion_finalizada_caseta;

        //metrica 3
        int[] tiempo_permanencia_nave   = new int[] { 0, 0, 0 };
        int[] tiempo_medio_cliente_nave = new int[] { 0, 0, 0 };
        int cantidad_clientes_atencion_finalizada_nave;

        //metrica 4
        int[] tiempo_permanencia_oficina   = new int[] { 0, 0, 0 };
        int[] tiempo_medio_cliente_oficina = new int[] { 0, 0, 0 };
        int cantidad_clientes_atencion_finalizada_oficina;

        //metrica 5
        int[] tiempo_permanencia_itv   = new int[] { 0, 0, 0 };
        int[] tiempo_medio_cliente_itv = new int[] { 0, 0, 0 };

        //metrica 6
        int[] tiempo_permanencia_cola_caseta = new int[] { 0, 0, 0 };
        int[] tiempo_medio_cliente_cola_caseta = new int[] { 0, 0, 0 };

        //metrica 7
        int[] tiempo_permanencia_cola_nave = new int[] { 0, 0, 0 };
        int[] tiempo_medio_cliente_cola_nave = new int[] { 0, 0, 0 };

        //metrica 8
        int[] tiempo_maximo_entre_llegadas = new int[] { 0, 0, 0 };

        //metrica 9
        int cantidad_clientes_que_se_van_por_cola_llena;

        //tabla con iteraciones
        DataTable tabla_iteraciones = new DataTable();

        public Simulacion(int minutos, int cantidad_llegadas, int cantidad_caseta, int cantidad_nave, int cantidad_oficina, int minutos_llegadas, int minutos_caseta, int minutos_nave, int minutos_oficina, int cantidad_maxima_cola_caseta)
        {
            InitializeComponent();
            this.minutos = minutos;

            this.cantidad_llegadas = cantidad_llegadas;
            this.cantidad_caseta = cantidad_caseta;
            this.cantidad_nave = cantidad_nave;
            this.cantidad_oficina = cantidad_oficina;

            this.minutos_llegadas = minutos_llegadas;
            this.minutos_caseta = minutos_caseta;
            this.minutos_nave = minutos_nave;
            this.minutos_oficina = minutos_oficina;

            this.cantidad_maxima_cola_caseta = cantidad_maxima_cola_caseta;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void calcularProximaLlegada()
        {

        }

        private void btn_simular_Click(object sender, EventArgs e)
        {

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
                        hay gente --> calcularTiempoDeAtencion() y cliente a SIENDO_ATENDIDO_CASETA/NAVE/OFICINA
                        no hay gente --> servidor a libre
                }
            }

            Asociar la tabla al dataSource
            */
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
            DataColumn columna_fin_atencion_nave        = new DataColumn("Fin atencion nave");
                       
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
            tabla_iteraciones.Columns.Add(columna_fin_atencion_nave   );
                                          
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
