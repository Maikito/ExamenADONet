using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenADONet
{
    public partial class frmAgregarProducto : Form
    {
        public frmAgregarProducto()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtPrecio.Text == "" || txtStock.Text == "") {

                MessageBox.Show("Debe ingresar la informacion completa");
            }else { 
               

            SqlCommand command = null;

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadenaConexion))
            {

                 command = new SqlCommand("INS_PRODUCTO", conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@NOMBRE", txtNombre.Text );
                command.Parameters.AddWithValue("@Precio", txtPrecio .Text );
                command.Parameters.AddWithValue("@Stock", txtStock .Text );
                conexion.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Se agrego exitosamente");
               
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, comunicar al administrador");
            }
            finally
            {
                command = null;

            }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
