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
    public partial class frmListado : Form
    {
        public string[,] MatrizProductos = new string[10, 4];
        public frmListado()
        {
            InitializeComponent();
        }

        private void lblVentasListado_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverListado_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();    
        }

        private void lblListado_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dgvListado.Rows.Clear();    
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            dgvListado.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                if (MatrizProductos[i,2] != null)
                {
                    dgvListado.Rows.Add(MatrizProductos[i, 0],
                        MatrizProductos[i, 1],
                        MatrizProductos[i, 2], 
                        MatrizProductos[i, 3]);
                }
            }
        
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (MatrizProductos[i,2] != null)
                {
                    if (cboProductoListado.Items.Contains(MatrizProductos[i, 2]) == false)
                    {
                        cboProductoListado.Items.Add(MatrizProductos[i, 2]);
                    }
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvListado.Rows.Clear();
            if (optProducto.Checked)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (MatrizProductos[i, 2]==cboProductoListado.Text) 
                    {
                        dgvListado.Rows.Add(MatrizProductos[i, 0],
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
                    if (MatrizProductos[i,3]==txtCantidadListado.Text)
                    {
                        dgvListado.Rows.Add(MatrizProductos[i, 0],
                                            MatrizProductos[i, 1],
                                            MatrizProductos[i, 2],
                                            MatrizProductos[i, 3]);
                    }
                }
            }
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
