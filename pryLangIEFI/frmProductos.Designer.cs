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
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblIdProductos = new System.Windows.Forms.Label();
            this.txtIdProductos = new System.Windows.Forms.TextBox();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.dtpFechaProductos = new System.Windows.Forms.DateTimePicker();
            this.lblCantidadProductos = new System.Windows.Forms.Label();
            this.txtCantidadProductos = new System.Windows.Forms.TextBox();
            this.btnListadoProductos = new System.Windows.Forms.Button();
            this.btnVolverProductos = new System.Windows.Forms.Button();
            this.btnCargarProductos = new System.Windows.Forms.Button();
            this.gbProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(36, 9);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(218, 50);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Productos";
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.btnListadoProductos);
            this.gbProductos.Controls.Add(this.btnVolverProductos);
            this.gbProductos.Controls.Add(this.btnCargarProductos);
            this.gbProductos.Controls.Add(this.txtCantidadProductos);
            this.gbProductos.Controls.Add(this.lblCantidadProductos);
            this.gbProductos.Controls.Add(this.dtpFechaProductos);
            this.gbProductos.Controls.Add(this.lblFechaVenta);
            this.gbProductos.Controls.Add(this.txtIdProductos);
            this.gbProductos.Controls.Add(this.lblIdProductos);
            this.gbProductos.Controls.Add(this.txtProducto);
            this.gbProductos.Controls.Add(this.lblProducto);
            this.gbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductos.Location = new System.Drawing.Point(12, 62);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(295, 323);
            this.gbProductos.TabIndex = 1;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Carga De Productos";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(6, 27);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(81, 20);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(10, 50);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(211, 22);
            this.txtProducto.TabIndex = 3;
            // 
            // lblIdProductos
            // 
            this.lblIdProductos.AutoSize = true;
            this.lblIdProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProductos.Location = new System.Drawing.Point(6, 84);
            this.lblIdProductos.Name = "lblIdProductos";
            this.lblIdProductos.Size = new System.Drawing.Size(27, 20);
            this.lblIdProductos.TabIndex = 9;
            this.lblIdProductos.Text = "Id:";
            // 
            // txtIdProductos
            // 
            this.txtIdProductos.Location = new System.Drawing.Point(10, 102);
            this.txtIdProductos.Name = "txtIdProductos";
            this.txtIdProductos.Size = new System.Drawing.Size(211, 22);
            this.txtIdProductos.TabIndex = 10;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.Location = new System.Drawing.Point(6, 143);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(141, 20);
            this.lblFechaVenta.TabIndex = 11;
            this.lblFechaVenta.Text = "Fecha Productos:";
            // 
            // dtpFechaProductos
            // 
            this.dtpFechaProductos.Location = new System.Drawing.Point(10, 166);
            this.dtpFechaProductos.Name = "dtpFechaProductos";
            this.dtpFechaProductos.Size = new System.Drawing.Size(211, 22);
            this.dtpFechaProductos.TabIndex = 12;
            // 
            // lblCantidadProductos
            // 
            this.lblCantidadProductos.AutoSize = true;
            this.lblCantidadProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProductos.Location = new System.Drawing.Point(7, 206);
            this.lblCantidadProductos.Name = "lblCantidadProductos";
            this.lblCantidadProductos.Size = new System.Drawing.Size(80, 20);
            this.lblCantidadProductos.TabIndex = 13;
            this.lblCantidadProductos.Text = "Cantidad:";
            // 
            // txtCantidadProductos
            // 
            this.txtCantidadProductos.Location = new System.Drawing.Point(93, 206);
            this.txtCantidadProductos.Name = "txtCantidadProductos";
            this.txtCantidadProductos.Size = new System.Drawing.Size(48, 22);
            this.txtCantidadProductos.TabIndex = 14;
            // 
            // btnListadoProductos
            // 
            this.btnListadoProductos.Location = new System.Drawing.Point(10, 278);
            this.btnListadoProductos.Name = "btnListadoProductos";
            this.btnListadoProductos.Size = new System.Drawing.Size(276, 35);
            this.btnListadoProductos.TabIndex = 17;
            this.btnListadoProductos.Text = "Listado";
            this.btnListadoProductos.UseVisualStyleBackColor = true;
            // 
            // btnVolverProductos
            // 
            this.btnVolverProductos.Location = new System.Drawing.Point(10, 232);
            this.btnVolverProductos.Name = "btnVolverProductos";
            this.btnVolverProductos.Size = new System.Drawing.Size(135, 40);
            this.btnVolverProductos.TabIndex = 16;
            this.btnVolverProductos.Text = "Volver";
            this.btnVolverProductos.UseVisualStyleBackColor = true;
            // 
            // btnCargarProductos
            // 
            this.btnCargarProductos.Location = new System.Drawing.Point(151, 232);
            this.btnCargarProductos.Name = "btnCargarProductos";
            this.btnCargarProductos.Size = new System.Drawing.Size(135, 40);
            this.btnCargarProductos.TabIndex = 15;
            this.btnCargarProductos.Text = "Cargar";
            this.btnCargarProductos.UseVisualStyleBackColor = true;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(346, 404);
            this.Controls.Add(this.gbProductos);
            this.Controls.Add(this.lblProductos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
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
        private System.Windows.Forms.Label lblCantidadProductos;
        private System.Windows.Forms.TextBox txtCantidadProductos;
        private System.Windows.Forms.Button btnListadoProductos;
        private System.Windows.Forms.Button btnVolverProductos;
        private System.Windows.Forms.Button btnCargarProductos;
    }
}