using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Facturacion;
using System.Data.SqlClient;
using Sistema_Facturacion.Formularios;


namespace Sistema_Facturacion

{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "" || txtClave.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return;
            }

            Conexion conexion = new Conexion();
            try
            {
                SqlConnection cn = conexion.AbrirConexion();

                String consulta = "SELECT * FROM Usuario WHERE Usuario=@usuario AND Clave=@clave AND Estado_usu='A'";

                SqlCommand comando = new SqlCommand(consulta, cn);

                comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@clave", txtClave.Text);

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    MessageBox.Show("Bienvenido al sistema");

                    FrmMenuPrincipal menu = new FrmMenuPrincipal();
                    menu.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtClave.Clear();
                    txtClave.Focus();
                }

                lector.Close();
                conexion.CerrarConexion();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        } 


    }
}