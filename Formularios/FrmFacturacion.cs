using Sistema_Facturacion.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Sistema_Facturacion.Formularios
{
    public partial class FrmFacturacion : Form
    {
        ClienteDAO clientes;
        ProductoDAO producto;
        DataRowView ProductoSeleccionado;
        DataRowView clienteSeleccionado;
        // Esta variable siempre tendrá la fila seleccionada actual (o null si no hay nada seleccionado)
        private ListViewItem filaSeleccionada;

        // Para calculo de factura
        int idProductoP;
        string nombreP;
        private int cantidadProductodb;
        decimal precioP, cantidadSeleccionada = 1;
        decimal subtotalP;
        decimal TotalG;
        decimal subtotalRestar;
        int idProductoInTag;

        public FrmFacturacion()
        {
            InitializeComponent();
            dtpFechaFactura.Value = System.DateTime.Now;
            clientes = new ClienteDAO();
            producto = new ProductoDAO();
            AutoAjustarColumnasProporcional();
        }

        private void btnAgregarArticulo_Click(object sender, System.EventArgs e)
        {
            if (ProductoSeleccionado == null)
            {
                MessageBox.Show("No hay Productos seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AgregaProductoALista();
        }

        private void AgregaProductoALista()
        {
            lVProductos.Visible = true;
            // 2. Extraer los datos del DataRowView (usa los nombres exactos de tu consulta SQL/DataTable)
            idProductoP = Convert.ToInt32(ProductoSeleccionado["Id_producto"]);
            nombreP = ProductoSeleccionado["Nombre"].ToString();
            precioP = Convert.ToDecimal(ProductoSeleccionado["Precio"]);


            // 4. Calcular el subtotalP
            subtotalP = cantidadSeleccionada * precioP;

            // 5. Crear el ListViewItem con la primera columna (Nombre)
            ListViewItem item = new ListViewItem(nombreP);

            // 6. Agregar las subcolumnas en el orden en que creaste el ListView
            item.SubItems.Add(cantidadSeleccionada.ToString());               // Columna Cantidad
            item.SubItems.Add(precioP.ToString("C2"));             // Columna Precio (Formato 0.00)
            item.SubItems.Add(subtotalP.ToString("C2"));           // Columna Subtotal (Formato 0.00)

            // 7. Guardar el ID del producto en el Tag para cuando guardes en la BD
            item.Tag = idProductoP;

            // 8. Insertar la fila en tu ListView
            lVProductos.Items.Add(item);

            // (Opcional) Recalcular el total de la pantalla
            CalcularTotalGeneral(true);
            nuCantidad.Value = 1;
            nuCantidad.Enabled = false;
            cBProducto.SelectedIndex = -1;
            ProductoSeleccionado = null;
        }

        private void CalcularTotalGeneral(bool oper)
        {
            if (oper)
            {
                TotalG += subtotalP;
                subtotalP = 0;
            }
            else
            {
                TotalG -= subtotalRestar;
                subtotalRestar = 0;
            }

            lBtotal.Text = TotalG.ToString("C2");
        }

        private void btnEliniarArticulo_Click(object sender, System.EventArgs e)
        {
            if (idProductoInTag == 0)
            {
                MessageBox.Show("No hay Producto seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Mostramos el MessageBox con botones de OK y Cancelar
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea procesar esta acción?", // Mensaje
                "Confirmación",                                    // Título de la ventana
                MessageBoxButtons.OKCancel,                        // Botones que se mostrarán
                MessageBoxIcon.Question                            // Icono de pregunta
            );

            // 2. Evaluamos si el usuario hizo clic en OK
            if (resultado == DialogResult.OK)
            {
                CalcularTotalGeneral(false);

                // Recorremos todos los elementos actualmente agregados en el ListView
                foreach (ListViewItem item in lVProductos.Items)
                {
                    // 1. Verificamos que el Tag no sea nulo y lo convertimos a int para comparar
                    if (item.Tag != null && Convert.ToInt32(item.Tag) == idProductoInTag)
                    {
                        // 2. Si coincide, lo removemos del ListView
                        lVProductos.Items.Remove(item);

                        // 4. Rompemos el ciclo (break) porque ya encontramos y eliminamos el elemento
                        break;
                    }
                }

                idProductoInTag = 0;
            }
        }

        private void btnLimpiar_Click(object sender, System.EventArgs e)
        {

        }

        private void nuCantidad_ValueChanged(object sender, System.EventArgs e)
        {
            if (nuCantidad.Value > cantidadProductodb)
            {
                MessageBox.Show("Limite maximo de producto en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nuCantidad.Value -= 1;
            }
            cantidadSeleccionada = nuCantidad.Value;
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
            clienteSeleccionado = (DataRowView)cBCliente.SelectedItem;

            // 3. Extraer los datos extra usando el nombre exacto de tus columnas en la BD
            lBCedula.Text = clienteSeleccionado["Cedula"].ToString();
            lBDireccion.Text = clienteSeleccionado["Direccion"].ToString();
        }

        private void ObtenerProductos()
        {

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
            ProductoSeleccionado = (DataRowView)cBProducto.SelectedItem;

            cantidadProductodb = Convert.ToInt32(ProductoSeleccionado["Stock"].ToString());
            nuCantidad.Enabled = true;

            // 3. Extraer los datos extra usando el nombre exacto de tus columnas en la BD
            //lBCedula.Text = ProductoSeleccionado["Cedula"].ToString();
            //lBDireccion.Text = ProductoSeleccionado["Direccion"].ToString();

            // MessageBox.Show($"Productos seleccionado {ProductoSeleccionado["Descripcion"]}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lVProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Validar que realmente haya un elemento seleccionado 
            // (es necesario porque al cambiar de selección el evento a veces se dispara con 0 elementos)
            if (lVProductos.SelectedItems.Count > 0)
            {
                // 2. Asignar la fila seleccionada a nuestra variable global
                filaSeleccionada = lVProductos.SelectedItems[0];

                // Obtener el ID oculto del producto que guardamos en el Tag
                idProductoInTag = (int)filaSeleccionada.Tag;

                subtotalRestar = Convert.ToDecimal(filaSeleccionada.SubItems[3].Text.Substring(1)); // Cuarta columna (Subtotal)

            }
            else
            {
                // Si el usuario hace clic en el espacio vacío del ListView, limpiamos la variable
                filaSeleccionada = null;
            }
        }

        private void btnCrearFactura_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null || lVProductos.Items.Count == 0)
            {

                MessageBox.Show("Faltan elementos importantes de esta factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Desea facturar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                // Entra aquí solo si hacen clic en "Sí"
                GenerarFactura();
            }

        }

        private void AutoAjustarColumnasProporcional()
        {
            // 1. Obtener el ancho real disponible dentro del ListView (sin contar los bordes)
            int anchoTotal = lVProductos.ClientSize.Width;

            // 2. Repartir el ancho usando porcentajes (Asegúrate de que sumen 1.00 o 100%)
            lVProductos.Columns[0].Width = (int)(anchoTotal * 0.45); // Producto: 45%
            lVProductos.Columns[1].Width = (int)(anchoTotal * 0.15); // Cantidad: 15%
            lVProductos.Columns[2].Width = (int)(anchoTotal * 0.20); // Precio: 20%
            lVProductos.Columns[3].Width = (int)(anchoTotal * 0.20); // Subtotal: 20%
        }


        private void GenerarFactura()
        {
            // Cambia esto por tu cadena de conexión real a SQL Server
            string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog = SistemaFacturacion; Integrated Security = True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Iniciamos una transacción para asegurar la integridad de los datos
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // ==========================================
                        // PASO 1: INSERTAR EN CABECERA_FACTURA
                        // ==========================================
                        string queryCabecera = @"
                    INSERT INTO [dbo].[Cabecera_factura] (Fecha, Id_cliente, Id_empleado, Total, Estado_factura)
                    VALUES (@Fecha, @IdCliente, @IdEmpleado, @Total, @Estado);
                    SELECT SCOPE_IDENTITY();"; // Recupera el Id_factura recién generado

                        int idFacturaGenerado = 0;

                        using (SqlCommand cmdCabecera = new SqlCommand(queryCabecera, connection, transaction))
                        {
                            cmdCabecera.Parameters.AddWithValue("@Fecha", dtpFechaFactura.Value);
                            cmdCabecera.Parameters.AddWithValue("@IdCliente", Convert.ToInt32(cBCliente.SelectedValue));

                            // Aquí colocas el ID del empleado logueado en tu sistema (por ahora dejamos 1 como ejemplo)
                            cmdCabecera.Parameters.AddWithValue("@IdEmpleado", 1);

                            // Convertimos el total acumulado en tu etiqueta o TextBox
                            cmdCabecera.Parameters.AddWithValue("@Total", Convert.ToDecimal(lBtotal.Text.Substring(1)));
                            cmdCabecera.Parameters.AddWithValue("@Estado", "A"); // 'A' de Activa

                            // ExecuteScalar ejecuta el INSERT y nos devuelve el id de la factura autogenerado
                            idFacturaGenerado = Convert.ToInt32(cmdCabecera.ExecuteScalar());
                        }

                        // ==========================================
                        // PASO 2: INSERTAR EN DETALLE_FACTURA
                        // ==========================================
                        string queryDetalle = @"
                    INSERT INTO [dbo].[Detalle_factura] (Id_factura, Id_producto, Cantidad, Precio_unitario, Subtotal)
                    VALUES (@IdFactura, @IdProducto, @Cantidad, @PrecioUnitario, @Subtotal);";

                        // Recorremos cada fila que el usuario agregó al ListView
                        foreach (ListViewItem fila in lVProductos.Items)
                        {
                            using (SqlCommand cmdDetalle = new SqlCommand(queryDetalle, connection, transaction))
                            {
                                // Recuperamos el ID del producto guardado de manera oculta en el Tag de la fila
                                int idProducto = (int)fila.Tag;

                                // Extraemos los textos de las columnas correspondientes
                                int cantidad = Convert.ToInt32(fila.SubItems[1].Text);
                                decimal precioUnitario = Convert.ToDecimal(fila.SubItems[2].Text.Substring(1));
                                decimal subtotal = Convert.ToDecimal(fila.SubItems[3].Text.Substring(1));

                                // Asignamos los parámetros de la base de datos
                                cmdDetalle.Parameters.AddWithValue("@IdFactura", idFacturaGenerado);
                                cmdDetalle.Parameters.AddWithValue("@IdProducto", idProducto);
                                cmdDetalle.Parameters.AddWithValue("@Cantidad", cantidad);
                                cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
                                cmdDetalle.Parameters.AddWithValue("@Subtotal", subtotal);

                                // Ejecutamos la inserción de esta fila de detalle
                                cmdDetalle.ExecuteNonQuery();
                            }
                        }

                        // ==========================================
                        // PASO 3: CONFIRMAR TRANSACCIÓN
                        // ==========================================
                        // Si todo se ejecutó sin errores, guardamos los cambios definitivamente en SQL Server
                        transaction.Commit();

                        MessageBox.Show($"Factura No. {idFacturaGenerado} creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiamos los controles para la siguiente factura
                        LimpiarPantallaFactura();
                    }
                    catch (Exception ex)
                    {
                        // Si ocurre CUALQUIER error en la cabecera o en alguno de los detalles,
                        // cancelamos todo lo que se intentó hacer para no dejar basura en la base de datos.
                        transaction.Rollback();
                        MessageBox.Show($"Ocurrió un error al guardar la factura: {ex.Message}", "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void LimpiarPantallaFactura()
        {
            idProductoInTag = 0;
            TotalG = 0;
            lBtotal.Text = TotalG.ToString("C2");
            clienteSeleccionado = null;
            ProductoSeleccionado = null;
            cBCliente.SelectedIndex = -1;
            // 1. Elimina todas las filas (artículos) del ListView
            lVProductos.Items.Clear();
            lBCedula.Text = string.Empty;
            lBDireccion.Text = string.Empty;

        }
    }
}
