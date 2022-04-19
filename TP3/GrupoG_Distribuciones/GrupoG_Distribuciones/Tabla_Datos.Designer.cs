
namespace GrupoG_Distribuciones
{
    partial class Tabla_Datos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabla_Datos));
            this.btn_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_rnd = new System.Windows.Forms.DataGridView();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.dataSet11 = new GrupoG_Distribuciones.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(1131, 14);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(55, 50);
            this.btn_salir.TabIndex = 26;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 54);
            this.label1.TabIndex = 27;
            this.label1.Text = "Generación de variables aleatorias";
            // 
            // dg_rnd
            // 
            this.dg_rnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_rnd.Location = new System.Drawing.Point(204, 92);
            this.dg_rnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dg_rnd.Name = "dg_rnd";
            this.dg_rnd.RowHeadersWidth = 51;
            this.dg_rnd.RowTemplate.Height = 24;
            this.dg_rnd.Size = new System.Drawing.Size(736, 487);
            this.dg_rnd.TabIndex = 28;
            // 
            // btn_continuar
            // 
            this.btn_continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_continuar.Location = new System.Drawing.Point(997, 534);
            this.btn_continuar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(169, 46);
            this.btn_continuar.TabIndex = 29;
            this.btn_continuar.Text = "Continuar";
            this.btn_continuar.UseVisualStyleBackColor = true;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(36, 534);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(117, 46);
            this.btn_volver.TabIndex = 30;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tabla_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1197, 656);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.dg_rnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tabla_Datos";
            this.Text = "Tabla_Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dg_rnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_rnd;
        private System.Windows.Forms.Button btn_continuar;
        private System.Windows.Forms.Button btn_volver;
        private DataSet1 dataSet11;
    }
}