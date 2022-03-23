﻿namespace TP1_GeneradorNumerosPseudoaleatorios
{
    partial class PantallaInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_semilla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cerrar_programa = new System.Windows.Forms.Button();
            this.txt_g = new System.Windows.Forms.TextBox();
            this.txt_k = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_multiplicativo = new System.Windows.Forms.RadioButton();
            this.rb_lineal = new System.Windows.Forms.RadioButton();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.lb_c = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_a = new TP1_GeneradorNumerosPseudoaleatorios.Clases.ComboBox01();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generador de números pseudoaleatorios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el valor de la semilla";
            // 
            // txt_semilla
            // 
            this.txt_semilla.Location = new System.Drawing.Point(68, 262);
            this.txt_semilla.Name = "txt_semilla";
            this.txt_semilla.Size = new System.Drawing.Size(86, 20);
            this.txt_semilla.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ingrese el valor de g considerando que m es 2^g";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ingrese el valor de k";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(577, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Seleccione la formula a aplicar a la constante multiplicativa";
            // 
            // btn_cerrar_programa
            // 
            this.btn_cerrar_programa.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_programa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_programa.BackgroundImage")));
            this.btn_cerrar_programa.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_programa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_programa.Location = new System.Drawing.Point(1127, 8);
            this.btn_cerrar_programa.Name = "btn_cerrar_programa";
            this.btn_cerrar_programa.Size = new System.Drawing.Size(41, 41);
            this.btn_cerrar_programa.TabIndex = 9;
            this.btn_cerrar_programa.UseVisualStyleBackColor = false;
            this.btn_cerrar_programa.Click += new System.EventHandler(this.btn_cerrar_programa_Click);
            // 
            // txt_g
            // 
            this.txt_g.Location = new System.Drawing.Point(68, 416);
            this.txt_g.Name = "txt_g";
            this.txt_g.Size = new System.Drawing.Size(86, 20);
            this.txt_g.TabIndex = 2;
            // 
            // txt_k
            // 
            this.txt_k.Location = new System.Drawing.Point(68, 313);
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(86, 20);
            this.txt_k.TabIndex = 2;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(931, 455);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(111, 42);
            this.btn_calcular.TabIndex = 11;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_cerrar_programa);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 56);
            this.panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_multiplicativo);
            this.groupBox1.Controls.Add(this.rb_lineal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(68, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 108);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo congruencial";
            // 
            // rb_multiplicativo
            // 
            this.rb_multiplicativo.AutoSize = true;
            this.rb_multiplicativo.Location = new System.Drawing.Point(6, 65);
            this.rb_multiplicativo.Name = "rb_multiplicativo";
            this.rb_multiplicativo.Size = new System.Drawing.Size(155, 29);
            this.rb_multiplicativo.TabIndex = 1;
            this.rb_multiplicativo.TabStop = true;
            this.rb_multiplicativo.Text = "Multiplicativo";
            this.rb_multiplicativo.UseVisualStyleBackColor = true;
            this.rb_multiplicativo.CheckedChanged += new System.EventHandler(this.rb_multiplicativo_CheckedChanged);
            // 
            // rb_lineal
            // 
            this.rb_lineal.AutoSize = true;
            this.rb_lineal.Location = new System.Drawing.Point(6, 30);
            this.rb_lineal.Name = "rb_lineal";
            this.rb_lineal.Size = new System.Drawing.Size(88, 29);
            this.rb_lineal.TabIndex = 0;
            this.rb_lineal.TabStop = true;
            this.rb_lineal.Text = "Lineal";
            this.rb_lineal.UseVisualStyleBackColor = true;
            this.rb_lineal.CheckedChanged += new System.EventHandler(this.rb_lineal_CheckedChanged);
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(68, 467);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(86, 20);
            this.txt_c.TabIndex = 15;
            // 
            // lb_c
            // 
            this.lb_c.AutoSize = true;
            this.lb_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_c.Location = new System.Drawing.Point(173, 461);
            this.lb_c.Name = "lb_c";
            this.lb_c.Size = new System.Drawing.Size(381, 25);
            this.lb_c.TabIndex = 16;
            this.lb_c.Text = "Ingrese el valor de la constante aditiva";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(68, 211);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(86, 20);
            this.txt_cantidad.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(173, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(411, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ingrese la cantidad de numeros a generar";
            // 
            // cmb_a
            // 
            this.cmb_a.FormattingEnabled = true;
            this.cmb_a.Location = new System.Drawing.Point(68, 364);
            this.cmb_a.Name = "cmb_a";
            this.cmb_a.Size = new System.Drawing.Size(87, 21);
            this.cmb_a.TabIndex = 13;
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1179, 521);
            this.ControlBox = false;
            this.Controls.Add(this.lb_c);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_a);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_k);
            this.Controls.Add(this.txt_g);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_semilla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PantallaInicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de Números Pseudoaleatorios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_semilla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cerrar_programa;
        private System.Windows.Forms.TextBox txt_g;
        private System.Windows.Forms.TextBox txt_k;
        private System.Windows.Forms.Button btn_calcular;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Clases.ComboBox01 cmb_a;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_multiplicativo;
        private System.Windows.Forms.RadioButton rb_lineal;
        private System.Windows.Forms.Label lb_c;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label8;
    }
}

