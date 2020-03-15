namespace Metodos_Numericos
{
    partial class FrmIteracionPunto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIteracionPunto));
            this.TxtX = new System.Windows.Forms.TextBox();
            this.TxtY = new System.Windows.Forms.TextBox();
            this.LblX = new System.Windows.Forms.Label();
            this.LblY = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnRegresar2 = new System.Windows.Forms.Button();
            this.LblValor = new System.Windows.Forms.Label();
            this.LblVx = new System.Windows.Forms.Label();
            this.LblVy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtX
            // 
            this.TxtX.Location = new System.Drawing.Point(36, 16);
            this.TxtX.Name = "TxtX";
            this.TxtX.Size = new System.Drawing.Size(39, 20);
            this.TxtX.TabIndex = 0;
            this.TxtX.TextChanged += new System.EventHandler(this.TxtX_TextChanged);
            this.TxtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtX_KeyPress);
            // 
            // TxtY
            // 
            this.TxtY.Location = new System.Drawing.Point(36, 49);
            this.TxtY.Name = "TxtY";
            this.TxtY.Size = new System.Drawing.Size(39, 20);
            this.TxtY.TabIndex = 1;
            this.TxtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtY_KeyPress);
            // 
            // LblX
            // 
            this.LblX.AutoSize = true;
            this.LblX.Location = new System.Drawing.Point(13, 19);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(17, 13);
            this.LblX.TabIndex = 2;
            this.LblX.Text = "X:";
            // 
            // LblY
            // 
            this.LblY.AutoSize = true;
            this.LblY.Location = new System.Drawing.Point(12, 53);
            this.LblY.Name = "LblY";
            this.LblY.Size = new System.Drawing.Size(17, 13);
            this.LblY.TabIndex = 3;
            this.LblY.Text = "Y:";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(163, 12);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnRegresar2
            // 
            this.BtnRegresar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegresar2.BackgroundImage")));
            this.BtnRegresar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegresar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar2.Location = new System.Drawing.Point(219, 88);
            this.BtnRegresar2.Name = "BtnRegresar2";
            this.BtnRegresar2.Size = new System.Drawing.Size(29, 23);
            this.BtnRegresar2.TabIndex = 34;
            this.BtnRegresar2.UseVisualStyleBackColor = true;
            this.BtnRegresar2.Click += new System.EventHandler(this.BtnRegresar2_Click);
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Location = new System.Drawing.Point(13, 92);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(0, 13);
            this.LblValor.TabIndex = 35;
            // 
            // LblVx
            // 
            this.LblVx.AutoSize = true;
            this.LblVx.Location = new System.Drawing.Point(13, 75);
            this.LblVx.Name = "LblVx";
            this.LblVx.Size = new System.Drawing.Size(0, 13);
            this.LblVx.TabIndex = 36;
            // 
            // LblVy
            // 
            this.LblVy.AutoSize = true;
            this.LblVy.Location = new System.Drawing.Point(13, 92);
            this.LblVy.Name = "LblVy";
            this.LblVy.Size = new System.Drawing.Size(0, 13);
            this.LblVy.TabIndex = 37;
            // 
            // FrmIteracionPunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 114);
            this.Controls.Add(this.LblVy);
            this.Controls.Add(this.LblVx);
            this.Controls.Add(this.LblValor);
            this.Controls.Add(this.BtnRegresar2);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.LblY);
            this.Controls.Add(this.LblX);
            this.Controls.Add(this.TxtY);
            this.Controls.Add(this.TxtX);
            this.Name = "FrmIteracionPunto";
            this.Text = "FrmIteracionPunto";
            this.Load += new System.EventHandler(this.FrmIteracionPunto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtX;
        private System.Windows.Forms.TextBox TxtY;
        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.Label LblY;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnRegresar2;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.Label LblVx;
        private System.Windows.Forms.Label LblVy;
    }
}