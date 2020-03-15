namespace Metodos_Numericos
{
    partial class Ea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ea));
            this.TxtActual = new System.Windows.Forms.TextBox();
            this.TxtAnterior = new System.Windows.Forms.TextBox();
            this.LblActual = new System.Windows.Forms.Label();
            this.LblAnterior = new System.Windows.Forms.Label();
            this.BtnEa = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtActual
            // 
            this.TxtActual.Location = new System.Drawing.Point(180, 12);
            this.TxtActual.Name = "TxtActual";
            this.TxtActual.Size = new System.Drawing.Size(100, 20);
            this.TxtActual.TabIndex = 0;
            this.TxtActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtActual_KeyPress);
            // 
            // TxtAnterior
            // 
            this.TxtAnterior.Location = new System.Drawing.Point(180, 48);
            this.TxtAnterior.Name = "TxtAnterior";
            this.TxtAnterior.Size = new System.Drawing.Size(100, 20);
            this.TxtAnterior.TabIndex = 1;
            this.TxtAnterior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAnterior_KeyPress);
            // 
            // LblActual
            // 
            this.LblActual.AutoSize = true;
            this.LblActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblActual.Location = new System.Drawing.Point(14, 13);
            this.LblActual.Name = "LblActual";
            this.LblActual.Size = new System.Drawing.Size(160, 16);
            this.LblActual.TabIndex = 2;
            this.LblActual.Text = "Dame el valor Actual: ";
            // 
            // LblAnterior
            // 
            this.LblAnterior.AutoSize = true;
            this.LblAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnterior.Location = new System.Drawing.Point(3, 52);
            this.LblAnterior.Name = "LblAnterior";
            this.LblAnterior.Size = new System.Drawing.Size(171, 16);
            this.LblAnterior.TabIndex = 3;
            this.LblAnterior.Text = "Dame el valor Anterior: ";
            // 
            // BtnEa
            // 
            this.BtnEa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEa.Location = new System.Drawing.Point(123, 87);
            this.BtnEa.Name = "BtnEa";
            this.BtnEa.Size = new System.Drawing.Size(41, 23);
            this.BtnEa.TabIndex = 4;
            this.BtnEa.Text = "Ea";
            this.BtnEa.UseVisualStyleBackColor = true;
            this.BtnEa.Click += new System.EventHandler(this.BtnEa_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.BackgroundImage")));
            this.BtnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.Location = new System.Drawing.Point(251, 88);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(29, 23);
            this.BtnRegresar.TabIndex = 11;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Ea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 122);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnEa);
            this.Controls.Add(this.LblAnterior);
            this.Controls.Add(this.LblActual);
            this.Controls.Add(this.TxtAnterior);
            this.Controls.Add(this.TxtActual);
            this.Name = "Ea";
            this.Text = "Ea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtActual;
        private System.Windows.Forms.TextBox TxtAnterior;
        private System.Windows.Forms.Label LblActual;
        private System.Windows.Forms.Label LblAnterior;
        private System.Windows.Forms.Button BtnEa;
        private System.Windows.Forms.Button BtnRegresar;
    }
}