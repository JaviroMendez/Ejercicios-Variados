namespace Metodos_Numericos
{
    partial class Et
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Et));
            this.LblVerdadero = new System.Windows.Forms.Label();
            this.LblActual = new System.Windows.Forms.Label();
            this.TxtVerdadero = new System.Windows.Forms.TextBox();
            this.TxtActual = new System.Windows.Forms.TextBox();
            this.BtnEt = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblVerdadero
            // 
            this.LblVerdadero.AutoSize = true;
            this.LblVerdadero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVerdadero.Location = new System.Drawing.Point(12, 26);
            this.LblVerdadero.Name = "LblVerdadero";
            this.LblVerdadero.Size = new System.Drawing.Size(152, 13);
            this.LblVerdadero.TabIndex = 0;
            this.LblVerdadero.Text = "Dame el Valor Verdadero:";
            // 
            // LblActual
            // 
            this.LblActual.AutoSize = true;
            this.LblActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblActual.Location = new System.Drawing.Point(12, 60);
            this.LblActual.Name = "LblActual";
            this.LblActual.Size = new System.Drawing.Size(130, 13);
            this.LblActual.TabIndex = 1;
            this.LblActual.Text = "Dame el Valor Actual:";
            // 
            // TxtVerdadero
            // 
            this.TxtVerdadero.Location = new System.Drawing.Point(180, 19);
            this.TxtVerdadero.Name = "TxtVerdadero";
            this.TxtVerdadero.Size = new System.Drawing.Size(100, 20);
            this.TxtVerdadero.TabIndex = 2;
            this.TxtVerdadero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVerdadero_KeyPress);
            // 
            // TxtActual
            // 
            this.TxtActual.Location = new System.Drawing.Point(180, 57);
            this.TxtActual.Name = "TxtActual";
            this.TxtActual.Size = new System.Drawing.Size(100, 20);
            this.TxtActual.TabIndex = 3;
            this.TxtActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtActual_KeyPress);
            // 
            // BtnEt
            // 
            this.BtnEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEt.Location = new System.Drawing.Point(130, 99);
            this.BtnEt.Name = "BtnEt";
            this.BtnEt.Size = new System.Drawing.Size(47, 23);
            this.BtnEt.TabIndex = 4;
            this.BtnEt.Text = "Et";
            this.BtnEt.UseVisualStyleBackColor = true;
            this.BtnEt.Click += new System.EventHandler(this.BtnEt_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.BackgroundImage")));
            this.BtnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.Location = new System.Drawing.Point(251, 99);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(29, 23);
            this.BtnRegresar.TabIndex = 12;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Et
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 134);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnEt);
            this.Controls.Add(this.TxtActual);
            this.Controls.Add(this.TxtVerdadero);
            this.Controls.Add(this.LblActual);
            this.Controls.Add(this.LblVerdadero);
            this.Name = "Et";
            this.Text = "Et";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblVerdadero;
        private System.Windows.Forms.Label LblActual;
        private System.Windows.Forms.TextBox TxtVerdadero;
        private System.Windows.Forms.TextBox TxtActual;
        private System.Windows.Forms.Button BtnEt;
        private System.Windows.Forms.Button BtnRegresar;
    }
}