namespace GrupoG_Distribuciones
{
    partial class ChiCuadrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiCuadrado));
            this.lbl_nivel_significancia = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_generar = new System.Windows.Forms.Button();
            this.txt_intervalo = new System.Windows.Forms.MaskedTextBox();
            this.lbl_intervalo = new System.Windows.Forms.Label();
            this.reporte_chi_cuadrado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_cerrar_programa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nivel_significancia
            // 
            this.lbl_nivel_significancia.AutoSize = true;
            this.lbl_nivel_significancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivel_significancia.Location = new System.Drawing.Point(454, 104);
            this.lbl_nivel_significancia.Name = "lbl_nivel_significancia";
            this.lbl_nivel_significancia.Size = new System.Drawing.Size(299, 24);
            this.lbl_nivel_significancia.TabIndex = 24;
            this.lbl_nivel_significancia.Text = "Nivel de significancia usado = 0.95";
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(12, 73);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(72, 23);
            this.btn_volver.TabIndex = 23;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_generar
            // 
            this.btn_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Location = new System.Drawing.Point(1084, 101);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 24);
            this.btn_generar.TabIndex = 22;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // txt_intervalo
            // 
            this.txt_intervalo.Location = new System.Drawing.Point(1084, 75);
            this.txt_intervalo.Mask = "99999";
            this.txt_intervalo.Name = "txt_intervalo";
            this.txt_intervalo.Size = new System.Drawing.Size(100, 20);
            this.txt_intervalo.TabIndex = 21;
            this.txt_intervalo.ValidatingType = typeof(int);
            // 
            // lbl_intervalo
            // 
            this.lbl_intervalo.AutoSize = true;
            this.lbl_intervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intervalo.Location = new System.Drawing.Point(354, 70);
            this.lbl_intervalo.Name = "lbl_intervalo";
            this.lbl_intervalo.Size = new System.Drawing.Size(403, 24);
            this.lbl_intervalo.TabIndex = 20;
            this.lbl_intervalo.Text = "ingrese la cantidad de intervalos (Sugerimos n)";
            // 
            // reporte_chi_cuadrado
            // 
            this.reporte_chi_cuadrado.LocalReport.ReportEmbeddedResource = "TP1_GeneradorNumerosPseudoaleatorios.Formularios.ReporteChiCuadrado.rdlc";
            this.reporte_chi_cuadrado.Location = new System.Drawing.Point(12, 161);
            this.reporte_chi_cuadrado.Name = "reporte_chi_cuadrado";
            this.reporte_chi_cuadrado.ServerReport.BearerToken = null;
            this.reporte_chi_cuadrado.Size = new System.Drawing.Size(1290, 676);
            this.reporte_chi_cuadrado.TabIndex = 25;
            // 
            // btn_cerrar_programa
            // 
            this.btn_cerrar_programa.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_programa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_programa.BackgroundImage")));
            this.btn_cerrar_programa.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_programa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_programa.Location = new System.Drawing.Point(1261, 12);
            this.btn_cerrar_programa.Name = "btn_cerrar_programa";
            this.btn_cerrar_programa.Size = new System.Drawing.Size(41, 41);
            this.btn_cerrar_programa.TabIndex = 26;
            this.btn_cerrar_programa.UseVisualStyleBackColor = false;
            this.btn_cerrar_programa.Click += new System.EventHandler(this.btn_cerrar_programa_Click);
            // 
            // ChiCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1314, 849);
            this.Controls.Add(this.btn_cerrar_programa);
            this.Controls.Add(this.reporte_chi_cuadrado);
            this.Controls.Add(this.lbl_nivel_significancia);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.txt_intervalo);
            this.Controls.Add(this.lbl_intervalo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiCuadrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiCuadrado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChiCuadrado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nivel_significancia;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.MaskedTextBox txt_intervalo;
        private System.Windows.Forms.Label lbl_intervalo;
        private Microsoft.Reporting.WinForms.ReportViewer reporte_chi_cuadrado;
        private System.Windows.Forms.Button btn_cerrar_programa;
    }
}