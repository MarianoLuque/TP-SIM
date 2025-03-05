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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_dias_a_simular = new System.Windows.Forms.Label();
            this.txt_cantidad_simulaciones = new System.Windows.Forms.MaskedTextBox();
            this.dg_nro_llegadas = new System.Windows.Forms.DataGridView();
            this.lbl_datos_simulacion = new System.Windows.Forms.Label();
            this.btn_simular = new System.Windows.Forms.Button();
            this.lbl_costos_produccion = new System.Windows.Forms.Label();
            this.lbl_ganancias_diarias = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.txt_costo_produccion = new System.Windows.Forms.MaskedTextBox();
            this.txt_ganancias = new System.Windows.Forms.MaskedTextBox();
            this.txt_cant_empleados_nomina = new System.Windows.Forms.MaskedTextBox();
            this.lbl_salario_diario = new System.Windows.Forms.Label();
            this.txt_salario_diario = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_cant_obreros_nomina = new System.Windows.Forms.Label();
            this.lbl_cant_minima_obrero = new System.Windows.Forms.Label();
            this.txt_cant_empleados_minima = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_nro_llegadas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(13, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(564, 42);
            this.lbl_titulo.TabIndex = 10;
            this.lbl_titulo.Text = "Montecarlo - Industria Automotriz";
            // 
            // lbl_dias_a_simular
            // 
            this.lbl_dias_a_simular.AutoSize = true;
            this.lbl_dias_a_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dias_a_simular.Location = new System.Drawing.Point(12, 68);
            this.lbl_dias_a_simular.Name = "lbl_dias_a_simular";
            this.lbl_dias_a_simular.Size = new System.Drawing.Size(499, 24);
            this.lbl_dias_a_simular.TabIndex = 11;
            this.lbl_dias_a_simular.Text = "Cantidad de días de operación a simular (por defecto 300):\r\n";
            // 
            // txt_cantidad_simulaciones
            // 
            this.txt_cantidad_simulaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_simulaciones.Location = new System.Drawing.Point(517, 65);
            this.txt_cantidad_simulaciones.Mask = "99999999";
            this.txt_cantidad_simulaciones.Name = "txt_cantidad_simulaciones";
            this.txt_cantidad_simulaciones.Size = new System.Drawing.Size(92, 29);
            this.txt_cantidad_simulaciones.TabIndex = 0;
            this.txt_cantidad_simulaciones.ValidatingType = typeof(int);
            // 
            // dg_nro_llegadas
            // 
            this.dg_nro_llegadas.AllowUserToAddRows = false;
            this.dg_nro_llegadas.AllowUserToDeleteRows = false;
            this.dg_nro_llegadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_nro_llegadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_nro_llegadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_nro_llegadas.Location = new System.Drawing.Point(210, 205);
            this.dg_nro_llegadas.Name = "dg_nro_llegadas";
            this.dg_nro_llegadas.ReadOnly = true;
            this.dg_nro_llegadas.Size = new System.Drawing.Size(514, 285);
            this.dg_nro_llegadas.TabIndex = 14;
            // 
            // lbl_datos_simulacion
            // 
            this.lbl_datos_simulacion.AutoSize = true;
            this.lbl_datos_simulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datos_simulacion.Location = new System.Drawing.Point(13, 205);
            this.lbl_datos_simulacion.Name = "lbl_datos_simulacion";
            this.lbl_datos_simulacion.Size = new System.Drawing.Size(0, 20);
            this.lbl_datos_simulacion.TabIndex = 13;
            // 
            // btn_simular
            // 
            this.btn_simular.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.Location = new System.Drawing.Point(837, 655);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(104, 34);
            this.btn_simular.TabIndex = 10;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // lbl_costos_produccion
            // 
            this.lbl_costos_produccion.AutoSize = true;
            this.lbl_costos_produccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costos_produccion.Location = new System.Drawing.Point(12, 524);
            this.lbl_costos_produccion.Name = "lbl_costos_produccion";
            this.lbl_costos_produccion.Size = new System.Drawing.Size(564, 24);
            this.lbl_costos_produccion.TabIndex = 16;
            this.lbl_costos_produccion.Text = "Valor de costos diarios de producción y venta (por defecto $2400):";
            // 
            // lbl_ganancias_diarias
            // 
            this.lbl_ganancias_diarias.AutoSize = true;
            this.lbl_ganancias_diarias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ganancias_diarias.Location = new System.Drawing.Point(12, 564);
            this.lbl_ganancias_diarias.Name = "lbl_ganancias_diarias";
            this.lbl_ganancias_diarias.Size = new System.Drawing.Size(354, 24);
            this.lbl_ganancias_diarias.TabIndex = 19;
            this.lbl_ganancias_diarias.Text = "Valor de venta diario (por defecto $4000):\r\n";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_b.Location = new System.Drawing.Point(367, 563);
            this.lbl_b.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(24, 25);
            this.lbl_b.TabIndex = 18;
            this.lbl_b.Text = "$";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_a.Location = new System.Drawing.Point(573, 523);
            this.lbl_a.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(24, 25);
            this.lbl_a.TabIndex = 17;
            this.lbl_a.Text = "$";
            // 
            // txt_costo_produccion
            // 
            this.txt_costo_produccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costo_produccion.Location = new System.Drawing.Point(602, 521);
            this.txt_costo_produccion.Mask = "99999";
            this.txt_costo_produccion.Name = "txt_costo_produccion";
            this.txt_costo_produccion.Size = new System.Drawing.Size(84, 29);
            this.txt_costo_produccion.TabIndex = 2;
            this.txt_costo_produccion.ValidatingType = typeof(int);
            // 
            // txt_ganancias
            // 
            this.txt_ganancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ganancias.Location = new System.Drawing.Point(396, 561);
            this.txt_ganancias.Mask = "99999";
            this.txt_ganancias.Name = "txt_ganancias";
            this.txt_ganancias.Size = new System.Drawing.Size(79, 29);
            this.txt_ganancias.TabIndex = 3;
            this.txt_ganancias.ValidatingType = typeof(int);
            // 
            // txt_cant_empleados_nomina
            // 
            this.txt_cant_empleados_nomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cant_empleados_nomina.Location = new System.Drawing.Point(436, 102);
            this.txt_cant_empleados_nomina.Mask = "99999";
            this.txt_cant_empleados_nomina.Name = "txt_cant_empleados_nomina";
            this.txt_cant_empleados_nomina.Size = new System.Drawing.Size(79, 29);
            this.txt_cant_empleados_nomina.TabIndex = 5;
            this.txt_cant_empleados_nomina.ValidatingType = typeof(int);
            // 
            // lbl_salario_diario
            // 
            this.lbl_salario_diario.AutoSize = true;
            this.lbl_salario_diario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salario_diario.Location = new System.Drawing.Point(12, 598);
            this.lbl_salario_diario.Name = "lbl_salario_diario";
            this.lbl_salario_diario.Size = new System.Drawing.Size(364, 24);
            this.lbl_salario_diario.TabIndex = 21;
            this.lbl_salario_diario.Text = "Salario diario por obrero (por defecto $30):";
            // 
            // txt_salario_diario
            // 
            this.txt_salario_diario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salario_diario.Location = new System.Drawing.Point(406, 598);
            this.txt_salario_diario.Mask = "99999";
            this.txt_salario_diario.Name = "txt_salario_diario";
            this.txt_salario_diario.Size = new System.Drawing.Size(84, 29);
            this.txt_salario_diario.TabIndex = 4;
            this.txt_salario_diario.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label5.Location = new System.Drawing.Point(377, 598);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "$";
            // 
            // lbl_cant_obreros_nomina
            // 
            this.lbl_cant_obreros_nomina.AutoSize = true;
            this.lbl_cant_obreros_nomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cant_obreros_nomina.Location = new System.Drawing.Point(12, 105);
            this.lbl_cant_obreros_nomina.Name = "lbl_cant_obreros_nomina";
            this.lbl_cant_obreros_nomina.Size = new System.Drawing.Size(418, 24);
            this.lbl_cant_obreros_nomina.TabIndex = 28;
            this.lbl_cant_obreros_nomina.Text = "Cantidad de obreros en nómina (por defecto 24):\r\n";
            // 
            // lbl_cant_minima_obrero
            // 
            this.lbl_cant_minima_obrero.AutoSize = true;
            this.lbl_cant_minima_obrero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cant_minima_obrero.Location = new System.Drawing.Point(12, 143);
            this.lbl_cant_minima_obrero.Name = "lbl_cant_minima_obrero";
            this.lbl_cant_minima_obrero.Size = new System.Drawing.Size(491, 24);
            this.lbl_cant_minima_obrero.TabIndex = 30;
            this.lbl_cant_minima_obrero.Text = "Cantidad mínima de obreros para operar (por defecto 20):\r\n";
            // 
            // txt_cant_empleados_minima
            // 
            this.txt_cant_empleados_minima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cant_empleados_minima.Location = new System.Drawing.Point(509, 140);
            this.txt_cant_empleados_minima.Mask = "99999";
            this.txt_cant_empleados_minima.Name = "txt_cant_empleados_minima";
            this.txt_cant_empleados_minima.Size = new System.Drawing.Size(79, 29);
            this.txt_cant_empleados_minima.TabIndex = 29;
            this.txt_cant_empleados_minima.ValidatingType = typeof(int);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(993, 730);
            this.Controls.Add(this.lbl_cant_minima_obrero);
            this.Controls.Add(this.txt_cant_empleados_minima);
            this.Controls.Add(this.lbl_cant_obreros_nomina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.lbl_ganancias_diarias);
            this.Controls.Add(this.lbl_costos_produccion);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.dg_nro_llegadas);
            this.Controls.Add(this.txt_ganancias);
            this.Controls.Add(this.txt_salario_diario);
            this.Controls.Add(this.txt_cant_empleados_nomina);
            this.Controls.Add(this.txt_costo_produccion);
            this.Controls.Add(this.txt_cantidad_simulaciones);
            this.Controls.Add(this.lbl_datos_simulacion);
            this.Controls.Add(this.lbl_salario_diario);
            this.Controls.Add(this.lbl_dias_a_simular);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP Final - SIM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Enter += new System.EventHandler(this.btn_simular_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dg_nro_llegadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_dias_a_simular;
        private System.Windows.Forms.MaskedTextBox txt_cantidad_simulaciones;
        private System.Windows.Forms.DataGridView dg_nro_llegadas;
        private System.Windows.Forms.Label lbl_datos_simulacion;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.Label lbl_costos_produccion;
        private System.Windows.Forms.Label lbl_ganancias_diarias;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.MaskedTextBox txt_costo_produccion;
        private System.Windows.Forms.MaskedTextBox txt_ganancias;
        private System.Windows.Forms.MaskedTextBox txt_cant_empleados_nomina;
        private System.Windows.Forms.Label lbl_salario_diario;
        private System.Windows.Forms.MaskedTextBox txt_salario_diario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_cant_obreros_nomina;
        private System.Windows.Forms.Label lbl_cant_minima_obrero;
        private System.Windows.Forms.MaskedTextBox txt_cant_empleados_minima;
    }
}

