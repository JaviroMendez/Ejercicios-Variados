namespace MultiplosDe3HastaEl1000Descendiente
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
            this.LblMultiplosRecursivo = new System.Windows.Forms.Label();
            this.LblMultiplosIterativo = new System.Windows.Forms.Label();
            this.TxtRecursivo = new System.Windows.Forms.TextBox();
            this.TxtIterativo = new System.Windows.Forms.TextBox();
            this.LblRecursivoTiempo = new System.Windows.Forms.Label();
            this.LblIterativoTiempo = new System.Windows.Forms.Label();
            this.BtnGo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblMultiplosRecursivo
            // 
            this.LblMultiplosRecursivo.AutoSize = true;
            this.LblMultiplosRecursivo.Location = new System.Drawing.Point(12, 24);
            this.LblMultiplosRecursivo.Name = "LblMultiplosRecursivo";
            this.LblMultiplosRecursivo.Size = new System.Drawing.Size(260, 13);
            this.LblMultiplosRecursivo.TabIndex = 0;
            this.LblMultiplosRecursivo.Text = "Multiplos de 3 Hasta el 1000 de Forma Descendiente:";
            // 
            // LblMultiplosIterativo
            // 
            this.LblMultiplosIterativo.AutoSize = true;
            this.LblMultiplosIterativo.Location = new System.Drawing.Point(12, 275);
            this.LblMultiplosIterativo.Name = "LblMultiplosIterativo";
            this.LblMultiplosIterativo.Size = new System.Drawing.Size(260, 13);
            this.LblMultiplosIterativo.TabIndex = 1;
            this.LblMultiplosIterativo.Text = "Multiplos de 3 Hasta el 1000 de Forma Descendiente:";
            // 
            // TxtRecursivo
            // 
            this.TxtRecursivo.Location = new System.Drawing.Point(278, 24);
            this.TxtRecursivo.Multiline = true;
            this.TxtRecursivo.Name = "TxtRecursivo";
            this.TxtRecursivo.Size = new System.Drawing.Size(806, 145);
            this.TxtRecursivo.TabIndex = 2;
            // 
            // TxtIterativo
            // 
            this.TxtIterativo.Location = new System.Drawing.Point(278, 275);
            this.TxtIterativo.Multiline = true;
            this.TxtIterativo.Name = "TxtIterativo";
            this.TxtIterativo.Size = new System.Drawing.Size(806, 145);
            this.TxtIterativo.TabIndex = 3;
            // 
            // LblRecursivoTiempo
            // 
            this.LblRecursivoTiempo.AutoSize = true;
            this.LblRecursivoTiempo.Location = new System.Drawing.Point(12, 46);
            this.LblRecursivoTiempo.Name = "LblRecursivoTiempo";
            this.LblRecursivoTiempo.Size = new System.Drawing.Size(96, 13);
            this.LblRecursivoTiempo.TabIndex = 4;
            this.LblRecursivoTiempo.Text = "Tiempo Recursivo:";
            // 
            // LblIterativoTiempo
            // 
            this.LblIterativoTiempo.AutoSize = true;
            this.LblIterativoTiempo.Location = new System.Drawing.Point(12, 304);
            this.LblIterativoTiempo.Name = "LblIterativoTiempo";
            this.LblIterativoTiempo.Size = new System.Drawing.Size(86, 13);
            this.LblIterativoTiempo.TabIndex = 5;
            this.LblIterativoTiempo.Text = "Tiempo Iterativo:";
            // 
            // BtnGo
            // 
            this.BtnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGo.Location = new System.Drawing.Point(632, 175);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(73, 53);
            this.BtnGo.TabIndex = 6;
            this.BtnGo.Text = "Go";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 426);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.LblIterativoTiempo);
            this.Controls.Add(this.LblRecursivoTiempo);
            this.Controls.Add(this.TxtIterativo);
            this.Controls.Add(this.TxtRecursivo);
            this.Controls.Add(this.LblMultiplosIterativo);
            this.Controls.Add(this.LblMultiplosRecursivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMultiplosRecursivo;
        private System.Windows.Forms.Label LblMultiplosIterativo;
        private System.Windows.Forms.TextBox TxtRecursivo;
        private System.Windows.Forms.TextBox TxtIterativo;
        private System.Windows.Forms.Label LblRecursivoTiempo;
        private System.Windows.Forms.Label LblIterativoTiempo;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.Timer timer1;
    }
}

