namespace Sistema_Facturacion.Formularios
{
    partial class FrmFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.lBVendedor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cBCliente = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lBDireccion = new System.Windows.Forms.Label();
            this.lBCedula = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lVProductos = new System.Windows.Forms.ListView();
            this.Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrecioUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.cBProducto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nuCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnEliniarArticulo = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lBItebis = new System.Windows.Forms.Label();
            this.lBSubtotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidad)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 37);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(947, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturación";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.00106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.73645F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(941, 83);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(682, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 77);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de Factura";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.2F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.8F));
            this.tableLayoutPanel4.Controls.Add(this.dtpFechaFactura, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lBVendedor, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(250, 56);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFactura.Location = new System.Drawing.Point(81, 3);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(166, 22);
            this.dtpFechaFactura.TabIndex = 3;
            // 
            // lBVendedor
            // 
            this.lBVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBVendedor.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBVendedor.Location = new System.Drawing.Point(81, 28);
            this.lBVendedor.Name = "lBVendedor";
            this.lBVendedor.Size = new System.Drawing.Size(166, 28);
            this.lBVendedor.TabIndex = 5;
            this.lBVendedor.Text = "admin";
            this.lBVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "Vendedor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Fecha";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cBCliente, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.37681F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.62319F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(307, 77);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccionar Cliente:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBCliente
            // 
            this.cBCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCliente.FormattingEnabled = true;
            this.cBCliente.Location = new System.Drawing.Point(3, 38);
            this.cBCliente.Name = "cBCliente";
            this.cBCliente.Size = new System.Drawing.Size(301, 21);
            this.cBCliente.TabIndex = 1;
            this.cBCliente.SelectionChangeCommitted += new System.EventHandler(this.cBCliente_SelectionChangeCommitted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(316, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 77);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de Cliente";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.9887F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.0113F));
            this.tableLayoutPanel3.Controls.Add(this.lBDireccion, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lBCedula, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(354, 56);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // lBDireccion
            // 
            this.lBDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBDireccion.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBDireccion.Location = new System.Drawing.Point(95, 28);
            this.lBDireccion.Name = "lBDireccion";
            this.lBDireccion.Size = new System.Drawing.Size(256, 28);
            this.lBDireccion.TabIndex = 5;
            this.lBDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lBCedula
            // 
            this.lBCedula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBCedula.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBCedula.Location = new System.Drawing.Point(95, 0);
            this.lBCedula.Name = "lBCedula";
            this.lBCedula.Size = new System.Drawing.Size(256, 28);
            this.lBCedula.TabIndex = 4;
            this.lBCedula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dirección:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cedula:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL CLIENTE";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Controls.Add(this.flowLayoutPanel1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(947, 310);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agregar Artículos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lVProductos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 251);
            this.panel2.TabIndex = 3;
            // 
            // lVProductos
            // 
            this.lVProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Producto,
            this.Cantidad,
            this.PrecioUnitario,
            this.subTotal});
            this.lVProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVProductos.GridLines = true;
            this.lVProductos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lVProductos.HideSelection = false;
            this.lVProductos.Location = new System.Drawing.Point(0, 0);
            this.lVProductos.Name = "lVProductos";
            this.lVProductos.Size = new System.Drawing.Size(941, 251);
            this.lVProductos.TabIndex = 2;
            this.lVProductos.UseCompatibleStateImageBehavior = false;
            // 
            // Producto
            // 
            this.Producto.Text = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.Text = "Precio Unitario";
            // 
            // subTotal
            // 
            this.subTotal.Text = "Sub Total";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.cBProducto);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.nuCantidad);
            this.flowLayoutPanel1.Controls.Add(this.btnAgregarArticulo);
            this.flowLayoutPanel1.Controls.Add(this.btnEliniarArticulo);
            this.flowLayoutPanel1.Controls.Add(this.btnLimpiar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(941, 38);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Producto:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBProducto
            // 
            this.cBProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBProducto.FormattingEnabled = true;
            this.cBProducto.Location = new System.Drawing.Point(73, 3);
            this.cBProducto.Name = "cBProducto";
            this.cBProducto.Size = new System.Drawing.Size(234, 24);
            this.cBProducto.TabIndex = 1;
            this.cBProducto.SelectedIndexChanged += new System.EventHandler(this.cBProducto_SelectedIndexChanged);
            this.cBProducto.SelectionChangeCommitted += new System.EventHandler(this.cBProducto_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(313, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 39);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cantidad:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nuCantidad
            // 
            this.nuCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuCantidad.Enabled = false;
            this.nuCantidad.Location = new System.Drawing.Point(383, 8);
            this.nuCantidad.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.nuCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuCantidad.Name = "nuCantidad";
            this.nuCantidad.Size = new System.Drawing.Size(64, 22);
            this.nuCantidad.TabIndex = 3;
            this.nuCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nuCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuCantidad.ValueChanged += new System.EventHandler(this.nuCantidad_ValueChanged);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulo.Image = global::Sistema_Facturacion.Properties.Resources.mas3;
            this.btnAgregarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(453, 3);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(148, 33);
            this.btnAgregarArticulo.TabIndex = 4;
            this.btnAgregarArticulo.Text = "Agregar Artículo";
            this.btnAgregarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnEliniarArticulo
            // 
            this.btnEliniarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliniarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliniarArticulo.Image = global::Sistema_Facturacion.Properties.Resources.borrar;
            this.btnEliniarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliniarArticulo.Location = new System.Drawing.Point(607, 3);
            this.btnEliniarArticulo.Name = "btnEliniarArticulo";
            this.btnEliniarArticulo.Size = new System.Drawing.Size(148, 33);
            this.btnEliniarArticulo.TabIndex = 5;
            this.btnEliniarArticulo.Text = "Eliminar Artículo";
            this.btnEliniarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliniarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliniarArticulo.UseVisualStyleBackColor = true;
            this.btnEliniarArticulo.Click += new System.EventHandler(this.btnEliniarArticulo_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Image = global::Sistema_Facturacion.Properties.Resources.borrar2;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(761, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(148, 33);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar Artículos";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel5);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Location = new System.Drawing.Point(633, 449);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(314, 101);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TOTALES";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.01299F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.98701F));
            this.tableLayoutPanel5.Controls.Add(this.label14, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lBItebis, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.lBSubtotal, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(308, 82);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(117, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 28);
            this.label14.TabIndex = 7;
            this.label14.Text = "$1,960";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 28);
            this.label13.TabIndex = 6;
            this.label13.Text = "GENERAL:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lBItebis
            // 
            this.lBItebis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBItebis.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBItebis.Location = new System.Drawing.Point(117, 27);
            this.lBItebis.Name = "lBItebis";
            this.lBItebis.Size = new System.Drawing.Size(188, 27);
            this.lBItebis.TabIndex = 5;
            this.lBItebis.Text = "$160";
            this.lBItebis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lBSubtotal
            // 
            this.lBSubtotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBSubtotal.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBSubtotal.Location = new System.Drawing.Point(117, 0);
            this.lBSubtotal.Name = "lBSubtotal";
            this.lBSubtotal.Size = new System.Drawing.Size(188, 27);
            this.lBSubtotal.TabIndex = 4;
            this.lBSubtotal.Text = "$1,800";
            this.lBSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 27);
            this.label11.TabIndex = 3;
            this.label11.Text = "ITBIS (18%):";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 27);
            this.label12.TabIndex = 1;
            this.label12.Text = "Subtotal:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btnCrearFactura, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnCancelar, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(470, 449);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(163, 101);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrearFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearFactura.Image = global::Sistema_Facturacion.Properties.Resources.guardar_datos;
            this.btnCrearFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearFactura.Location = new System.Drawing.Point(3, 3);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(157, 44);
            this.btnCrearFactura.TabIndex = 5;
            this.btnCrearFactura.Text = "CREAR FACTURA";
            this.btnCrearFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearFactura.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(3, 53);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 45);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 550);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(963, 589);
            this.Name = "FrmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFacturacion";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidad)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lBDireccion;
        private System.Windows.Forms.Label lBCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label lBVendedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nuCantidad;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnEliniarArticulo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListView lVProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader Producto;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader PrecioUnitario;
        private System.Windows.Forms.ColumnHeader subTotal;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lBItebis;
        private System.Windows.Forms.Label lBSubtotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.Button btnCancelar;
    }
}