using System.Data.SqlClient;

namespace Sistema_Facturacion
{
    public class Conexion
    {
        private SqlConnection conexion = new SqlConnection(@"Data Source=localhost\SQLEXPRESS; Initial Catalog = SistemaFacturacion; Integrated Security = True");

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion; 
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion; 
        }



    }

}
