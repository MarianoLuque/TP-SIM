namespace TP1_GeneradorNumerosPseudoaleatorios
{
    partial class NuestraSerie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuestraSerie));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_semilla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cerrar_programa = new System.Windows.Forms.Button();
            this.txt_g = new System.Windows.Forms.TextBox();
            this.txt_k = new System.Windows.Forms.TextBox();
            this.btn_cc = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_multiplicativo = new System.Windows.Forms.RadioButton();
            this.rb_lineal = new System.Windows.Forms.RadioButton();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.lb_c = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dg_iteraciones = new System.Windows.Forms.DataGridView();
            this.dg_datos = new System.Windows.Forms.DataGridView();
            this.btn_generar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.cmb_a = new TP1_GeneradorNumerosPseudoaleatorios.Clases.ComboBox01();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_iteraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(816, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generador de números pseudoaleatorios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el valor de la semilla";
            // 
            // txt_semilla
            // 
            this.txt_semilla.Location = new System.Drawing.Point(21, 314);
            this.txt_semilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_semilla.Name = "txt_semilla";
            this.txt_semilla.Size = new System.Drawing.Size(113, 22);
            this.txt_semilla.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 496);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(595, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ingrese el valor de g considerando que m es 2^g";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ingrese el valor de k";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 432);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(720, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Seleccione la formula a aplicar a la constante multiplicativa";
            // 
            // btn_cerrar_programa
            // 
            this.btn_cerrar_programa.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_programa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_programa.BackgroundImage")));
            this.btn_cerrar_programa.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_programa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_programa.Location = new System.Drawing.Point(1661, 10);
            this.btn_cerrar_programa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cerrar_programa.Name = "btn_cerrar_programa";
            this.btn_cerrar_programa.Size = new System.Drawing.Size(55, 50);
            this.btn_cerrar_programa.TabIndex = 9;
            this.btn_cerrar_programa.UseVisualStyleBackColor = false;
            this.btn_cerrar_programa.Click += new System.EventHandler(this.btn_cerrar_programa_Click);
            // 
            // txt_g
            // 
            this.txt_g.Location = new System.Drawing.Point(21, 503);
            this.txt_g.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_g.Name = "txt_g";
            this.txt_g.Size = new System.Drawing.Size(113, 22);
            this.txt_g.TabIndex = 4;
            // 
            // txt_k
            // 
            this.txt_k.Location = new System.Drawing.Point(21, 377);
            this.txt_k.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(113, 22);
            this.txt_k.TabIndex = 2;
            // 
            // btn_cc
            // 
            this.btn_cc.Enabled = false;
            this.btn_cc.Location = new System.Drawing.Point(1511, 549);
            this.btn_cc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cc.Name = "btn_cc";
            this.btn_cc.Size = new System.Drawing.Size(204, 57);
            this.btn_cc.TabIndex = 11;
            this.btn_cc.Text = "Prueba de Chi Cuadrado";
            this.btn_cc.UseVisualStyleBackColor = true;
            this.btn_cc.Click += new System.EventHandler(this.btn_cc_Click);
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
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1753, 69);
            this.panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_multiplicativo);
            this.groupBox1.Controls.Add(this.rb_lineal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(551, 133);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo congruencial";
            // 
            // rb_multiplicativo
            // 
            this.rb_multiplicativo.AutoSize = true;
            this.rb_multiplicativo.Location = new System.Drawing.Point(8, 80);
            this.rb_multiplicativo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_multiplicativo.Name = "rb_multiplicativo";
            this.rb_multiplicativo.Size = new System.Drawing.Size(191, 35);
            this.rb_multiplicativo.TabIndex = 1;
            this.rb_multiplicativo.TabStop = true;
            this.rb_multiplicativo.Text = "Multiplicativo";
            this.rb_multiplicativo.UseVisualStyleBackColor = true;
            this.rb_multiplicativo.CheckedChanged += new System.EventHandler(this.rb_multiplicativo_CheckedChanged);
            // 
            // rb_lineal
            // 
            this.rb_lineal.AutoSize = true;
            this.rb_lineal.Location = new System.Drawing.Point(8, 37);
            this.rb_lineal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_lineal.Name = "rb_lineal";
            this.rb_lineal.Size = new System.Drawing.Size(107, 35);
            this.rb_lineal.TabIndex = 0;
            this.rb_lineal.TabStop = true;
            this.rb_lineal.Text = "Lineal";
            this.rb_lineal.UseVisualStyleBackColor = true;
            this.rb_lineal.CheckedChanged += new System.EventHandler(this.rb_lineal_CheckedChanged);
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(21, 566);
            this.txt_c.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(113, 22);
            this.txt_c.TabIndex = 5;
            // 
            // lb_c
            // 
            this.lb_c.AutoSize = true;
            this.lb_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_c.Location = new System.Drawing.Point(149, 559);
            this.lb_c.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_c.Name = "lb_c";
            this.lb_c.Size = new System.Drawing.Size(476, 31);
            this.lb_c.TabIndex = 16;
            this.lb_c.Text = "Ingrese el valor de la constante aditiva";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(21, 251);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(113, 22);
            this.txt_cantidad.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(149, 244);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(514, 31);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ingrese la cantidad de numeros a generar";
            // 
            // dg_iteraciones
            // 
            this.dg_iteraciones.AllowUserToAddRows = false;
            this.dg_iteraciones.AllowUserToDeleteRows = false;
            this.dg_iteraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_iteraciones.Location = new System.Drawing.Point(969, 203);
            this.dg_iteraciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_iteraciones.Name = "dg_iteraciones";
            this.dg_iteraciones.ReadOnly = true;
            this.dg_iteraciones.RowHeadersWidth = 51;
            this.dg_iteraciones.Size = new System.Drawing.Size(745, 325);
            this.dg_iteraciones.TabIndex = 18;
            // 
            // dg_datos
            // 
            this.dg_datos.AllowUserToAddRows = false;
            this.dg_datos.AllowUserToDeleteRows = false;
            this.dg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_datos.Location = new System.Drawing.Point(969, 89);
            this.dg_datos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_datos.Name = "dg_datos";
            this.dg_datos.ReadOnly = true;
            this.dg_datos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dg_datos.Size = new System.Drawing.Size(745, 107);
            this.dg_datos.TabIndex = 17;
            // 
            // btn_generar
            // 
            this.btn_generar.Enabled = false;
            this.btn_generar.Location = new System.Drawing.Point(765, 119);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(176, 57);
            this.btn_generar.TabIndex = 6;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(969, 549);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(149, 57);
            this.btn_volver.TabIndex = 7;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // cmb_a
            // 
            this.cmb_a.FormattingEnabled = true;
            this.cmb_a.Location = new System.Drawing.Point(21, 439);
            this.cmb_a.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_a.Name = "cmb_a";
            this.cmb_a.Size = new System.Drawing.Size(115, 24);
            this.cmb_a.TabIndex = 3;
            // 
            // NuestraSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1744, 641);
            this.ControlBox = false;
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.dg_iteraciones);
            this.Controls.Add(this.dg_datos);
            this.Controls.Add(this.lb_c);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_a);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cc);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuestraSerie";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_iteraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).EndInit();
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
        private System.Windows.Forms.Button btn_cc;
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
        private System.Windows.Forms.DataGridView dg_iteraciones;
        private System.Windows.Forms.DataGridView dg_datos;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button btn_volver;
    }
}

