using System.Windows.Forms;

namespace Sistema_Facturacion.Formularios
{
    public partial class FrmFacturacion : Form
    {
        public FrmFacturacion()
        {
            InitializeComponent();
            dtpFechaFactura.Value = System.DateTime.Now;
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
    }
}
