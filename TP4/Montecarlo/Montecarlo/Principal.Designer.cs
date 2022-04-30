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
            this.txt_costo_por_noche = new System.Windows.Forms.MaskedTextBox();
            this.txt_costo_muelle_vacio = new System.Windows.Forms.MaskedTextBox();
            this.btn_cerrar_programa = new System.Windows.Forms.Button();
            this.btn_simular = new System.Windows.Forms.Button();
            this.lbl_dist_uniforme = new System.Windows.Forms.Label();
            this.lbl_dist_poisson = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.txt_dist_uniforme_a = new System.Windows.Forms.MaskedTextBox();
            this.txt_dist_uniforme_b = new System.Windows.Forms.MaskedTextBox();
            this.txt_dist_poisson_hs = new System.Windows.Forms.MaskedTextBox();
            this.lbl_barcos = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_media_normal = new System.Windows.Forms.MaskedTextBox();
            this.txt_desviacion_normal = new System.Windows.Forms.MaskedTextBox();
            this.lbl_hs = new System.Windows.Forms.Label();
            this.txt_dist_poisson_barcos = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_nro_llegadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_nro_descargas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Montecarlo - Muelles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la cantidad de días a simular";
            // 
            // txt_cantidad_simulaciones
            // 
            this.txt_cantidad_simulaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_simulaciones.Location = new System.Drawing.Point(373, 78);
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
            this.groupBox1.Location = new System.Drawing.Point(17, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la cantidad de muelles que tendra la simulación";
            // 
            // rb_dos_muelle
            // 
            this.rb_dos_muelle.AutoSize = true;
            this.rb_dos_muelle.Location = new System.Drawing.Point(577, 26);
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
            this.rb_un_muelle.Location = new System.Drawing.Point(267, 26);
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
            this.dg_nro_llegadas.Location = new System.Drawing.Point(204, 229);
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
            this.dg_nro_descargas.Location = new System.Drawing.Point(510, 229);
            this.dg_nro_descargas.Name = "dg_nro_descargas";
            this.dg_nro_descargas.ReadOnly = true;
            this.dg_nro_descargas.Size = new System.Drawing.Size(257, 188);
            this.dg_nro_descargas.TabIndex = 5;
            // 
            // lbl_datos_simulacion
            // 
            this.lbl_datos_simulacion.AutoSize = true;
            this.lbl_datos_simulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datos_simulacion.Location = new System.Drawing.Point(13, 205);
            this.lbl_datos_simulacion.Name = "lbl_datos_simulacion";
            this.lbl_datos_simulacion.Size = new System.Drawing.Size(0, 20);
            this.lbl_datos_simulacion.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(673, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ingrese el costo por barco por pasar la noche en el muelle (Por defecto $1500):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(646, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ingrese el costo por cada barco descargado (Por defecto Normal(800; 120)):";
            // 
            // txt_k_mv
            // 
            this.txt_k_mv.AutoSize = true;
            this.txt_k_mv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_k_mv.Location = new System.Drawing.Point(13, 549);
            this.txt_k_mv.Name = "txt_k_mv";
            this.txt_k_mv.Size = new System.Drawing.Size(518, 24);
            this.txt_k_mv.TabIndex = 1;
            this.txt_k_mv.Text = "Ingrese el costo por tener el muelle vacio (Por defecto 3200):";
            // 
            // txt_costo_por_noche
            // 
            this.txt_costo_por_noche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costo_por_noche.Location = new System.Drawing.Point(696, 440);
            this.txt_costo_por_noche.Mask = "999999999999";
            this.txt_costo_por_noche.Name = "txt_costo_por_noche";
            this.txt_costo_por_noche.Size = new System.Drawing.Size(168, 29);
            this.txt_costo_por_noche.TabIndex = 2;
            this.txt_costo_por_noche.ValidatingType = typeof(int);
            // 
            // txt_costo_muelle_vacio
            // 
            this.txt_costo_muelle_vacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costo_muelle_vacio.Location = new System.Drawing.Point(549, 546);
            this.txt_costo_muelle_vacio.Mask = "999999999999";
            this.txt_costo_muelle_vacio.Name = "txt_costo_muelle_vacio";
            this.txt_costo_muelle_vacio.Size = new System.Drawing.Size(168, 29);
            this.txt_costo_muelle_vacio.TabIndex = 2;
            this.txt_costo_muelle_vacio.ValidatingType = typeof(int);
            // 
            // btn_cerrar_programa
            // 
            this.btn_cerrar_programa.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_programa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_programa.BackgroundImage")));
            this.btn_cerrar_programa.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_programa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_programa.Location = new System.Drawing.Point(970, 9);
            this.btn_cerrar_programa.Name = "btn_cerrar_programa";
            this.btn_cerrar_programa.Size = new System.Drawing.Size(41, 41);
            this.btn_cerrar_programa.TabIndex = 15;
            this.btn_cerrar_programa.UseVisualStyleBackColor = false;
            this.btn_cerrar_programa.Click += new System.EventHandler(this.btn_cerrar_programa_Click);
            // 
            // btn_simular
            // 
            this.btn_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.Location = new System.Drawing.Point(883, 592);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(104, 34);
            this.btn_simular.TabIndex = 16;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // lbl_dist_uniforme
            // 
            this.lbl_dist_uniforme.AutoSize = true;
            this.lbl_dist_uniforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dist_uniforme.Location = new System.Drawing.Point(13, 325);
            this.lbl_dist_uniforme.Name = "lbl_dist_uniforme";
            this.lbl_dist_uniforme.Size = new System.Drawing.Size(543, 24);
            this.lbl_dist_uniforme.TabIndex = 17;
            this.lbl_dist_uniforme.Text = "Ingrese los valores de la distribución Uniforme (Por defecto 0;9):";
            this.lbl_dist_uniforme.Visible = false;
            // 
            // lbl_dist_poisson
            // 
            this.lbl_dist_poisson.AutoSize = true;
            this.lbl_dist_poisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dist_poisson.Location = new System.Drawing.Point(13, 365);
            this.lbl_dist_poisson.Name = "lbl_dist_poisson";
            this.lbl_dist_poisson.Size = new System.Drawing.Size(663, 24);
            this.lbl_dist_poisson.TabIndex = 17;
            this.lbl_dist_poisson.Text = "Ingrese los valores de la distribución Poisson (Por defecto 20 barcos en 12hs):";
            this.lbl_dist_poisson.Visible = false;
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_b.Location = new System.Drawing.Point(736, 324);
            this.lbl_b.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(26, 25);
            this.lbl_b.TabIndex = 53;
            this.lbl_b.Text = "B";
            this.lbl_b.Visible = false;
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_a.Location = new System.Drawing.Point(563, 326);
            this.lbl_a.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(26, 25);
            this.lbl_a.TabIndex = 52;
            this.lbl_a.Text = "A";
            this.lbl_a.Visible = false;
            // 
            // txt_dist_uniforme_a
            // 
            this.txt_dist_uniforme_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dist_uniforme_a.Location = new System.Drawing.Point(594, 324);
            this.txt_dist_uniforme_a.Mask = "999999999";
            this.txt_dist_uniforme_a.Name = "txt_dist_uniforme_a";
            this.txt_dist_uniforme_a.Size = new System.Drawing.Size(123, 29);
            this.txt_dist_uniforme_a.TabIndex = 2;
            this.txt_dist_uniforme_a.ValidatingType = typeof(int);
            this.txt_dist_uniforme_a.Visible = false;
            // 
            // txt_dist_uniforme_b
            // 
            this.txt_dist_uniforme_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dist_uniforme_b.Location = new System.Drawing.Point(767, 324);
            this.txt_dist_uniforme_b.Mask = "999999999";
            this.txt_dist_uniforme_b.Name = "txt_dist_uniforme_b";
            this.txt_dist_uniforme_b.Size = new System.Drawing.Size(123, 29);
            this.txt_dist_uniforme_b.TabIndex = 2;
            this.txt_dist_uniforme_b.ValidatingType = typeof(int);
            this.txt_dist_uniforme_b.Visible = false;
            // 
            // txt_dist_poisson_hs
            // 
            this.txt_dist_poisson_hs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dist_poisson_hs.Location = new System.Drawing.Point(872, 362);
            this.txt_dist_poisson_hs.Mask = "99999";
            this.txt_dist_poisson_hs.Name = "txt_dist_poisson_hs";
            this.txt_dist_poisson_hs.Size = new System.Drawing.Size(79, 29);
            this.txt_dist_poisson_hs.TabIndex = 2;
            this.txt_dist_poisson_hs.ValidatingType = typeof(int);
            this.txt_dist_poisson_hs.Visible = false;
            // 
            // lbl_barcos
            // 
            this.lbl_barcos.AutoSize = true;
            this.lbl_barcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barcos.Location = new System.Drawing.Point(773, 365);
            this.lbl_barcos.Name = "lbl_barcos";
            this.lbl_barcos.Size = new System.Drawing.Size(94, 24);
            this.lbl_barcos.TabIndex = 1;
            this.lbl_barcos.Text = "barcos en";
            this.lbl_barcos.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label10.Location = new System.Drawing.Point(823, 496);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 25);
            this.label10.TabIndex = 55;
            this.label10.Text = "δ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label11.Location = new System.Drawing.Point(672, 496);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 25);
            this.label11.TabIndex = 54;
            this.label11.Text = "µ";
            // 
            // txt_media_normal
            // 
            this.txt_media_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_media_normal.Location = new System.Drawing.Point(716, 494);
            this.txt_media_normal.Mask = "99999";
            this.txt_media_normal.Name = "txt_media_normal";
            this.txt_media_normal.Size = new System.Drawing.Size(79, 29);
            this.txt_media_normal.TabIndex = 2;
            this.txt_media_normal.ValidatingType = typeof(int);
            // 
            // txt_desviacion_normal
            // 
            this.txt_desviacion_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desviacion_normal.Location = new System.Drawing.Point(872, 494);
            this.txt_desviacion_normal.Mask = "99999";
            this.txt_desviacion_normal.Name = "txt_desviacion_normal";
            this.txt_desviacion_normal.Size = new System.Drawing.Size(79, 29);
            this.txt_desviacion_normal.TabIndex = 2;
            this.txt_desviacion_normal.ValidatingType = typeof(int);
            // 
            // lbl_hs
            // 
            this.lbl_hs.AutoSize = true;
            this.lbl_hs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hs.Location = new System.Drawing.Point(957, 365);
            this.lbl_hs.Name = "lbl_hs";
            this.lbl_hs.Size = new System.Drawing.Size(30, 24);
            this.lbl_hs.TabIndex = 1;
            this.lbl_hs.Text = "hs";
            this.lbl_hs.Visible = false;
            // 
            // txt_dist_poisson_barcos
            // 
            this.txt_dist_poisson_barcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dist_poisson_barcos.Location = new System.Drawing.Point(688, 362);
            this.txt_dist_poisson_barcos.Mask = "99999";
            this.txt_dist_poisson_barcos.Name = "txt_dist_poisson_barcos";
            this.txt_dist_poisson_barcos.Size = new System.Drawing.Size(79, 29);
            this.txt_dist_poisson_barcos.TabIndex = 2;
            this.txt_dist_poisson_barcos.ValidatingType = typeof(int);
            this.txt_dist_poisson_barcos.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1023, 649);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.lbl_dist_poisson);
            this.Controls.Add(this.lbl_dist_uniforme);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.btn_cerrar_programa);
            this.Controls.Add(this.dg_nro_descargas);
            this.Controls.Add(this.dg_nro_llegadas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_costo_muelle_vacio);
            this.Controls.Add(this.txt_dist_uniforme_b);
            this.Controls.Add(this.txt_desviacion_normal);
            this.Controls.Add(this.txt_media_normal);
            this.Controls.Add(this.txt_dist_poisson_barcos);
            this.Controls.Add(this.txt_dist_poisson_hs);
            this.Controls.Add(this.txt_dist_uniforme_a);
            this.Controls.Add(this.txt_costo_por_noche);
            this.Controls.Add(this.txt_cantidad_simulaciones);
            this.Controls.Add(this.lbl_datos_simulacion);
            this.Controls.Add(this.txt_k_mv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_hs);
            this.Controls.Add(this.lbl_barcos);
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
        private System.Windows.Forms.MaskedTextBox txt_costo_por_noche;
        private System.Windows.Forms.MaskedTextBox txt_costo_muelle_vacio;
        private System.Windows.Forms.Button btn_cerrar_programa;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.Label lbl_dist_uniforme;
        private System.Windows.Forms.Label lbl_dist_poisson;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.MaskedTextBox txt_dist_uniforme_a;
        private System.Windows.Forms.MaskedTextBox txt_dist_uniforme_b;
        private System.Windows.Forms.MaskedTextBox txt_dist_poisson_hs;
        private System.Windows.Forms.Label lbl_barcos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txt_media_normal;
        private System.Windows.Forms.MaskedTextBox txt_desviacion_normal;
        private System.Windows.Forms.Label lbl_hs;
        private System.Windows.Forms.MaskedTextBox txt_dist_poisson_barcos;
    }
}

