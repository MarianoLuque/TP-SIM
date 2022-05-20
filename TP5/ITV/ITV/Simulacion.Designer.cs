namespace ITV
{
    partial class Simulacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulacion));
            this.btn_cerrar_programa = new System.Windows.Forms.Button();
            this.btn_simular = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar_programa
            // 
            this.btn_cerrar_programa.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_programa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_programa.BackgroundImage")));
            this.btn_cerrar_programa.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_programa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_programa.Location = new System.Drawing.Point(1336, 12);
            this.btn_cerrar_programa.Name = "btn_cerrar_programa";
            this.btn_cerrar_programa.Size = new System.Drawing.Size(41, 41);
            this.btn_cerrar_programa.TabIndex = 17;
            this.btn_cerrar_programa.UseVisualStyleBackColor = false;
            // 
            // btn_simular
            // 
            this.btn_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.Location = new System.Drawing.Point(807, 101);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(104, 34);
            this.btn_simular.TabIndex = 22;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(484, 101);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(104, 34);
            this.btn_volver.TabIndex = 23;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 42);
            this.label1.TabIndex = 24;
            this.label1.Text = "Simulación de colas - ITV";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1365, 513);
            this.dataGridView1.TabIndex = 25;
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1389, 676);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.btn_cerrar_programa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Simulacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar_programa;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}