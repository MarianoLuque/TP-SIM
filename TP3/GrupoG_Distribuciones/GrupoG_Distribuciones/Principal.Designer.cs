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
            this.rb_poisson = new System.Windows.Forms.RadioButton();
            this.rb_exponencial = new System.Windows.Forms.RadioButton();
            this.rb_uniforme = new System.Windows.Forms.RadioButton();
            this.rb_normal = new System.Windows.Forms.RadioButton();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.msk_A = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.msk_B = new System.Windows.Forms.MaskedTextBox();
            this.msk_de = new System.Windows.Forms.MaskedTextBox();
            this.msk_media_normal = new System.Windows.Forms.MaskedTextBox();
            this.msk_media_exp = new System.Windows.Forms.MaskedTextBox();
            this.msk_lam_exp = new System.Windows.Forms.MaskedTextBox();
            this.msk_media_poi = new System.Windows.Forms.MaskedTextBox();
            this.msk_lam_poi = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gb_distribucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(1393, 15);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(55, 50);
            this.btn_salir.TabIndex = 25;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 54);
            this.label1.TabIndex = 26;
            this.label1.Text = "Generación de variables aleatorias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(514, 31);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ingrese la cantidad de números a generar";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(633, 132);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cantidad.Mask = "99999";
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(91, 30);
            this.txt_cantidad.TabIndex = 28;
            this.txt_cantidad.ValidatingType = typeof(int);
            // 
            // gb_distribucion
            // 
            this.gb_distribucion.Controls.Add(this.rb_poisson);
            this.gb_distribucion.Controls.Add(this.rb_exponencial);
            this.gb_distribucion.Controls.Add(this.rb_uniforme);
            this.gb_distribucion.Controls.Add(this.rb_normal);
            this.gb_distribucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_distribucion.Location = new System.Drawing.Point(60, 199);
            this.gb_distribucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_distribucion.Name = "gb_distribucion";
            this.gb_distribucion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_distribucion.Size = new System.Drawing.Size(619, 268);
            this.gb_distribucion.TabIndex = 29;
            this.gb_distribucion.TabStop = false;
            this.gb_distribucion.Text = "Seleccione el tipo de distribución ";
            // 
            // rb_poisson
            // 
            this.rb_poisson.AutoSize = true;
            this.rb_poisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_poisson.Location = new System.Drawing.Point(49, 188);
            this.rb_poisson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_poisson.Name = "rb_poisson";
            this.rb_poisson.Size = new System.Drawing.Size(342, 35);
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
            this.rb_exponencial.Location = new System.Drawing.Point(49, 146);
            this.rb_exponencial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_exponencial.Name = "rb_exponencial";
            this.rb_exponencial.Size = new System.Drawing.Size(399, 35);
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
            this.rb_uniforme.Location = new System.Drawing.Point(49, 63);
            this.rb_uniforme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_uniforme.Name = "rb_uniforme";
            this.rb_uniforme.Size = new System.Drawing.Size(371, 35);
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
            this.rb_normal.Location = new System.Drawing.Point(49, 105);
            this.rb_normal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_normal.Name = "rb_normal";
            this.rb_normal.Size = new System.Drawing.Size(342, 35);
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
            this.btn_continuar.Location = new System.Drawing.Point(1268, 542);
            this.btn_continuar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(180, 47);
            this.btn_continuar.TabIndex = 30;
            this.btn_continuar.Text = "Continuar";
            this.btn_continuar.UseVisualStyleBackColor = true;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // msk_A
            // 
            this.msk_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.msk_A.Location = new System.Drawing.Point(776, 233);
            this.msk_A.Mask = "99999999";
            this.msk_A.Name = "msk_A";
            this.msk_A.Size = new System.Drawing.Size(133, 37);
            this.msk_A.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.Location = new System.Drawing.Point(724, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 31);
            this.label3.TabIndex = 33;
            this.label3.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.Location = new System.Drawing.Point(915, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 31);
            this.label4.TabIndex = 34;
            this.label4.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label5.Location = new System.Drawing.Point(918, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "δ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label6.Location = new System.Drawing.Point(727, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 31);
            this.label6.TabIndex = 37;
            this.label6.Text = "µ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label7.Location = new System.Drawing.Point(920, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 31);
            this.label7.TabIndex = 42;
            this.label7.Text = "x̄";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label8.Location = new System.Drawing.Point(728, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 31);
            this.label8.TabIndex = 41;
            this.label8.Text = "λ";
            // 
            // msk_B
            // 
            this.msk_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.msk_B.Location = new System.Drawing.Point(988, 233);
            this.msk_B.Mask = "99999999";
            this.msk_B.Name = "msk_B";
            this.msk_B.Size = new System.Drawing.Size(133, 37);
            this.msk_B.TabIndex = 43;
            // 
            // msk_de
            // 
            this.msk_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.msk_de.Location = new System.Drawing.Point(988, 289);
            this.msk_de.Mask = "99999999";
            this.msk_de.Name = "msk_de";
            this.msk_de.Size = new System.Drawing.Size(133, 37);
            this.msk_de.TabIndex = 45;
            // 
            // msk_media_normal
            // 
            this.msk_media_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.msk_media_normal.Location = new System.Drawing.Point(776, 289);
            this.msk_media_normal.Mask = "99999999";
            this.msk_media_normal.Name = "msk_media_normal";
            this.msk_media_normal.Size = new System.Drawing.Size(133, 37);
            this.msk_media_normal.TabIndex = 44;
            // 
            // msk_media_exp
            // 
            this.msk_media_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.msk_media_exp.Location = new System.Drawing.Point(988, 343);
            this.msk_media_exp.Mask = "99999999";
            this.msk_media_exp.Name = "msk_media_exp";
            this.msk_media_exp.Size = new System.Drawing.Size(133, 37);
            this.msk_media_exp.TabIndex = 47;
            // 
            // msk_lam_exp
            // 
            this.msk_lam_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.msk_lam_exp.Location = new System.Drawing.Point(776, 343);
            this.msk_lam_exp.Mask = "99999999";
            this.msk_lam_exp.Name = "msk_lam_exp";
            this.msk_lam_exp.Size = new System.Drawing.Size(133, 37);
            this.msk_lam_exp.TabIndex = 46;
            // 
            // msk_media_poi
            // 
            this.msk_media_poi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.msk_media_poi.Location = new System.Drawing.Point(988, 398);
            this.msk_media_poi.Mask = "99999999";
            this.msk_media_poi.Name = "msk_media_poi";
            this.msk_media_poi.Size = new System.Drawing.Size(133, 37);
            this.msk_media_poi.TabIndex = 51;
            // 
            // msk_lam_poi
            // 
            this.msk_lam_poi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.msk_lam_poi.Location = new System.Drawing.Point(776, 398);
            this.msk_lam_poi.Mask = "99999999";
            this.msk_lam_poi.Name = "msk_lam_poi";
            this.msk_lam_poi.Size = new System.Drawing.Size(133, 37);
            this.msk_lam_poi.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label9.Location = new System.Drawing.Point(920, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 31);
            this.label9.TabIndex = 49;
            this.label9.Text = "x̄";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label10.Location = new System.Drawing.Point(728, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 31);
            this.label10.TabIndex = 48;
            this.label10.Text = "λ";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1464, 603);
            this.ControlBox = false;
            this.Controls.Add(this.msk_media_poi);
            this.Controls.Add(this.msk_lam_poi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.msk_media_exp);
            this.Controls.Add(this.msk_lam_exp);
            this.Controls.Add(this.msk_de);
            this.Controls.Add(this.msk_media_normal);
            this.Controls.Add(this.msk_B);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msk_A);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.gb_distribucion);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gb_distribucion.ResumeLayout(false);
            this.gb_distribucion.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox msk_A;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox msk_B;
        private System.Windows.Forms.MaskedTextBox msk_de;
        private System.Windows.Forms.MaskedTextBox msk_media_normal;
        private System.Windows.Forms.MaskedTextBox msk_media_exp;
        private System.Windows.Forms.MaskedTextBox msk_lam_exp;
        private System.Windows.Forms.MaskedTextBox msk_media_poi;
        private System.Windows.Forms.MaskedTextBox msk_lam_poi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

