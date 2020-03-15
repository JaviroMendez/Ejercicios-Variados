namespace ContarNumerosPrimos
{
    partial class Form1
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
            this.TxtNumeros = new System.Windows.Forms.TextBox();
            this.Btnprimos = new System.Windows.Forms.Button();
            this.Lblprimos = new System.Windows.Forms.Label();
            this.Txtprimos = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblTime = new System.Windows.Forms.Label();
            this.LblTr = new System.Windows.Forms.Label();
            this.LblTi = new System.Windows.Forms.Label();
            this.TxtAux = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumero.Location = new System.Drawing.Point(12, 24);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(300, 16);
            this.LblNumero.TabIndex = 0;
            this.LblNumero.Text = "Hasta que Numero quieres Buscar primos:";
            // 
            // TxtNumeros
            // 
            this.TxtNumeros.Location = new System.Drawing.Point(328, 20);
            this.TxtNumeros.Name = "TxtNumeros";
            this.TxtNumeros.Size = new System.Drawing.Size(63, 20);
            this.TxtNumeros.TabIndex = 1;
            this.TxtNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeros_KeyPress);
            // 
            // Btnprimos
            // 
            this.Btnprimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnprimos.Location = new System.Drawing.Point(162, 60);
            this.Btnprimos.Name = "Btnprimos";
            this.Btnprimos.Size = new System.Drawing.Size(75, 23);
            this.Btnprimos.TabIndex = 2;
            this.Btnprimos.Text = "Primos";
            this.Btnprimos.UseVisualStyleBackColor = true;
            this.Btnprimos.Click += new System.EventHandler(this.Btnprimos_Click);
            // 
            // Lblprimos
            // 
            this.Lblprimos.AutoSize = true;
            this.Lblprimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblprimos.Location = new System.Drawing.Point(12, 111);
            this.Lblprimos.Name = "Lblprimos";
            this.Lblprimos.Size = new System.Drawing.Size(0, 13);
            this.Lblprimos.TabIndex = 3;
            // 
            // Txtprimos
            // 
            this.Txtprimos.Location = new System.Drawing.Point(2, 133);
            this.Txtprimos.Multiline = true;
            this.Txtprimos.Name = "Txtprimos";
            this.Txtprimos.Size = new System.Drawing.Size(389, 206);
            this.Txtprimos.TabIndex = 4;
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.Location = new System.Drawing.Point(44, 50);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(58, 13);
            this.LblTime.TabIndex = 5;
            this.LblTime.Text = "Tiempos:";
            // 
            // LblTr
            // 
            this.LblTr.AutoSize = true;
            this.LblTr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTr.Location = new System.Drawing.Point(-1, 65);
            this.LblTr.Name = "LblTr";
            this.LblTr.Size = new System.Drawing.Size(0, 12);
            this.LblTr.TabIndex = 6;
            // 
            // LblTi
            // 
            this.LblTi.AutoSize = true;
            this.LblTi.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTi.Location = new System.Drawing.Point(0, 88);
            this.LblTi.Name = "LblTi";
            this.LblTi.Size = new System.Drawing.Size(0, 12);
            this.LblTi.TabIndex = 7;
            // 
            // TxtAux
            // 
            this.TxtAux.Location = new System.Drawing.Point(291, 104);
            this.TxtAux.Name = "TxtAux";
            this.TxtAux.Size = new System.Drawing.Size(100, 20);
            this.TxtAux.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 351);
            this.Controls.Add(this.TxtAux);
            this.Controls.Add(this.LblTi);
            this.Controls.Add(this.LblTr);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.Txtprimos);
            this.Controls.Add(this.Lblprimos);
            this.Controls.Add(this.Btnprimos);
            this.Controls.Add(this.TxtNumeros);
            this.Controls.Add(this.LblNumero);
            this.Name = "Form1";
            this.Text = "Primos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.TextBox TxtNumeros;
        private System.Windows.Forms.Button Btnprimos;
        private System.Windows.Forms.Label Lblprimos;
        private System.Windows.Forms.TextBox Txtprimos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblTr;
        private System.Windows.Forms.Label LblTi;
        private System.Windows.Forms.TextBox TxtAux;
    }
}

