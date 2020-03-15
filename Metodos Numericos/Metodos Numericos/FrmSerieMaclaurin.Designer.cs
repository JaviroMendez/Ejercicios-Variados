namespace Metodos_Numericos
{
    partial class FrmSerieMaclaurin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSerieMaclaurin));
            this.LblX = new System.Windows.Forms.Label();
            this.LblTerminos = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.DgvSerie = new System.Windows.Forms.DataGridView();
            this.Terminos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtValorX = new System.Windows.Forms.TextBox();
            this.TxtCalcular = new System.Windows.Forms.TextBox();
            this.BtnEt = new System.Windows.Forms.Button();
            this.BtnEa = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSerie)).BeginInit();
            this.SuspendLayout();
            // 
            // LblX
            // 
            this.LblX.AutoSize = true;
            this.LblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblX.Location = new System.Drawing.Point(12, 26);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(148, 15);
            this.LblX.TabIndex = 0;
            this.LblX.Text = "Dame el Valor para X:";
            // 
            // LblTerminos
            // 
            this.LblTerminos.AutoSize = true;
            this.LblTerminos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTerminos.Location = new System.Drawing.Point(12, 66);
            this.LblTerminos.Name = "LblTerminos";
            this.LblTerminos.Size = new System.Drawing.Size(140, 15);
            this.LblTerminos.TabIndex = 1;
            this.LblTerminos.Text = "Terminos a Calcular:";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(107, 101);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 4;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // DgvSerie
            // 
            this.DgvSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSerie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Terminos,
            this.Resultados,
            this.Column1,
            this.Column2});
            this.DgvSerie.Location = new System.Drawing.Point(27, 130);
            this.DgvSerie.Name = "DgvSerie";
            this.DgvSerie.Size = new System.Drawing.Size(351, 369);
            this.DgvSerie.TabIndex = 5;
            // 
            // Terminos
            // 
            this.Terminos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Terminos.HeaderText = "N";
            this.Terminos.Name = "Terminos";
            this.Terminos.Width = 21;
            // 
            // Resultados
            // 
            this.Resultados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Resultados.HeaderText = "Resultados";
            this.Resultados.Name = "Resultados";
            this.Resultados.Width = 85;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Et % (Relativo Verdadero)";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ea % (Relativo)";
            this.Column2.Name = "Column2";
            // 
            // TxtValorX
            // 
            this.TxtValorX.Location = new System.Drawing.Point(167, 21);
            this.TxtValorX.Name = "TxtValorX";
            this.TxtValorX.Size = new System.Drawing.Size(100, 20);
            this.TxtValorX.TabIndex = 6;
            this.TxtValorX.TextChanged += new System.EventHandler(this.TxtValorX_TextChanged);
            this.TxtValorX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorX_KeyPress);
            // 
            // TxtCalcular
            // 
            this.TxtCalcular.Location = new System.Drawing.Point(167, 61);
            this.TxtCalcular.Name = "TxtCalcular";
            this.TxtCalcular.Size = new System.Drawing.Size(100, 20);
            this.TxtCalcular.TabIndex = 7;
            this.TxtCalcular.TextChanged += new System.EventHandler(this.TxtCalcular_TextChanged);
            this.TxtCalcular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCalcular_KeyPress);
            // 
            // BtnEt
            // 
            this.BtnEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEt.Location = new System.Drawing.Point(329, 19);
            this.BtnEt.Name = "BtnEt";
            this.BtnEt.Size = new System.Drawing.Size(29, 23);
            this.BtnEt.TabIndex = 8;
            this.BtnEt.Text = "Et";
            this.BtnEt.UseVisualStyleBackColor = true;
            this.BtnEt.Click += new System.EventHandler(this.BtnEt_Click);
            // 
            // BtnEa
            // 
            this.BtnEa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEa.Location = new System.Drawing.Point(329, 58);
            this.BtnEa.Name = "BtnEa";
            this.BtnEa.Size = new System.Drawing.Size(29, 23);
            this.BtnEa.TabIndex = 9;
            this.BtnEa.Text = "Ea";
            this.BtnEa.UseVisualStyleBackColor = true;
            this.BtnEa.Click += new System.EventHandler(this.BtnEa_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.BackgroundImage")));
            this.BtnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.Location = new System.Drawing.Point(329, 101);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(29, 23);
            this.BtnRegresar.TabIndex = 10;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // FrmSerieMaclaurin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 511);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnEa);
            this.Controls.Add(this.BtnEt);
            this.Controls.Add(this.TxtCalcular);
            this.Controls.Add(this.TxtValorX);
            this.Controls.Add(this.DgvSerie);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblTerminos);
            this.Controls.Add(this.LblX);
            this.Name = "FrmSerieMaclaurin";
            this.Text = "FrmSerieMaclaurin";
            ((System.ComponentModel.ISupportInitialize)(this.DgvSerie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.Label LblTerminos;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.DataGridView DgvSerie;
        private System.Windows.Forms.TextBox TxtValorX;
        private System.Windows.Forms.TextBox TxtCalcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Terminos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button BtnEt;
        private System.Windows.Forms.Button BtnEa;
        private System.Windows.Forms.Button BtnRegresar;
    }
}