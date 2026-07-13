using Sistema_Facturacion.Clases;
using System;
using System.Windows.Forms;

namespace Sistema_Facturacion.Formularios
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void CargarEmpleados()
        {
            UsuarioDAO usuario = new UsuarioDAO();

            cmbEmpleado.DataSource = usuario.MostrarEmpleados();

            cmbEmpleado.DisplayMember = "Nombre";

            cmbEmpleado.ValueMember = "Id_empleado";
        }

        private void CargarRoles()
        {
            UsuarioDAO usuario = new UsuarioDAO();

            cmbRol.DataSource = usuario.MostrarRoles();

            cmbRol.DisplayMember = "Nombre_rol";

            cmbRol.ValueMember = "Id_rol";
        }
        private void CargarEstado()
        {
            cmbEstado.Items.Clear();

            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");

            cmbEstado.SelectedIndex = 0;
        }   

        private void CargarUsuarios()
        {
            UsuarioDAO usuario = new UsuarioDAO();

            dgvUsuarios.DataSource = usuario.MostrarUsuarios();

            dgvUsuarios.Columns["Clave"].Visible = false;
            dgvUsuarios.Columns["Id_empleado"].Visible = false;
            dgvUsuarios.Columns["Id_rol"].Visible = false;
        }


        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarRoles();
            CargarEstado();
            CargarUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "" || txtClave.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;


            }

            UsuarioDAO usuario = new UsuarioDAO();

            string nombreUsuario = txtUsuario.Text;
            string clave = txtClave.Text;

            int idEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue);

            int idRol = Convert.ToInt32(cmbRol.SelectedValue);

            string estado;

            if (cmbEstado.Text == "Activo")
            {
                estado = "A";
            }
            else
            {
                estado = "I";
            }
            
            if (usuario.GuardarUsuario(nombreUsuario, clave, idEmpleado, idRol, estado))
            {
                MessageBox.Show("Usuario guardado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarUsuarios();

                txtUsuario.Clear();
                txtClave.Clear();

                cmbEmpleado.SelectedIndex = 0;
                cmbRol.SelectedIndex = 0;
                cmbEstado.SelectedIndex = 0;

                txtIdUsuario.Focus();
            } 
            else
            {
                MessageBox.Show("No se pudo guardar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Id_Usuario"].Value.ToString();

                txtUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();

                txtClave.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Clave"].Value.ToString();

                cmbEmpleado.SelectedValue = dgvUsuarios.Rows[e.RowIndex].Cells["Id_empleado"].Value;

                cmbRol.SelectedValue = dgvUsuarios.Rows[e.RowIndex].Cells["Id_rol"].Value;

                cmbEstado.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Estado"].Value.ToString();




            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione un usuario del listado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                
                                
                return;
            }

            UsuarioDAO usuario = new UsuarioDAO();

            int idUsuario = Convert.ToInt32(txtIdUsuario.Text);

            string nombreUsuario = txtUsuario.Text;
            string clave = txtClave.Text;

            int idEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue);
            int idRol = Convert.ToInt32(cmbRol.SelectedValue);

            string estado;

            if (cmbEstado.Text == "Activo")
            {
                estado = "A";
            }
            else
            {
                estado = "I";
            }

            if (usuario.ModificarUsuario(idUsuario, nombreUsuario, clave, idEmpleado, idRol, estado))
            {
                MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                               

                CargarUsuarios();

                txtIdUsuario.Clear();
                txtUsuario.Clear();
                txtClave.Clear();

                cmbEmpleado.SelectedIndex = 0;
                cmbRol.SelectedIndex = 0;
                cmbEstado.SelectedIndex = 0;

                txtUsuario.Focus();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione un usuario del listado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            

            if (respuesta == DialogResult.Yes)
            {
                UsuarioDAO usuario = new UsuarioDAO();

                int idUsuario = Convert.ToInt32(txtIdUsuario.Text);

                if (usuario.EliminarUsuario(idUsuario))
                {
                    MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    

                    CargarUsuarios();

                    txtIdUsuario.Clear();
                    txtUsuario.Clear();
                    txtClave.Clear();

                    cmbEmpleado.SelectedIndex = 0;
                    cmbRol.SelectedIndex = 0;
                    cmbEstado.SelectedIndex = 0;

                    txtUsuario.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdUsuario.Clear();
            txtUsuario.Clear();
            txtClave.Clear();

            cmbEmpleado.SelectedIndex = 0;
            cmbRol.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;

            txtUsuario.Focus();
        }
    }       
}
