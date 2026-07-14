using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Clases
{
    public class ProductoDAO
    {
        Conexion conexion = new Conexion();


        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlConnection cn = conexion.AbrirConexion();

                string consulta = "SELECT dbo.Producto.* FROM dbo.Producto WHERE Estado = 1";

                SqlDataAdapter da = new SqlDataAdapter(consulta, cn);

                da.Fill(tabla);

                conexion.CerrarConexion();
            }
            catch
            {
                conexion.CerrarConexion();
            }
            return tabla;
        }




    }
}
