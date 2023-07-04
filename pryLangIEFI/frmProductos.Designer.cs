namespace pryLangIEFI
{
    partial class frmProductos
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
            this.lblProductos = new System.Windows.Forms.Label();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.btnListadoProductos = new System.Windows.Forms.Button();
            this.btnVolverProductos = new System.Windows.Forms.Button();
            this.btnCargarProductos = new System.Windows.Forms.Button();
            this.dtpFechaProductos = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.txtIdProductos = new System.Windows.Forms.TextBox();
            this.lblIdProductos = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(36, 9);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(217, 49);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Productos";
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.btnListadoProductos);
            this.gbProductos.Controls.Add(this.btnVolverProductos);
            this.gbProductos.Controls.Add(this.btnCargarProductos);
            this.gbProductos.Controls.Add(this.dtpFechaProductos);
            this.gbProductos.Controls.Add(this.lblFechaVenta);
            this.gbProductos.Controls.Add(this.txtIdProductos);
            this.gbProductos.Controls.Add(this.lblIdProductos);
            this.gbProductos.Controls.Add(this.txtProducto);
            this.gbProductos.Controls.Add(this.lblProducto);
            this.gbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductos.Location = new System.Drawing.Point(12, 62);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(362, 324);
            this.gbProductos.TabIndex = 1;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Carga De Productos";
            this.gbProductos.Enter += new System.EventHandler(this.gbProductos_Enter);
            // 
            // btnListadoProductos
            // 
            this.btnListadoProductos.Location = new System.Drawing.Point(30, 260);
            this.btnListadoProductos.Name = "btnListadoProductos";
            this.btnListadoProductos.Size = new System.Drawing.Size(271, 43);
            this.btnListadoProductos.TabIndex = 17;
            this.btnListadoProductos.Text = "Listado";
            this.btnListadoProductos.UseVisualStyleBackColor = true;
            this.btnListadoProductos.Click += new System.EventHandler(this.btnListadoProductos_Click);
            // 
            // btnVolverProductos
            // 
            this.btnVolverProductos.Location = new System.Drawing.Point(30, 207);
            this.btnVolverProductos.Name = "btnVolverProductos";
            this.btnVolverProductos.Size = new System.Drawing.Size(131, 48);
            this.btnVolverProductos.TabIndex = 16;
            this.btnVolverProductos.Text = "Volver";
            this.btnVolverProductos.UseVisualStyleBackColor = true;
            this.btnVolverProductos.Click += new System.EventHandler(this.btnVolverProductos_Click);
            // 
            // btnCargarProductos
            // 
            this.btnCargarProductos.Location = new System.Drawing.Point(167, 207);
            this.btnCargarProductos.Name = "btnCargarProductos";
            this.btnCargarProductos.Size = new System.Drawing.Size(134, 48);
            this.btnCargarProductos.TabIndex = 15;
            this.btnCargarProductos.Text = "Cargar";
            this.btnCargarProductos.UseVisualStyleBackColor = true;
            this.btnCargarProductos.Click += new System.EventHandler(this.btnCargarProductos_Click);
            // 
            // dtpFechaProductos
            // 
            this.dtpFechaProductos.Location = new System.Drawing.Point(33, 153);
            this.dtpFechaProductos.Name = "dtpFechaProductos";
            this.dtpFechaProductos.Size = new System.Drawing.Size(268, 22);
            this.dtpFechaProductos.TabIndex = 12;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.Location = new System.Drawing.Point(29, 130);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(141, 20);
            this.lblFechaVenta.TabIndex = 11;
            this.lblFechaVenta.Text = "Fecha Productos:";
            // 
            // txtIdProductos
            // 
            this.txtIdProductos.Location = new System.Drawing.Point(89, 74);
            this.txtIdProductos.Name = "txtIdProductos";
            this.txtIdProductos.Size = new System.Drawing.Size(268, 22);
            this.txtIdProductos.TabIndex = 10;
            // 
            // lblIdProductos
            // 
            this.lblIdProductos.AutoSize = true;
            this.lblIdProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProductos.Location = new System.Drawing.Point(56, 74);
            this.lblIdProductos.Name = "lblIdProductos";
            this.lblIdProductos.Size = new System.Drawing.Size(27, 20);
            this.lblIdProductos.TabIndex = 9;
            this.lblIdProductos.Text = "Id:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(89, 40);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(268, 22);
            this.txtProducto.TabIndex = 3;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(2, 40);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(81, 20);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvProductos.Location = new System.Drawing.Point(380, 62);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(473, 150);
            this.dgvProductos.TabIndex = 2;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(860, 408);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.gbProductos);
            this.Controls.Add(this.lblProductos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblIdProductos;
        private System.Windows.Forms.TextBox txtIdProductos;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaProductos;
        private System.Windows.Forms.Button btnListadoProductos;
        private System.Windows.Forms.Button btnVolverProductos;
        private System.Windows.Forms.Button btnCargarProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}