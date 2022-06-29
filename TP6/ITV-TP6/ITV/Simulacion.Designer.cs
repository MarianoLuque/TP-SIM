namespace ITV
{
    partial class Simulacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulacion));
            this.btn_cerrar_programa = new System.Windows.Forms.Button();
            this.btn_simular = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_colas = new System.Windows.Forms.DataGridView();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.txt_desde = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_clientes_se_van_cola_llena = new System.Windows.Forms.Label();
            this.lbl_maximo_tiempo_entre_llegadas = new System.Windows.Forms.Label();
            this.lbl_tiempo_medio_cliente_cola_caseta = new System.Windows.Forms.Label();
            this.lbl_tiempo_medio_cliente_caseta = new System.Windows.Forms.Label();
            this.lbl_tiempo_medio_cola_nave = new System.Windows.Forms.Label();
            this.lbl_tiempo_medio_cliente_nave = new System.Windows.Forms.Label();
            this.lbl_longitud_media_cola_nave = new System.Windows.Forms.Label();
            this.lbl_tiempo_medio_cliente_ITV = new System.Windows.Forms.Label();
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_atentados = new System.Windows.Forms.DataGridView();
            this.dg_bloqueo_llegadas = new System.Windows.Forms.DataGridView();
            this.dg_bloqueo_servidor = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_h = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_A = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dg_atentados2 = new System.Windows.Forms.DataGridView();
            this.dg_atentados3 = new System.Windows.Forms.DataGridView();
            this.dg_bloqueo_llegadas2 = new System.Windows.Forms.DataGridView();
            this.dg_bloqueo_servidor2 = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_colas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_atentados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bloqueo_llegadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bloqueo_servidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_atentados2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_atentados3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bloqueo_llegadas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bloqueo_servidor2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar_programa
            // 
            this.btn_cerrar_programa.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_programa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_programa.BackgroundImage")));
            this.btn_cerrar_programa.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_programa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_programa.Location = new System.Drawing.Point(1733, 14);
            this.btn_cerrar_programa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cerrar_programa.Name = "btn_cerrar_programa";
            this.btn_cerrar_programa.Size = new System.Drawing.Size(55, 50);
            this.btn_cerrar_programa.TabIndex = 17;
            this.btn_cerrar_programa.UseVisualStyleBackColor = false;
            this.btn_cerrar_programa.Click += new System.EventHandler(this.btn_cerrar_programa_Click);
            // 
            // btn_simular
            // 
            this.btn_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.Location = new System.Drawing.Point(1649, 142);
            this.btn_simular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(139, 42);
            this.btn_simular.TabIndex = 22;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(16, 142);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(139, 42);
            this.btn_volver.TabIndex = 23;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 54);
            this.label1.TabIndex = 24;
            this.label1.Text = "Simulación de colas - ITV";
            // 
            // dg_colas
            // 
            this.dg_colas.AllowUserToAddRows = false;
            this.dg_colas.AllowUserToDeleteRows = false;
            this.dg_colas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_colas.Location = new System.Drawing.Point(16, 197);
            this.dg_colas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_colas.Name = "dg_colas";
            this.dg_colas.ReadOnly = true;
            this.dg_colas.RowHeadersWidth = 51;
            this.dg_colas.Size = new System.Drawing.Size(1772, 631);
            this.dg_colas.TabIndex = 25;
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.Location = new System.Drawing.Point(621, 102);
            this.lbl_desde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(447, 31);
            this.lbl_desde.TabIndex = 26;
            this.lbl_desde.Text = "Ingrese desde que iteración mostrar";
            // 
            // txt_desde
            // 
            this.txt_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desde.Location = new System.Drawing.Point(1537, 102);
            this.txt_desde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_desde.Mask = "999999";
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(104, 34);
            this.txt_desde.TabIndex = 27;
            this.txt_desde.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_clientes_se_van_cola_llena);
            this.groupBox1.Controls.Add(this.lbl_maximo_tiempo_entre_llegadas);
            this.groupBox1.Controls.Add(this.lbl_tiempo_medio_cliente_cola_caseta);
            this.groupBox1.Controls.Add(this.lbl_tiempo_medio_cliente_caseta);
            this.groupBox1.Controls.Add(this.lbl_tiempo_medio_cola_nave);
            this.groupBox1.Controls.Add(this.lbl_tiempo_medio_cliente_nave);
            this.groupBox1.Controls.Add(this.lbl_longitud_media_cola_nave);
            this.groupBox1.Controls.Add(this.lbl_tiempo_medio_cliente_ITV);
            this.groupBox1.Controls.Add(this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.groupBox1.Location = new System.Drawing.Point(16, 1743);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1772, 400);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Métricas";
            // 
            // lbl_clientes_se_van_cola_llena
            // 
            this.lbl_clientes_se_van_cola_llena.AutoSize = true;
            this.lbl_clientes_se_van_cola_llena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_clientes_se_van_cola_llena.Location = new System.Drawing.Point(27, 350);
            this.lbl_clientes_se_van_cola_llena.Name = "lbl_clientes_se_van_cola_llena";
            this.lbl_clientes_se_van_cola_llena.Size = new System.Drawing.Size(926, 31);
            this.lbl_clientes_se_van_cola_llena.TabIndex = 45;
            this.lbl_clientes_se_van_cola_llena.Text = "Cantidad de clientes que se van del sistema porque no hay lugar en la cola: ";
            // 
            // lbl_maximo_tiempo_entre_llegadas
            // 
            this.lbl_maximo_tiempo_entre_llegadas.AutoSize = true;
            this.lbl_maximo_tiempo_entre_llegadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_maximo_tiempo_entre_llegadas.Location = new System.Drawing.Point(27, 309);
            this.lbl_maximo_tiempo_entre_llegadas.Name = "lbl_maximo_tiempo_entre_llegadas";
            this.lbl_maximo_tiempo_entre_llegadas.Size = new System.Drawing.Size(653, 31);
            this.lbl_maximo_tiempo_entre_llegadas.TabIndex = 44;
            this.lbl_maximo_tiempo_entre_llegadas.Text = "Máximo tiempo entre llegadas de clientes al sistema: ";
            // 
            // lbl_tiempo_medio_cliente_cola_caseta
            // 
            this.lbl_tiempo_medio_cliente_cola_caseta.AutoSize = true;
            this.lbl_tiempo_medio_cliente_cola_caseta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_cliente_cola_caseta.Location = new System.Drawing.Point(27, 270);
            this.lbl_tiempo_medio_cliente_cola_caseta.Name = "lbl_tiempo_medio_cliente_cola_caseta";
            this.lbl_tiempo_medio_cliente_cola_caseta.Size = new System.Drawing.Size(708, 31);
            this.lbl_tiempo_medio_cliente_cola_caseta.TabIndex = 43;
            this.lbl_tiempo_medio_cliente_cola_caseta.Text = "Tiempo medio que un cliente pasa en la cola de la caseta:";
            // 
            // lbl_tiempo_medio_cliente_caseta
            // 
            this.lbl_tiempo_medio_cliente_caseta.AutoSize = true;
            this.lbl_tiempo_medio_cliente_caseta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_cliente_caseta.Location = new System.Drawing.Point(27, 229);
            this.lbl_tiempo_medio_cliente_caseta.Name = "lbl_tiempo_medio_cliente_caseta";
            this.lbl_tiempo_medio_cliente_caseta.Size = new System.Drawing.Size(760, 31);
            this.lbl_tiempo_medio_cliente_caseta.TabIndex = 42;
            this.lbl_tiempo_medio_cliente_caseta.Text = "Tiempo medio que un cliente pasa en la caseta (incluye cola): ";
            // 
            // lbl_tiempo_medio_cola_nave
            // 
            this.lbl_tiempo_medio_cola_nave.AutoSize = true;
            this.lbl_tiempo_medio_cola_nave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_cola_nave.Location = new System.Drawing.Point(27, 190);
            this.lbl_tiempo_medio_cola_nave.Name = "lbl_tiempo_medio_cola_nave";
            this.lbl_tiempo_medio_cola_nave.Size = new System.Drawing.Size(693, 31);
            this.lbl_tiempo_medio_cola_nave.TabIndex = 41;
            this.lbl_tiempo_medio_cola_nave.Text = "Tiempo medio que un cliente pasa en la cola de la nave: ";
            // 
            // lbl_tiempo_medio_cliente_nave
            // 
            this.lbl_tiempo_medio_cliente_nave.AutoSize = true;
            this.lbl_tiempo_medio_cliente_nave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_cliente_nave.Location = new System.Drawing.Point(27, 149);
            this.lbl_tiempo_medio_cliente_nave.Name = "lbl_tiempo_medio_cliente_nave";
            this.lbl_tiempo_medio_cliente_nave.Size = new System.Drawing.Size(738, 31);
            this.lbl_tiempo_medio_cliente_nave.TabIndex = 40;
            this.lbl_tiempo_medio_cliente_nave.Text = "Tiempo medio que un cliente pasa en la nave (incluye cola): ";
            // 
            // lbl_longitud_media_cola_nave
            // 
            this.lbl_longitud_media_cola_nave.AutoSize = true;
            this.lbl_longitud_media_cola_nave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_longitud_media_cola_nave.Location = new System.Drawing.Point(27, 110);
            this.lbl_longitud_media_cola_nave.Name = "lbl_longitud_media_cola_nave";
            this.lbl_longitud_media_cola_nave.Size = new System.Drawing.Size(459, 31);
            this.lbl_longitud_media_cola_nave.TabIndex = 39;
            this.lbl_longitud_media_cola_nave.Text = "Longitud media de la cola de la nave:";
            // 
            // lbl_tiempo_medio_cliente_ITV
            // 
            this.lbl_tiempo_medio_cliente_ITV.AutoSize = true;
            this.lbl_tiempo_medio_cliente_ITV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_cliente_ITV.Location = new System.Drawing.Point(27, 69);
            this.lbl_tiempo_medio_cliente_ITV.Name = "lbl_tiempo_medio_cliente_ITV";
            this.lbl_tiempo_medio_cliente_ITV.Size = new System.Drawing.Size(653, 31);
            this.lbl_tiempo_medio_cliente_ITV.TabIndex = 38;
            this.lbl_tiempo_medio_cliente_ITV.Text = "Tiempo medio que un cliente se encuentra en la ITV: ";
            // 
            // lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina
            // 
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.AutoSize = true;
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Location = new System.Drawing.Point(27, 30);
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Name = "lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina";
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Size = new System.Drawing.Size(758, 31);
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.TabIndex = 37;
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Text = "Tiempo medio que un cliente pasa en la oficina (incluye cola): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1763, 1231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 46;
            // 
            // dg_atentados
            // 
            this.dg_atentados.AllowUserToAddRows = false;
            this.dg_atentados.AllowUserToDeleteRows = false;
            this.dg_atentados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_atentados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_atentados.Location = new System.Drawing.Point(16, 896);
            this.dg_atentados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_atentados.Name = "dg_atentados";
            this.dg_atentados.RowHeadersWidth = 15;
            this.dg_atentados.Size = new System.Drawing.Size(1740, 235);
            this.dg_atentados.TabIndex = 47;
            // 
            // dg_bloqueo_llegadas
            // 
            this.dg_bloqueo_llegadas.AllowUserToAddRows = false;
            this.dg_bloqueo_llegadas.AllowUserToDeleteRows = false;
            this.dg_bloqueo_llegadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_bloqueo_llegadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_bloqueo_llegadas.Location = new System.Drawing.Point(16, 1198);
            this.dg_bloqueo_llegadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_bloqueo_llegadas.Name = "dg_bloqueo_llegadas";
            this.dg_bloqueo_llegadas.RowHeadersWidth = 20;
            this.dg_bloqueo_llegadas.Size = new System.Drawing.Size(1740, 235);
            this.dg_bloqueo_llegadas.TabIndex = 47;
            // 
            // dg_bloqueo_servidor
            // 
            this.dg_bloqueo_servidor.AllowUserToAddRows = false;
            this.dg_bloqueo_servidor.AllowUserToDeleteRows = false;
            this.dg_bloqueo_servidor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_bloqueo_servidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_bloqueo_servidor.Location = new System.Drawing.Point(16, 1502);
            this.dg_bloqueo_servidor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_bloqueo_servidor.Name = "dg_bloqueo_servidor";
            this.dg_bloqueo_servidor.RowHeadersWidth = 51;
            this.dg_bloqueo_servidor.Size = new System.Drawing.Size(1740, 235);
            this.dg_bloqueo_servidor.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1116, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 31);
            this.label3.TabIndex = 48;
            this.label3.Text = "Paso del runge kutta (h)";
            // 
            // txt_h
            // 
            this.txt_h.Enabled = false;
            this.txt_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_h.Location = new System.Drawing.Point(1439, 144);
            this.txt_h.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_h.Name = "txt_h";
            this.txt_h.Size = new System.Drawing.Size(203, 34);
            this.txt_h.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 862);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 31);
            this.label4.TabIndex = 48;
            this.label4.Text = "dA/dt = β * A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(765, 862);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 31);
            this.label5.TabIndex = 48;
            this.label5.Text = "t = 0";
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_A.Location = new System.Drawing.Point(924, 862);
            this.lbl_A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(388, 31);
            this.lbl_A.TabIndex = 48;
            this.lbl_A.Text = "A(0) = reloj en la llegada nro 80";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 1161);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 31);
            this.label7.TabIndex = 48;
            this.label7.Text = "dL/dt = -((L/0,8).t^2)-L";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(765, 1161);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 31);
            this.label8.TabIndex = 48;
            this.label8.Text = "t = 0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(924, 1161);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 31);
            this.label9.TabIndex = 48;
            this.label9.Text = "L(0) = reloj";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(404, 862);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(300, 31);
            this.label10.TabIndex = 48;
            this.label10.Text = "Condiciones iniciales ->";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(404, 1161);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(300, 31);
            this.label11.TabIndex = 48;
            this.label11.Text = "Condiciones iniciales ->";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(404, 1465);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(300, 31);
            this.label12.TabIndex = 48;
            this.label12.Text = "Condiciones iniciales ->";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 1465);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(265, 31);
            this.label13.TabIndex = 48;
            this.label13.Text = "dS/dt = 0,2 * S + 3 - t";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(765, 1465);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 31);
            this.label14.TabIndex = 48;
            this.label14.Text = "t = 0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(924, 1465);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 31);
            this.label15.TabIndex = 48;
            this.label15.Text = "S(0) = reloj";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1163, 1161);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(214, 31);
            this.label16.TabIndex = 48;
            this.label16.Text = "t = 1 ≡ 5 minutos";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1163, 1465);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(214, 31);
            this.label17.TabIndex = 48;
            this.label17.Text = "t = 1 ≡ 2 minutos";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1389, 862);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(214, 31);
            this.label18.TabIndex = 48;
            this.label18.Text = "t = 1 ≡ 9 minutos";
            // 
            // dg_atentados2
            // 
            this.dg_atentados2.AllowUserToAddRows = false;
            this.dg_atentados2.AllowUserToDeleteRows = false;
            this.dg_atentados2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_atentados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_atentados2.Location = new System.Drawing.Point(1791, 896);
            this.dg_atentados2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_atentados2.Name = "dg_atentados2";
            this.dg_atentados2.RowHeadersWidth = 15;
            this.dg_atentados2.Size = new System.Drawing.Size(27, 235);
            this.dg_atentados2.TabIndex = 47;
            // 
            // dg_atentados3
            // 
            this.dg_atentados3.AllowUserToAddRows = false;
            this.dg_atentados3.AllowUserToDeleteRows = false;
            this.dg_atentados3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_atentados3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_atentados3.Location = new System.Drawing.Point(1826, 896);
            this.dg_atentados3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_atentados3.Name = "dg_atentados3";
            this.dg_atentados3.RowHeadersWidth = 15;
            this.dg_atentados3.Size = new System.Drawing.Size(22, 235);
            this.dg_atentados3.TabIndex = 47;
            // 
            // dg_bloqueo_llegadas2
            // 
            this.dg_bloqueo_llegadas2.AllowUserToAddRows = false;
            this.dg_bloqueo_llegadas2.AllowUserToDeleteRows = false;
            this.dg_bloqueo_llegadas2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_bloqueo_llegadas2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_bloqueo_llegadas2.Location = new System.Drawing.Point(1796, 1198);
            this.dg_bloqueo_llegadas2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_bloqueo_llegadas2.Name = "dg_bloqueo_llegadas2";
            this.dg_bloqueo_llegadas2.RowHeadersWidth = 20;
            this.dg_bloqueo_llegadas2.Size = new System.Drawing.Size(22, 235);
            this.dg_bloqueo_llegadas2.TabIndex = 47;
            // 
            // dg_bloqueo_servidor2
            // 
            this.dg_bloqueo_servidor2.AllowUserToAddRows = false;
            this.dg_bloqueo_servidor2.AllowUserToDeleteRows = false;
            this.dg_bloqueo_servidor2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_bloqueo_servidor2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_bloqueo_servidor2.Location = new System.Drawing.Point(1796, 1502);
            this.dg_bloqueo_servidor2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_bloqueo_servidor2.Name = "dg_bloqueo_servidor2";
            this.dg_bloqueo_servidor2.RowHeadersWidth = 51;
            this.dg_bloqueo_servidor2.Size = new System.Drawing.Size(22, 235);
            this.dg_bloqueo_servidor2.TabIndex = 47;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(16, 2145);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 31);
            this.label19.TabIndex = 50;
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1852, 1100);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_h);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_A);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg_bloqueo_servidor2);
            this.Controls.Add(this.dg_bloqueo_servidor);
            this.Controls.Add(this.dg_bloqueo_llegadas2);
            this.Controls.Add(this.dg_bloqueo_llegadas);
            this.Controls.Add(this.dg_atentados3);
            this.Controls.Add(this.dg_atentados2);
            this.Controls.Add(this.dg_atentados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_desde);
            this.Controls.Add(this.lbl_desde);
            this.Controls.Add(this.dg_colas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.btn_cerrar_programa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Simulacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulacion";
            this.Load += new System.EventHandler(this.Simulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_colas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_atentados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bloqueo_llegadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bloqueo_servidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_atentados2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_atentados3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bloqueo_llegadas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bloqueo_servidor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar_programa;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_colas;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.MaskedTextBox txt_desde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_clientes_se_van_cola_llena;
        private System.Windows.Forms.Label lbl_maximo_tiempo_entre_llegadas;
        private System.Windows.Forms.Label lbl_tiempo_medio_cliente_cola_caseta;
        private System.Windows.Forms.Label lbl_tiempo_medio_cliente_caseta;
        private System.Windows.Forms.Label lbl_tiempo_medio_cola_nave;
        private System.Windows.Forms.Label lbl_tiempo_medio_cliente_nave;
        private System.Windows.Forms.Label lbl_longitud_media_cola_nave;
        private System.Windows.Forms.Label lbl_tiempo_medio_cliente_ITV;
        private System.Windows.Forms.Label lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_atentados;
        private System.Windows.Forms.DataGridView dg_bloqueo_llegadas;
        private System.Windows.Forms.DataGridView dg_bloqueo_servidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_h;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dg_atentados2;
        private System.Windows.Forms.DataGridView dg_atentados3;
        private System.Windows.Forms.DataGridView dg_bloqueo_llegadas2;
        private System.Windows.Forms.DataGridView dg_bloqueo_servidor2;
        private System.Windows.Forms.Label label19;
    }
}