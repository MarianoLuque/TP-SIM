namespace Ejercicio222
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
            btn_cerrar_programa = new Button();
            btn_simular = new Button();
            btn_volver = new Button();
            label1 = new Label();
            dg_colas_1 = new DataGridView();
            lbl_desde = new Label();
            groupBox1 = new GroupBox();
            lbl_maxima_espera2_maquina2 = new Label();
            lbl_maxima_espera1_maquina2 = new Label();
            lbl_maxima_espera2_maquina1 = new Label();
            lbl_maquina_conveniente2 = new Label();
            label7 = new Label();
            label8 = new Label();
            lbl_gasto2_maquina2 = new Label();
            lbl_gasto2_maquina1 = new Label();
            label4 = new Label();
            label3 = new Label();
            lbl_maxima_espera1_maquina1 = new Label();
            lbl_maquina_conveniente1 = new Label();
            lbl_tiempo_medio_cliente_nave = new Label();
            lbl_costo1_maquina1 = new Label();
            lbl_gasto1_maquina2 = new Label();
            lbl_gasto1_maquina1 = new Label();
            label2 = new Label();
            txt_desde = new MaskedTextBox();
            dg_colas_2 = new DataGridView();
            dg_colas_3 = new DataGridView();
            dg_colas_4 = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_colas_1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_colas_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dg_colas_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dg_colas_4).BeginInit();
            SuspendLayout();
            // 
            // btn_cerrar_programa
            // 
            btn_cerrar_programa.BackColor = Color.Transparent;
            btn_cerrar_programa.FlatAppearance.BorderSize = 0;
            btn_cerrar_programa.FlatStyle = FlatStyle.Flat;
            btn_cerrar_programa.Location = new Point(1517, 13);
            btn_cerrar_programa.Margin = new Padding(4, 3, 4, 3);
            btn_cerrar_programa.Name = "btn_cerrar_programa";
            btn_cerrar_programa.Size = new Size(48, 47);
            btn_cerrar_programa.TabIndex = 17;
            btn_cerrar_programa.UseVisualStyleBackColor = false;
            btn_cerrar_programa.Click += btn_cerrar_programa_Click;
            // 
            // btn_simular
            // 
            btn_simular.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_simular.Location = new Point(1443, 40);
            btn_simular.Margin = new Padding(4, 3, 4, 3);
            btn_simular.Name = "btn_simular";
            btn_simular.Size = new Size(121, 39);
            btn_simular.TabIndex = 22;
            btn_simular.Text = "Simular";
            btn_simular.UseVisualStyleBackColor = true;
            btn_simular.Click += btn_simular_Click;
            // 
            // btn_volver
            // 
            btn_volver.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_volver.Location = new Point(14, 40);
            btn_volver.Margin = new Padding(4, 3, 4, 3);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(121, 39);
            btn_volver.TabIndex = 23;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_volver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F);
            label1.Location = new Point(614, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(286, 29);
            label1.TabIndex = 24;
            label1.Text = "Simulación de colas - ITV";
            // 
            // dg_colas_1
            // 
            dg_colas_1.AllowUserToAddRows = false;
            dg_colas_1.AllowUserToDeleteRows = false;
            dg_colas_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_colas_1.Location = new Point(15, 84);
            dg_colas_1.Margin = new Padding(4, 3, 4, 3);
            dg_colas_1.Name = "dg_colas_1";
            dg_colas_1.ReadOnly = true;
            dg_colas_1.RowHeadersWidth = 51;
            dg_colas_1.Size = new Size(1550, 184);
            dg_colas_1.TabIndex = 25;
            // 
            // lbl_desde
            // 
            lbl_desde.AutoSize = true;
            lbl_desde.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_desde.Location = new Point(544, 43);
            lbl_desde.Margin = new Padding(4, 0, 4, 0);
            lbl_desde.Name = "lbl_desde";
            lbl_desde.Size = new Size(356, 25);
            lbl_desde.TabIndex = 26;
            lbl_desde.Text = "Ingrese desde que iteración mostrar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_maxima_espera2_maquina2);
            groupBox1.Controls.Add(lbl_maxima_espera1_maquina2);
            groupBox1.Controls.Add(lbl_maxima_espera2_maquina1);
            groupBox1.Controls.Add(lbl_maquina_conveniente2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lbl_gasto2_maquina2);
            groupBox1.Controls.Add(lbl_gasto2_maquina1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbl_maxima_espera1_maquina1);
            groupBox1.Controls.Add(lbl_maquina_conveniente1);
            groupBox1.Controls.Add(lbl_tiempo_medio_cliente_nave);
            groupBox1.Controls.Add(lbl_costo1_maquina1);
            groupBox1.Controls.Add(lbl_gasto1_maquina2);
            groupBox1.Controls.Add(lbl_gasto1_maquina1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 15.75F);
            groupBox1.Location = new Point(15, 866);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1549, 300);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultados";
            // 
            // lbl_maxima_espera2_maquina2
            // 
            lbl_maxima_espera2_maquina2.AutoSize = true;
            lbl_maxima_espera2_maquina2.Font = new Font("Microsoft Sans Serif", 15.75F);
            lbl_maxima_espera2_maquina2.Location = new Point(828, 260);
            lbl_maxima_espera2_maquina2.Margin = new Padding(2, 0, 2, 0);
            lbl_maxima_espera2_maquina2.Name = "lbl_maxima_espera2_maquina2";
            lbl_maxima_espera2_maquina2.Size = new Size(414, 25);
            lbl_maxima_espera2_maquina2.TabIndex = 52;
            lbl_maxima_espera2_maquina2.Text = "Máxima espera de un cheque maquina 2: ";
            // 
            // lbl_maxima_espera1_maquina2
            // 
            lbl_maxima_espera1_maquina2.AutoSize = true;
            lbl_maxima_espera1_maquina2.Font = new Font("Microsoft Sans Serif", 15.75F);
            lbl_maxima_espera1_maquina2.Location = new Point(93, 260);
            lbl_maxima_espera1_maquina2.Margin = new Padding(2, 0, 2, 0);
            lbl_maxima_espera1_maquina2.Name = "lbl_maxima_espera1_maquina2";
            lbl_maxima_espera1_maquina2.Size = new Size(414, 25);
            lbl_maxima_espera1_maquina2.TabIndex = 51;
            lbl_maxima_espera1_maquina2.Text = "Máxima espera de un cheque maquina 2: ";
            // 
            // lbl_maxima_espera2_maquina1
            // 
            lbl_maxima_espera2_maquina1.AutoSize = true;
            lbl_maxima_espera2_maquina1.Font = new Font("Microsoft Sans Serif", 15.75F);
            lbl_maxima_espera2_maquina1.Location = new Point(828, 228);
            lbl_maxima_espera2_maquina1.Margin = new Padding(2, 0, 2, 0);
            lbl_maxima_espera2_maquina1.Name = "lbl_maxima_espera2_maquina1";
            lbl_maxima_espera2_maquina1.Size = new Size(414, 25);
            lbl_maxima_espera2_maquina1.TabIndex = 50;
            lbl_maxima_espera2_maquina1.Text = "Máxima espera de un cheque maquina 1: ";
            // 
            // lbl_maquina_conveniente2
            // 
            lbl_maquina_conveniente2.AutoSize = true;
            lbl_maquina_conveniente2.Font = new Font("Microsoft Sans Serif", 15.75F);
            lbl_maquina_conveniente2.Location = new Point(828, 196);
            lbl_maquina_conveniente2.Margin = new Padding(2, 0, 2, 0);
            lbl_maquina_conveniente2.Name = "lbl_maquina_conveniente2";
            lbl_maquina_conveniente2.Size = new Size(326, 25);
            lbl_maquina_conveniente2.TabIndex = 49;
            lbl_maquina_conveniente2.Text = "Máquina que conviene comprar: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F);
            label7.Location = new Point(828, 165);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(246, 25);
            label7.TabIndex = 48;
            label7.Text = "Costo máquina 2: 30000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F);
            label8.Location = new Point(828, 132);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(246, 25);
            label8.TabIndex = 47;
            label8.Text = "Costo máquina 1: 40000";
            // 
            // lbl_gasto2_maquina2
            // 
            lbl_gasto2_maquina2.AutoSize = true;
            lbl_gasto2_maquina2.Font = new Font("Microsoft Sans Serif", 15.75F);
            lbl_gasto2_maquina2.Location = new Point(828, 99);
            lbl_gasto2_maquina2.Margin = new Padding(2, 0, 2, 0);
            lbl_gasto2_maquina2.Name = "lbl_gasto2_maquina2";
            lbl_gasto2_maquina2.Size = new Size(187, 25);
            lbl_gasto2_maquina2.TabIndex = 46;
            lbl_gasto2_maquina2.Text = "Gasto máquina 2: ";
            // 
            // lbl_gasto2_maquina1
            // 
            lbl_gasto2_maquina1.AutoSize = true;
            lbl_gasto2_maquina1.Font = new Font("Microsoft Sans Serif", 15.75F);
            lbl_gasto2_maquina1.Location = new Point(828, 67);
            lbl_gasto2_maquina1.Margin = new Padding(2, 0, 2, 0);
            lbl_gasto2_maquina1.Name = "lbl_gasto2_maquina1";
            lbl_gasto2_maquina1.Size = new Size(187, 25);
            lbl_gasto2_maquina1.TabIndex = 45;
            lbl_gasto2_maquina1.Text = "Gasto máquina 1: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F);
            label4.Location = new Point(778, 35);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 44;
            label4.Text = "Considerando ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F);
            label3.Location = new Point(46, 35);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 43;
            label3.Text = "Considerando ";
            // 
            // lbl_maxima_espera1_maquina1
            // 
            lbl_maxima_espera1_maquina1.AutoSize = true;
            lbl_maxima_espera1_maquina1.Font = new Font("Microsoft Sans Serif", 15.75F);
            lbl_maxima_espera1_maquina1.Location = new Point(93, 228);
            lbl_maxima_espera1_maquina1.Margin = new Padding(2, 0, 2, 0);
            lbl_maxima_espera1_maquina1.Name = "lbl_maxima_espera1_maquina1";
            lbl_maxima_espera1_maquina1.Size = new Size(414, 25);
            lbl_maxima_espera1_maquina1.TabIndex = 42;
            lbl_maxima_espera1_maquina1.Text = "Máxima espera de un cheque maquina 1: ";
            // 
            // lbl_maquina_conveniente1
            // 
            lbl_maquina_conveniente1.AutoSize = true;
            lbl_maquina_conveniente1.Font = new Font("Microsoft Sans Serif", 15.75F);
            lbl_maquina_conveniente1.Location = new Point(93, 196);
            lbl_maquina_conveniente1.Margin = new Padding(2, 0, 2, 0);
            lbl_maquina_conveniente1.Name = "lbl_maquina_conveniente1";
            lbl_maquina_conveniente1.Size = new Size(326, 25);
            lbl_maquina_conveniente1.TabIndex = 41;
            lbl_maquina_conveniente1.Text = "Máquina que conviene comprar: ";
            // 
            // lbl_tiempo_medio_cliente_nave
            // 
            lbl_tiempo_medio_cliente_nave.AutoSize = true;
            lbl_tiempo_medio_cliente_nave.Font = new Font("Microsoft Sans Serif", 15.75F);
            lbl_tiempo_medio_cliente_nave.Location = new Point(93, 165);
            lbl_tiempo_medio_cliente_nave.Margin = new Padding(2, 0, 2, 0);
            lbl_tiempo_medio_cliente_nave.Name = "lbl_tiempo_medio_cliente_nave";
            lbl_tiempo_medio_cliente_nave.Size = new Size(246, 25);
            lbl_tiempo_medio_cliente_nave.TabIndex = 40;
            lbl_tiempo_medio_cliente_nave.Text = "Costo máquina 2: 30000";
            // 
            // lbl_costo1_maquina1
            // 
            lbl_costo1_maquina1.AutoSize = true;
            lbl_costo1_maquina1.Font = new Font("Microsoft Sans Serif", 15.75F);
            lbl_costo1_maquina1.Location = new Point(93, 132);
            lbl_costo1_maquina1.Margin = new Padding(2, 0, 2, 0);
            lbl_costo1_maquina1.Name = "lbl_costo1_maquina1";
            lbl_costo1_maquina1.Size = new Size(246, 25);
            lbl_costo1_maquina1.TabIndex = 39;
            lbl_costo1_maquina1.Text = "Costo máquina 1: 40000";
            // 
            // lbl_gasto1_maquina2
            // 
            lbl_gasto1_maquina2.AutoSize = true;
            lbl_gasto1_maquina2.Font = new Font("Microsoft Sans Serif", 15.75F);
            lbl_gasto1_maquina2.Location = new Point(93, 99);
            lbl_gasto1_maquina2.Margin = new Padding(2, 0, 2, 0);
            lbl_gasto1_maquina2.Name = "lbl_gasto1_maquina2";
            lbl_gasto1_maquina2.Size = new Size(187, 25);
            lbl_gasto1_maquina2.TabIndex = 38;
            lbl_gasto1_maquina2.Text = "Gasto máquina 2: ";
            // 
            // lbl_gasto1_maquina1
            // 
            lbl_gasto1_maquina1.AutoSize = true;
            lbl_gasto1_maquina1.Font = new Font("Microsoft Sans Serif", 15.75F);
            lbl_gasto1_maquina1.Location = new Point(93, 67);
            lbl_gasto1_maquina1.Margin = new Padding(2, 0, 2, 0);
            lbl_gasto1_maquina1.Name = "lbl_gasto1_maquina1";
            lbl_gasto1_maquina1.Size = new Size(187, 25);
            lbl_gasto1_maquina1.TabIndex = 37;
            lbl_gasto1_maquina1.Text = "Gasto máquina 1: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1542, 1154);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 46;
            // 
            // txt_desde
            // 
            txt_desde.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_desde.Location = new Point(1345, 41);
            txt_desde.Margin = new Padding(4, 3, 4, 3);
            txt_desde.Mask = "9999999";
            txt_desde.Name = "txt_desde";
            txt_desde.Size = new Size(92, 29);
            txt_desde.TabIndex = 27;
            txt_desde.ValidatingType = typeof(int);
            // 
            // dg_colas_2
            // 
            dg_colas_2.AllowUserToAddRows = false;
            dg_colas_2.AllowUserToDeleteRows = false;
            dg_colas_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_colas_2.Location = new Point(15, 274);
            dg_colas_2.Margin = new Padding(4, 3, 4, 3);
            dg_colas_2.Name = "dg_colas_2";
            dg_colas_2.ReadOnly = true;
            dg_colas_2.RowHeadersWidth = 51;
            dg_colas_2.Size = new Size(1550, 184);
            dg_colas_2.TabIndex = 47;
            // 
            // dg_colas_3
            // 
            dg_colas_3.AllowUserToAddRows = false;
            dg_colas_3.AllowUserToDeleteRows = false;
            dg_colas_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_colas_3.Location = new Point(15, 484);
            dg_colas_3.Margin = new Padding(4, 3, 4, 3);
            dg_colas_3.Name = "dg_colas_3";
            dg_colas_3.ReadOnly = true;
            dg_colas_3.RowHeadersWidth = 51;
            dg_colas_3.Size = new Size(1550, 184);
            dg_colas_3.TabIndex = 48;
            // 
            // dg_colas_4
            // 
            dg_colas_4.AllowUserToAddRows = false;
            dg_colas_4.AllowUserToDeleteRows = false;
            dg_colas_4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_colas_4.Location = new Point(15, 674);
            dg_colas_4.Margin = new Padding(4, 3, 4, 3);
            dg_colas_4.Name = "dg_colas_4";
            dg_colas_4.ReadOnly = true;
            dg_colas_4.RowHeadersWidth = 51;
            dg_colas_4.Size = new Size(1550, 184);
            dg_colas_4.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(14, 461);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(413, 20);
            label5.TabIndex = 50;
            label5.Text = "Considerando un 20% de aumento en la tasa de llegadas";
            // 
            // Simulacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1620, 1100);
            Controls.Add(label5);
            Controls.Add(dg_colas_4);
            Controls.Add(dg_colas_3);
            Controls.Add(dg_colas_2);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(txt_desde);
            Controls.Add(lbl_desde);
            Controls.Add(dg_colas_1);
            Controls.Add(label1);
            Controls.Add(btn_volver);
            Controls.Add(btn_simular);
            Controls.Add(btn_cerrar_programa);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Simulacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simulacion";
            Load += Simulacion_Load;
            ((System.ComponentModel.ISupportInitialize)dg_colas_1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_colas_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dg_colas_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dg_colas_4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar_programa;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_colas_1;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_maxima_espera1_maquina1;
        private System.Windows.Forms.Label lbl_maquina_conveniente1;
        private System.Windows.Forms.Label lbl_tiempo_medio_cliente_nave;
        private System.Windows.Forms.Label lbl_costo1_maquina1;
        private System.Windows.Forms.Label lbl_gasto1_maquina2;
        private System.Windows.Forms.Label lbl_gasto1_maquina1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_desde;
        private Label lbl_maxima_espera2_maquina1;
        private Label lbl_maquina_conveniente2;
        private Label label7;
        private Label label8;
        private Label lbl_gasto2_maquina2;
        private Label lbl_gasto2_maquina1;
        private Label label4;
        private Label label3;
        private DataGridView dg_colas_2;
        private DataGridView dg_colas_3;
        private DataGridView dg_colas_4;
        private Label lbl_maxima_espera2_maquina2;
        private Label lbl_maxima_espera1_maquina2;
        private Label label5;
    }
}