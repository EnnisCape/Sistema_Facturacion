using Sistema_Facturacion.Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_Facturacion.Formularios
{
    public partial class FrmFacturacion : Form
    {
        ClienteDAO clientes;
        ProductoDAO producto;
        private int cantidadProducto;


        public FrmFacturacion()
        {
            InitializeComponent();
            dtpFechaFactura.Value = System.DateTime.Now;
            clientes = new ClienteDAO();
            producto = new ProductoDAO();
        }

        private void btnAgregarArticulo_Click(object sender, System.EventArgs e)
        {

        }

        private void btnEliniarArticulo_Click(object sender, System.EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, System.EventArgs e)
        {

        }

        private void nuCantidad_ValueChanged(object sender, System.EventArgs e)
        {
            if (nuCantidad.Value > cantidadProducto) {
                MessageBox.Show("Limite maximo de producto en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nuCantidad.Value -= 1;
            }

           
        }

        private void cBProducto_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void FrmFacturacion_Load(object sender, System.EventArgs e)
        {

            ObtenerClientes();
            ObtenerProductos();


        }

        private void ObtenerClientes()
        {
            // 1. Llamas a tu método que retorna el DataTable
            DataTable dtClientes = clientes.MostrarClientes();
            try
            {
                // 2. Validar que no venga vacío o nulo
                if (dtClientes != null && dtClientes.Rows.Count > 0)
                {
                    // Vinculas el DataTable directamente como la fuente de datos
                    cBCliente.DataSource = dtClientes;

                    // Indica qué columna del DataTable quieres que VEA el usuario en el dropdown
                    cBCliente.DisplayMember = "Nombre";

                    // Indica qué columna del DataTable quieres usar internamente como VALOR (el ID o Llave Primaria)
                    cBCliente.ValueMember = "Id_cliente";

                    // Opcional: Hace que el ComboBox inicie vacío sin seleccionar a nadie por defecto
                    cBCliente.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se encontraron clientes en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cBCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // 1. Validar que realmente haya una fila seleccionada válida
            if (cBCliente.SelectedIndex == -1 || cBCliente.SelectedItem == null)
            {
                return;
            }
            // 2. Convertir el SelectedItem al tipo DataRowView (la fila de la tabla)
            DataRowView filaSeleccionada = (DataRowView)cBCliente.SelectedItem;

            // 3. Extraer los datos extra usando el nombre exacto de tus columnas en la BD
            lBCedula.Text = filaSeleccionada["Cedula"].ToString();
            lBDireccion.Text = filaSeleccionada["Direccion"].ToString();
        }

        private void ObtenerProductos() {

            // 1. Llamas a tu método que retorna el DataTable
            DataTable dtProductos = producto.MostrarProductos();
            try
            {
                // 2. Validar que no venga vacío o nulo
                if (dtProductos != null && dtProductos.Rows.Count > 0)
                {
                    // Vinculas el DataTable directamente como la fuente de datos
                    cBProducto.DataSource = dtProductos;

                    // Indica qué columna del DataTable quieres que VEA el usuario en el dropdown
                    cBProducto.DisplayMember = "Nombre";

                    // Indica qué columna del DataTable quieres usar internamente como VALOR (el ID o Llave Primaria)
                    cBProducto.ValueMember = "Id_producto";

                    // Opcional: Hace que el ComboBox inicie vacío sin seleccionar a nadie por defecto
                    cBProducto.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se encontraron productos en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void cBProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // 1. Validar que realmente haya una fila seleccionada válida
            if (cBProducto.SelectedIndex == -1 || cBProducto.SelectedItem == null)
            {
                return;
            }
            // 2. Convertir el SelectedItem al tipo DataRowView (la fila de la tabla)
            DataRowView filaSeleccionada = (DataRowView)cBProducto.SelectedItem;

            cantidadProducto = Convert.ToInt32(filaSeleccionada["Stock"].ToString());
            nuCantidad.Enabled = true;

            // 3. Extraer los datos extra usando el nombre exacto de tus columnas en la BD
            //lBCedula.Text = filaSeleccionada["Cedula"].ToString();
            //lBDireccion.Text = filaSeleccionada["Direccion"].ToString();

            // MessageBox.Show($"Productos seleccionado {filaSeleccionada["Descripcion"]}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
