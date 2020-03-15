namespace Metodos_Numericos
{
    partial class MenuIV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuIV));
            this.BtnTrapecio = new System.Windows.Forms.Button();
            this.BtnSimpson = new System.Windows.Forms.Button();
            this.BtnRegresar2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // BtnTrapecio
            // 
            this.BtnTrapecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTrapecio.Location = new System.Drawing.Point(31, 42);
            this.BtnTrapecio.Name = "BtnTrapecio";
            this.BtnTrapecio.Size = new System.Drawing.Size(75, 23);
            this.BtnTrapecio.TabIndex = 0;
            this.BtnTrapecio.Text = "Trapecio";
            this.toolTip1.SetToolTip(this.BtnTrapecio, "Método del Trapecio");
            this.BtnTrapecio.UseVisualStyleBackColor = true;
            this.BtnTrapecio.Click += new System.EventHandler(this.BtnTrapecio_Click);
            // 
            // BtnSimpson
            // 
            this.BtnSimpson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimpson.Location = new System.Drawing.Point(31, 90);
            this.BtnSimpson.Name = "BtnSimpson";
            this.BtnSimpson.Size = new System.Drawing.Size(75, 23);
            this.BtnSimpson.TabIndex = 1;
            this.BtnSimpson.Text = "Simpson";
            this.toolTip1.SetToolTip(this.BtnSimpson, "REGLA DE SIMPSON 3/8");
            this.BtnSimpson.UseVisualStyleBackColor = true;
            this.BtnSimpson.Click += new System.EventHandler(this.BtnSimpson_Click);
            // 
            // BtnRegresar2
            // 
            this.BtnRegresar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegresar2.BackgroundImage")));
            this.BtnRegresar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegresar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar2.Location = new System.Drawing.Point(115, 129);
            this.BtnRegresar2.Name = "BtnRegresar2";
            this.BtnRegresar2.Size = new System.Drawing.Size(29, 23);
            this.BtnRegresar2.TabIndex = 37;
            this.BtnRegresar2.UseVisualStyleBackColor = true;
            this.BtnRegresar2.Click += new System.EventHandler(this.BtnRegresar2_Click);
            // 
            // MenuIV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 180);
            this.Controls.Add(this.BtnRegresar2);
            this.Controls.Add(this.BtnSimpson);
            this.Controls.Add(this.BtnTrapecio);
            this.Name = "MenuIV";
            this.Text = "MenuIV";
            this.Load += new System.EventHandler(this.MenuIV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTrapecio;
        private System.Windows.Forms.Button BtnSimpson;
        private System.Windows.Forms.Button BtnRegresar2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}