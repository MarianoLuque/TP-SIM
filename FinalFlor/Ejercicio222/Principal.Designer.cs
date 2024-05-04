using System.Security.Principal;

namespace Ejercicio222
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btn_cerrar_programa = new Button();
            txt_cantidad_horas = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txt_cantidad_cheques_maquina2 = new MaskedTextBox();
            label5 = new Label();
            txt_horas_maquina2 = new MaskedTextBox();
            label7 = new Label();
            label12 = new Label();
            txt_cantidad_cheques_maquina1 = new MaskedTextBox();
            txt_cantidad_cheques_llegadas = new MaskedTextBox();
            label11 = new Label();
            txt_horas_maquina1 = new MaskedTextBox();
            txt_horas_llegadas = new MaskedTextBox();
            lbl_hs = new Label();
            lbl_barcos = new Label();
            label6 = new Label();
            label3 = new Label();
            btn_simular = new Button();
            rb_horas = new RadioButton();
            groupBox2 = new GroupBox();
            label14 = new Label();
            txt_cantidad_eventos = new MaskedTextBox();
            rb_eventos = new RadioButton();
            cb_mostrar_clientes = new CheckBox();
            label15 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_cerrar_programa
            // 
            btn_cerrar_programa.BackColor = Color.Transparent;
            btn_cerrar_programa.BackgroundImage = Properties.Resources.cerrar;
            btn_cerrar_programa.FlatAppearance.BorderSize = 0;
            btn_cerrar_programa.FlatStyle = FlatStyle.Flat;
            btn_cerrar_programa.Location = new Point(799, 12);
            btn_cerrar_programa.Margin = new Padding(4);
            btn_cerrar_programa.Name = "btn_cerrar_programa";
            btn_cerrar_programa.Size = new Size(48, 47);
            btn_cerrar_programa.TabIndex = 16;
            btn_cerrar_programa.UseVisualStyleBackColor = false;
            btn_cerrar_programa.Click += btn_cerrar_programa_Click;
            // 
            // txt_cantidad_horas
            // 
            txt_cantidad_horas.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_cantidad_horas.Location = new Point(584, 79);
            txt_cantidad_horas.Margin = new Padding(4);
            txt_cantidad_horas.Mask = "99999";
            txt_cantidad_horas.Name = "txt_cantidad_horas";
            txt_cantidad_horas.Size = new Size(196, 29);
            txt_cantidad_horas.TabIndex = 17;
            txt_cantidad_horas.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 79);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(419, 29);
            label2.TabIndex = 19;
            label2.Text = "Ingrese la cantidad de horas a simular";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(489, 42);
            label1.TabIndex = 18;
            label1.Text = "Simulación de colas - Banco";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_cantidad_cheques_maquina2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_horas_maquina2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txt_cantidad_cheques_maquina1);
            groupBox1.Controls.Add(txt_cantidad_cheques_llegadas);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txt_horas_maquina1);
            groupBox1.Controls.Add(txt_horas_llegadas);
            groupBox1.Controls.Add(lbl_hs);
            groupBox1.Controls.Add(lbl_barcos);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(56, 299);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(792, 208);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Probabilidad de Eventos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(696, 158);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 24);
            label4.TabIndex = 30;
            label4.Text = "minutos";
            // 
            // txt_cantidad_cheques_maquina2
            // 
            txt_cantidad_cheques_maquina2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_cantidad_cheques_maquina2.Location = new Point(368, 155);
            txt_cantidad_cheques_maquina2.Margin = new Padding(4);
            txt_cantidad_cheques_maquina2.Mask = "999";
            txt_cantidad_cheques_maquina2.Name = "txt_cantidad_cheques_maquina2";
            txt_cantidad_cheques_maquina2.Size = new Size(98, 29);
            txt_cantidad_cheques_maquina2.TabIndex = 27;
            txt_cantidad_cheques_maquina2.ValidatingType = typeof(int);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(474, 159);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 24);
            label5.TabIndex = 29;
            label5.Text = "cheques en";
            // 
            // txt_horas_maquina2
            // 
            txt_horas_maquina2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_horas_maquina2.Location = new Point(596, 155);
            txt_horas_maquina2.Margin = new Padding(4);
            txt_horas_maquina2.Mask = "999";
            txt_horas_maquina2.Name = "txt_horas_maquina2";
            txt_horas_maquina2.Size = new Size(92, 29);
            txt_horas_maquina2.TabIndex = 28;
            txt_horas_maquina2.ValidatingType = typeof(int);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(112, 158);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(212, 24);
            label7.TabIndex = 26;
            label7.Text = "Fin atencion máquina 2:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(696, 112);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(76, 24);
            label12.TabIndex = 25;
            label12.Text = "minutos";
            // 
            // txt_cantidad_cheques_maquina1
            // 
            txt_cantidad_cheques_maquina1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_cantidad_cheques_maquina1.Location = new Point(368, 109);
            txt_cantidad_cheques_maquina1.Margin = new Padding(4);
            txt_cantidad_cheques_maquina1.Mask = "999";
            txt_cantidad_cheques_maquina1.Name = "txt_cantidad_cheques_maquina1";
            txt_cantidad_cheques_maquina1.Size = new Size(98, 29);
            txt_cantidad_cheques_maquina1.TabIndex = 22;
            txt_cantidad_cheques_maquina1.ValidatingType = typeof(int);
            // 
            // txt_cantidad_cheques_llegadas
            // 
            txt_cantidad_cheques_llegadas.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_cantidad_cheques_llegadas.Location = new Point(368, 62);
            txt_cantidad_cheques_llegadas.Margin = new Padding(4);
            txt_cantidad_cheques_llegadas.Mask = "999";
            txt_cantidad_cheques_llegadas.Name = "txt_cantidad_cheques_llegadas";
            txt_cantidad_cheques_llegadas.Size = new Size(98, 29);
            txt_cantidad_cheques_llegadas.TabIndex = 22;
            txt_cantidad_cheques_llegadas.ValidatingType = typeof(int);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(474, 112);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(111, 24);
            label11.TabIndex = 24;
            label11.Text = "cheques en";
            // 
            // txt_horas_maquina1
            // 
            txt_horas_maquina1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_horas_maquina1.Location = new Point(596, 109);
            txt_horas_maquina1.Margin = new Padding(4);
            txt_horas_maquina1.Mask = "999";
            txt_horas_maquina1.Name = "txt_horas_maquina1";
            txt_horas_maquina1.Size = new Size(92, 29);
            txt_horas_maquina1.TabIndex = 23;
            txt_horas_maquina1.ValidatingType = typeof(int);
            // 
            // txt_horas_llegadas
            // 
            txt_horas_llegadas.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_horas_llegadas.Location = new Point(596, 61);
            txt_horas_llegadas.Margin = new Padding(4);
            txt_horas_llegadas.Mask = "999";
            txt_horas_llegadas.Name = "txt_horas_llegadas";
            txt_horas_llegadas.Size = new Size(92, 29);
            txt_horas_llegadas.TabIndex = 23;
            txt_horas_llegadas.ValidatingType = typeof(int);
            // 
            // lbl_hs
            // 
            lbl_hs.AutoSize = true;
            lbl_hs.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_hs.Location = new Point(696, 65);
            lbl_hs.Margin = new Padding(4, 0, 4, 0);
            lbl_hs.Name = "lbl_hs";
            lbl_hs.Size = new Size(76, 24);
            lbl_hs.TabIndex = 25;
            lbl_hs.Text = "minutos";
            // 
            // lbl_barcos
            // 
            lbl_barcos.AutoSize = true;
            lbl_barcos.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_barcos.Location = new Point(474, 65);
            lbl_barcos.Margin = new Padding(4, 0, 4, 0);
            lbl_barcos.Name = "lbl_barcos";
            lbl_barcos.Size = new Size(111, 24);
            lbl_barcos.TabIndex = 24;
            lbl_barcos.Text = "cheques en";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(112, 112);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(212, 24);
            label6.TabIndex = 19;
            label6.Text = "Fin atencion máquina 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 65);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(275, 24);
            label3.TabIndex = 19;
            label3.Text = "Llegada de cheques al sistema:";
            // 
            // btn_simular
            // 
            btn_simular.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_simular.Location = new Point(725, 527);
            btn_simular.Margin = new Padding(4);
            btn_simular.Name = "btn_simular";
            btn_simular.Size = new Size(122, 39);
            btn_simular.TabIndex = 21;
            btn_simular.Text = "Continuar";
            btn_simular.UseVisualStyleBackColor = true;
            btn_simular.Click += btn_simular_Click;
            // 
            // rb_horas
            // 
            rb_horas.AutoSize = true;
            rb_horas.Font = new Font("Microsoft Sans Serif", 15.75F);
            rb_horas.Location = new Point(11, 43);
            rb_horas.Margin = new Padding(3, 2, 3, 2);
            rb_horas.Name = "rb_horas";
            rb_horas.Size = new Size(299, 29);
            rb_horas.TabIndex = 22;
            rb_horas.TabStop = true;
            rb_horas.Text = "Cantidad de horas a simular";
            rb_horas.UseVisualStyleBackColor = true;
            rb_horas.CheckedChanged += CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txt_cantidad_eventos);
            groupBox2.Controls.Add(rb_eventos);
            groupBox2.Controls.Add(txt_cantidad_horas);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(rb_horas);
            groupBox2.Font = new Font("Microsoft Sans Serif", 20.25F);
            groupBox2.Location = new Point(56, 67);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(791, 215);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Parámetros para la cantidad de eventos";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 18F);
            label14.Location = new Point(73, 162);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(443, 29);
            label14.TabIndex = 25;
            label14.Text = "Ingrese la cantidad de eventos a simular";
            // 
            // txt_cantidad_eventos
            // 
            txt_cantidad_eventos.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_cantidad_eventos.Location = new Point(584, 162);
            txt_cantidad_eventos.Margin = new Padding(4);
            txt_cantidad_eventos.Mask = "9999999";
            txt_cantidad_eventos.Name = "txt_cantidad_eventos";
            txt_cantidad_eventos.Size = new Size(196, 29);
            txt_cantidad_eventos.TabIndex = 24;
            txt_cantidad_eventos.ValidatingType = typeof(int);
            // 
            // rb_eventos
            // 
            rb_eventos.AutoSize = true;
            rb_eventos.Font = new Font("Microsoft Sans Serif", 15.75F);
            rb_eventos.Location = new Point(11, 125);
            rb_eventos.Margin = new Padding(3, 2, 3, 2);
            rb_eventos.Name = "rb_eventos";
            rb_eventos.Size = new Size(321, 29);
            rb_eventos.TabIndex = 23;
            rb_eventos.TabStop = true;
            rb_eventos.Text = "Cantidad de eventos a simular";
            rb_eventos.UseVisualStyleBackColor = true;
            rb_eventos.CheckedChanged += CheckedChanged;
            // 
            // cb_mostrar_clientes
            // 
            cb_mostrar_clientes.AutoSize = true;
            cb_mostrar_clientes.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_mostrar_clientes.Location = new Point(421, 532);
            cb_mostrar_clientes.Margin = new Padding(4);
            cb_mostrar_clientes.Name = "cb_mostrar_clientes";
            cb_mostrar_clientes.RightToLeft = RightToLeft.Yes;
            cb_mostrar_clientes.Size = new Size(240, 28);
            cb_mostrar_clientes.TabIndex = 24;
            cb_mostrar_clientes.Text = "Mostrar todos los clientes";
            cb_mostrar_clientes.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(43, 902);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(0, 25);
            label15.TabIndex = 27;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(903, 586);
            Controls.Add(label15);
            Controls.Add(cb_mostrar_clientes);
            Controls.Add(groupBox2);
            Controls.Add(btn_simular);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btn_cerrar_programa);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Principal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar_programa;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_horas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_cheques_llegadas;
        private System.Windows.Forms.MaskedTextBox txt_horas_llegadas;
        private System.Windows.Forms.Label lbl_hs;
        private System.Windows.Forms.Label lbl_barcos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_cheques_maquina1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txt_horas_maquina1;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.RadioButton rb_horas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_eventos;
        private System.Windows.Forms.RadioButton rb_eventos;
        private System.Windows.Forms.CheckBox cb_mostrar_clientes;
        private System.Windows.Forms.Label label15;
        private Label label4;
        private MaskedTextBox txt_cantidad_cheques_maquina2;
        private Label label5;
        private MaskedTextBox txt_horas_maquina2;
        private Label label7;
    }
}

