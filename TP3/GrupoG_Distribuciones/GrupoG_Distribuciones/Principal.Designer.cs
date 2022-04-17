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
            this.rb_normal = new System.Windows.Forms.RadioButton();
            this.rb_uniforme = new System.Windows.Forms.RadioButton();
            this.rb_exponencial = new System.Windows.Forms.RadioButton();
            this.rb_poisson = new System.Windows.Forms.RadioButton();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.gb_distribucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(1045, 12);
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
            this.txt_cantidad.Mask = "99999";
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(69, 26);
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
            this.gb_distribucion.Location = new System.Drawing.Point(45, 162);
            this.gb_distribucion.Name = "gb_distribucion";
            this.gb_distribucion.Size = new System.Drawing.Size(464, 218);
            this.gb_distribucion.TabIndex = 29;
            this.gb_distribucion.TabStop = false;
            this.gb_distribucion.Text = "Seleccione el tipo de distribución ";
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
            // rb_exponencial
            // 
            this.rb_exponencial.AutoSize = true;
            this.rb_exponencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_exponencial.Location = new System.Drawing.Point(37, 119);
            this.rb_exponencial.Name = "rb_exponencial";
            this.rb_exponencial.Size = new System.Drawing.Size(321, 29);
            this.rb_exponencial.TabIndex = 0;
            this.rb_exponencial.TabStop = true;
            this.rb_exponencial.Text = "Distribución Exponencial (λ, x̄)";
            this.rb_exponencial.UseVisualStyleBackColor = true;
            this.rb_exponencial.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rb_poisson
            // 
            this.rb_poisson.AutoSize = true;
            this.rb_poisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_poisson.Location = new System.Drawing.Point(37, 153);
            this.rb_poisson.Name = "rb_poisson";
            this.rb_poisson.Size = new System.Drawing.Size(274, 29);
            this.rb_poisson.TabIndex = 0;
            this.rb_poisson.TabStop = true;
            this.rb_poisson.Text = "Distribución Poisson(λ, x̄)";
            this.rb_poisson.UseVisualStyleBackColor = true;
            this.rb_poisson.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // btn_continuar
            // 
            this.btn_continuar.Enabled = false;
            this.btn_continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuar.Location = new System.Drawing.Point(951, 440);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(135, 38);
            this.btn_continuar.TabIndex = 30;
            this.btn_continuar.Text = "Continuar";
            this.btn_continuar.UseVisualStyleBackColor = true;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1098, 490);
            this.ControlBox = false;
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.gb_distribucion);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
    }
}

