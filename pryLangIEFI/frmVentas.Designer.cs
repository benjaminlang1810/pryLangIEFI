namespace pryLangIEFI
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.lblVentas = new System.Windows.Forms.Label();
            this.gbNuevaVenta = new System.Windows.Forms.GroupBox();
            this.btnFiltrarVentas = new System.Windows.Forms.Button();
            this.txtCantidadVentas2 = new System.Windows.Forms.TextBox();
            this.cboProductoVentas = new System.Windows.Forms.ComboBox();
            this.optCantidadVentas = new System.Windows.Forms.RadioButton();
            this.optProductoVentas = new System.Windows.Forms.RadioButton();
            this.btnListadoVentas = new System.Windows.Forms.Button();
            this.btnVolverVentas = new System.Windows.Forms.Button();
            this.btnCargarVentas = new System.Windows.Forms.Button();
            this.lblCantidadVentas = new System.Windows.Forms.Label();
            this.dtpFechaVentas = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.lblProductoVentas = new System.Windows.Forms.Label();
            this.txtProductoVentas = new System.Windows.Forms.TextBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudCantidadVentas = new System.Windows.Forms.NumericUpDown();
            this.gbNuevaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVentas.Location = new System.Drawing.Point(12, 9);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(155, 49);
            this.lblVentas.TabIndex = 0;
            this.lblVentas.Text = "Ventas";
            this.lblVentas.Click += new System.EventHandler(this.lblVentas_Click);
            // 
            // gbNuevaVenta
            // 
            this.gbNuevaVenta.Controls.Add(this.nudCantidadVentas);
            this.gbNuevaVenta.Controls.Add(this.btnFiltrarVentas);
            this.gbNuevaVenta.Controls.Add(this.txtCantidadVentas2);
            this.gbNuevaVenta.Controls.Add(this.cboProductoVentas);
            this.gbNuevaVenta.Controls.Add(this.optCantidadVentas);
            this.gbNuevaVenta.Controls.Add(this.optProductoVentas);
            this.gbNuevaVenta.Controls.Add(this.btnListadoVentas);
            this.gbNuevaVenta.Controls.Add(this.btnVolverVentas);
            this.gbNuevaVenta.Controls.Add(this.btnCargarVentas);
            this.gbNuevaVenta.Controls.Add(this.lblCantidadVentas);
            this.gbNuevaVenta.Controls.Add(this.dtpFechaVentas);
            this.gbNuevaVenta.Controls.Add(this.lblFechaVenta);
            this.gbNuevaVenta.Controls.Add(this.lblProductoVentas);
            this.gbNuevaVenta.Controls.Add(this.txtProductoVentas);
            this.gbNuevaVenta.Location = new System.Drawing.Point(21, 61);
            this.gbNuevaVenta.Name = "gbNuevaVenta";
            this.gbNuevaVenta.Size = new System.Drawing.Size(395, 468);
            this.gbNuevaVenta.TabIndex = 1;
            this.gbNuevaVenta.TabStop = false;
            this.gbNuevaVenta.Text = "Nueva Venta";
            // 
            // btnFiltrarVentas
            // 
            this.btnFiltrarVentas.Location = new System.Drawing.Point(100, 418);
            this.btnFiltrarVentas.Name = "btnFiltrarVentas";
            this.btnFiltrarVentas.Size = new System.Drawing.Size(155, 31);
            this.btnFiltrarVentas.TabIndex = 15;
            this.btnFiltrarVentas.Text = "Filtrar";
            this.btnFiltrarVentas.UseVisualStyleBackColor = true;
            this.btnFiltrarVentas.Click += new System.EventHandler(this.btnFiltrarVentas_Click);
            // 
            // txtCantidadVentas2
            // 
            this.txtCantidadVentas2.Location = new System.Drawing.Point(230, 388);
            this.txtCantidadVentas2.Name = "txtCantidadVentas2";
            this.txtCantidadVentas2.Size = new System.Drawing.Size(155, 22);
            this.txtCantidadVentas2.TabIndex = 14;
            // 
            // cboProductoVentas
            // 
            this.cboProductoVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductoVentas.FormattingEnabled = true;
            this.cboProductoVentas.Location = new System.Drawing.Point(15, 386);
            this.cboProductoVentas.Name = "cboProductoVentas";
            this.cboProductoVentas.Size = new System.Drawing.Size(155, 24);
            this.cboProductoVentas.TabIndex = 13;
            // 
            // optCantidadVentas
            // 
            this.optCantidadVentas.AutoSize = true;
            this.optCantidadVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCantidadVentas.Location = new System.Drawing.Point(230, 364);
            this.optCantidadVentas.Name = "optCantidadVentas";
            this.optCantidadVentas.Size = new System.Drawing.Size(96, 24);
            this.optCantidadVentas.TabIndex = 12;
            this.optCantidadVentas.Text = "Cantidad";
            this.optCantidadVentas.UseVisualStyleBackColor = true;
            // 
            // optProductoVentas
            // 
            this.optProductoVentas.AutoSize = true;
            this.optProductoVentas.Checked = true;
            this.optProductoVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optProductoVentas.Location = new System.Drawing.Point(15, 364);
            this.optProductoVentas.Name = "optProductoVentas";
            this.optProductoVentas.Size = new System.Drawing.Size(97, 24);
            this.optProductoVentas.TabIndex = 11;
            this.optProductoVentas.TabStop = true;
            this.optProductoVentas.Text = "Producto";
            this.optProductoVentas.UseVisualStyleBackColor = true;
            // 
            // btnListadoVentas
            // 
            this.btnListadoVentas.Location = new System.Drawing.Point(15, 282);
            this.btnListadoVentas.Name = "btnListadoVentas";
            this.btnListadoVentas.Size = new System.Drawing.Size(276, 44);
            this.btnListadoVentas.TabIndex = 10;
            this.btnListadoVentas.Text = "Listado";
            this.btnListadoVentas.UseVisualStyleBackColor = true;
            this.btnListadoVentas.Click += new System.EventHandler(this.btnListadoVentas_Click);
            // 
            // btnVolverVentas
            // 
            this.btnVolverVentas.Location = new System.Drawing.Point(15, 227);
            this.btnVolverVentas.Name = "btnVolverVentas";
            this.btnVolverVentas.Size = new System.Drawing.Size(135, 49);
            this.btnVolverVentas.TabIndex = 7;
            this.btnVolverVentas.Text = "Volver";
            this.btnVolverVentas.UseVisualStyleBackColor = true;
            this.btnVolverVentas.Click += new System.EventHandler(this.btnVolverVentas_Click);
            // 
            // btnCargarVentas
            // 
            this.btnCargarVentas.Location = new System.Drawing.Point(156, 227);
            this.btnCargarVentas.Name = "btnCargarVentas";
            this.btnCargarVentas.Size = new System.Drawing.Size(135, 49);
            this.btnCargarVentas.TabIndex = 6;
            this.btnCargarVentas.Text = "Cargar";
            this.btnCargarVentas.UseVisualStyleBackColor = true;
            this.btnCargarVentas.Click += new System.EventHandler(this.btnCargarVentas_Click);
            // 
            // lblCantidadVentas
            // 
            this.lblCantidadVentas.AutoSize = true;
            this.lblCantidadVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVentas.Location = new System.Drawing.Point(65, 179);
            this.lblCantidadVentas.Name = "lblCantidadVentas";
            this.lblCantidadVentas.Size = new System.Drawing.Size(80, 20);
            this.lblCantidadVentas.TabIndex = 4;
            this.lblCantidadVentas.Text = "Cantidad:";
            // 
            // dtpFechaVentas
            // 
            this.dtpFechaVentas.Location = new System.Drawing.Point(15, 134);
            this.dtpFechaVentas.Name = "dtpFechaVentas";
            this.dtpFechaVentas.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaVentas.TabIndex = 3;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.Location = new System.Drawing.Point(15, 111);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(108, 20);
            this.lblFechaVenta.TabIndex = 2;
            this.lblFechaVenta.Text = "Fecha Venta:";
            // 
            // lblProductoVentas
            // 
            this.lblProductoVentas.AutoSize = true;
            this.lblProductoVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoVentas.Location = new System.Drawing.Point(15, 32);
            this.lblProductoVentas.Name = "lblProductoVentas";
            this.lblProductoVentas.Size = new System.Drawing.Size(81, 20);
            this.lblProductoVentas.TabIndex = 1;
            this.lblProductoVentas.Text = "Producto:";
            // 
            // txtProductoVentas
            // 
            this.txtProductoVentas.Location = new System.Drawing.Point(15, 55);
            this.txtProductoVentas.Name = "txtProductoVentas";
            this.txtProductoVentas.Size = new System.Drawing.Size(265, 22);
            this.txtProductoVentas.TabIndex = 0;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Fecha,
            this.Producto,
            this.Cantidad});
            this.dgvVentas.Location = new System.Drawing.Point(422, 61);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(553, 400);
            this.dgvVentas.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 125;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // nudCantidadVentas
            // 
            this.nudCantidadVentas.Location = new System.Drawing.Point(151, 180);
            this.nudCantidadVentas.Name = "nudCantidadVentas";
            this.nudCantidadVentas.Size = new System.Drawing.Size(82, 22);
            this.nudCantidadVentas.TabIndex = 16;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(987, 555);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.gbNuevaVenta);
            this.Controls.Add(this.lblVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.gbNuevaVenta.ResumeLayout(false);
            this.gbNuevaVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.GroupBox gbNuevaVenta;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Label lblProductoVentas;
        private System.Windows.Forms.TextBox txtProductoVentas;
        private System.Windows.Forms.Label lblCantidadVentas;
        private System.Windows.Forms.DateTimePicker dtpFechaVentas;
        private System.Windows.Forms.Button btnVolverVentas;
        private System.Windows.Forms.Button btnCargarVentas;
        private System.Windows.Forms.Button btnListadoVentas;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnFiltrarVentas;
        private System.Windows.Forms.TextBox txtCantidadVentas2;
        private System.Windows.Forms.ComboBox cboProductoVentas;
        private System.Windows.Forms.RadioButton optCantidadVentas;
        private System.Windows.Forms.RadioButton optProductoVentas;
        private System.Windows.Forms.NumericUpDown nudCantidadVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}