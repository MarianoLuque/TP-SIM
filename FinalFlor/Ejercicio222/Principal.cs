namespace Ejercicio222
{
    public partial class Principal : Form
    {
        string? parametro_cantidad;
        public Principal()
        {
            InitializeComponent();
        }
        
        private void btn_simular_Click(object sender, EventArgs e)
        {
            if (!rb_eventos.Checked && !rb_horas.Checked)
            {
                MessageBox.Show("Seleccione un parámetro para la cantidad de eventos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (rb_horas.Checked && txt_cantidad_horas.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad de horas a simular", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (rb_eventos.Checked && (txt_cantidad_eventos.Text == "" || int.Parse(txt_cantidad_eventos.Text) < 400))
            {
                MessageBox.Show("Ingrese la cantidad de eventos a simular (mayor o igual a 400)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_cantidad_cheques_llegadas.Text == "" || txt_cantidad_cheques_maquina1.Text == "" || txt_cantidad_cheques_maquina2.Text == "" )
            {
                MessageBox.Show("Ingrese la cantidad de cheques que llegan al sistema y que son atendidos en cada máquina", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_horas_llegadas.Text == "" || txt_horas_maquina1.Text == "" || txt_horas_maquina1.Text == "" )
            {
                MessageBox.Show("Ingrese la cantidad de horas en los que llegan los cheques al sistema y que tardan en la atención de cada máquina", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (rb_eventos.Checked)
            {
                parametro_cantidad = "eventos";
                Simulacion simulacion = new Simulacion(int.Parse(txt_cantidad_eventos.Text), 
                                                       int.Parse(txt_cantidad_cheques_llegadas.Text), int.Parse(txt_cantidad_cheques_maquina1.Text), int.Parse(txt_cantidad_cheques_maquina2.Text), 
                                                       int.Parse(txt_horas_llegadas.Text), int.Parse(txt_horas_maquina1.Text), int.Parse(txt_horas_maquina2.Text),
                                                       parametro_cantidad, cb_mostrar_clientes.Checked);
                simulacion.ShowDialog();

            }

            if (rb_horas.Checked)
            {
                parametro_cantidad = "minutos";
                Simulacion simulacion = new Simulacion(int.Parse(txt_cantidad_horas.Text),
                                                       int.Parse(txt_cantidad_cheques_llegadas.Text), int.Parse(txt_cantidad_cheques_maquina1.Text), int.Parse(txt_cantidad_cheques_maquina2.Text),
                                                       int.Parse(txt_horas_llegadas.Text), int.Parse(txt_horas_maquina1.Text), int.Parse(txt_horas_maquina2.Text),
                                                       parametro_cantidad, cb_mostrar_clientes.Checked);
                simulacion.ShowDialog();
            }
        }
        //Cierra el programa
        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Se ejecuta cuando carga el formulario
        private void Principal_Load(object sender, EventArgs e)
        {
            txt_cantidad_horas.Enabled = false;
            txt_cantidad_eventos.Enabled = false;

            //Cantidad de cheques que dice el enunciado
            txt_cantidad_cheques_llegadas.Text = "800";
            txt_cantidad_cheques_maquina1.Text = "1600";
            txt_cantidad_cheques_maquina2.Text = "1000";

            //Cantidad de horas que dice el enunciado
            txt_horas_llegadas.Text = "60";
            txt_horas_maquina1.Text = "60";
            txt_horas_maquina2.Text = "60";
        }
        //Deshabilita y limpia los txt de los parámetros para la cantidad de eventos
        private void CheckedChanged(object sender, EventArgs e)
        {
            if (rb_eventos.Checked)
            {
                txt_cantidad_horas.Enabled = false;
                txt_cantidad_eventos.Enabled = true;
                txt_cantidad_horas.Text = "";
            }
            if (rb_horas.Checked)
            {
                txt_cantidad_horas.Enabled = true;
                txt_cantidad_eventos.Enabled = false;
                txt_cantidad_eventos.Text = "";
            }
        }
    }
}
