namespace Montecarlo
{
    partial class Tabla
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
            this.label1 = new System.Windows.Forms.Label();
            this.dg_montecarlo = new System.Windows.Forms.DataGridView();
            this.lbl_datos_simulacion = new System.Windows.Forms.Label();
            this.btn_simular = new System.Windows.Forms.Button();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.txt_desde = new System.Windows.Forms.MaskedTextBox();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_m3 = new System.Windows.Forms.Label();
            this.lbl_m5 = new System.Windows.Forms.Label();
            this.lbl_m1 = new System.Windows.Forms.Label();
            this.lbl_m4 = new System.Windows.Forms.Label();
            this.lbl_m2 = new System.Windows.Forms.Label();
            this.lbl_m6 = new System.Windows.Forms.Label();
            this.txt_hasta = new System.Windows.Forms.MaskedTextBox();
            this.lbl_hasta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_montecarlo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Montecarlo - Industria Automotriz";
            // 
            // dg_montecarlo
            // 
            this.dg_montecarlo.AllowUserToAddRows = false;
            this.dg_montecarlo.AllowUserToDeleteRows = false;
            this.dg_montecarlo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_montecarlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_montecarlo.Location = new System.Drawing.Point(15, 120);
            this.dg_montecarlo.Name = "dg_montecarlo";
            this.dg_montecarlo.ReadOnly = true;
            this.dg_montecarlo.Size = new System.Drawing.Size(1343, 297);
            this.dg_montecarlo.TabIndex = 4;
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
            // btn_simular
            // 
            this.btn_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.Location = new System.Drawing.Point(1185, 63);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(124, 30);
            this.btn_simular.TabIndex = 2;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.Location = new System.Drawing.Point(236, 66);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(356, 25);
            this.lbl_desde.TabIndex = 18;
            this.lbl_desde.Text = "Ingrese desde que iteración mostrar";
            // 
            // txt_desde
            // 
            this.txt_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desde.Location = new System.Drawing.Point(598, 66);
            this.txt_desde.Mask = "99999";
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(79, 29);
            this.txt_desde.TabIndex = 1;
            this.txt_desde.ValidatingType = typeof(int);
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(12, 63);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(124, 30);
            this.btn_volver.TabIndex = 0;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(571, 39);
            this.label2.TabIndex = 18;
            this.label2.Text = "Resultados de la simulación y métricas";
            // 
            // lbl_m3
            // 
            this.lbl_m3.AutoSize = true;
            this.lbl_m3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_m3.Location = new System.Drawing.Point(17, 519);
            this.lbl_m3.Name = "lbl_m3";
            this.lbl_m3.Size = new System.Drawing.Size(409, 25);
            this.lbl_m3.TabIndex = 18;
            this.lbl_m3.Text = "Promedio diario de empleados ausentes: ";
            // 
            // lbl_m5
            // 
            this.lbl_m5.AutoSize = true;
            this.lbl_m5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_m5.Location = new System.Drawing.Point(17, 630);
            this.lbl_m5.Name = "lbl_m5";
            this.lbl_m5.Size = new System.Drawing.Size(267, 25);
            this.lbl_m5.TabIndex = 18;
            this.lbl_m5.Text = "Beneficio promedio diario: ";
            // 
            // lbl_m1
            // 
            this.lbl_m1.AutoSize = true;
            this.lbl_m1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_m1.Location = new System.Drawing.Point(17, 556);
            this.lbl_m1.Name = "lbl_m1";
            this.lbl_m1.Size = new System.Drawing.Size(173, 25);
            this.lbl_m1.TabIndex = 18;
            this.lbl_m1.Text = "Días operativos: ";
            // 
            // lbl_m4
            // 
            this.lbl_m4.AutoSize = true;
            this.lbl_m4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_m4.Location = new System.Drawing.Point(17, 667);
            this.lbl_m4.Name = "lbl_m4";
            this.lbl_m4.Size = new System.Drawing.Size(160, 25);
            this.lbl_m4.TabIndex = 18;
            this.lbl_m4.Text = "Beneficio total: ";
            // 
            // lbl_m2
            // 
            this.lbl_m2.AutoSize = true;
            this.lbl_m2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_m2.Location = new System.Drawing.Point(17, 593);
            this.lbl_m2.Name = "lbl_m2";
            this.lbl_m2.Size = new System.Drawing.Size(203, 25);
            this.lbl_m2.TabIndex = 18;
            this.lbl_m2.Text = "Días no operativos: ";
            // 
            // lbl_m6
            // 
            this.lbl_m6.AutoSize = true;
            this.lbl_m6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_m6.Location = new System.Drawing.Point(17, 482);
            this.lbl_m6.Name = "lbl_m6";
            this.lbl_m6.Size = new System.Drawing.Size(97, 25);
            this.lbl_m6.TabIndex = 18;
            this.lbl_m6.Text = "Nómina: ";
            // 
            // txt_hasta
            // 
            this.txt_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hasta.Location = new System.Drawing.Point(768, 66);
            this.txt_hasta.Mask = "99999999";
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(92, 29);
            this.txt_hasta.TabIndex = 1;
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_hasta.Location = new System.Drawing.Point(700, 67);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(62, 24);
            this.lbl_hasta.TabIndex = 2;
            this.lbl_hasta.Text = "Hasta:";
            // 
            // Tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txt_hasta);
            this.Controls.Add(this.lbl_hasta);
            this.Controls.Add(this.txt_desde);
            this.Controls.Add(this.lbl_m6);
            this.Controls.Add(this.lbl_m4);
            this.Controls.Add(this.lbl_m1);
            this.Controls.Add(this.lbl_m2);
            this.Controls.Add(this.lbl_m5);
            this.Controls.Add(this.lbl_m3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_desde);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.dg_montecarlo);
            this.Controls.Add(this.lbl_datos_simulacion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tabla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tabla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_montecarlo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_montecarlo;
        private System.Windows.Forms.Label lbl_datos_simulacion;
        #endregion
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.MaskedTextBox txt_desde;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_m3;
        private System.Windows.Forms.Label lbl_m5;
        private System.Windows.Forms.Label lbl_m1;
        private System.Windows.Forms.Label lbl_m4;
        private System.Windows.Forms.Label lbl_m2;
        private System.Windows.Forms.Label lbl_m6;
        private System.Windows.Forms.MaskedTextBox txt_hasta;
        private System.Windows.Forms.Label lbl_hasta;
    }
}