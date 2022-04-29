namespace Montecarlo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cantidad_simulaciones = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_dos_muelle = new System.Windows.Forms.RadioButton();
            this.rb_un_muelle = new System.Windows.Forms.RadioButton();
            this.dg_nro_llegadas = new System.Windows.Forms.DataGridView();
            this.dg_nro_descargas = new System.Windows.Forms.DataGridView();
            this.lbl_datos_simulacion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_k_mv = new System.Windows.Forms.Label();
            this.txt_k_m = new System.Windows.Forms.MaskedTextBox();
            this.txt_k_d = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.btn_cerrar_programa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_nro_llegadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_nro_descargas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Montecarlo - Muelles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la cantidad de simulaciones a realizar";
            // 
            // txt_cantidad_simulaciones
            // 
            this.txt_cantidad_simulaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_simulaciones.Location = new System.Drawing.Point(424, 131);
            this.txt_cantidad_simulaciones.Mask = "999999999999";
            this.txt_cantidad_simulaciones.Name = "txt_cantidad_simulaciones";
            this.txt_cantidad_simulaciones.Size = new System.Drawing.Size(168, 29);
            this.txt_cantidad_simulaciones.TabIndex = 2;
            this.txt_cantidad_simulaciones.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_dos_muelle);
            this.groupBox1.Controls.Add(this.rb_un_muelle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(149, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la cantidad de muelles que tendra la simulación";
            // 
            // rb_dos_muelle
            // 
            this.rb_dos_muelle.AutoSize = true;
            this.rb_dos_muelle.Location = new System.Drawing.Point(334, 26);
            this.rb_dos_muelle.Name = "rb_dos_muelle";
            this.rb_dos_muelle.Size = new System.Drawing.Size(99, 24);
            this.rb_dos_muelle.TabIndex = 0;
            this.rb_dos_muelle.TabStop = true;
            this.rb_dos_muelle.Text = "2 Muelles";
            this.rb_dos_muelle.UseVisualStyleBackColor = true;
            this.rb_dos_muelle.CheckedChanged += new System.EventHandler(this.rb_cantidad_muelles_CheckedChanged);
            // 
            // rb_un_muelle
            // 
            this.rb_un_muelle.AutoSize = true;
            this.rb_un_muelle.Location = new System.Drawing.Point(126, 26);
            this.rb_un_muelle.Name = "rb_un_muelle";
            this.rb_un_muelle.Size = new System.Drawing.Size(90, 24);
            this.rb_un_muelle.TabIndex = 0;
            this.rb_un_muelle.TabStop = true;
            this.rb_un_muelle.Text = "1 Muelle";
            this.rb_un_muelle.UseVisualStyleBackColor = true;
            this.rb_un_muelle.CheckedChanged += new System.EventHandler(this.rb_cantidad_muelles_CheckedChanged);
            // 
            // dg_nro_llegadas
            // 
            this.dg_nro_llegadas.AllowUserToAddRows = false;
            this.dg_nro_llegadas.AllowUserToDeleteRows = false;
            this.dg_nro_llegadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_nro_llegadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_nro_llegadas.Location = new System.Drawing.Point(149, 280);
            this.dg_nro_llegadas.Name = "dg_nro_llegadas";
            this.dg_nro_llegadas.ReadOnly = true;
            this.dg_nro_llegadas.Size = new System.Drawing.Size(253, 188);
            this.dg_nro_llegadas.TabIndex = 4;
            // 
            // dg_nro_descargas
            // 
            this.dg_nro_descargas.AllowUserToAddRows = false;
            this.dg_nro_descargas.AllowUserToDeleteRows = false;
            this.dg_nro_descargas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_nro_descargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_nro_descargas.Location = new System.Drawing.Point(433, 280);
            this.dg_nro_descargas.Name = "dg_nro_descargas";
            this.dg_nro_descargas.ReadOnly = true;
            this.dg_nro_descargas.Size = new System.Drawing.Size(257, 188);
            this.dg_nro_descargas.TabIndex = 5;
            // 
            // lbl_datos_simulacion
            // 
            this.lbl_datos_simulacion.AutoSize = true;
            this.lbl_datos_simulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datos_simulacion.Location = new System.Drawing.Point(144, 260);
            this.lbl_datos_simulacion.Name = "lbl_datos_simulacion";
            this.lbl_datos_simulacion.Size = new System.Drawing.Size(0, 20);
            this.lbl_datos_simulacion.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(668, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ingrese el costo por barco por pasar la noche en el muelle (Por defecto $1500)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(641, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ingrese el costo por cada barco descargado (Por defecto Normal(800; 120))";
            // 
            // txt_k_mv
            // 
            this.txt_k_mv.AutoSize = true;
            this.txt_k_mv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_k_mv.Location = new System.Drawing.Point(13, 616);
            this.txt_k_mv.Name = "txt_k_mv";
            this.txt_k_mv.Size = new System.Drawing.Size(513, 24);
            this.txt_k_mv.TabIndex = 1;
            this.txt_k_mv.Text = "Ingrese el costo por tener el muelle vacio (Por defecto 3200)";
            // 
            // txt_k_m
            // 
            this.txt_k_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_k_m.Location = new System.Drawing.Point(696, 507);
            this.txt_k_m.Mask = "999999999999";
            this.txt_k_m.Name = "txt_k_m";
            this.txt_k_m.Size = new System.Drawing.Size(168, 29);
            this.txt_k_m.TabIndex = 2;
            this.txt_k_m.ValidatingType = typeof(int);
            // 
            // txt_k_d
            // 
            this.txt_k_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_k_d.Location = new System.Drawing.Point(696, 561);
            this.txt_k_d.Mask = "999999999999";
            this.txt_k_d.Name = "txt_k_d";
            this.txt_k_d.Size = new System.Drawing.Size(168, 29);
            this.txt_k_d.TabIndex = 2;
            this.txt_k_d.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox3.Location = new System.Drawing.Point(696, 613);
            this.maskedTextBox3.Mask = "999999999999";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(168, 29);
            this.maskedTextBox3.TabIndex = 2;
            this.maskedTextBox3.ValidatingType = typeof(int);
            // 
            // btn_cerrar_programa
            // 
            this.btn_cerrar_programa.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_programa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_programa.BackgroundImage")));
            this.btn_cerrar_programa.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_programa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_programa.Location = new System.Drawing.Point(849, 9);
            this.btn_cerrar_programa.Name = "btn_cerrar_programa";
            this.btn_cerrar_programa.Size = new System.Drawing.Size(41, 41);
            this.btn_cerrar_programa.TabIndex = 15;
            this.btn_cerrar_programa.UseVisualStyleBackColor = false;
            this.btn_cerrar_programa.Click += new System.EventHandler(this.btn_cerrar_programa_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(902, 746);
            this.Controls.Add(this.btn_cerrar_programa);
            this.Controls.Add(this.dg_nro_descargas);
            this.Controls.Add(this.dg_nro_llegadas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.txt_k_d);
            this.Controls.Add(this.txt_k_m);
            this.Controls.Add(this.txt_cantidad_simulaciones);
            this.Controls.Add(this.lbl_datos_simulacion);
            this.Controls.Add(this.txt_k_mv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_nro_llegadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_nro_descargas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_simulaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_dos_muelle;
        private System.Windows.Forms.RadioButton rb_un_muelle;
        private System.Windows.Forms.DataGridView dg_nro_llegadas;
        private System.Windows.Forms.DataGridView dg_nro_descargas;
        private System.Windows.Forms.Label lbl_datos_simulacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_k_mv;
        private System.Windows.Forms.MaskedTextBox txt_k_m;
        private System.Windows.Forms.MaskedTextBox txt_k_d;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Button btn_cerrar_programa;
    }
}

