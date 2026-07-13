using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Clases
{
    public class ClienteDAO
    {
        Conexion conexion = new Conexion();

        public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlConnection cn = conexion.AbrirConexion();

                string consulta = "SELECT [Id_cliente],[Nombre],[Cedula],[Telefono], [Direccion], [Email],[Estado_cliente] FROM [dbo].[Cliente] WHERE Estado_cliente = 'A'";

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
