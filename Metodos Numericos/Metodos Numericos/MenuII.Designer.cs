namespace Metodos_Numericos
{
    partial class MenuII
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuII));
            this.BtnIntervaloBiseccion = new System.Windows.Forms.Button();
            this.BtnRegresar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnIntervaloBiseccion
            // 
            this.BtnIntervaloBiseccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIntervaloBiseccion.Location = new System.Drawing.Point(44, 24);
            this.BtnIntervaloBiseccion.Name = "BtnIntervaloBiseccion";
            this.BtnIntervaloBiseccion.Size = new System.Drawing.Size(139, 23);
            this.BtnIntervaloBiseccion.TabIndex = 2;
            this.BtnIntervaloBiseccion.Text = "Intervalo-Biseccion";
            this.BtnIntervaloBiseccion.UseVisualStyleBackColor = true;
            this.BtnIntervaloBiseccion.Click += new System.EventHandler(this.BtnIntervaloBiseccion_Click);
            // 
            // BtnRegresar2
            // 
            this.BtnRegresar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegresar2.BackgroundImage")));
            this.BtnRegresar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegresar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar2.Location = new System.Drawing.Point(198, 50);
            this.BtnRegresar2.Name = "BtnRegresar2";
            this.BtnRegresar2.Size = new System.Drawing.Size(29, 23);
            this.BtnRegresar2.TabIndex = 35;
            this.BtnRegresar2.UseVisualStyleBackColor = true;
            this.BtnRegresar2.Click += new System.EventHandler(this.BtnRegresar2_Click);
            // 
            // MenuII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 85);
            this.Controls.Add(this.BtnRegresar2);
            this.Controls.Add(this.BtnIntervaloBiseccion);
            this.Name = "MenuII";
            this.Text = "MenuII";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnIntervaloBiseccion;
        private System.Windows.Forms.Button BtnRegresar2;
    }
}