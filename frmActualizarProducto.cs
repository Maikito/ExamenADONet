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
    public partial class frmActualizarProducto : Form
    {
        public frmActualizarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            SqlCommand command = null;
            List<Producto> productos = null;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadenaConexion))
                {

                    command = new SqlCommand("GET_PRODUCTO_BY_ID", conexion);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IDPRODUCTO", txtCodigo.Text);


                    productos = new List<Producto>();


                    conexion.Open();
                    SqlDataReader reader = command.ExecuteReader();




                    reader.Read();
                    txtNombre.Text = Convert.ToString(reader["Nombre"]);
                    txtPrecio.Text = Convert.ToString(reader["Precio"]);
                    txtStock.Text = Convert.ToString(reader["Stock"]);


                }

                } catch (Exception) {
                MessageBox.Show("Error, comunicar al administrador");
            }
            finally
            {
                command = null;
                productos = null;
            }
        } 
    
     
            

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text =="" || txtNombre.Text == "" || txtPrecio.Text == "" || txtStock.Text == "")
            {

                MessageBox.Show("Debe ingresar la informacion completa");
            }
            else
            {

                SqlCommand command = null;


                try
                {
                    using (SqlConnection conexion = new SqlConnection(Conexion.cadenaConexion))
                    {

                        command = new SqlCommand("UPD_PRODUCTO", conexion);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@IDPRODUCTO", txtCodigo.Text);
                        command.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
                        command.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                        command.Parameters.AddWithValue("@Stock", txtStock.Text);
                        conexion.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Se actualizo exitosamente");

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
}
