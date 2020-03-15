namespace Metodos_Numericos
{
    partial class FrmMenuIntervalo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuIntervalo));
            this.BtnEjemplo1 = new System.Windows.Forms.Button();
            this.BtnEjemplo2 = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.LblCoeficiente = new System.Windows.Forms.Label();
            this.Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEjemplo1
            // 
            this.BtnEjemplo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEjemplo1.Location = new System.Drawing.Point(39, 21);
            this.BtnEjemplo1.Name = "BtnEjemplo1";
            this.BtnEjemplo1.Size = new System.Drawing.Size(75, 23);
            this.BtnEjemplo1.TabIndex = 0;
            this.BtnEjemplo1.Text = "Ejemplo1";
            this.BtnEjemplo1.UseVisualStyleBackColor = true;
            this.BtnEjemplo1.Click += new System.EventHandler(this.BtnEjemplo1_Click);
            // 
            // BtnEjemplo2
            // 
            this.BtnEjemplo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEjemplo2.Location = new System.Drawing.Point(272, 21);
            this.BtnEjemplo2.Name = "BtnEjemplo2";
            this.BtnEjemplo2.Size = new System.Drawing.Size(75, 23);
            this.BtnEjemplo2.TabIndex = 1;
            this.BtnEjemplo2.Text = "Ejemplo2";
            this.BtnEjemplo2.UseVisualStyleBackColor = true;
            this.BtnEjemplo2.Click += new System.EventHandler(this.BtnEjemplo2_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.BackgroundImage")));
            this.BtnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.Location = new System.Drawing.Point(357, 86);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(29, 23);
            this.BtnRegresar.TabIndex = 13;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // LblCoeficiente
            // 
            this.LblCoeficiente.AutoSize = true;
            this.LblCoeficiente.Location = new System.Drawing.Point(22, 54);
            this.LblCoeficiente.Name = "LblCoeficiente";
            this.LblCoeficiente.Size = new System.Drawing.Size(114, 13);
            this.LblCoeficiente.TabIndex = 14;
            this.LblCoeficiente.Text = "Coeficiente de Arrastre";
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(259, 54);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(113, 13);
            this.Lbl.TabIndex = 15;
            this.Lbl.Text = "f(x) = sen 10x + cos 3x";
            // 
            // FrmMenuIntervalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 114);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.LblCoeficiente);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnEjemplo2);
            this.Controls.Add(this.BtnEjemplo1);
            this.Name = "FrmMenuIntervalo";
            this.Text = "FrmMenuIntervalo";
            this.Load += new System.EventHandler(this.FrmMenuIntervalo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEjemplo1;
        private System.Windows.Forms.Button BtnEjemplo2;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label LblCoeficiente;
        private System.Windows.Forms.Label Lbl;
    }
}