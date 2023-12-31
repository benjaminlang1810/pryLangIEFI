﻿using System;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Hide();    
            frmProductos frmProductos = new frmProductos(); 
            frmProductos.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVentas frmVentas = new frmVentas();  
            frmVentas.ShowDialog();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {   
            this.Hide();
            frmListado frmListado = new frmListado();
            frmListado.ShowDialog();
        }
    }
}
