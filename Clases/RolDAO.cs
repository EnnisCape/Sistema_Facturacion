using System.Data;
using System.Data.SqlClient;
namespace Sistema_Facturacion.Clases
{
    public class RolDAO
    {
        Conexion conexion = new Conexion();

        public bool GuardarRol(string nombreRol)
        {
            try
            {
                SqlConnection cn = conexion.AbrirConexion();

                string consulta = "INSERT INTO Rol (Nombre_rol) VALUES (@NombreRol)";

                SqlCommand cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@NombreRol", nombreRol);

                cmd.ExecuteNonQuery();

                conexion.CerrarConexion();

                return true;




            }
            catch
            {
                return false;
            }
        }
        public DataTable MostrarRoles()
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlConnection cn = conexion.AbrirConexion();

                string consulta = "SELECT Id_rol, Nombre_rol FROM Rol";

                SqlDataAdapter da = new SqlDataAdapter(consulta, cn);


                da.Fill(tabla);

                conexion.CerrarConexion();
            }
            catch
            {


            }

            return tabla;
        }

        public bool ModificarRol(int idRol, string nombreRol)
        {
            try
            {
                SqlConnection cn = conexion.AbrirConexion();

                string consulta = "UPDATE Rol SET Nombre_rol = @NombreRol WHERE Id_rol = @IdRol";

                SqlCommand cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@NombreRol", nombreRol);
                cmd.Parameters.AddWithValue("@idRol", idRol);

                cmd.ExecuteNonQuery();

                conexion.CerrarConexion();

                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool EliminarRol(int idRol)
        {
            try
            {
                SqlConnection cn = conexion.AbrirConexion();

                string consulta = "DELETE FROM Rol WHERE Id_rol = @IdRol";

                SqlCommand cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@IdRol", idRol);

                cmd.ExecuteNonQuery();

                conexion.CerrarConexion();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}



