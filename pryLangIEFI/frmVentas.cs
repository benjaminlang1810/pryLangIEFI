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
        public string[,] MatrizProductos = new string[10, 4];
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
            
            listado.ShowDialog();   
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

                    MatrizProductos[fila, 0] = (fila+1).ToString();
                    MatrizProductos[fila, 1] = dtpFechaVentas.Text;
                    MatrizProductos[fila, 2] = txtProductoVentas.Text;
                    MatrizProductos[fila, 3] = nudCantidadVentas.Text;
                    listado.MatrizProductos[fila,0]=(fila+1).ToString();
                    listado.MatrizProductos[fila,1]=dtpFechaVentas.Text;
                    listado.MatrizProductos[fila, 2] = txtProductoVentas.Text;
                    listado.MatrizProductos[fila, 3] = nudCantidadVentas.Text;
                    dgvVentas.Rows.Add(MatrizProductos[fila,0],
                                       MatrizProductos[fila,1], 
                                       MatrizProductos[fila,2],
                                       MatrizProductos[fila,3] );
                                                            fila++;

                }

            }
            else
            {
                MessageBox.Show("Agrege un Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            cboProductoVentas.Items.Add(txtProductoVentas.Text);
           
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        private void txtCantidadVentas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrarVentas_Click(object sender, EventArgs e)
        {
            dgvVentas.Rows.Clear();
            if (optProductoVentas.Checked)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (MatrizProductos[i, 2] == cboProductoVentas.Text)
                    {
                            dgvVentas.Rows.Add(
                            MatrizProductos[i, 0],
                            MatrizProductos[i, 1],
                            MatrizProductos[i, 2],
                            MatrizProductos[i, 3]);
                    }
                }
            }
            else
            {
                   for (int i = 0; i < 10; i++)
                   {
                        if (MatrizProductos[i, 3] == txtCantidadVentas2.Text)
                        {
                            dgvVentas.Rows.Add(
                            MatrizProductos[i, 0],
                            MatrizProductos[i, 1],
                            MatrizProductos[i, 2],
                            MatrizProductos[i, 3]);
                        }
                   }
            }
        }
    }
}
