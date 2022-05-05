namespace GrupoG_Distribuciones
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.MaskedTextBox();
            this.gb_distribucion = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_con = new System.Windows.Forms.RadioButton();
            this.rb_bm = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_lambda_exp = new System.Windows.Forms.RadioButton();
            this.rb_media_exp = new System.Windows.Forms.RadioButton();
            this.rb_poisson = new System.Windows.Forms.RadioButton();
            this.rb_exponencial = new System.Windows.Forms.RadioButton();
            this.rb_uniforme = new System.Windows.Forms.RadioButton();
            this.rb_normal = new System.Windows.Forms.RadioButton();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.msk_A = new System.Windows.Forms.TextBox();
            this.msk_B = new System.Windows.Forms.TextBox();
            this.msk_media_normal = new System.Windows.Forms.TextBox();
            this.msk_de = new System.Windows.Forms.TextBox();
            this.msk_media_exp = new System.Windows.Forms.TextBox();
            this.msk_lam_exp = new System.Windows.Forms.TextBox();
            this.msk_lam_poi = new System.Windows.Forms.TextBox();
            this.gb_distribucion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(1032, 11);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(41, 41);
            this.btn_salir.TabIndex = 25;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 42);
            this.label1.TabIndex = 26;
            this.label1.Text = "Generación de variables aleatorias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ingrese la cantidad de números a generar";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(475, 107);
            this.txt_cantidad.Mask = "9999";
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(69, 26);
            this.txt_cantidad.TabIndex = 28;
            this.txt_cantidad.ValidatingType = typeof(int);
            // 
            // gb_distribucion
            // 
            this.gb_distribucion.Controls.Add(this.groupBox2);
            this.gb_distribucion.Controls.Add(this.groupBox1);
            this.gb_distribucion.Controls.Add(this.rb_poisson);
            this.gb_distribucion.Controls.Add(this.rb_exponencial);
            this.gb_distribucion.Controls.Add(this.rb_uniforme);
            this.gb_distribucion.Controls.Add(this.rb_normal);
            this.gb_distribucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_distribucion.Location = new System.Drawing.Point(45, 162);
            this.gb_distribucion.Name = "gb_distribucion";
            this.gb_distribucion.Size = new System.Drawing.Size(464, 317);
            this.gb_distribucion.TabIndex = 29;
            this.gb_distribucion.TabStop = false;
            this.gb_distribucion.Text = "Seleccione el tipo de distribución ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_con);
            this.groupBox2.Controls.Add(this.rb_bm);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox2.Location = new System.Drawing.Point(54, 118);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(368, 53);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione el método de cálculo:";
            // 
            // rb_con
            // 
            this.rb_con.AutoSize = true;
            this.rb_con.Location = new System.Drawing.Point(187, 21);
            this.rb_con.Margin = new System.Windows.Forms.Padding(2);
            this.rb_con.Name = "rb_con";
            this.rb_con.Size = new System.Drawing.Size(134, 28);
            this.rb_con.TabIndex = 1;
            this.rb_con.TabStop = true;
            this.rb_con.Text = "Convolución";
            this.rb_con.UseVisualStyleBackColor = true;
            this.rb_con.CheckedChanged += new System.EventHandler(this.box_con_changed);
            // 
            // rb_bm
            // 
            this.rb_bm.AutoSize = true;
            this.rb_bm.Location = new System.Drawing.Point(70, 21);
            this.rb_bm.Margin = new System.Windows.Forms.Padding(2);
            this.rb_bm.Name = "rb_bm";
            this.rb_bm.Size = new System.Drawing.Size(119, 28);
            this.rb_bm.TabIndex = 0;
            this.rb_bm.TabStop = true;
            this.rb_bm.Text = "Box-Muller";
            this.rb_bm.UseVisualStyleBackColor = true;
            this.rb_bm.CheckedChanged += new System.EventHandler(this.box_con_changed);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_lambda_exp);
            this.groupBox1.Controls.Add(this.rb_media_exp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(54, 208);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(369, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la variable a ingresar";
            // 
            // rb_lambda_exp
            // 
            this.rb_lambda_exp.AutoSize = true;
            this.rb_lambda_exp.Location = new System.Drawing.Point(146, 24);
            this.rb_lambda_exp.Margin = new System.Windows.Forms.Padding(2);
            this.rb_lambda_exp.Name = "rb_lambda_exp";
            this.rb_lambda_exp.Size = new System.Drawing.Size(38, 28);
            this.rb_lambda_exp.TabIndex = 3;
            this.rb_lambda_exp.TabStop = true;
            this.rb_lambda_exp.Text = "λ";
            this.rb_lambda_exp.UseVisualStyleBackColor = true;
            this.rb_lambda_exp.CheckedChanged += new System.EventHandler(this.exponencial_parametro_changed);
            // 
            // rb_media_exp
            // 
            this.rb_media_exp.AutoSize = true;
            this.rb_media_exp.Location = new System.Drawing.Point(104, 24);
            this.rb_media_exp.Margin = new System.Windows.Forms.Padding(2);
            this.rb_media_exp.Name = "rb_media_exp";
            this.rb_media_exp.Size = new System.Drawing.Size(38, 28);
            this.rb_media_exp.TabIndex = 2;
            this.rb_media_exp.TabStop = true;
            this.rb_media_exp.Text = "x̄";
            this.rb_media_exp.UseVisualStyleBackColor = true;
            this.rb_media_exp.CheckedChanged += new System.EventHandler(this.exponencial_parametro_changed);
            // 
            // rb_poisson
            // 
            this.rb_poisson.AutoSize = true;
            this.rb_poisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_poisson.Location = new System.Drawing.Point(37, 280);
            this.rb_poisson.Name = "rb_poisson";
            this.rb_poisson.Size = new System.Drawing.Size(274, 29);
            this.rb_poisson.TabIndex = 0;
            this.rb_poisson.TabStop = true;
            this.rb_poisson.Text = "Distribución Poisson(λ, x̄)";
            this.rb_poisson.UseVisualStyleBackColor = true;
            this.rb_poisson.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rb_exponencial
            // 
            this.rb_exponencial.AutoSize = true;
            this.rb_exponencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_exponencial.Location = new System.Drawing.Point(37, 176);
            this.rb_exponencial.Name = "rb_exponencial";
            this.rb_exponencial.Size = new System.Drawing.Size(321, 29);
            this.rb_exponencial.TabIndex = 0;
            this.rb_exponencial.TabStop = true;
            this.rb_exponencial.Text = "Distribución Exponencial (λ, x̄)";
            this.rb_exponencial.UseVisualStyleBackColor = true;
            this.rb_exponencial.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rb_uniforme
            // 
            this.rb_uniforme.AutoSize = true;
            this.rb_uniforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_uniforme.Location = new System.Drawing.Point(37, 51);
            this.rb_uniforme.Name = "rb_uniforme";
            this.rb_uniforme.Size = new System.Drawing.Size(295, 29);
            this.rb_uniforme.TabIndex = 0;
            this.rb_uniforme.TabStop = true;
            this.rb_uniforme.Text = "Distribución Uniforme (A, B)";
            this.rb_uniforme.UseVisualStyleBackColor = true;
            this.rb_uniforme.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rb_normal
            // 
            this.rb_normal.AutoSize = true;
            this.rb_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_normal.Location = new System.Drawing.Point(37, 85);
            this.rb_normal.Name = "rb_normal";
            this.rb_normal.Size = new System.Drawing.Size(273, 29);
            this.rb_normal.TabIndex = 0;
            this.rb_normal.TabStop = true;
            this.rb_normal.Text = "Distribución Normal (µ, δ)";
            this.rb_normal.UseVisualStyleBackColor = true;
            this.rb_normal.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // btn_continuar
            // 
            this.btn_continuar.Enabled = false;
            this.btn_continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuar.Location = new System.Drawing.Point(938, 431);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(135, 38);
            this.btn_continuar.TabIndex = 30;
            this.btn_continuar.Text = "Continuar";
            this.btn_continuar.UseVisualStyleBackColor = true;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.Location = new System.Drawing.Point(559, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.Location = new System.Drawing.Point(710, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label5.Location = new System.Drawing.Point(712, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "δ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label6.Location = new System.Drawing.Point(561, 300);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "µ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label7.Location = new System.Drawing.Point(562, 392);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "x̄";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label8.Location = new System.Drawing.Point(713, 392);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "λ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label10.Location = new System.Drawing.Point(546, 442);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 25);
            this.label10.TabIndex = 48;
            this.label10.Text = "λ ó x̄";
            // 
            // msk_A
            // 
            this.msk_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_A.Location = new System.Drawing.Point(605, 189);
            this.msk_A.Name = "msk_A";
            this.msk_A.Size = new System.Drawing.Size(100, 31);
            this.msk_A.TabIndex = 51;
            // 
            // msk_B
            // 
            this.msk_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_B.Location = new System.Drawing.Point(742, 188);
            this.msk_B.Name = "msk_B";
            this.msk_B.Size = new System.Drawing.Size(100, 31);
            this.msk_B.TabIndex = 51;
            // 
            // msk_media_normal
            // 
            this.msk_media_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_media_normal.Location = new System.Drawing.Point(605, 297);
            this.msk_media_normal.Name = "msk_media_normal";
            this.msk_media_normal.Size = new System.Drawing.Size(100, 31);
            this.msk_media_normal.TabIndex = 51;
            // 
            // msk_de
            // 
            this.msk_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_de.Location = new System.Drawing.Point(740, 297);
            this.msk_de.Name = "msk_de";
            this.msk_de.Size = new System.Drawing.Size(100, 31);
            this.msk_de.TabIndex = 51;
            // 
            // msk_media_exp
            // 
            this.msk_media_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_media_exp.Location = new System.Drawing.Point(607, 389);
            this.msk_media_exp.Name = "msk_media_exp";
            this.msk_media_exp.Size = new System.Drawing.Size(100, 31);
            this.msk_media_exp.TabIndex = 51;
            // 
            // msk_lam_exp
            // 
            this.msk_lam_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_lam_exp.Location = new System.Drawing.Point(742, 386);
            this.msk_lam_exp.Name = "msk_lam_exp";
            this.msk_lam_exp.Size = new System.Drawing.Size(100, 31);
            this.msk_lam_exp.TabIndex = 51;
            // 
            // msk_lam_poi
            // 
            this.msk_lam_poi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_lam_poi.Location = new System.Drawing.Point(609, 436);
            this.msk_lam_poi.Name = "msk_lam_poi";
            this.msk_lam_poi.Size = new System.Drawing.Size(231, 31);
            this.msk_lam_poi.TabIndex = 51;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1085, 490);
            this.ControlBox = false;
            this.Controls.Add(this.msk_lam_poi);
            this.Controls.Add(this.msk_lam_exp);
            this.Controls.Add(this.msk_de);
            this.Controls.Add(this.msk_B);
            this.Controls.Add(this.msk_media_exp);
            this.Controls.Add(this.msk_media_normal);
            this.Controls.Add(this.msk_A);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.gb_distribucion);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gb_distribucion.ResumeLayout(false);
            this.gb_distribucion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_cantidad;
        private System.Windows.Forms.GroupBox gb_distribucion;
        private System.Windows.Forms.RadioButton rb_poisson;
        private System.Windows.Forms.RadioButton rb_exponencial;
        private System.Windows.Forms.RadioButton rb_uniforme;
        private System.Windows.Forms.RadioButton rb_normal;
        private System.Windows.Forms.Button btn_continuar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_lambda_exp;
        private System.Windows.Forms.RadioButton rb_media_exp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_con;
        private System.Windows.Forms.RadioButton rb_bm;
        private System.Windows.Forms.TextBox msk_A;
        private System.Windows.Forms.TextBox msk_B;
        private System.Windows.Forms.TextBox msk_media_normal;
        private System.Windows.Forms.TextBox msk_de;
        private System.Windows.Forms.TextBox msk_media_exp;
        private System.Windows.Forms.TextBox msk_lam_exp;
        private System.Windows.Forms.TextBox msk_lam_poi;
    }
}

