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
            ((System.ComponentModel.ISupportInitialize)(this.dg_colas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar_programa
            // 
            this.btn_cerrar_programa.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_programa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_programa.BackgroundImage")));
            this.btn_cerrar_programa.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_programa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_programa.Location = new System.Drawing.Point(1733, 13);
            this.btn_cerrar_programa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar_programa.Name = "btn_cerrar_programa";
            this.btn_cerrar_programa.Size = new System.Drawing.Size(55, 50);
            this.btn_cerrar_programa.TabIndex = 17;
            this.btn_cerrar_programa.UseVisualStyleBackColor = false;
            this.btn_cerrar_programa.Click += new System.EventHandler(this.btn_cerrar_programa_Click);
            // 
            // btn_simular
            // 
            this.btn_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.Location = new System.Drawing.Point(1649, 119);
            this.btn_simular.Margin = new System.Windows.Forms.Padding(4);
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
            this.btn_volver.Location = new System.Drawing.Point(16, 122);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4);
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
            this.dg_colas.Location = new System.Drawing.Point(16, 186);
            this.dg_colas.Margin = new System.Windows.Forms.Padding(4);
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
            this.lbl_desde.Location = new System.Drawing.Point(621, 124);
            this.lbl_desde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(447, 31);
            this.lbl_desde.TabIndex = 26;
            this.lbl_desde.Text = "Ingrese desde que iteración mostrar";
            // 
            // txt_desde
            // 
            this.txt_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desde.Location = new System.Drawing.Point(1537, 123);
            this.txt_desde.Margin = new System.Windows.Forms.Padding(4);
            this.txt_desde.Mask = "9999999";
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
            this.groupBox1.Location = new System.Drawing.Point(16, 824);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1772, 400);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Métricas";
            // 
            // lbl_clientes_se_van_cola_llena
            // 
            this.lbl_clientes_se_van_cola_llena.AutoSize = true;
            this.lbl_clientes_se_van_cola_llena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_clientes_se_van_cola_llena.Location = new System.Drawing.Point(26, 349);
            this.lbl_clientes_se_van_cola_llena.Name = "lbl_clientes_se_van_cola_llena";
            this.lbl_clientes_se_van_cola_llena.Size = new System.Drawing.Size(926, 31);
            this.lbl_clientes_se_van_cola_llena.TabIndex = 45;
            this.lbl_clientes_se_van_cola_llena.Text = "Cantidad de clientes que se van del sistema porque no hay lugar en la cola: ";
            // 
            // lbl_maximo_tiempo_entre_llegadas
            // 
            this.lbl_maximo_tiempo_entre_llegadas.AutoSize = true;
            this.lbl_maximo_tiempo_entre_llegadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_maximo_tiempo_entre_llegadas.Location = new System.Drawing.Point(26, 309);
            this.lbl_maximo_tiempo_entre_llegadas.Name = "lbl_maximo_tiempo_entre_llegadas";
            this.lbl_maximo_tiempo_entre_llegadas.Size = new System.Drawing.Size(653, 31);
            this.lbl_maximo_tiempo_entre_llegadas.TabIndex = 44;
            this.lbl_maximo_tiempo_entre_llegadas.Text = "Máximo tiempo entre llegadas de clientes al sistema: ";
            // 
            // lbl_tiempo_medio_cliente_cola_caseta
            // 
            this.lbl_tiempo_medio_cliente_cola_caseta.AutoSize = true;
            this.lbl_tiempo_medio_cliente_cola_caseta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_cliente_cola_caseta.Location = new System.Drawing.Point(26, 269);
            this.lbl_tiempo_medio_cliente_cola_caseta.Name = "lbl_tiempo_medio_cliente_cola_caseta";
            this.lbl_tiempo_medio_cliente_cola_caseta.Size = new System.Drawing.Size(708, 31);
            this.lbl_tiempo_medio_cliente_cola_caseta.TabIndex = 43;
            this.lbl_tiempo_medio_cliente_cola_caseta.Text = "Tiempo medio que un cliente pasa en la cola de la caseta:";
            // 
            // lbl_tiempo_medio_cliente_caseta
            // 
            this.lbl_tiempo_medio_cliente_caseta.AutoSize = true;
            this.lbl_tiempo_medio_cliente_caseta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_cliente_caseta.Location = new System.Drawing.Point(26, 229);
            this.lbl_tiempo_medio_cliente_caseta.Name = "lbl_tiempo_medio_cliente_caseta";
            this.lbl_tiempo_medio_cliente_caseta.Size = new System.Drawing.Size(760, 31);
            this.lbl_tiempo_medio_cliente_caseta.TabIndex = 42;
            this.lbl_tiempo_medio_cliente_caseta.Text = "Tiempo medio que un cliente pasa en la caseta (incluye cola): ";
            // 
            // lbl_tiempo_medio_cola_nave
            // 
            this.lbl_tiempo_medio_cola_nave.AutoSize = true;
            this.lbl_tiempo_medio_cola_nave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_cola_nave.Location = new System.Drawing.Point(26, 189);
            this.lbl_tiempo_medio_cola_nave.Name = "lbl_tiempo_medio_cola_nave";
            this.lbl_tiempo_medio_cola_nave.Size = new System.Drawing.Size(693, 31);
            this.lbl_tiempo_medio_cola_nave.TabIndex = 41;
            this.lbl_tiempo_medio_cola_nave.Text = "Tiempo medio que un cliente pasa en la cola de la nave: ";
            // 
            // lbl_tiempo_medio_cliente_nave
            // 
            this.lbl_tiempo_medio_cliente_nave.AutoSize = true;
            this.lbl_tiempo_medio_cliente_nave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_cliente_nave.Location = new System.Drawing.Point(26, 149);
            this.lbl_tiempo_medio_cliente_nave.Name = "lbl_tiempo_medio_cliente_nave";
            this.lbl_tiempo_medio_cliente_nave.Size = new System.Drawing.Size(738, 31);
            this.lbl_tiempo_medio_cliente_nave.TabIndex = 40;
            this.lbl_tiempo_medio_cliente_nave.Text = "Tiempo medio que un cliente pasa en la nave (incluye cola): ";
            // 
            // lbl_longitud_media_cola_nave
            // 
            this.lbl_longitud_media_cola_nave.AutoSize = true;
            this.lbl_longitud_media_cola_nave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_longitud_media_cola_nave.Location = new System.Drawing.Point(26, 109);
            this.lbl_longitud_media_cola_nave.Name = "lbl_longitud_media_cola_nave";
            this.lbl_longitud_media_cola_nave.Size = new System.Drawing.Size(459, 31);
            this.lbl_longitud_media_cola_nave.TabIndex = 39;
            this.lbl_longitud_media_cola_nave.Text = "Longitud media de la cola de la nave:";
            // 
            // lbl_tiempo_medio_cliente_ITV
            // 
            this.lbl_tiempo_medio_cliente_ITV.AutoSize = true;
            this.lbl_tiempo_medio_cliente_ITV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_cliente_ITV.Location = new System.Drawing.Point(26, 69);
            this.lbl_tiempo_medio_cliente_ITV.Name = "lbl_tiempo_medio_cliente_ITV";
            this.lbl_tiempo_medio_cliente_ITV.Size = new System.Drawing.Size(653, 31);
            this.lbl_tiempo_medio_cliente_ITV.TabIndex = 38;
            this.lbl_tiempo_medio_cliente_ITV.Text = "Tiempo medio que un cliente se encuentra en la ITV: ";
            // 
            // lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina
            // 
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.AutoSize = true;
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Location = new System.Drawing.Point(26, 29);
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Name = "lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina";
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Size = new System.Drawing.Size(758, 31);
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.TabIndex = 37;
            this.lbl_tiempo_medio_que_un_cliente_pasa_en_la_oficina.Text = "Tiempo medio que un cliente pasa en la oficina (incluye cola): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1762, 1231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 46;
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1852, 1147);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Simulacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulacion";
            this.Load += new System.EventHandler(this.Simulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_colas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}