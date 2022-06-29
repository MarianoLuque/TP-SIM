namespace ITV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btn_cerrar_programa = new System.Windows.Forms.Button();
            this.txt_cantidad_minutos = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cantidad_clientes_oficina = new System.Windows.Forms.MaskedTextBox();
            this.txt_cantidad_clientes_nave = new System.Windows.Forms.MaskedTextBox();
            this.txt_cantidad_clientes_caseta = new System.Windows.Forms.MaskedTextBox();
            this.txt_cantidad_clientes_llegadas = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_minutos_nave = new System.Windows.Forms.MaskedTextBox();
            this.txt_minutos_oficina = new System.Windows.Forms.MaskedTextBox();
            this.txt_minutos_caseta = new System.Windows.Forms.MaskedTextBox();
            this.txt_minutos_llegadas = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_hs = new System.Windows.Forms.Label();
            this.lbl_barcos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_cantidad_maxima_cola = new System.Windows.Forms.MaskedTextBox();
            this.btn_simular = new System.Windows.Forms.Button();
            this.rb_minutos = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_cantidad_eventos = new System.Windows.Forms.MaskedTextBox();
            this.rb_eventos = new System.Windows.Forms.RadioButton();
            this.cb_mostrar_clientes = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_cantidad_oficinas = new System.Windows.Forms.MaskedTextBox();
            this.txt_cantidad_naves = new System.Windows.Forms.MaskedTextBox();
            this.txt_cantidad_casetas = new System.Windows.Forms.MaskedTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar_programa
            // 
            this.btn_cerrar_programa.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_programa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_programa.BackgroundImage")));
            this.btn_cerrar_programa.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_programa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_programa.Location = new System.Drawing.Point(913, 14);
            this.btn_cerrar_programa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cerrar_programa.Name = "btn_cerrar_programa";
            this.btn_cerrar_programa.Size = new System.Drawing.Size(55, 50);
            this.btn_cerrar_programa.TabIndex = 16;
            this.btn_cerrar_programa.UseVisualStyleBackColor = false;
            this.btn_cerrar_programa.Click += new System.EventHandler(this.btn_cerrar_programa_Click);
            // 
            // txt_cantidad_minutos
            // 
            this.txt_cantidad_minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_minutos.Location = new System.Drawing.Point(668, 84);
            this.txt_cantidad_minutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cantidad_minutos.Mask = "99999";
            this.txt_cantidad_minutos.Name = "txt_cantidad_minutos";
            this.txt_cantidad_minutos.Size = new System.Drawing.Size(223, 34);
            this.txt_cantidad_minutos.TabIndex = 17;
            this.txt_cantidad_minutos.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(546, 36);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ingrese la cantidad de minutos a simular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 54);
            this.label1.TabIndex = 18;
            this.label1.Text = "Simulación de colas - ITV";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_cantidad_clientes_oficina);
            this.groupBox1.Controls.Add(this.txt_cantidad_clientes_nave);
            this.groupBox1.Controls.Add(this.txt_cantidad_clientes_caseta);
            this.groupBox1.Controls.Add(this.txt_cantidad_clientes_llegadas);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_minutos_nave);
            this.groupBox1.Controls.Add(this.txt_minutos_oficina);
            this.groupBox1.Controls.Add(this.txt_minutos_caseta);
            this.groupBox1.Controls.Add(this.txt_minutos_llegadas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_hs);
            this.groupBox1.Controls.Add(this.lbl_barcos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 319);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(905, 278);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Probabilidad de Eventos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(795, 213);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 29);
            this.label12.TabIndex = 25;
            this.label12.Text = "minutos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(795, 165);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 29);
            this.label10.TabIndex = 25;
            this.label10.Text = "minutos";
            // 
            // txt_cantidad_clientes_oficina
            // 
            this.txt_cantidad_clientes_oficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_clientes_oficina.Location = new System.Drawing.Point(428, 209);
            this.txt_cantidad_clientes_oficina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cantidad_clientes_oficina.Mask = "999";
            this.txt_cantidad_clientes_oficina.Name = "txt_cantidad_clientes_oficina";
            this.txt_cantidad_clientes_oficina.Size = new System.Drawing.Size(111, 34);
            this.txt_cantidad_clientes_oficina.TabIndex = 22;
            this.txt_cantidad_clientes_oficina.ValidatingType = typeof(int);
            // 
            // txt_cantidad_clientes_nave
            // 
            this.txt_cantidad_clientes_nave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_clientes_nave.Location = new System.Drawing.Point(428, 161);
            this.txt_cantidad_clientes_nave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cantidad_clientes_nave.Mask = "999";
            this.txt_cantidad_clientes_nave.Name = "txt_cantidad_clientes_nave";
            this.txt_cantidad_clientes_nave.Size = new System.Drawing.Size(111, 34);
            this.txt_cantidad_clientes_nave.TabIndex = 22;
            this.txt_cantidad_clientes_nave.ValidatingType = typeof(int);
            // 
            // txt_cantidad_clientes_caseta
            // 
            this.txt_cantidad_clientes_caseta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_clientes_caseta.Location = new System.Drawing.Point(428, 113);
            this.txt_cantidad_clientes_caseta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cantidad_clientes_caseta.Mask = "999";
            this.txt_cantidad_clientes_caseta.Name = "txt_cantidad_clientes_caseta";
            this.txt_cantidad_clientes_caseta.Size = new System.Drawing.Size(111, 34);
            this.txt_cantidad_clientes_caseta.TabIndex = 22;
            this.txt_cantidad_clientes_caseta.ValidatingType = typeof(int);
            // 
            // txt_cantidad_clientes_llegadas
            // 
            this.txt_cantidad_clientes_llegadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_clientes_llegadas.Location = new System.Drawing.Point(431, 65);
            this.txt_cantidad_clientes_llegadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cantidad_clientes_llegadas.Mask = "999";
            this.txt_cantidad_clientes_llegadas.Name = "txt_cantidad_clientes_llegadas";
            this.txt_cantidad_clientes_llegadas.Size = new System.Drawing.Size(111, 34);
            this.txt_cantidad_clientes_llegadas.TabIndex = 22;
            this.txt_cantidad_clientes_llegadas.ValidatingType = typeof(int);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(548, 213);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 29);
            this.label11.TabIndex = 24;
            this.label11.Text = "clientes en";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(795, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 29);
            this.label8.TabIndex = 25;
            this.label8.Text = "minutos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(548, 165);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "clientes en";
            // 
            // txt_minutos_nave
            // 
            this.txt_minutos_nave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_minutos_nave.Location = new System.Drawing.Point(681, 161);
            this.txt_minutos_nave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_minutos_nave.Mask = "999";
            this.txt_minutos_nave.Name = "txt_minutos_nave";
            this.txt_minutos_nave.Size = new System.Drawing.Size(104, 34);
            this.txt_minutos_nave.TabIndex = 23;
            this.txt_minutos_nave.ValidatingType = typeof(int);
            // 
            // txt_minutos_oficina
            // 
            this.txt_minutos_oficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_minutos_oficina.Location = new System.Drawing.Point(681, 209);
            this.txt_minutos_oficina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_minutos_oficina.Mask = "999";
            this.txt_minutos_oficina.Name = "txt_minutos_oficina";
            this.txt_minutos_oficina.Size = new System.Drawing.Size(104, 34);
            this.txt_minutos_oficina.TabIndex = 23;
            this.txt_minutos_oficina.ValidatingType = typeof(int);
            // 
            // txt_minutos_caseta
            // 
            this.txt_minutos_caseta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_minutos_caseta.Location = new System.Drawing.Point(681, 113);
            this.txt_minutos_caseta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_minutos_caseta.Mask = "999";
            this.txt_minutos_caseta.Name = "txt_minutos_caseta";
            this.txt_minutos_caseta.Size = new System.Drawing.Size(104, 34);
            this.txt_minutos_caseta.TabIndex = 23;
            this.txt_minutos_caseta.ValidatingType = typeof(int);
            // 
            // txt_minutos_llegadas
            // 
            this.txt_minutos_llegadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_minutos_llegadas.Location = new System.Drawing.Point(681, 65);
            this.txt_minutos_llegadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_minutos_llegadas.Mask = "999";
            this.txt_minutos_llegadas.Name = "txt_minutos_llegadas";
            this.txt_minutos_llegadas.Size = new System.Drawing.Size(104, 34);
            this.txt_minutos_llegadas.TabIndex = 23;
            this.txt_minutos_llegadas.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(548, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "clientes en";
            // 
            // lbl_hs
            // 
            this.lbl_hs.AutoSize = true;
            this.lbl_hs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hs.Location = new System.Drawing.Point(795, 69);
            this.lbl_hs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hs.Name = "lbl_hs";
            this.lbl_hs.Size = new System.Drawing.Size(97, 29);
            this.lbl_hs.TabIndex = 25;
            this.lbl_hs.Text = "minutos";
            // 
            // lbl_barcos
            // 
            this.lbl_barcos.AutoSize = true;
            this.lbl_barcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barcos.Location = new System.Drawing.Point(548, 69);
            this.lbl_barcos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_barcos.Name = "lbl_barcos";
            this.lbl_barcos.Size = new System.Drawing.Size(129, 29);
            this.lbl_barcos.TabIndex = 24;
            this.lbl_barcos.Text = "clientes en";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fin atencion oficina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fin atencion nave:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fin atencion caseta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Llegada de clientes al sistema:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(59, 869);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(635, 31);
            this.label13.TabIndex = 19;
            this.label13.Text = "Cantidad máxima de clientes en la cola de la caseta";
            // 
            // txt_cantidad_maxima_cola
            // 
            this.txt_cantidad_maxima_cola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_maxima_cola.Location = new System.Drawing.Point(747, 869);
            this.txt_cantidad_maxima_cola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cantidad_maxima_cola.Mask = "999";
            this.txt_cantidad_maxima_cola.Name = "txt_cantidad_maxima_cola";
            this.txt_cantidad_maxima_cola.Size = new System.Drawing.Size(223, 34);
            this.txt_cantidad_maxima_cola.TabIndex = 17;
            this.txt_cantidad_maxima_cola.ValidatingType = typeof(int);
            // 
            // btn_simular
            // 
            this.btn_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.Location = new System.Drawing.Point(829, 924);
            this.btn_simular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(139, 42);
            this.btn_simular.TabIndex = 21;
            this.btn_simular.Text = "Continuar";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // rb_minutos
            // 
            this.rb_minutos.AutoSize = true;
            this.rb_minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.rb_minutos.Location = new System.Drawing.Point(13, 46);
            this.rb_minutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_minutos.Name = "rb_minutos";
            this.rb_minutos.Size = new System.Drawing.Size(399, 35);
            this.rb_minutos.TabIndex = 22;
            this.rb_minutos.TabStop = true;
            this.rb_minutos.Text = "Cantidad de minutos a simular";
            this.rb_minutos.UseVisualStyleBackColor = true;
            this.rb_minutos.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_cantidad_eventos);
            this.groupBox2.Controls.Add(this.rb_eventos);
            this.groupBox2.Controls.Add(this.txt_cantidad_minutos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rb_minutos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.groupBox2.Location = new System.Drawing.Point(64, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(904, 229);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parámetros para la cantidad de eventos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 177);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(499, 31);
            this.label14.TabIndex = 25;
            this.label14.Text = "Ingrese la cantidad de eventos a simular";
            // 
            // txt_cantidad_eventos
            // 
            this.txt_cantidad_eventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_eventos.Location = new System.Drawing.Point(668, 174);
            this.txt_cantidad_eventos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cantidad_eventos.Mask = "999999";
            this.txt_cantidad_eventos.Name = "txt_cantidad_eventos";
            this.txt_cantidad_eventos.Size = new System.Drawing.Size(223, 34);
            this.txt_cantidad_eventos.TabIndex = 24;
            this.txt_cantidad_eventos.ValidatingType = typeof(int);
            // 
            // rb_eventos
            // 
            this.rb_eventos.AutoSize = true;
            this.rb_eventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.rb_eventos.Location = new System.Drawing.Point(13, 139);
            this.rb_eventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_eventos.Name = "rb_eventos";
            this.rb_eventos.Size = new System.Drawing.Size(400, 35);
            this.rb_eventos.TabIndex = 23;
            this.rb_eventos.TabStop = true;
            this.rb_eventos.Text = "Cantidad de eventos a simular";
            this.rb_eventos.UseVisualStyleBackColor = true;
            this.rb_eventos.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // cb_mostrar_clientes
            // 
            this.cb_mostrar_clientes.AutoSize = true;
            this.cb_mostrar_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mostrar_clientes.Location = new System.Drawing.Point(483, 929);
            this.cb_mostrar_clientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_mostrar_clientes.Name = "cb_mostrar_clientes";
            this.cb_mostrar_clientes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_mostrar_clientes.Size = new System.Drawing.Size(309, 33);
            this.cb_mostrar_clientes.TabIndex = 24;
            this.cb_mostrar_clientes.Text = "Mostrar todos los clientes";
            this.cb_mostrar_clientes.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_cantidad_oficinas);
            this.groupBox3.Controls.Add(this.txt_cantidad_naves);
            this.groupBox3.Controls.Add(this.txt_cantidad_casetas);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(64, 615);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(905, 208);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cantidad de servidores";
            // 
            // txt_cantidad_oficinas
            // 
            this.txt_cantidad_oficinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_oficinas.Location = new System.Drawing.Point(428, 148);
            this.txt_cantidad_oficinas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cantidad_oficinas.Mask = "99";
            this.txt_cantidad_oficinas.Name = "txt_cantidad_oficinas";
            this.txt_cantidad_oficinas.Size = new System.Drawing.Size(111, 34);
            this.txt_cantidad_oficinas.TabIndex = 22;
            this.txt_cantidad_oficinas.ValidatingType = typeof(int);
            // 
            // txt_cantidad_naves
            // 
            this.txt_cantidad_naves.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_naves.Location = new System.Drawing.Point(428, 100);
            this.txt_cantidad_naves.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cantidad_naves.Mask = "99";
            this.txt_cantidad_naves.Name = "txt_cantidad_naves";
            this.txt_cantidad_naves.Size = new System.Drawing.Size(111, 34);
            this.txt_cantidad_naves.TabIndex = 22;
            this.txt_cantidad_naves.ValidatingType = typeof(int);
            // 
            // txt_cantidad_casetas
            // 
            this.txt_cantidad_casetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_casetas.Location = new System.Drawing.Point(428, 52);
            this.txt_cantidad_casetas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cantidad_casetas.Mask = "99";
            this.txt_cantidad_casetas.Name = "txt_cantidad_casetas";
            this.txt_cantidad_casetas.Size = new System.Drawing.Size(111, 34);
            this.txt_cantidad_casetas.TabIndex = 22;
            this.txt_cantidad_casetas.ValidatingType = typeof(int);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(165, 153);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(231, 29);
            this.label24.TabIndex = 19;
            this.label24.Text = "Cantidad de oficinas";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(184, 105);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(212, 29);
            this.label25.TabIndex = 19;
            this.label25.Text = "Cantidad de naves";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(165, 57);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(231, 29);
            this.label26.TabIndex = 19;
            this.label26.Text = "Cantidad de casetas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(49, 962);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 31);
            this.label15.TabIndex = 27;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1032, 981);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cb_mostrar_clientes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_cantidad_maxima_cola);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cerrar_programa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar_programa;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_minutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_clientes_llegadas;
        private System.Windows.Forms.MaskedTextBox txt_minutos_llegadas;
        private System.Windows.Forms.Label lbl_hs;
        private System.Windows.Forms.Label lbl_barcos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_clientes_oficina;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_clientes_nave;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_clientes_caseta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txt_minutos_nave;
        private System.Windows.Forms.MaskedTextBox txt_minutos_oficina;
        private System.Windows.Forms.MaskedTextBox txt_minutos_caseta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_maxima_cola;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.RadioButton rb_minutos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_eventos;
        private System.Windows.Forms.RadioButton rb_eventos;
        private System.Windows.Forms.CheckBox cb_mostrar_clientes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_oficinas;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_naves;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_casetas;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label15;
    }
}

