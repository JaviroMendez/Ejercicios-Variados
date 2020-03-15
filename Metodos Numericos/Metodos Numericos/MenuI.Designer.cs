namespace Metodos_Numericos
{
    partial class MenuI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuI));
            this.BtnSerieMaclaurin = new System.Windows.Forms.Button();
            this.BtnRegresar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSerieMaclaurin
            // 
            this.BtnSerieMaclaurin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSerieMaclaurin.Location = new System.Drawing.Point(40, 31);
            this.BtnSerieMaclaurin.Name = "BtnSerieMaclaurin";
            this.BtnSerieMaclaurin.Size = new System.Drawing.Size(139, 23);
            this.BtnSerieMaclaurin.TabIndex = 1;
            this.BtnSerieMaclaurin.Text = "Serie de Maclaurin";
            this.BtnSerieMaclaurin.UseVisualStyleBackColor = true;
            this.BtnSerieMaclaurin.Click += new System.EventHandler(this.BtnSerieMaclaurin_Click);
            // 
            // BtnRegresar2
            // 
            this.BtnRegresar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegresar2.BackgroundImage")));
            this.BtnRegresar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegresar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar2.Location = new System.Drawing.Point(188, 62);
            this.BtnRegresar2.Name = "BtnRegresar2";
            this.BtnRegresar2.Size = new System.Drawing.Size(29, 23);
            this.BtnRegresar2.TabIndex = 34;
            this.BtnRegresar2.UseVisualStyleBackColor = true;
            this.BtnRegresar2.Click += new System.EventHandler(this.BtnRegresar2_Click);
            // 
            // MenuI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 97);
            this.Controls.Add(this.BtnRegresar2);
            this.Controls.Add(this.BtnSerieMaclaurin);
            this.Name = "MenuI";
            this.Text = "MenuI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSerieMaclaurin;
        private System.Windows.Forms.Button BtnRegresar2;
    }
}