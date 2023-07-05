namespace pryLangIEFI
{
    partial class frmListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListado));
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListado = new System.Windows.Forms.Label();
            this.optProducto = new System.Windows.Forms.RadioButton();
            this.optCantidad = new System.Windows.Forms.RadioButton();
            this.cboProductoListado = new System.Windows.Forms.ComboBox();
            this.txtCantidadListado = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnVolverListado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Fecha,
            this.Producto,
            this.Cantidad});
            this.dgvListado.Location = new System.Drawing.Point(9, 61);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.RowTemplate.Height = 24;
            this.dgvListado.Size = new System.Drawing.Size(656, 154);
            this.dgvListado.TabIndex = 0;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
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
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(284, 7);
            this.lblListado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(126, 40);
            this.lblListado.TabIndex = 4;
            this.lblListado.Text = "Listado";
            this.lblListado.Click += new System.EventHandler(this.lblListado_Click);
            // 
            // optProducto
            // 
            this.optProducto.AutoSize = true;
            this.optProducto.Checked = true;
            this.optProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optProducto.Location = new System.Drawing.Point(200, 219);
            this.optProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optProducto.Name = "optProducto";
            this.optProducto.Size = new System.Drawing.Size(83, 21);
            this.optProducto.TabIndex = 5;
            this.optProducto.TabStop = true;
            this.optProducto.Text = "Producto";
            this.optProducto.UseVisualStyleBackColor = true;
            // 
            // optCantidad
            // 
            this.optCantidad.AutoSize = true;
            this.optCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCantidad.Location = new System.Drawing.Point(361, 219);
            this.optCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optCantidad.Name = "optCantidad";
            this.optCantidad.Size = new System.Drawing.Size(82, 21);
            this.optCantidad.TabIndex = 6;
            this.optCantidad.TabStop = true;
            this.optCantidad.Text = "Cantidad";
            this.optCantidad.UseVisualStyleBackColor = true;
            // 
            // cboProductoListado
            // 
            this.cboProductoListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductoListado.FormattingEnabled = true;
            this.cboProductoListado.Location = new System.Drawing.Point(200, 237);
            this.cboProductoListado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboProductoListado.Name = "cboProductoListado";
            this.cboProductoListado.Size = new System.Drawing.Size(143, 21);
            this.cboProductoListado.TabIndex = 7;
            // 
            // txtCantidadListado
            // 
            this.txtCantidadListado.Location = new System.Drawing.Point(361, 239);
            this.txtCantidadListado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidadListado.Name = "txtCantidadListado";
            this.txtCantidadListado.Size = new System.Drawing.Size(143, 20);
            this.txtCantidadListado.TabIndex = 8;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(263, 263);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(142, 25);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Location = new System.Drawing.Point(263, 352);
            this.btnVerTodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(142, 25);
            this.btnVerTodo.TabIndex = 10;
            this.btnVerTodo.Text = "Ver todo";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(9, 361);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(142, 25);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnVolverListado
            // 
            this.btnVolverListado.Location = new System.Drawing.Point(524, 361);
            this.btnVolverListado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolverListado.Name = "btnVolverListado";
            this.btnVolverListado.Size = new System.Drawing.Size(142, 25);
            this.btnVolverListado.TabIndex = 12;
            this.btnVolverListado.Text = "Volver";
            this.btnVolverListado.UseVisualStyleBackColor = true;
            this.btnVolverListado.Click += new System.EventHandler(this.btnVolverListado_Click);
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(674, 388);
            this.Controls.Add(this.btnVolverListado);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnVerTodo);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtCantidadListado);
            this.Controls.Add(this.cboProductoListado);
            this.Controls.Add(this.optCantidad);
            this.Controls.Add(this.optProducto);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.dgvListado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmListado";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.RadioButton optProducto;
        private System.Windows.Forms.RadioButton optCantidad;
        private System.Windows.Forms.ComboBox cboProductoListado;
        private System.Windows.Forms.TextBox txtCantidadListado;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnVolverListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}