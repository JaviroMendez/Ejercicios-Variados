namespace SinMath
{
    partial class SinMath
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
            this.components = new System.ComponentModel.Container();
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblElevar = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtElevar = new System.Windows.Forms.TextBox();
            this.LblTr = new System.Windows.Forms.Label();
            this.LblTi = new System.Windows.Forms.Label();
            this.BtnYa = new System.Windows.Forms.Button();
            this.TxtRr = new System.Windows.Forms.TextBox();
            this.TxtRi = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumero.Location = new System.Drawing.Point(12, 9);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(153, 13);
            this.LblNumero.TabIndex = 0;
            this.LblNumero.Text = "Dame el numero a Elevar:";
            // 
            // LblElevar
            // 
            this.LblElevar.AutoSize = true;
            this.LblElevar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblElevar.Location = new System.Drawing.Point(51, 39);
            this.LblElevar.Name = "LblElevar";
            this.LblElevar.Size = new System.Drawing.Size(114, 13);
            this.LblElevar.TabIndex = 1;
            this.LblElevar.Text = "A cuanto elevaras:";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(171, 2);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(100, 20);
            this.TxtNumero.TabIndex = 2;
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // TxtElevar
            // 
            this.TxtElevar.Location = new System.Drawing.Point(171, 32);
            this.TxtElevar.Name = "TxtElevar";
            this.TxtElevar.Size = new System.Drawing.Size(100, 20);
            this.TxtElevar.TabIndex = 3;
            this.TxtElevar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtElevar_KeyPress);
            // 
            // LblTr
            // 
            this.LblTr.AutoSize = true;
            this.LblTr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTr.Location = new System.Drawing.Point(12, 75);
            this.LblTr.Name = "LblTr";
            this.LblTr.Size = new System.Drawing.Size(0, 13);
            this.LblTr.TabIndex = 4;
            // 
            // LblTi
            // 
            this.LblTi.AutoSize = true;
            this.LblTi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTi.Location = new System.Drawing.Point(12, 103);
            this.LblTi.Name = "LblTi";
            this.LblTi.Size = new System.Drawing.Size(0, 13);
            this.LblTi.TabIndex = 5;
            // 
            // BtnYa
            // 
            this.BtnYa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnYa.Location = new System.Drawing.Point(293, 12);
            this.BtnYa.Name = "BtnYa";
            this.BtnYa.Size = new System.Drawing.Size(35, 23);
            this.BtnYa.TabIndex = 6;
            this.BtnYa.Text = "Ya";
            this.BtnYa.UseVisualStyleBackColor = true;
            this.BtnYa.Click += new System.EventHandler(this.BtnYa_Click);
            // 
            // TxtRr
            // 
            this.TxtRr.Location = new System.Drawing.Point(228, 75);
            this.TxtRr.Name = "TxtRr";
            this.TxtRr.Size = new System.Drawing.Size(100, 20);
            this.TxtRr.TabIndex = 7;
            // 
            // TxtRi
            // 
            this.TxtRi.Location = new System.Drawing.Point(228, 103);
            this.TxtRi.Name = "TxtRi";
            this.TxtRi.Size = new System.Drawing.Size(100, 20);
            this.TxtRi.TabIndex = 8;
            // 
            // SinMath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 129);
            this.Controls.Add(this.TxtRi);
            this.Controls.Add(this.TxtRr);
            this.Controls.Add(this.BtnYa);
            this.Controls.Add(this.LblTi);
            this.Controls.Add(this.LblTr);
            this.Controls.Add(this.TxtElevar);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.LblElevar);
            this.Controls.Add(this.LblNumero);
            this.Name = "SinMath";
            this.Text = "SinMath";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblElevar;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtElevar;
        private System.Windows.Forms.Label LblTr;
        private System.Windows.Forms.Label LblTi;
        private System.Windows.Forms.Button BtnYa;
        private System.Windows.Forms.TextBox TxtRr;
        private System.Windows.Forms.TextBox TxtRi;
        private System.Windows.Forms.Timer timer1;
    }
}

