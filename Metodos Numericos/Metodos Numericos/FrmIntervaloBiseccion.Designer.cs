namespace Metodos_Numericos
{
    partial class FrmIntervaloBiseccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIntervaloBiseccion));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.LblInicio = new System.Windows.Forms.Label();
            this.LblFin = new System.Windows.Forms.Label();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.TxtInicio = new System.Windows.Forms.TextBox();
            this.TxtFin = new System.Windows.Forms.TextBox();
            this.BtnRegresar1 = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.LblBiseccion = new System.Windows.Forms.Label();
            this.LblIntervalos = new System.Windows.Forms.Label();
            this.ChtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DgvBiseccion = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvIntervalo = new System.Windows.Forms.DataGridView();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRegresar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChtGrafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBiseccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIntervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblInicio
            // 
            this.LblInicio.AutoSize = true;
            this.LblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInicio.Location = new System.Drawing.Point(9, 57);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(49, 16);
            this.LblInicio.TabIndex = 14;
            this.LblInicio.Text = "Inicio:";
            // 
            // LblFin
            // 
            this.LblFin.AutoSize = true;
            this.LblFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFin.Location = new System.Drawing.Point(12, 84);
            this.LblFin.Name = "LblFin";
            this.LblFin.Size = new System.Drawing.Size(33, 16);
            this.LblFin.TabIndex = 15;
            this.LblFin.Text = "Fin:";
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.Location = new System.Drawing.Point(45, 21);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(150, 16);
            this.LblMensaje.TabIndex = 16;
            this.LblMensaje.Text = "Dame los Intervalos:";
            // 
            // TxtInicio
            // 
            this.TxtInicio.Location = new System.Drawing.Point(64, 53);
            this.TxtInicio.Name = "TxtInicio";
            this.TxtInicio.Size = new System.Drawing.Size(37, 20);
            this.TxtInicio.TabIndex = 17;
            this.TxtInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInicio_KeyPress);
            // 
            // TxtFin
            // 
            this.TxtFin.Location = new System.Drawing.Point(64, 80);
            this.TxtFin.Name = "TxtFin";
            this.TxtFin.Size = new System.Drawing.Size(37, 20);
            this.TxtFin.TabIndex = 18;
            this.TxtFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFin_KeyPress);
            // 
            // BtnRegresar1
            // 
            this.BtnRegresar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegresar1.BackgroundImage")));
            this.BtnRegresar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegresar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar1.Location = new System.Drawing.Point(191, 104);
            this.BtnRegresar1.Name = "BtnRegresar1";
            this.BtnRegresar1.Size = new System.Drawing.Size(29, 23);
            this.BtnRegresar1.TabIndex = 31;
            this.BtnRegresar1.UseVisualStyleBackColor = true;
            this.BtnRegresar1.Click += new System.EventHandler(this.BtnRegresar1_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(137, 50);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(75, 23);
            this.BtnIniciar.TabIndex = 32;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // LblBiseccion
            // 
            this.LblBiseccion.AutoSize = true;
            this.LblBiseccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBiseccion.Location = new System.Drawing.Point(401, 18);
            this.LblBiseccion.Name = "LblBiseccion";
            this.LblBiseccion.Size = new System.Drawing.Size(80, 16);
            this.LblBiseccion.TabIndex = 38;
            this.LblBiseccion.Text = "Biseccion:";
            // 
            // LblIntervalos
            // 
            this.LblIntervalos.AutoSize = true;
            this.LblIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIntervalos.Location = new System.Drawing.Point(121, 18);
            this.LblIntervalos.Name = "LblIntervalos";
            this.LblIntervalos.Size = new System.Drawing.Size(80, 16);
            this.LblIntervalos.TabIndex = 37;
            this.LblIntervalos.Text = "Intervalos:";
            // 
            // ChtGrafico
            // 
            chartArea2.Name = "ChartArea1";
            this.ChtGrafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChtGrafico.Legends.Add(legend2);
            this.ChtGrafico.Location = new System.Drawing.Point(584, 97);
            this.ChtGrafico.Name = "ChtGrafico";
            this.ChtGrafico.Size = new System.Drawing.Size(310, 300);
            this.ChtGrafico.TabIndex = 36;
            this.ChtGrafico.Text = "chart1";
            // 
            // DgvBiseccion
            // 
            this.DgvBiseccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBiseccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DgvBiseccion.Location = new System.Drawing.Point(317, 40);
            this.DgvBiseccion.Name = "DgvBiseccion";
            this.DgvBiseccion.Size = new System.Drawing.Size(240, 446);
            this.DgvBiseccion.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "C";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // DgvIntervalo
            // 
            this.DgvIntervalo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIntervalo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C,
            this.Valor});
            this.DgvIntervalo.Location = new System.Drawing.Point(48, 40);
            this.DgvIntervalo.Name = "DgvIntervalo";
            this.DgvIntervalo.Size = new System.Drawing.Size(240, 446);
            this.DgvIntervalo.TabIndex = 34;
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.Name = "C";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // BtnRegresar2
            // 
            this.BtnRegresar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegresar2.BackgroundImage")));
            this.BtnRegresar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegresar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar2.Location = new System.Drawing.Point(865, 463);
            this.BtnRegresar2.Name = "BtnRegresar2";
            this.BtnRegresar2.Size = new System.Drawing.Size(29, 23);
            this.BtnRegresar2.TabIndex = 33;
            this.BtnRegresar2.UseVisualStyleBackColor = true;
            this.BtnRegresar2.Click += new System.EventHandler(this.BtnRegresar2_Click);
            // 
            // FrmIntervaloBiseccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 498);
            this.Controls.Add(this.LblBiseccion);
            this.Controls.Add(this.LblIntervalos);
            this.Controls.Add(this.ChtGrafico);
            this.Controls.Add(this.DgvBiseccion);
            this.Controls.Add(this.DgvIntervalo);
            this.Controls.Add(this.BtnRegresar2);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.BtnRegresar1);
            this.Controls.Add(this.TxtFin);
            this.Controls.Add(this.TxtInicio);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.LblFin);
            this.Controls.Add(this.LblInicio);
            this.Name = "FrmIntervaloBiseccion";
            this.Text = "FrmIntervaloBiseccion";
            this.Load += new System.EventHandler(this.FrmIntervaloBiseccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChtGrafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBiseccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIntervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInicio;
        private System.Windows.Forms.Label LblFin;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.TextBox TxtInicio;
        private System.Windows.Forms.TextBox TxtFin;
        private System.Windows.Forms.Button BtnRegresar1;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Label LblBiseccion;
        private System.Windows.Forms.Label LblIntervalos;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChtGrafico;
        private System.Windows.Forms.DataGridView DgvBiseccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView DgvIntervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Button BtnRegresar2;
    }
}