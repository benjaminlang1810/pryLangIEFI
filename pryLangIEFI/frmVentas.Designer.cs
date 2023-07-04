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
            this.lblVentas = new System.Windows.Forms.Label();
            this.gbNuevaVenta = new System.Windows.Forms.GroupBox();
            this.btnListadoVentas = new System.Windows.Forms.Button();
            this.txtIdVentas = new System.Windows.Forms.TextBox();
            this.lblIdVentas = new System.Windows.Forms.Label();
            this.btnVolverVentas = new System.Windows.Forms.Button();
            this.btnCargarVentas = new System.Windows.Forms.Button();
            this.txtCantidadVentas = new System.Windows.Forms.TextBox();
            this.lblCantidadVentas = new System.Windows.Forms.Label();
            this.dtpFechaVentas = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.lblProductoVentas = new System.Windows.Forms.Label();
            this.txtProductoVentas = new System.Windows.Forms.TextBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbNuevaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVentas.Location = new System.Drawing.Point(62, 9);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(155, 49);
            this.lblVentas.TabIndex = 0;
            this.lblVentas.Text = "Ventas";
            this.lblVentas.Click += new System.EventHandler(this.lblVentas_Click);
            // 
            // gbNuevaVenta
            // 
            this.gbNuevaVenta.Controls.Add(this.btnListadoVentas);
            this.gbNuevaVenta.Controls.Add(this.txtIdVentas);
            this.gbNuevaVenta.Controls.Add(this.lblIdVentas);
            this.gbNuevaVenta.Controls.Add(this.btnVolverVentas);
            this.gbNuevaVenta.Controls.Add(this.btnCargarVentas);
            this.gbNuevaVenta.Controls.Add(this.txtCantidadVentas);
            this.gbNuevaVenta.Controls.Add(this.lblCantidadVentas);
            this.gbNuevaVenta.Controls.Add(this.dtpFechaVentas);
            this.gbNuevaVenta.Controls.Add(this.lblFechaVenta);
            this.gbNuevaVenta.Controls.Add(this.lblProductoVentas);
            this.gbNuevaVenta.Controls.Add(this.txtProductoVentas);
            this.gbNuevaVenta.Location = new System.Drawing.Point(6, 61);
            this.gbNuevaVenta.Name = "gbNuevaVenta";
            this.gbNuevaVenta.Size = new System.Drawing.Size(314, 402);
            this.gbNuevaVenta.TabIndex = 1;
            this.gbNuevaVenta.TabStop = false;
            this.gbNuevaVenta.Text = "Nueva Venta";
            // 
            // btnListadoVentas
            // 
            this.btnListadoVentas.Location = new System.Drawing.Point(4, 307);
            this.btnListadoVentas.Name = "btnListadoVentas";
            this.btnListadoVentas.Size = new System.Drawing.Size(276, 44);
            this.btnListadoVentas.TabIndex = 10;
            this.btnListadoVentas.Text = "Listado";
            this.btnListadoVentas.UseVisualStyleBackColor = true;
            this.btnListadoVentas.Click += new System.EventHandler(this.btnListadoVentas_Click);
            // 
            // txtIdVentas
            // 
            this.txtIdVentas.Location = new System.Drawing.Point(15, 112);
            this.txtIdVentas.Name = "txtIdVentas";
            this.txtIdVentas.Size = new System.Drawing.Size(265, 22);
            this.txtIdVentas.TabIndex = 9;
            // 
            // lblIdVentas
            // 
            this.lblIdVentas.AutoSize = true;
            this.lblIdVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVentas.Location = new System.Drawing.Point(15, 89);
            this.lblIdVentas.Name = "lblIdVentas";
            this.lblIdVentas.Size = new System.Drawing.Size(27, 20);
            this.lblIdVentas.TabIndex = 8;
            this.lblIdVentas.Text = "Id:";
            // 
            // btnVolverVentas
            // 
            this.btnVolverVentas.Location = new System.Drawing.Point(4, 252);
            this.btnVolverVentas.Name = "btnVolverVentas";
            this.btnVolverVentas.Size = new System.Drawing.Size(135, 49);
            this.btnVolverVentas.TabIndex = 7;
            this.btnVolverVentas.Text = "Volver";
            this.btnVolverVentas.UseVisualStyleBackColor = true;
            this.btnVolverVentas.Click += new System.EventHandler(this.btnVolverVentas_Click);
            // 
            // btnCargarVentas
            // 
            this.btnCargarVentas.Location = new System.Drawing.Point(145, 252);
            this.btnCargarVentas.Name = "btnCargarVentas";
            this.btnCargarVentas.Size = new System.Drawing.Size(135, 49);
            this.btnCargarVentas.TabIndex = 6;
            this.btnCargarVentas.Text = "Cargar";
            this.btnCargarVentas.UseVisualStyleBackColor = true;
            this.btnCargarVentas.Click += new System.EventHandler(this.btnCargarVentas_Click);
            // 
            // txtCantidadVentas
            // 
            this.txtCantidadVentas.Location = new System.Drawing.Point(147, 220);
            this.txtCantidadVentas.Name = "txtCantidadVentas";
            this.txtCantidadVentas.Size = new System.Drawing.Size(48, 22);
            this.txtCantidadVentas.TabIndex = 5;
            // 
            // lblCantidadVentas
            // 
            this.lblCantidadVentas.AutoSize = true;
            this.lblCantidadVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVentas.Location = new System.Drawing.Point(61, 220);
            this.lblCantidadVentas.Name = "lblCantidadVentas";
            this.lblCantidadVentas.Size = new System.Drawing.Size(80, 20);
            this.lblCantidadVentas.TabIndex = 4;
            this.lblCantidadVentas.Text = "Cantidad:";
            // 
            // dtpFechaVentas
            // 
            this.dtpFechaVentas.Location = new System.Drawing.Point(11, 175);
            this.dtpFechaVentas.Name = "dtpFechaVentas";
            this.dtpFechaVentas.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaVentas.TabIndex = 3;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.Location = new System.Drawing.Point(11, 152);
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
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvVentas.Location = new System.Drawing.Point(326, 61);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(568, 150);
            this.dgvVentas.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(906, 474);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.gbNuevaVenta);
            this.Controls.Add(this.lblVentas);
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.gbNuevaVenta.ResumeLayout(false);
            this.gbNuevaVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.GroupBox gbNuevaVenta;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Label lblProductoVentas;
        private System.Windows.Forms.TextBox txtProductoVentas;
        private System.Windows.Forms.TextBox txtCantidadVentas;
        private System.Windows.Forms.Label lblCantidadVentas;
        private System.Windows.Forms.DateTimePicker dtpFechaVentas;
        private System.Windows.Forms.Button btnVolverVentas;
        private System.Windows.Forms.Button btnCargarVentas;
        private System.Windows.Forms.TextBox txtIdVentas;
        private System.Windows.Forms.Label lblIdVentas;
        private System.Windows.Forms.Button btnListadoVentas;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}