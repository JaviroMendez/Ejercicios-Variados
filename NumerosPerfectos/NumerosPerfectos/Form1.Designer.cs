namespace NumerosPerfectos
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
            this.LblRango = new System.Windows.Forms.Label();
            this.TxtRango = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblTr = new System.Windows.Forms.Label();
            this.LblTi = new System.Windows.Forms.Label();
            this.TxtNumeros = new System.Windows.Forms.TextBox();
            this.LblNumeros = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TxtAux = new System.Windows.Forms.TextBox();
            this.LblAux = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblRango
            // 
            this.LblRango.AutoSize = true;
            this.LblRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRango.Location = new System.Drawing.Point(12, 9);
            this.LblRango.Name = "LblRango";
            this.LblRango.Size = new System.Drawing.Size(93, 13);
            this.LblRango.TabIndex = 0;
            this.LblRango.Text = "Dame el rango:";
            // 
            // TxtRango
            // 
            this.TxtRango.Location = new System.Drawing.Point(111, 2);
            this.TxtRango.Name = "TxtRango";
            this.TxtRango.Size = new System.Drawing.Size(56, 20);
            this.TxtRango.TabIndex = 1;
            this.TxtRango.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRango_KeyPress);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(55, 37);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblTr
            // 
            this.LblTr.AutoSize = true;
            this.LblTr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTr.Location = new System.Drawing.Point(12, 102);
            this.LblTr.Name = "LblTr";
            this.LblTr.Size = new System.Drawing.Size(0, 13);
            this.LblTr.TabIndex = 3;
            // 
            // LblTi
            // 
            this.LblTi.AutoSize = true;
            this.LblTi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTi.Location = new System.Drawing.Point(12, 139);
            this.LblTi.Name = "LblTi";
            this.LblTi.Size = new System.Drawing.Size(0, 13);
            this.LblTi.TabIndex = 4;
            // 
            // TxtNumeros
            // 
            this.TxtNumeros.Location = new System.Drawing.Point(307, 6);
            this.TxtNumeros.Name = "TxtNumeros";
            this.TxtNumeros.Size = new System.Drawing.Size(175, 20);
            this.TxtNumeros.TabIndex = 5;
            // 
            // LblNumeros
            // 
            this.LblNumeros.AutoSize = true;
            this.LblNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeros.Location = new System.Drawing.Point(183, 9);
            this.LblNumeros.Name = "LblNumeros";
            this.LblNumeros.Size = new System.Drawing.Size(118, 13);
            this.LblNumeros.TabIndex = 6;
            this.LblNumeros.Text = "Numeros Perfectos:";
            // 
            // TxtAux
            // 
            this.TxtAux.Location = new System.Drawing.Point(307, 32);
            this.TxtAux.Name = "TxtAux";
            this.TxtAux.Size = new System.Drawing.Size(175, 20);
            this.TxtAux.TabIndex = 7;
            // 
            // LblAux
            // 
            this.LblAux.AutoSize = true;
            this.LblAux.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAux.Location = new System.Drawing.Point(269, 35);
            this.LblAux.Name = "LblAux";
            this.LblAux.Size = new System.Drawing.Size(32, 13);
            this.LblAux.TabIndex = 8;
            this.LblAux.Text = "Aux:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 161);
            this.Controls.Add(this.LblAux);
            this.Controls.Add(this.TxtAux);
            this.Controls.Add(this.LblNumeros);
            this.Controls.Add(this.TxtNumeros);
            this.Controls.Add(this.LblTi);
            this.Controls.Add(this.LblTr);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtRango);
            this.Controls.Add(this.LblRango);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRango;
        private System.Windows.Forms.TextBox TxtRango;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblTr;
        private System.Windows.Forms.Label LblTi;
        private System.Windows.Forms.TextBox TxtNumeros;
        private System.Windows.Forms.Label LblNumeros;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TxtAux;
        private System.Windows.Forms.Label LblAux;
    }
}

