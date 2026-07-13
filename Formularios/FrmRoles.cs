using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Facturacion.Clases;

namespace Sistema_Facturacion.Formularios
{
    public partial class FrmRoles : Form
    {
        public FrmRoles()
        {
            InitializeComponent();
        }
        private void CargarRoles()
        {
            RolDAO rol = new RolDAO();

            dgvRoles.DataSource = rol.MostrarRoles();
        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            CargarRoles();

            txtIdRol.Clear();
            txtNombreRol.Clear();

            dgvRoles.ClearSelection();

            txtNombreRol.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)

        {


            if (txtNombreRol.Text.Trim() == "")
            {
                MessageBox.Show("Debe escribir el nombre del rol.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreRol.Focus();
                return;
            }


            RolDAO rol = new RolDAO();


            if (rol.GuardarRol(txtNombreRol.Text))
            {
                MessageBox.Show("Rol guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreRol.Clear();
                txtNombreRol.Focus();

                CargarRoles();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdRol.Text = dgvRoles.Rows[e.RowIndex].Cells["Id_rol"].Value.ToString();
                txtNombreRol.Text = dgvRoles.Rows[e.RowIndex].Cells["Nombre_rol"].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIdRol.Text == "")
            {
                MessageBox.Show("Seleccione un rol.");
                return;
            }

            RolDAO rol = new RolDAO();

            if (rol.ModificarRol(
                Convert.ToInt32(txtIdRol.Text),
                txtNombreRol.Text))
            {
                MessageBox.Show("Rol modificado correctamente.");

                CargarRoles();

                txtIdRol.Clear();
                txtNombreRol.Clear();
                txtNombreRol.Focus();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el rol.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdRol.Text == "")
            {
                MessageBox.Show("Seleccione un rol para eliminar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este rol?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                RolDAO rol = new RolDAO();

                if (rol.EliminarRol(Convert.ToInt32(txtIdRol.Text)))
                {
                    MessageBox.Show("Rol eliminado correctamente.",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    CargarRoles();

                    txtIdRol.Clear();
                    txtNombreRol.Clear();
                    txtNombreRol.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el rol.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdRol.Clear();
            txtNombreRol.Clear();

            txtNombreRol.Focus();

            dgvRoles.ClearSelection();
        }
    }
}
