namespace Pares_e_Impares
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumeros = new System.Windows.Forms.TextBox();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblRecursivo = new System.Windows.Forms.Label();
            this.LblIterativo = new System.Windows.Forms.Label();
            this.TxtResultado2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dame los numeros separados por una coma:";
            // 
            // TxtNumeros
            // 
            this.TxtNumeros.Location = new System.Drawing.Point(244, 2);
            this.TxtNumeros.Name = "TxtNumeros";
            this.TxtNumeros.Size = new System.Drawing.Size(558, 20);
            this.TxtNumeros.TabIndex = 1;
            this.TxtNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Location = new System.Drawing.Point(354, 28);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(75, 23);
            this.BtnVerificar.TabIndex = 2;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(12, 57);
            this.TxtResultado.Multiline = true;
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(790, 69);
            this.TxtResultado.TabIndex = 3;
            // 
            // LblRecursivo
            // 
            this.LblRecursivo.AutoSize = true;
            this.LblRecursivo.Location = new System.Drawing.Point(12, 33);
            this.LblRecursivo.Name = "LblRecursivo";
            this.LblRecursivo.Size = new System.Drawing.Size(96, 13);
            this.LblRecursivo.TabIndex = 4;
            this.LblRecursivo.Text = "Tiempo Recursivo:";
            // 
            // LblIterativo
            // 
            this.LblIterativo.AutoSize = true;
            this.LblIterativo.Location = new System.Drawing.Point(12, 138);
            this.LblIterativo.Name = "LblIterativo";
            this.LblIterativo.Size = new System.Drawing.Size(86, 13);
            this.LblIterativo.TabIndex = 5;
            this.LblIterativo.Text = "Tiempo Iterativo:";
            // 
            // TxtResultado2
            // 
            this.TxtResultado2.Location = new System.Drawing.Point(12, 154);
            this.TxtResultado2.Multiline = true;
            this.TxtResultado2.Name = "TxtResultado2";
            this.TxtResultado2.Size = new System.Drawing.Size(790, 69);
            this.TxtResultado2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 244);
            this.Controls.Add(this.TxtResultado2);
            this.Controls.Add(this.LblIterativo);
            this.Controls.Add(this.LblRecursivo);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.TxtNumeros);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumeros;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblRecursivo;
        private System.Windows.Forms.Label LblIterativo;
        private System.Windows.Forms.TextBox TxtResultado2;
    }
}

