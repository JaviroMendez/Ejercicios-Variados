namespace Metodos_Numericos
{
    partial class FrmGauss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGauss));
            this.TxtX = new System.Windows.Forms.TextBox();
            this.TxtY = new System.Windows.Forms.TextBox();
            this.TxtZ = new System.Windows.Forms.TextBox();
            this.LblX = new System.Windows.Forms.Label();
            this.LblY = new System.Windows.Forms.Label();
            this.LblZ = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LblVuleltas = new System.Windows.Forms.Label();
            this.BtnRegresar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtX
            // 
            this.TxtX.Location = new System.Drawing.Point(39, 12);
            this.TxtX.Name = "TxtX";
            this.TxtX.Size = new System.Drawing.Size(100, 20);
            this.TxtX.TabIndex = 0;
            this.TxtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtX_KeyPress);
            // 
            // TxtY
            // 
            this.TxtY.Location = new System.Drawing.Point(39, 38);
            this.TxtY.Name = "TxtY";
            this.TxtY.Size = new System.Drawing.Size(100, 20);
            this.TxtY.TabIndex = 1;
            this.TxtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtY_KeyPress);
            // 
            // TxtZ
            // 
            this.TxtZ.Location = new System.Drawing.Point(39, 64);
            this.TxtZ.Name = "TxtZ";
            this.TxtZ.Size = new System.Drawing.Size(100, 20);
            this.TxtZ.TabIndex = 2;
            this.TxtZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtZ_KeyPress);
            // 
            // LblX
            // 
            this.LblX.AutoSize = true;
            this.LblX.Location = new System.Drawing.Point(12, 15);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(17, 13);
            this.LblX.TabIndex = 3;
            this.LblX.Text = "X:";
            // 
            // LblY
            // 
            this.LblY.AutoSize = true;
            this.LblY.Location = new System.Drawing.Point(12, 41);
            this.LblY.Name = "LblY";
            this.LblY.Size = new System.Drawing.Size(17, 13);
            this.LblY.TabIndex = 4;
            this.LblY.Text = "Y:";
            // 
            // LblZ
            // 
            this.LblZ.AutoSize = true;
            this.LblZ.Location = new System.Drawing.Point(12, 67);
            this.LblZ.Name = "LblZ";
            this.LblZ.Size = new System.Drawing.Size(17, 13);
            this.LblZ.TabIndex = 5;
            this.LblZ.Text = "Z:";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(163, 36);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 6;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // LblVuleltas
            // 
            this.LblVuleltas.AutoSize = true;
            this.LblVuleltas.Location = new System.Drawing.Point(12, 126);
            this.LblVuleltas.Name = "LblVuleltas";
            this.LblVuleltas.Size = new System.Drawing.Size(0, 13);
            this.LblVuleltas.TabIndex = 7;
            // 
            // BtnRegresar2
            // 
            this.BtnRegresar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegresar2.BackgroundImage")));
            this.BtnRegresar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegresar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar2.Location = new System.Drawing.Point(304, 137);
            this.BtnRegresar2.Name = "BtnRegresar2";
            this.BtnRegresar2.Size = new System.Drawing.Size(29, 23);
            this.BtnRegresar2.TabIndex = 35;
            this.BtnRegresar2.UseVisualStyleBackColor = true;
            this.BtnRegresar2.Click += new System.EventHandler(this.BtnRegresar2_Click);
            // 
            // FrmGauss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 162);
            this.Controls.Add(this.BtnRegresar2);
            this.Controls.Add(this.LblVuleltas);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.LblZ);
            this.Controls.Add(this.LblY);
            this.Controls.Add(this.LblX);
            this.Controls.Add(this.TxtZ);
            this.Controls.Add(this.TxtY);
            this.Controls.Add(this.TxtX);
            this.Name = "FrmGauss";
            this.Text = "FrmGauss";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtX;
        private System.Windows.Forms.TextBox TxtY;
        private System.Windows.Forms.TextBox TxtZ;
        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.Label LblY;
        private System.Windows.Forms.Label LblZ;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblVuleltas;
        private System.Windows.Forms.Button BtnRegresar2;
    }
}