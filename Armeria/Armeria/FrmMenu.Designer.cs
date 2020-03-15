namespace Armeria
{
    partial class FrmMenu
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
            this.BtnCliente = new System.Windows.Forms.Button();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.LblSaludo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCliente
            // 
            this.BtnCliente.BackColor = System.Drawing.Color.Silver;
            this.BtnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.Location = new System.Drawing.Point(57, 80);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(75, 23);
            this.BtnCliente.TabIndex = 0;
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.UseVisualStyleBackColor = false;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // BtnProducto
            // 
            this.BtnProducto.BackColor = System.Drawing.Color.Silver;
            this.BtnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducto.Location = new System.Drawing.Point(241, 80);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(78, 23);
            this.BtnProducto.TabIndex = 1;
            this.BtnProducto.Text = "Producto";
            this.BtnProducto.UseVisualStyleBackColor = false;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // LblSaludo
            // 
            this.LblSaludo.AutoSize = true;
            this.LblSaludo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaludo.ForeColor = System.Drawing.Color.Silver;
            this.LblSaludo.Location = new System.Drawing.Point(95, 23);
            this.LblSaludo.Name = "LblSaludo";
            this.LblSaludo.Size = new System.Drawing.Size(187, 24);
            this.LblSaludo.TabIndex = 2;
            this.LblSaludo.Text = "Bienvenido Javier ";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(361, 144);
            this.Controls.Add(this.LblSaludo);
            this.Controls.Add(this.BtnProducto);
            this.Controls.Add(this.BtnCliente);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Label LblSaludo;
    }
}