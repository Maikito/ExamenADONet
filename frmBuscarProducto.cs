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
using System.Data.SqlClient;


namespace ExamenADONet
{
    public partial class frmBuscarProducto : Form
    {
        public frmBuscarProducto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            SqlCommand command = null;
            List<Producto> productos;
            try
            {


                using (SqlConnection conexion = new SqlConnection(Conexion.cadenaConexion))
                {

                    command = new SqlCommand("GET_PRODUCTO", conexion);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);


                productos = new List<Producto>();
                    conexion.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        productos.Add(new Producto
                        {
                            IdProducto = Convert.ToInt16(reader["IdProducto"]),
                            Nombre = Convert.ToString(reader["Nombre"]),
                            precio = Convert.ToDecimal(reader["Precio"]),
                            stock = Convert.ToInt16(reader["Stock"]),
                            FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"])

                        });
                    }
                    dgvProducto.DataSource = productos;


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, comunicar al administrador");
            }
            finally {
                command = null;
                productos = null;
            }

        }
    }
}
