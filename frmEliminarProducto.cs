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

namespace ExamenADONet
{
    public partial class frmEliminarProducto : Form
    {
        public frmEliminarProducto()
        {
            InitializeComponent();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand command = null;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadenaConexion))
            {

                 command = new SqlCommand("DEL_PRODUCTO", conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IDPRODUCTO",txtCodigo .Text );

                conexion.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Se elimino exitosamente");

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
}
