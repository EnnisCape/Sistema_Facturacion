using Sistema_Facturacion.Clases;
using System.Windows.Forms;

namespace Sistema_Facturacion.Formularios
{
    public partial class FrmFacturacion : Form
    {
        public FrmFacturacion()
        {
            InitializeComponent();
            dtpFechaFactura.Value = System.DateTime.Now;
            ClienteDAO clientes = new ClienteDAO(); 
        }

        private void btnAgregarArticulo_Click(object sender, System.EventArgs e) {

        }

        private void btnEliniarArticulo_Click(object sender, System.EventArgs e) {

        }

        private void btnLimpiar_Click(object sender, System.EventArgs e) {

        }

        private void nuCantidad_ValueChanged(object sender, System.EventArgs e) {

        }

        private void cBProducto_SelectedIndexChanged(object sender, System.EventArgs e) {

        }

        private void cBCliente_SelectedIndexChanged(object sender, System.EventArgs e) {

        }

        private void FrmFacturacion_Load(object sender, System.EventArgs e)
        {
            
        }
    }
}
