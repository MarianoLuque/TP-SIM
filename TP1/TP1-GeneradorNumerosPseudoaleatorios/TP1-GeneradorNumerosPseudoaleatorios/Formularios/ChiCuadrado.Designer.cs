﻿namespace TP1_GeneradorNumerosPseudoaleatorios.Formularios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiCuadrado));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrar_programa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reporte_chi_cuadrado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbl_intervalo = new System.Windows.Forms.Label();
            this.txt_intervalo = new System.Windows.Forms.MaskedTextBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btn_cerrar_programa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-104, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2341, 70);
            this.panel1.TabIndex = 13;
            // 
            // btn_cerrar_programa
            // 
            this.btn_cerrar_programa.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_programa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_programa.BackgroundImage")));
            this.btn_cerrar_programa.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_programa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_programa.Location = new System.Drawing.Point(1909, 9);
            this.btn_cerrar_programa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar_programa.Name = "btn_cerrar_programa";
            this.btn_cerrar_programa.Size = new System.Drawing.Size(55, 50);
            this.btn_cerrar_programa.TabIndex = 14;
            this.btn_cerrar_programa.UseVisualStyleBackColor = false;
            this.btn_cerrar_programa.Click += new System.EventHandler(this.btn_cerrar_programa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prueba de Chi Cuadrado";
            // 
            // reporte_chi_cuadrado
            // 
            this.reporte_chi_cuadrado.LocalReport.ReportEmbeddedResource = "TP1_GeneradorNumerosPseudoaleatorios.Formularios.ReporteChiCuadrado.rdlc";
            this.reporte_chi_cuadrado.Location = new System.Drawing.Point(13, 177);
            this.reporte_chi_cuadrado.Margin = new System.Windows.Forms.Padding(4);
            this.reporte_chi_cuadrado.Name = "reporte_chi_cuadrado";
            this.reporte_chi_cuadrado.ServerReport.BearerToken = null;
            this.reporte_chi_cuadrado.Size = new System.Drawing.Size(1847, 820);
            this.reporte_chi_cuadrado.TabIndex = 14;
            // 
            // lbl_intervalo
            // 
            this.lbl_intervalo.AutoSize = true;
            this.lbl_intervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intervalo.Location = new System.Drawing.Point(152, 84);
            this.lbl_intervalo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_intervalo.Name = "lbl_intervalo";
            this.lbl_intervalo.Size = new System.Drawing.Size(517, 29);
            this.lbl_intervalo.TabIndex = 15;
            this.lbl_intervalo.Text = "ingrese la cantidad de intervalos (Sugerimos n)";
            // 
            // txt_intervalo
            // 
            this.txt_intervalo.Location = new System.Drawing.Point(1126, 84);
            this.txt_intervalo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_intervalo.Mask = "99999";
            this.txt_intervalo.Name = "txt_intervalo";
            this.txt_intervalo.Size = new System.Drawing.Size(132, 22);
            this.txt_intervalo.TabIndex = 16;
            this.txt_intervalo.ValidatingType = typeof(int);
            // 
            // btn_generar
            // 
            this.btn_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Location = new System.Drawing.Point(1126, 114);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(100, 30);
            this.btn_generar.TabIndex = 17;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(26, 87);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(96, 28);
            this.btn_volver.TabIndex = 18;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nivel de significancia usado = 0.95";
            // 
            // ChiCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1876, 1024);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.txt_intervalo);
            this.Controls.Add(this.lbl_intervalo);
            this.Controls.Add(this.reporte_chi_cuadrado);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChiCuadrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiCuadrado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChiCuadrado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cerrar_programa;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reporte_chi_cuadrado;
        private System.Windows.Forms.MaskedTextBox txt_intervalo;
        private System.Windows.Forms.Label lbl_intervalo;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label2;
    }
}