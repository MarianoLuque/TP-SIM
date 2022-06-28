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
            ((System.ComponentModel.ISupportInitialize)(this.dg_colas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_atentados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bloqueo_llegadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bloqueo_servidor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar_programa
            // 
            this.btn_cerrar_programa.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_programa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_programa.BackgroundImage")));
            this.btn_cerrar_programa.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_programa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_programa.Location = new System.Drawing.Point(1300, 11);
            this.btn_cerrar_programa.Name = "btn_cerrar_programa";
            this.btn_cerrar_programa.Size = new System.Drawing.Size(41, 41);
            this.btn_cerrar_programa.TabIndex = 17;
            this.btn_cerrar_programa.UseVisualStyleBackColor = false;
            this.btn_cerrar_programa.Click += new System.EventHandler(this.btn_cerrar_programa_Click);
            // 
            // btn_simular
            // 
            this.btn_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.Location = new System.Drawing.Point(1237, 97);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(104, 34);
            this.btn_simular.TabIndex = 22;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(12, 99);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(104, 34);
            this.btn_volver.TabIndex = 23;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 42);
            this.label1.TabIndex = 24;
            this.label1.Text = "Simulación de colas - ITV";
            // 
            // dg_colas
            // 
            this.dg_colas.AllowUserToAddRows = false;
            this.dg_colas.AllowUserToDeleteRows = false;
            this.dg_colas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_colas.Location = new System.Drawing.Point(12, 151);
            this.dg_colas.Name = "dg_colas";
            this.dg_colas.ReadOnly = true;
            this.dg_colas.RowHeadersWidth = 51;
            this.dg_colas.Size = new System.Drawing.Size(1329, 513);
            this.dg_colas.TabIndex = 25;
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.Location = new System.Drawing.Point(466, 101);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(356, 25);
            this.lbl_desde.TabIndex = 26;
            this.lbl_desde.Text = "Ingrese desde que iteración mostrar";
            // 
            // txt_desde
            // 
            this.txt_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desde.Location = new System.Drawing.Point(1153, 100);
            this.txt_desde.Mask = "9999999";
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(79, 29);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 1321);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1329, 325);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Métricas";
            // 
            // lbl_clientes_se_van_cola_llena
            // 
            this.lbl_clientes_se_van_cola_llena.AutoSize = true;
            this.lbl_clientes_se_van_cola_llena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_clientes_se_van_cola_llena.Location = new System.Drawing.Point(20, 284);
            this.lbl_clientes_se_van_cola_llena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_clientes_se_van_cola_llena.Name = "lbl_clientes_se_van_cola_llena";
            this.lbl_clientes_se_van_cola_llena.Size = new System.Drawing.Size(744, 25);
            this.lbl_clientes_se_van_cola_llena.TabIndex = 45;
            this.lbl_clientes_se_van_cola_llena.Text = "Cantidad de clientes que se van del sistema porque no hay lugar en la cola: ";
            // 
            // lbl_maximo_tiempo_entre_llegadas
            // 
            this.lbl_maximo_tiempo_entre_llegadas.AutoSize = true;
            this.lbl_maximo_tiempo_entre_llegadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_maximo_tiempo_entre_llegadas.Location = new System.Drawing.Point(20, 251);
            this.lbl_maximo_tiempo_entre_llegadas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_maximo_tiempo_entre_llegadas.Name = "lbl_maximo_tiempo_entre_llegadas";
            this.lbl_maximo_tiempo_entre_llegadas.Size = new System.Drawing.Size(524, 25);
            this.lbl_maximo_tiempo_entre_llegadas.TabIndex = 44;
            this.lbl_maximo_tiempo_entre_llegadas.Text = "Máximo tiempo entre llegadas de clientes al sistema: ";
            // 
            // lbl_tiempo_medio_cliente_cola_caseta
            // 
            this.lbl_tiempo_medio_cliente_cola_caseta.AutoSize = true;
            this.lbl_tiempo_medio_cliente_cola_caseta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_cliente_cola_caseta.Location = new System.Drawing.Point(20, 219);
            this.lbl_tiempo_medio_cliente_cola_caseta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tiempo_medio_cliente_cola_caseta.Name = "lbl_tiempo_medio_cliente_cola_caseta";
            this.lbl_tiempo_medio_cliente_cola_caseta.Size = new System.Drawing.Size(569, 25);
            this.lbl_tiempo_medio_cliente_cola_caseta.TabIndex = 43;
            this.lbl_tiempo_medio_cliente_cola_caseta.Text = "Tiempo medio que un cliente pasa en la cola de la caseta:";
            // 
            // lbl_tiempo_medio_cliente_caseta
            // 
            this.lbl_tiempo_medio_cliente_caseta.AutoSize = true;
            this.lbl_tiempo_medio_cliente_caseta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_cliente_caseta.Location = new System.Drawing.Point(20, 186);
            this.lbl_tiempo_medio_cliente_caseta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tiempo_medio_cliente_caseta.Name = "lbl_tiempo_medio_cliente_caseta";
            this.lbl_tiempo_medio_cliente_caseta.Size = new System.Drawing.Size(610, 25);
            this.lbl_tiempo_medio_cliente_caseta.TabIndex = 42;
            this.lbl_tiempo_medio_cliente_caseta.Text = "Tiempo medio que un cliente pasa en la caseta (incluye cola): ";
            // 
            // lbl_tiempo_medio_cola_nave
            // 
            this.lbl_tiempo_medio_cola_nave.AutoSize = true;
            this.lbl_tiempo_medio_cola_nave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_cola_nave.Location = new System.Drawing.Point(20, 154);
            this.lbl_tiempo_medio_cola_nave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tiempo_medio_cola_nave.Name = "lbl_tiempo_medio_cola_nave";
            this.lbl_tiempo_medio_cola_nave.Size = new System.Drawing.Size(558, 25);
            this.lbl_tiempo_medio_cola_nave.TabIndex = 41;
            this.lbl_tiempo_medio_cola_nave.Text = "Tiempo medio que un cliente pasa en la cola de la nave: ";
            // 
            // lbl_tiempo_medio_cliente_nave
            // 
            this.lbl_tiempo_medio_cliente_nave.AutoSize = true;
            this.lbl_tiempo_medio_cliente_nave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_cliente_nave.Location = new System.Drawing.Point(20, 121);
            this.lbl_tiempo_medio_cliente_nave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tiempo_medio_cliente_nave.Name = "lbl_tiempo_medio_cliente_nave";
            this.lbl_tiempo_medio_cliente_nave.Size = new System.Drawing.Size(593, 25);
            this.lbl_tiempo_medio_cliente_nave.TabIndex = 40;
            this.lbl_tiempo_medio_cliente_nave.Text = "Tiempo medio que un cliente pasa en la nave (incluye cola): ";
            // 
            // lbl_longitud_media_cola_nave
            // 
            this.lbl_longitud_media_cola_nave.AutoSize = true;
            this.lbl_longitud_media_cola_nave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_longitud_media_cola_nave.Location = new System.Drawing.Point(20, 89);
            this.lbl_longitud_media_cola_nave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_longitud_media_cola_nave.Name = "lbl_longitud_media_cola_nave";
            this.lbl_longitud_media_cola_nave.Size = new System.Drawing.Size(370, 25);
            this.lbl_longitud_media_cola_nave.TabIndex = 39;
            this.lbl_longitud_media_cola_nave.Text = "Longitud media de la cola de la nave:";
            // 
            // lbl_tiempo_medio_cliente_ITV
            // 
            this.lbl_tiempo_medio_cliente_ITV.AutoSize = true;
            this.lbl_tiempo_medio_cliente_ITV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_cliente_ITV.Location = new System.Drawing.Point(20, 56);
            this.lbl_tiempo_medio_cliente_ITV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tiempo_medio_cliente_ITV.Name = "lbl_tiempo_medio_cliente_ITV";
            this.lbl_tiempo_medio_cliente_ITV.Size = new System.Drawing.Size(522, 25);
            this.lbl_tiempo_medio_cliente_ITV.TabIndex = 38;
            this.lbl_tiempo_medio_cliente_ITV.Text = "Tiempo medio que un cliente se encuentra en la ITV: ";
            // 
            // lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina
            // 
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.AutoSize = true;
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Location = new System.Drawing.Point(20, 24);
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Name = "lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina";
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Size = new System.Drawing.Size(609, 25);
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.TabIndex = 37;
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Text = "Tiempo medio que un cliente pasa en la oficina (incluye cola): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1322, 1000);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 46;
            // 
            // dg_atentados
            // 
            this.dg_atentados.AllowUserToAddRows = false;
            this.dg_atentados.AllowUserToDeleteRows = false;
            this.dg_atentados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_atentados.Location = new System.Drawing.Point(12, 680);
            this.dg_atentados.Name = "dg_atentados";
            this.dg_atentados.Size = new System.Drawing.Size(1329, 191);
            this.dg_atentados.TabIndex = 47;
            // 
            // dg_bloqueo_llegadas
            // 
            this.dg_bloqueo_llegadas.AllowUserToAddRows = false;
            this.dg_bloqueo_llegadas.AllowUserToDeleteRows = false;
            this.dg_bloqueo_llegadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_bloqueo_llegadas.Location = new System.Drawing.Point(12, 887);
            this.dg_bloqueo_llegadas.Name = "dg_bloqueo_llegadas";
            this.dg_bloqueo_llegadas.Size = new System.Drawing.Size(1329, 191);
            this.dg_bloqueo_llegadas.TabIndex = 47;
            // 
            // dg_bloqueo_servidor
            // 
            this.dg_bloqueo_servidor.AllowUserToAddRows = false;
            this.dg_bloqueo_servidor.AllowUserToDeleteRows = false;
            this.dg_bloqueo_servidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_bloqueo_servidor.Location = new System.Drawing.Point(12, 1094);
            this.dg_bloqueo_servidor.Name = "dg_bloqueo_servidor";
            this.dg_bloqueo_servidor.Size = new System.Drawing.Size(1329, 191);
            this.dg_bloqueo_servidor.TabIndex = 47;
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1389, 894);
            this.Controls.Add(this.dg_bloqueo_servidor);
            this.Controls.Add(this.dg_bloqueo_llegadas);
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
    }
}