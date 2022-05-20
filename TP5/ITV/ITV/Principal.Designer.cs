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
            this.txt_cantidad_simulaciones = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cantidad_clientes_llegadas = new System.Windows.Forms.MaskedTextBox();
            this.txt_minutos_llegadas = new System.Windows.Forms.MaskedTextBox();
            this.lbl_hs = new System.Windows.Forms.Label();
            this.lbl_barcos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cantidad_clientes_caseta = new System.Windows.Forms.MaskedTextBox();
            this.txt_cantidad_clientes_nave = new System.Windows.Forms.MaskedTextBox();
            this.txt_cantidad_clientes_oficina = new System.Windows.Forms.MaskedTextBox();
            this.txt_minutos_caseta = new System.Windows.Forms.MaskedTextBox();
            this.txt_minutos_oficina = new System.Windows.Forms.MaskedTextBox();
            this.txt_minutos_nave = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_cantidad_maxima_cola = new System.Windows.Forms.MaskedTextBox();
            this.btn_simular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar_programa
            // 
            this.btn_cerrar_programa.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_programa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_programa.BackgroundImage")));
            this.btn_cerrar_programa.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_programa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_programa.Location = new System.Drawing.Point(821, 12);
            this.btn_cerrar_programa.Name = "btn_cerrar_programa";
            this.btn_cerrar_programa.Size = new System.Drawing.Size(41, 41);
            this.btn_cerrar_programa.TabIndex = 16;
            this.btn_cerrar_programa.UseVisualStyleBackColor = false;
            this.btn_cerrar_programa.Click += new System.EventHandler(this.btn_cerrar_programa_Click);
            // 
            // txt_cantidad_simulaciones
            // 
            this.txt_cantidad_simulaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_simulaciones.Location = new System.Drawing.Point(558, 85);
            this.txt_cantidad_simulaciones.Mask = "99999";
            this.txt_cantidad_simulaciones.Name = "txt_cantidad_simulaciones";
            this.txt_cantidad_simulaciones.Size = new System.Drawing.Size(168, 29);
            this.txt_cantidad_simulaciones.TabIndex = 17;
            this.txt_cantidad_simulaciones.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ingrese la cantidad de minutos a simular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 42);
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
            this.groupBox1.Location = new System.Drawing.Point(47, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 226);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Probabilidad de Eventos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Llegada de clientes al sistema:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fin atencion caseta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fin atencion nave:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fin atencion oficina:";
            // 
            // txt_cantidad_clientes_llegadas
            // 
            this.txt_cantidad_clientes_llegadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_clientes_llegadas.Location = new System.Drawing.Point(323, 53);
            this.txt_cantidad_clientes_llegadas.Mask = "999";
            this.txt_cantidad_clientes_llegadas.Name = "txt_cantidad_clientes_llegadas";
            this.txt_cantidad_clientes_llegadas.Size = new System.Drawing.Size(84, 29);
            this.txt_cantidad_clientes_llegadas.TabIndex = 22;
            this.txt_cantidad_clientes_llegadas.ValidatingType = typeof(int);
            // 
            // txt_minutos_llegadas
            // 
            this.txt_minutos_llegadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_minutos_llegadas.Location = new System.Drawing.Point(511, 53);
            this.txt_minutos_llegadas.Mask = "999";
            this.txt_minutos_llegadas.Name = "txt_minutos_llegadas";
            this.txt_minutos_llegadas.Size = new System.Drawing.Size(79, 29);
            this.txt_minutos_llegadas.TabIndex = 23;
            this.txt_minutos_llegadas.ValidatingType = typeof(int);
            // 
            // lbl_hs
            // 
            this.lbl_hs.AutoSize = true;
            this.lbl_hs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hs.Location = new System.Drawing.Point(596, 56);
            this.lbl_hs.Name = "lbl_hs";
            this.lbl_hs.Size = new System.Drawing.Size(76, 24);
            this.lbl_hs.TabIndex = 25;
            this.lbl_hs.Text = "minutos";
            // 
            // lbl_barcos
            // 
            this.lbl_barcos.AutoSize = true;
            this.lbl_barcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barcos.Location = new System.Drawing.Point(411, 56);
            this.lbl_barcos.Name = "lbl_barcos";
            this.lbl_barcos.Size = new System.Drawing.Size(101, 24);
            this.lbl_barcos.TabIndex = 24;
            this.lbl_barcos.Text = "clientes en";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(411, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "clientes en";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(596, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "minutos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(411, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "clientes en";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(596, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "minutos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(411, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 24);
            this.label11.TabIndex = 24;
            this.label11.Text = "clientes en";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(596, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "minutos";
            // 
            // txt_cantidad_clientes_caseta
            // 
            this.txt_cantidad_clientes_caseta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_clientes_caseta.Location = new System.Drawing.Point(321, 92);
            this.txt_cantidad_clientes_caseta.Mask = "999";
            this.txt_cantidad_clientes_caseta.Name = "txt_cantidad_clientes_caseta";
            this.txt_cantidad_clientes_caseta.Size = new System.Drawing.Size(84, 29);
            this.txt_cantidad_clientes_caseta.TabIndex = 22;
            this.txt_cantidad_clientes_caseta.ValidatingType = typeof(int);
            // 
            // txt_cantidad_clientes_nave
            // 
            this.txt_cantidad_clientes_nave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_clientes_nave.Location = new System.Drawing.Point(321, 131);
            this.txt_cantidad_clientes_nave.Mask = "999";
            this.txt_cantidad_clientes_nave.Name = "txt_cantidad_clientes_nave";
            this.txt_cantidad_clientes_nave.Size = new System.Drawing.Size(84, 29);
            this.txt_cantidad_clientes_nave.TabIndex = 22;
            this.txt_cantidad_clientes_nave.ValidatingType = typeof(int);
            // 
            // txt_cantidad_clientes_oficina
            // 
            this.txt_cantidad_clientes_oficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_clientes_oficina.Location = new System.Drawing.Point(321, 170);
            this.txt_cantidad_clientes_oficina.Mask = "999";
            this.txt_cantidad_clientes_oficina.Name = "txt_cantidad_clientes_oficina";
            this.txt_cantidad_clientes_oficina.Size = new System.Drawing.Size(84, 29);
            this.txt_cantidad_clientes_oficina.TabIndex = 22;
            this.txt_cantidad_clientes_oficina.ValidatingType = typeof(int);
            // 
            // txt_minutos_caseta
            // 
            this.txt_minutos_caseta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_minutos_caseta.Location = new System.Drawing.Point(511, 92);
            this.txt_minutos_caseta.Mask = "999";
            this.txt_minutos_caseta.Name = "txt_minutos_caseta";
            this.txt_minutos_caseta.Size = new System.Drawing.Size(79, 29);
            this.txt_minutos_caseta.TabIndex = 23;
            this.txt_minutos_caseta.ValidatingType = typeof(int);
            // 
            // txt_minutos_oficina
            // 
            this.txt_minutos_oficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_minutos_oficina.Location = new System.Drawing.Point(511, 170);
            this.txt_minutos_oficina.Mask = "999";
            this.txt_minutos_oficina.Name = "txt_minutos_oficina";
            this.txt_minutos_oficina.Size = new System.Drawing.Size(79, 29);
            this.txt_minutos_oficina.TabIndex = 23;
            this.txt_minutos_oficina.ValidatingType = typeof(int);
            // 
            // txt_minutos_nave
            // 
            this.txt_minutos_nave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_minutos_nave.Location = new System.Drawing.Point(511, 131);
            this.txt_minutos_nave.Mask = "999";
            this.txt_minutos_nave.Name = "txt_minutos_nave";
            this.txt_minutos_nave.Size = new System.Drawing.Size(79, 29);
            this.txt_minutos_nave.TabIndex = 23;
            this.txt_minutos_nave.ValidatingType = typeof(int);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(42, 411);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(510, 25);
            this.label13.TabIndex = 19;
            this.label13.Text = "Cantidad máxima de clientes en la cola de la caseta";
            // 
            // txt_cantidad_maxima_cola
            // 
            this.txt_cantidad_maxima_cola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_maxima_cola.Location = new System.Drawing.Point(558, 409);
            this.txt_cantidad_maxima_cola.Mask = "99999";
            this.txt_cantidad_maxima_cola.Name = "txt_cantidad_maxima_cola";
            this.txt_cantidad_maxima_cola.Size = new System.Drawing.Size(168, 29);
            this.txt_cantidad_maxima_cola.TabIndex = 17;
            this.txt_cantidad_maxima_cola.ValidatingType = typeof(int);
            // 
            // btn_simular
            // 
            this.btn_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.Location = new System.Drawing.Point(756, 407);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(104, 34);
            this.btn_simular.TabIndex = 21;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(874, 494);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_cantidad_maxima_cola);
            this.Controls.Add(this.txt_cantidad_simulaciones);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cerrar_programa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar_programa;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_simulaciones;
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
    }
}

