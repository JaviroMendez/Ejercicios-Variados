namespace Metodos_Numericos
{
    partial class MenuIII
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuIII));
            this.BtnGauss = new System.Windows.Forms.Button();
            this.BtnIteracion = new System.Windows.Forms.Button();
            this.BtnRegresar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGauss
            // 
            this.BtnGauss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGauss.Location = new System.Drawing.Point(69, 80);
            this.BtnGauss.Name = "BtnGauss";
            this.BtnGauss.Size = new System.Drawing.Size(139, 23);
            this.BtnGauss.TabIndex = 5;
            this.BtnGauss.Text = "Gauss Seidel";
            this.BtnGauss.UseVisualStyleBackColor = true;
            this.BtnGauss.Click += new System.EventHandler(this.BtnGauss_Click);
            // 
            // BtnIteracion
            // 
            this.BtnIteracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIteracion.Location = new System.Drawing.Point(69, 25);
            this.BtnIteracion.Name = "BtnIteracion";
            this.BtnIteracion.Size = new System.Drawing.Size(139, 23);
            this.BtnIteracion.TabIndex = 4;
            this.BtnIteracion.Text = "Iteracion Punto Fijo";
            this.BtnIteracion.UseVisualStyleBackColor = true;
            this.BtnIteracion.Click += new System.EventHandler(this.BtnIteracion_Click);
            // 
            // BtnRegresar2
            // 
            this.BtnRegresar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegresar2.BackgroundImage")));
            this.BtnRegresar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegresar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar2.Location = new System.Drawing.Point(263, 99);
            this.BtnRegresar2.Name = "BtnRegresar2";
            this.BtnRegresar2.Size = new System.Drawing.Size(29, 23);
            this.BtnRegresar2.TabIndex = 36;
            this.BtnRegresar2.UseVisualStyleBackColor = true;
            this.BtnRegresar2.Click += new System.EventHandler(this.BtnRegresar2_Click);
            // 
            // MenuIII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 123);
            this.Controls.Add(this.BtnRegresar2);
            this.Controls.Add(this.BtnGauss);
            this.Controls.Add(this.BtnIteracion);
            this.Name = "MenuIII";
            this.Text = "MenuIII";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGauss;
        private System.Windows.Forms.Button BtnIteracion;
        private System.Windows.Forms.Button BtnRegresar2;
    }
}