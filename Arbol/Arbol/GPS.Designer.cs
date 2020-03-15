namespace Arbol
{
    partial class GPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPS));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CbOrigen = new System.Windows.Forms.ComboBox();
            this.CbDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnTrazar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CbOrigen
            // 
            this.CbOrigen.FormattingEnabled = true;
            this.CbOrigen.Location = new System.Drawing.Point(5, 44);
            this.CbOrigen.Name = "CbOrigen";
            this.CbOrigen.Size = new System.Drawing.Size(121, 21);
            this.CbOrigen.TabIndex = 1;
            // 
            // CbDestino
            // 
            this.CbDestino.FormattingEnabled = true;
            this.CbDestino.Location = new System.Drawing.Point(5, 102);
            this.CbDestino.Name = "CbDestino";
            this.CbDestino.Size = new System.Drawing.Size(121, 21);
            this.CbDestino.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destino:";
            // 
            // BtnTrazar
            // 
            this.BtnTrazar.Location = new System.Drawing.Point(27, 143);
            this.BtnTrazar.Name = "BtnTrazar";
            this.BtnTrazar.Size = new System.Drawing.Size(75, 23);
            this.BtnTrazar.TabIndex = 5;
            this.BtnTrazar.Text = "Trazar";
            this.BtnTrazar.UseVisualStyleBackColor = true;
            this.BtnTrazar.Click += new System.EventHandler(this.BtnTrazar_Click);
            // 
            // GPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 348);
            this.Controls.Add(this.BtnTrazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbDestino);
            this.Controls.Add(this.CbOrigen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GPS";
            this.Text = "GPS";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CbOrigen;
        private System.Windows.Forms.ComboBox CbDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnTrazar;
    }
}