namespace Factorial
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
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblResultadoRecursivo1 = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.BtnFactorial = new System.Windows.Forms.Button();
            this.LblRecursivo = new System.Windows.Forms.Label();
            this.LblIterativo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TxtResultado2 = new System.Windows.Forms.TextBox();
            this.LblResultadoRecursivo2 = new System.Windows.Forms.Label();
            this.LblResultadoIterativo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumero.Location = new System.Drawing.Point(28, 23);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(66, 16);
            this.LblNumero.TabIndex = 0;
            this.LblNumero.Text = "Numero:";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(100, 19);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(100, 20);
            this.TxtNumero.TabIndex = 1;
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // LblResultadoRecursivo1
            // 
            this.LblResultadoRecursivo1.AutoSize = true;
            this.LblResultadoRecursivo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultadoRecursivo1.Location = new System.Drawing.Point(11, 80);
            this.LblResultadoRecursivo1.Name = "LblResultadoRecursivo1";
            this.LblResultadoRecursivo1.Size = new System.Drawing.Size(79, 16);
            this.LblResultadoRecursivo1.TabIndex = 2;
            this.LblResultadoRecursivo1.Text = "Resultado";
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(100, 76);
            this.TxtResultado.Multiline = true;
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(1245, 575);
            this.TxtResultado.TabIndex = 3;
            this.TxtResultado.TextChanged += new System.EventHandler(this.TxtResultado_TextChanged);
            this.TxtResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtResultado_KeyPress);
            // 
            // BtnFactorial
            // 
            this.BtnFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFactorial.Location = new System.Drawing.Point(220, 17);
            this.BtnFactorial.Name = "BtnFactorial";
            this.BtnFactorial.Size = new System.Drawing.Size(83, 23);
            this.BtnFactorial.TabIndex = 4;
            this.BtnFactorial.Text = "Factorial";
            this.BtnFactorial.UseVisualStyleBackColor = true;
            this.BtnFactorial.Click += new System.EventHandler(this.BtnFactorial_Click);
            // 
            // LblRecursivo
            // 
            this.LblRecursivo.AutoSize = true;
            this.LblRecursivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecursivo.Location = new System.Drawing.Point(12, 654);
            this.LblRecursivo.Name = "LblRecursivo";
            this.LblRecursivo.Size = new System.Drawing.Size(139, 16);
            this.LblRecursivo.TabIndex = 5;
            this.LblRecursivo.Text = "Tiempo Recursivo:";
            // 
            // LblIterativo
            // 
            this.LblIterativo.AutoSize = true;
            this.LblIterativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIterativo.Location = new System.Drawing.Point(12, 680);
            this.LblIterativo.Name = "LblIterativo";
            this.LblIterativo.Size = new System.Drawing.Size(125, 16);
            this.LblIterativo.TabIndex = 6;
            this.LblIterativo.Text = "Tiempo Iterativo:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TxtResultado2
            // 
            this.TxtResultado2.Location = new System.Drawing.Point(481, 19);
            this.TxtResultado2.Name = "TxtResultado2";
            this.TxtResultado2.Size = new System.Drawing.Size(864, 20);
            this.TxtResultado2.TabIndex = 7;
            // 
            // LblResultadoRecursivo2
            // 
            this.LblResultadoRecursivo2.AutoSize = true;
            this.LblResultadoRecursivo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultadoRecursivo2.Location = new System.Drawing.Point(12, 96);
            this.LblResultadoRecursivo2.Name = "LblResultadoRecursivo2";
            this.LblResultadoRecursivo2.Size = new System.Drawing.Size(82, 16);
            this.LblResultadoRecursivo2.TabIndex = 8;
            this.LblResultadoRecursivo2.Text = "Recursivo:";
            // 
            // LblResultadoIterativo
            // 
            this.LblResultadoIterativo.AutoSize = true;
            this.LblResultadoIterativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultadoIterativo.Location = new System.Drawing.Point(332, 19);
            this.LblResultadoIterativo.Name = "LblResultadoIterativo";
            this.LblResultadoIterativo.Size = new System.Drawing.Size(143, 16);
            this.LblResultadoIterativo.TabIndex = 9;
            this.LblResultadoIterativo.Text = "Resultado Iterativo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 705);
            this.Controls.Add(this.LblResultadoIterativo);
            this.Controls.Add(this.LblResultadoRecursivo2);
            this.Controls.Add(this.TxtResultado2);
            this.Controls.Add(this.LblIterativo);
            this.Controls.Add(this.LblRecursivo);
            this.Controls.Add(this.BtnFactorial);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.LblResultadoRecursivo1);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.LblNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblResultadoRecursivo1;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button BtnFactorial;
        private System.Windows.Forms.Label LblRecursivo;
        private System.Windows.Forms.Label LblIterativo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TxtResultado2;
        private System.Windows.Forms.Label LblResultadoRecursivo2;
        private System.Windows.Forms.Label LblResultadoIterativo;
    }
}

