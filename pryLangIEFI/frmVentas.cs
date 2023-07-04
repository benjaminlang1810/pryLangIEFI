using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLangIEFI
{
    public partial class frmVentas : Form
    {
        string[,] MatrizProductos = new string[10, 4];
        int fila = 0;
        frmListado listado = new frmListado();  
        public frmVentas()
        {
            InitializeComponent();
            txtProductoVentas.Focus();  
        }

        private void lblVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnListadoVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListado frmListado = new frmListado();   
            frmListado.ShowDialog();    
        }

        private void btnVolverVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal principal = new frmPrincipal();
            principal.ShowDialog();
        }

        private void btnCargarVentas_Click(object sender, EventArgs e)
        {
            if (txtProductoVentas.Text != "")
            {
                if (dtpFechaVentas.Value < DateTime.Today)
                {
                    MessageBox.Show("Selecciones una fecha actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    listado.MatrizProductos[fila, 0] = (fila + 1).ToString();
                    listado.MatrizProductos[fila, 1] = dtpFechaVentas.Text;
                    listado.MatrizProductos[fila, 2] = txtProductoVentas.Text;
                    listado.MatrizProductos[fila, 3] = txtCantidadVentas.Text;
                    MatrizProductos[fila, 0] = (fila + 1).ToString();
                    MatrizProductos[fila, 1] = dtpFechaVentas.Text;
                    MatrizProductos[fila, 2] = txtProductoVentas.Text;
                    MatrizProductos[fila, 3] = txtCantidadVentas.Text;
                    dgvVentas.Rows.Add(MatrizProductos[fila,0], MatrizProductos[fila,1], MatrizProductos[fila,2], MatrizProductos[fila,3] );
                    fila++;

                }

            }
            else
            {
                MessageBox.Show("Agrege un Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
