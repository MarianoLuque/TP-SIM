namespace TP1_GeneradorNumerosPseudoaleatorios.Formularios
{
    partial class SerieLenguaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerieLenguaje));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dg_iteraciones = new System.Windows.Forms.DataGridView();
            this.btn_generar = new System.Windows.Forms.Button();
            this.txt_cantidad = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cerrar_programa = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_cc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_iteraciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dg_iteraciones
            // 
            this.dg_iteraciones.AllowUserToAddRows = false;
            this.dg_iteraciones.AllowUserToDeleteRows = false;
            this.dg_iteraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_iteraciones.Location = new System.Drawing.Point(48, 160);
            this.dg_iteraciones.Name = "dg_iteraciones";
            this.dg_iteraciones.ReadOnly = true;
            this.dg_iteraciones.Size = new System.Drawing.Size(273, 264);
            this.dg_iteraciones.TabIndex = 19;
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(47, 112);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(87, 30);
            this.btn_generar.TabIndex = 20;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(366, 74);
            this.txt_cantidad.Mask = "99999";
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(57, 20);
            this.txt_cantidad.TabIndex = 21;
            this.txt_cantidad.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ingrese la cantidad de numeros a generar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_cerrar_programa);
            this.panel1.Location = new System.Drawing.Point(-72, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 50);
            this.panel1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Generador de números pseudoaleatorios";
            // 
            // btn_cerrar_programa
            // 
            this.btn_cerrar_programa.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_programa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_programa.BackgroundImage")));
            this.btn_cerrar_programa.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_programa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_programa.Location = new System.Drawing.Point(1246, 8);
            this.btn_cerrar_programa.Name = "btn_cerrar_programa";
            this.btn_cerrar_programa.Size = new System.Drawing.Size(41, 41);
            this.btn_cerrar_programa.TabIndex = 9;
            this.btn_cerrar_programa.UseVisualStyleBackColor = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.BackgroundImage")));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(514, 5);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(41, 42);
            this.btn_cerrar.TabIndex = 24;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_cc
            // 
            this.btn_cc.Enabled = false;
            this.btn_cc.Location = new System.Drawing.Point(327, 392);
            this.btn_cc.Name = "btn_cc";
            this.btn_cc.Size = new System.Drawing.Size(144, 32);
            this.btn_cc.TabIndex = 24;
            this.btn_cc.Text = "Prueba de Chi Cuadrado";
            this.btn_cc.UseVisualStyleBackColor = true;
            this.btn_cc.Click += new System.EventHandler(this.btn_cc_Click);
            // 
            // SerieLenguaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.btn_cc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.dg_iteraciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SerieLenguaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SerieLenguaje";
            ((System.ComponentModel.ISupportInitialize)(this.dg_iteraciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.DataGridView dg_iteraciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_cantidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cerrar_programa;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_cc;
    }
}