namespace Metodos_Numericos
{
    partial class Intervalo_Biseccion
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intervalo_Biseccion));
            this.LblInicio = new System.Windows.Forms.Label();
            this.LblFin = new System.Windows.Forms.Label();
            this.LblDatos = new System.Windows.Forms.Label();
            this.TxtInicio = new System.Windows.Forms.TextBox();
            this.TxtFin = new System.Windows.Forms.TextBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.Lblg = new System.Windows.Forms.Label();
            this.Lblm = new System.Windows.Forms.Label();
            this.Lblt = new System.Windows.Forms.Label();
            this.Lblv = new System.Windows.Forms.Label();
            this.Txtm = new System.Windows.Forms.TextBox();
            this.Txtg = new System.Windows.Forms.TextBox();
            this.Txtv = new System.Windows.Forms.TextBox();
            this.Txtt = new System.Windows.Forms.TextBox();
            this.DgvIntervalo = new System.Windows.Forms.DataGridView();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvBiseccion = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnRegresar2 = new System.Windows.Forms.Button();
            this.BtnRegresar1 = new System.Windows.Forms.Button();
            this.LblIntervalos = new System.Windows.Forms.Label();
            this.LblBiseccion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIntervalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBiseccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChtGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // LblInicio
            // 
            this.LblInicio.AutoSize = true;
            this.LblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInicio.Location = new System.Drawing.Point(12, 33);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(49, 16);
            this.LblInicio.TabIndex = 13;
            this.LblInicio.Text = "Inicio:";
            // 
            // LblFin
            // 
            this.LblFin.AutoSize = true;
            this.LblFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFin.Location = new System.Drawing.Point(12, 60);
            this.LblFin.Name = "LblFin";
            this.LblFin.Size = new System.Drawing.Size(33, 16);
            this.LblFin.TabIndex = 14;
            this.LblFin.Text = "Fin:";
            // 
            // LblDatos
            // 
            this.LblDatos.AutoSize = true;
            this.LblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatos.Location = new System.Drawing.Point(57, 9);
            this.LblDatos.Name = "LblDatos";
            this.LblDatos.Size = new System.Drawing.Size(223, 16);
            this.LblDatos.TabIndex = 15;
            this.LblDatos.Text = "Completa los siguientes Datos:";
            // 
            // TxtInicio
            // 
            this.TxtInicio.Location = new System.Drawing.Point(67, 33);
            this.TxtInicio.Name = "TxtInicio";
            this.TxtInicio.Size = new System.Drawing.Size(36, 20);
            this.TxtInicio.TabIndex = 16;
            this.TxtInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInicio_KeyPress);
            // 
            // TxtFin
            // 
            this.TxtFin.Location = new System.Drawing.Point(67, 60);
            this.TxtFin.Name = "TxtFin";
            this.TxtFin.Size = new System.Drawing.Size(36, 20);
            this.TxtFin.TabIndex = 17;
            this.TxtFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFin_KeyPress);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(261, 42);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(75, 23);
            this.BtnIniciar.TabIndex = 18;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // Lblg
            // 
            this.Lblg.AutoSize = true;
            this.Lblg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblg.Location = new System.Drawing.Point(24, 105);
            this.Lblg.Name = "Lblg";
            this.Lblg.Size = new System.Drawing.Size(21, 16);
            this.Lblg.TabIndex = 19;
            this.Lblg.Text = "g:";
            // 
            // Lblm
            // 
            this.Lblm.AutoSize = true;
            this.Lblm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblm.Location = new System.Drawing.Point(24, 131);
            this.Lblm.Name = "Lblm";
            this.Lblm.Size = new System.Drawing.Size(24, 16);
            this.Lblm.TabIndex = 20;
            this.Lblm.Text = "m:";
            // 
            // Lblt
            // 
            this.Lblt.AutoSize = true;
            this.Lblt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblt.Location = new System.Drawing.Point(24, 160);
            this.Lblt.Name = "Lblt";
            this.Lblt.Size = new System.Drawing.Size(16, 16);
            this.Lblt.TabIndex = 21;
            this.Lblt.Text = "t:";
            // 
            // Lblv
            // 
            this.Lblv.AutoSize = true;
            this.Lblv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblv.Location = new System.Drawing.Point(24, 187);
            this.Lblv.Name = "Lblv";
            this.Lblv.Size = new System.Drawing.Size(20, 16);
            this.Lblv.TabIndex = 22;
            this.Lblv.Text = "v:";
            this.Lblv.Click += new System.EventHandler(this.label4_Click);
            // 
            // Txtm
            // 
            this.Txtm.Location = new System.Drawing.Point(67, 131);
            this.Txtm.Name = "Txtm";
            this.Txtm.Size = new System.Drawing.Size(36, 20);
            this.Txtm.TabIndex = 24;
            this.Txtm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Txtg
            // 
            this.Txtg.Location = new System.Drawing.Point(67, 104);
            this.Txtg.Name = "Txtg";
            this.Txtg.Size = new System.Drawing.Size(36, 20);
            this.Txtg.TabIndex = 23;
            this.Txtg.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Txtv
            // 
            this.Txtv.Location = new System.Drawing.Point(67, 187);
            this.Txtv.Name = "Txtv";
            this.Txtv.Size = new System.Drawing.Size(36, 20);
            this.Txtv.TabIndex = 26;
            // 
            // Txtt
            // 
            this.Txtt.Location = new System.Drawing.Point(67, 160);
            this.Txtt.Name = "Txtt";
            this.Txtt.Size = new System.Drawing.Size(36, 20);
            this.Txtt.TabIndex = 25;
            // 
            // DgvIntervalo
            // 
            this.DgvIntervalo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIntervalo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C,
            this.Valor});
            this.DgvIntervalo.Location = new System.Drawing.Point(15, 47);
            this.DgvIntervalo.Name = "DgvIntervalo";
            this.DgvIntervalo.Size = new System.Drawing.Size(240, 446);
            this.DgvIntervalo.TabIndex = 27;
            this.DgvIntervalo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIntervalo_CellContentClick);
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
            // DgvBiseccion
            // 
            this.DgvBiseccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBiseccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DgvBiseccion.Location = new System.Drawing.Point(284, 47);
            this.DgvBiseccion.Name = "DgvBiseccion";
            this.DgvBiseccion.Size = new System.Drawing.Size(240, 446);
            this.DgvBiseccion.TabIndex = 28;
            this.DgvBiseccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBiseccion_CellContentClick);
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
            // ChtGrafico
            // 
            chartArea2.Name = "ChartArea1";
            this.ChtGrafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChtGrafico.Legends.Add(legend2);
            this.ChtGrafico.Location = new System.Drawing.Point(551, 104);
            this.ChtGrafico.Name = "ChtGrafico";
            this.ChtGrafico.Size = new System.Drawing.Size(310, 300);
            this.ChtGrafico.TabIndex = 29;
            this.ChtGrafico.Text = "chart1";
            // 
            // BtnRegresar2
            // 
            this.BtnRegresar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegresar2.BackgroundImage")));
            this.BtnRegresar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegresar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar2.Location = new System.Drawing.Point(832, 470);
            this.BtnRegresar2.Name = "BtnRegresar2";
            this.BtnRegresar2.Size = new System.Drawing.Size(29, 23);
            this.BtnRegresar2.TabIndex = 12;
            this.BtnRegresar2.UseVisualStyleBackColor = true;
            this.BtnRegresar2.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnRegresar1
            // 
            this.BtnRegresar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegresar1.BackgroundImage")));
            this.BtnRegresar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegresar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar1.Location = new System.Drawing.Point(261, 81);
            this.BtnRegresar1.Name = "BtnRegresar1";
            this.BtnRegresar1.Size = new System.Drawing.Size(29, 23);
            this.BtnRegresar1.TabIndex = 30;
            this.BtnRegresar1.UseVisualStyleBackColor = true;
            this.BtnRegresar1.Click += new System.EventHandler(this.BtnRegresar1_Click);
            // 
            // LblIntervalos
            // 
            this.LblIntervalos.AutoSize = true;
            this.LblIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIntervalos.Location = new System.Drawing.Point(88, 25);
            this.LblIntervalos.Name = "LblIntervalos";
            this.LblIntervalos.Size = new System.Drawing.Size(80, 16);
            this.LblIntervalos.TabIndex = 31;
            this.LblIntervalos.Text = "Intervalos:";
            // 
            // LblBiseccion
            // 
            this.LblBiseccion.AutoSize = true;
            this.LblBiseccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBiseccion.Location = new System.Drawing.Point(368, 25);
            this.LblBiseccion.Name = "LblBiseccion";
            this.LblBiseccion.Size = new System.Drawing.Size(80, 16);
            this.LblBiseccion.TabIndex = 32;
            this.LblBiseccion.Text = "Biseccion:";
            // 
            // Intervalo_Biseccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 505);
            this.Controls.Add(this.LblBiseccion);
            this.Controls.Add(this.LblIntervalos);
            this.Controls.Add(this.BtnRegresar1);
            this.Controls.Add(this.ChtGrafico);
            this.Controls.Add(this.DgvBiseccion);
            this.Controls.Add(this.DgvIntervalo);
            this.Controls.Add(this.Txtv);
            this.Controls.Add(this.Txtt);
            this.Controls.Add(this.Txtm);
            this.Controls.Add(this.Txtg);
            this.Controls.Add(this.Lblv);
            this.Controls.Add(this.Lblt);
            this.Controls.Add(this.Lblm);
            this.Controls.Add(this.Lblg);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.TxtFin);
            this.Controls.Add(this.TxtInicio);
            this.Controls.Add(this.LblDatos);
            this.Controls.Add(this.LblFin);
            this.Controls.Add(this.LblInicio);
            this.Controls.Add(this.BtnRegresar2);
            this.Name = "Intervalo_Biseccion";
            this.Text = "Intervalo_Biseccion";
            this.Load += new System.EventHandler(this.Intervalo_Biseccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvIntervalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBiseccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChtGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblInicio;
        private System.Windows.Forms.Label LblFin;
        private System.Windows.Forms.Label LblDatos;
        private System.Windows.Forms.TextBox TxtInicio;
        private System.Windows.Forms.TextBox TxtFin;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Label Lblg;
        private System.Windows.Forms.Label Lblm;
        private System.Windows.Forms.Label Lblt;
        private System.Windows.Forms.Label Lblv;
        private System.Windows.Forms.TextBox Txtm;
        private System.Windows.Forms.TextBox Txtg;
        private System.Windows.Forms.TextBox Txtv;
        private System.Windows.Forms.TextBox Txtt;
        private System.Windows.Forms.DataGridView DgvIntervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridView DgvBiseccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChtGrafico;
        private System.Windows.Forms.Button BtnRegresar2;
        private System.Windows.Forms.Button BtnRegresar1;
        private System.Windows.Forms.Label LblIntervalos;
        private System.Windows.Forms.Label LblBiseccion;
    }
}