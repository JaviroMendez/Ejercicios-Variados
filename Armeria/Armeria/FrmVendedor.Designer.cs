namespace Armeria
{
    partial class FrmVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendedor));
            this.TxtCc = new System.Windows.Forms.TextBox();
            this.LblCc = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblNombreM = new System.Windows.Forms.Label();
            this.LblDescripcionM = new System.Windows.Forms.Label();
            this.DgvVendedor = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtCcantidad = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCc
            // 
            this.TxtCc.Location = new System.Drawing.Point(107, 31);
            this.TxtCc.Name = "TxtCc";
            this.TxtCc.Size = new System.Drawing.Size(125, 20);
            this.TxtCc.TabIndex = 0;
            this.TxtCc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCc_KeyPress);
            // 
            // LblCc
            // 
            this.LblCc.AutoSize = true;
            this.LblCc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblCc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCc.Location = new System.Drawing.Point(49, 35);
            this.LblCc.Name = "LblCc";
            this.LblCc.Size = new System.Drawing.Size(30, 16);
            this.LblCc.TabIndex = 1;
            this.LblCc.Text = "Cc:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(12, 73);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(67, 16);
            this.LblNombre.TabIndex = 3;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(3, 156);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(74, 16);
            this.LblCantidad.TabIndex = 4;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(3, 112);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(95, 16);
            this.LblDescripcion.TabIndex = 5;
            this.LblDescripcion.Text = "Descripcion:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.SystemColors.Desktop;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnBuscar.Location = new System.Drawing.Point(238, 26);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(86, 29);
            this.BtnBuscar.TabIndex = 15;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblNombreM
            // 
            this.LblNombreM.AutoSize = true;
            this.LblNombreM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreM.Location = new System.Drawing.Point(114, 73);
            this.LblNombreM.Name = "LblNombreM";
            this.LblNombreM.Size = new System.Drawing.Size(0, 16);
            this.LblNombreM.TabIndex = 16;
            // 
            // LblDescripcionM
            // 
            this.LblDescripcionM.AutoSize = true;
            this.LblDescripcionM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcionM.Location = new System.Drawing.Point(114, 112);
            this.LblDescripcionM.Name = "LblDescripcionM";
            this.LblDescripcionM.Size = new System.Drawing.Size(0, 16);
            this.LblDescripcionM.TabIndex = 17;
            // 
            // DgvVendedor
            // 
            this.DgvVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Descripcion,
            this.Cantidad,
            this.Valor});
            this.DgvVendedor.Location = new System.Drawing.Point(6, 175);
            this.DgvVendedor.Name = "DgvVendedor";
            this.DgvVendedor.Size = new System.Drawing.Size(445, 113);
            this.DgvVendedor.TabIndex = 19;
            this.DgvVendedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVendedor_CellClick);
            this.DgvVendedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVendedor_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // TxtCcantidad
            // 
            this.TxtCcantidad.Location = new System.Drawing.Point(83, 152);
            this.TxtCcantidad.Name = "TxtCcantidad";
            this.TxtCcantidad.Size = new System.Drawing.Size(31, 20);
            this.TxtCcantidad.TabIndex = 20;
            this.TxtCcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCcantidad_KeyPress);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnAgregar.FlatAppearance.BorderSize = 5;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Location = new System.Drawing.Point(83, 294);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(115, 29);
            this.BtnAgregar.TabIndex = 21;
            this.BtnAgregar.Text = "+";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.BackColor = System.Drawing.Color.Red;
            this.BtnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitar.ForeColor = System.Drawing.Color.Black;
            this.BtnQuitar.Location = new System.Drawing.Point(280, 293);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(115, 30);
            this.BtnQuitar.TabIndex = 22;
            this.BtnQuitar.Text = "-";
            this.BtnQuitar.UseVisualStyleBackColor = false;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.Fuchsia;
            this.BtnInicio.Location = new System.Drawing.Point(468, 12);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(22, 23);
            this.BtnInicio.TabIndex = 23;
            this.BtnInicio.Text = "I";
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 335);
            this.Controls.Add(this.BtnInicio);
            this.Controls.Add(this.BtnQuitar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtCcantidad);
            this.Controls.Add(this.DgvVendedor);
            this.Controls.Add(this.LblDescripcionM);
            this.Controls.Add(this.LblNombreM);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCc);
            this.Controls.Add(this.TxtCc);
            this.Name = "FrmVendedor";
            this.Text = "FrmVendedor";
            this.Load += new System.EventHandler(this.FrmVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCc;
        private System.Windows.Forms.Label LblCc;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblNombreM;
        private System.Windows.Forms.Label LblDescripcionM;
        private System.Windows.Forms.DataGridView DgvVendedor;
        private System.Windows.Forms.TextBox TxtCcantidad;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Button BtnInicio;
    }
}