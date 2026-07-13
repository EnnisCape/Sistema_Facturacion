using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Sistema_Facturacion.Clases
{
    public class UsuarioDAO
    {
        Conexion conexion = new Conexion();

        public DataTable MostrarEmpleados()
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlConnection cn = conexion.AbrirConexion();

                string consulta = "SELECT Id_empleado, Nombre FROM Empleado";

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
        public bool GuardarUsuario(string usuario, string clave, int idEmpleado, int idRol, string estado)
        {
            try
            {
                SqlConnection cn = conexion.AbrirConexion();

                string consulta = @"INSERT INTO Usuario
                            (Usuario, Clave, Id_empleado, Id_rol, Estado_usu)
                            VALUES
                            (@Usuario, @Clave, @IdEmpleado, @IdRol, @Estado)";

                SqlCommand cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Clave", clave);
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                cmd.Parameters.AddWithValue("@IdRol", idRol);
                cmd.Parameters.AddWithValue("@Estado", estado);

                cmd.ExecuteNonQuery();

                conexion.CerrarConexion();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ModificarUsuario (int idUsuario, string usuario, string clave, int idEmpleado, int idRol, string estado)
        {
            try
            {
                SqlConnection cn = conexion.AbrirConexion();

                string consulta = @"UPDATE Usuario
                            SET Usuario = @Usuario,
                                Clave = @Clave,
                                Id_empleado = @IdEmpleado,
                                Id_rol = @IdRol,
                                Estado_usu = @Estado
                            WHERE Id_Usuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Clave", clave);
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                cmd.Parameters.AddWithValue("@IdRol", idRol);
                cmd.Parameters.AddWithValue("@Estado", estado);

                cmd.ExecuteNonQuery();

                conexion.CerrarConexion();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarUsuario(int idUsuario)
        {
            try
            {
                SqlConnection cn = conexion.AbrirConexion();

                string consulta = "DELETE FROM Usuario WHERE Id_Usuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                cmd.ExecuteNonQuery();

                conexion.CerrarConexion();

                return true;

            }
            catch
            {
                return false;
            }
        }      
        



        public DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlConnection cn = conexion.AbrirConexion();

                string consulta = @"SELECT
                                U.Id_Usuario,
                                U.Clave,
                                U.Id_empleado,
                                U.Id_rol,
                                U.Usuario,
                                E.Nombre AS Empleado,
                                R.Nombre_rol AS Rol,
                                CASE
                                    WHEN U.Estado_usu = 'A' THEN 'Activo'
                                    ELSE 'Inactivo'
                                END AS Estado
                            FROM Usuario U
                            INNER JOIN Empleado E
                                ON U.Id_empleado = E.Id_empleado
                            INNER JOIN Rol R
                                ON U.Id_rol = R.Id_rol";

                SqlDataAdapter da = new SqlDataAdapter(consulta, cn);

                da.Fill(tabla);

                conexion.CerrarConexion();

            }                          
            catch                       
            {                          
                                                                      
            }                                
                                       
                                       
            return tabla;              
                                           
        }                              
    }                                       
}
