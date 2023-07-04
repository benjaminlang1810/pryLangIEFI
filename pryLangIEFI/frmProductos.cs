using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLangIEFI
{
    public partial class frmProductos : Form
    {
        string[,] MatrizProductos = new string[10, 4];
        int fila = 0;
        frmListado listado = new frmListado();  
        public frmProductos()
        {
            InitializeComponent();
            txtProducto.Focus(); 
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

        }

        private void gbProductos_Enter(object sender, EventArgs e)
        {

        }

        private void btnVolverProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal principal = new frmPrincipal();
            principal.ShowDialog();
        }

        private void btnCargarProductos_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text != "")
            {
                if (dtpFechaProductos.Value < DateTime.Today)
                {
                    MessageBox.Show("Selecciones una fecha actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int n = dgvProductos.Rows.Add();
                    dgvProductos.Rows[n].Cells[1].Value = txtIdProductos.Text;
                    dgvProductos.Rows[n].Cells[0].Value = txtProducto.Text;
                    dgvProductos.Rows[n].Cells[2].Value = dtpFechaProductos.Text;

                    listado.MatrizProductos[fila,1]=(fila+1).ToString();
                    listado.MatrizProductos[fila, 2] = dtpFechaProductos.Text;
                    listado.MatrizProductos[fila,0]= txtProducto.Text;
                    fila++;
                }
                
            }
            else
            {
                MessageBox.Show("Agrege un Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListadoProductos_Click(object sender, EventArgs e)
        {
            frmListado frmListado = new frmListado();  
            frmListado.ShowDialog();    
        }
    }
}
