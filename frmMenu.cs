using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenADONet
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnFrmBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarProducto frm = new frmBuscarProducto();
            frm.ShowDialog();
        }

        private void frmAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarProducto frm = new frmAgregarProducto();
            frm.ShowDialog();
        }

        private void btnFrmActualizar_Click(object sender, EventArgs e)
        {
            frmActualizarProducto frm = new frmActualizarProducto();
            frm.ShowDialog();
        }

        private void btnFrmEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarProducto frm = new frmEliminarProducto();
            frm.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
