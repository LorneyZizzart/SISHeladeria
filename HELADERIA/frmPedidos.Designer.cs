namespace HELADERIA
{
    partial class frmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidos));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxTipoProducto = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tblProducto = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.lblPrecio_Producto = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumero_Mesa = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNombre_Producto = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblTipo_Producto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tblLista_Pedidos = new System.Windows.Forms.DataGridView();
            this.groupBoxMeseros = new System.Windows.Forms.GroupBox();
            this.tblUsuarios = new System.Windows.Forms.DataGridView();
            this.txtNombre_Mesero = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tblListaDePedidos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboxTipoPedido = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProducto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLista_Pedidos)).BeginInit();
            this.groupBoxMeseros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarios)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblListaDePedidos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "PEDIDOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxTipoProducto);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tblProducto);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(916, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 666);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCTOS A LA VENTA";
            // 
            // cboxTipoProducto
            // 
            this.cboxTipoProducto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTipoProducto.FormattingEnabled = true;
            this.cboxTipoProducto.Location = new System.Drawing.Point(253, 31);
            this.cboxTipoProducto.Name = "cboxTipoProducto";
            this.cboxTipoProducto.Size = new System.Drawing.Size(180, 26);
            this.cboxTipoProducto.TabIndex = 21;
            this.cboxTipoProducto.SelectedIndexChanged += new System.EventHandler(this.cboxTipoProducto_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(248, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "Selecionar por el tipo de Producto:";
            // 
            // tblProducto
            // 
            this.tblProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProducto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tblProducto.Location = new System.Drawing.Point(6, 70);
            this.tblProducto.Name = "tblProducto";
            this.tblProducto.Size = new System.Drawing.Size(427, 587);
            this.tblProducto.TabIndex = 0;
            this.tblProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblProducto_CellClick);
            this.tblProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblProducto_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNumeroPedido);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnDerecha);
            this.groupBox2.Controls.Add(this.btnIzquierda);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.lblPrecio_Producto);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblNombre_Producto);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.lblTipo_Producto);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(383, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 133);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PEDIDOS";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPedido.Location = new System.Drawing.Point(148, 25);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(21, 19);
            this.lblNumeroPedido.TabIndex = 16;
            this.lblNumeroPedido.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Número de Pedido:";
            // 
            // btnDerecha
            // 
            this.btnDerecha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerecha.Location = new System.Drawing.Point(446, 56);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(67, 33);
            this.btnDerecha.TabIndex = 14;
            this.btnDerecha.Text = ">>";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzquierda.Location = new System.Drawing.Point(446, 19);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(67, 33);
            this.btnIzquierda.TabIndex = 12;
            this.btnIzquierda.Text = "<<";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(88, 101);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 19);
            this.label20.TabIndex = 13;
            this.label20.Text = "Bolivianos.";
            // 
            // lblPrecio_Producto
            // 
            this.lblPrecio_Producto.AutoSize = true;
            this.lblPrecio_Producto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio_Producto.Location = new System.Drawing.Point(67, 101);
            this.lblPrecio_Producto.Name = "lblPrecio_Producto";
            this.lblPrecio_Producto.Size = new System.Drawing.Size(0, 19);
            this.lblPrecio_Producto.TabIndex = 12;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 101);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 19);
            this.label21.TabIndex = 11;
            this.label21.Text = "Precio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(321, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "*";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNumero_Mesa);
            this.panel1.Location = new System.Drawing.Point(340, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 67);
            this.panel1.TabIndex = 9;
            // 
            // lblNumero_Mesa
            // 
            this.lblNumero_Mesa.AutoSize = true;
            this.lblNumero_Mesa.Font = new System.Drawing.Font("Calibri", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero_Mesa.Location = new System.Drawing.Point(-11, -23);
            this.lblNumero_Mesa.Name = "lblNumero_Mesa";
            this.lblNumero_Mesa.Size = new System.Drawing.Size(89, 106);
            this.lblNumero_Mesa.TabIndex = 8;
            this.lblNumero_Mesa.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(281, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mesa: *";
            // 
            // lblNombre_Producto
            // 
            this.lblNombre_Producto.AutoSize = true;
            this.lblNombre_Producto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre_Producto.Location = new System.Drawing.Point(77, 77);
            this.lblNombre_Producto.Name = "lblNombre_Producto";
            this.lblNombre_Producto.Size = new System.Drawing.Size(0, 19);
            this.lblNombre_Producto.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(340, 96);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(173, 27);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblTipo_Producto
            // 
            this.lblTipo_Producto.AutoSize = true;
            this.lblTipo_Producto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo_Producto.Location = new System.Drawing.Point(139, 50);
            this.lblTipo_Producto.Name = "lblTipo_Producto";
            this.lblTipo_Producto.Size = new System.Drawing.Size(21, 19);
            this.lblTipo_Producto.TabIndex = 3;
            this.lblTipo_Producto.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de Producto: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(498, 258);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 33);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tblLista_Pedidos);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 383);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LISTA DE PEDIDOS";
            // 
            // tblLista_Pedidos
            // 
            this.tblLista_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLista_Pedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tblLista_Pedidos.Location = new System.Drawing.Point(6, 27);
            this.tblLista_Pedidos.Name = "tblLista_Pedidos";
            this.tblLista_Pedidos.Size = new System.Drawing.Size(339, 350);
            this.tblLista_Pedidos.TabIndex = 0;
            this.tblLista_Pedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblLista_Pedidos_CellClick);
            // 
            // groupBoxMeseros
            // 
            this.groupBoxMeseros.Controls.Add(this.tblUsuarios);
            this.groupBoxMeseros.Controls.Add(this.txtNombre_Mesero);
            this.groupBoxMeseros.Controls.Add(this.label15);
            this.groupBoxMeseros.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMeseros.Location = new System.Drawing.Point(383, 297);
            this.groupBoxMeseros.Name = "groupBoxMeseros";
            this.groupBoxMeseros.Size = new System.Drawing.Size(525, 198);
            this.groupBoxMeseros.TabIndex = 7;
            this.groupBoxMeseros.TabStop = false;
            this.groupBoxMeseros.Text = "MESEROS EN SERVICIO";
            // 
            // tblUsuarios
            // 
            this.tblUsuarios.AllowUserToOrderColumns = true;
            this.tblUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tblUsuarios.Location = new System.Drawing.Point(6, 70);
            this.tblUsuarios.Name = "tblUsuarios";
            this.tblUsuarios.Size = new System.Drawing.Size(513, 122);
            this.tblUsuarios.TabIndex = 1;
            this.tblUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblUsuarios_CellClick);
            // 
            // txtNombre_Mesero
            // 
            this.txtNombre_Mesero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre_Mesero.Location = new System.Drawing.Point(263, 41);
            this.txtNombre_Mesero.Name = "txtNombre_Mesero";
            this.txtNombre_Mesero.Size = new System.Drawing.Size(256, 23);
            this.txtNombre_Mesero.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(199, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 19);
            this.label15.TabIndex = 24;
            this.label15.Text = "Buscar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(541, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(361, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Los campos requeridos estan marcados con un  [ * ]";
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPedido.Location = new System.Drawing.Point(613, 258);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(109, 33);
            this.btnNuevoPedido.TabIndex = 11;
            this.btnNuevoPedido.Text = "Nuevo Pedido";
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(383, 258);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(109, 33);
            this.btnListar.TabIndex = 12;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tblListaDePedidos);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 496);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(896, 207);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PEDIDOS REALIZADOS";
            // 
            // tblListaDePedidos
            // 
            this.tblListaDePedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblListaDePedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tblListaDePedidos.Location = new System.Drawing.Point(6, 19);
            this.tblListaDePedidos.Name = "tblListaDePedidos";
            this.tblListaDePedidos.Size = new System.Drawing.Size(884, 179);
            this.tblListaDePedidos.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblPrecioTotal);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(12, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 51);
            this.panel2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bolivianos";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(137, 12);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(23, 26);
            this.lblPrecioTotal.TabIndex = 5;
            this.lblPrecioTotal.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 26);
            this.label10.TabIndex = 4;
            this.label10.Text = "PRECIO TOTAL:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(643, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tipo de Pedido:";
            // 
            // cboxTipoPedido
            // 
            this.cboxTipoPedido.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTipoPedido.FormattingEnabled = true;
            this.cboxTipoPedido.Items.AddRange(new object[] {
            "Para la mesa",
            "Para llevar"});
            this.cboxTipoPedido.Location = new System.Drawing.Point(756, 86);
            this.cboxTipoPedido.Name = "cboxTipoPedido";
            this.cboxTipoPedido.Size = new System.Drawing.Size(146, 26);
            this.cboxTipoPedido.TabIndex = 17;
            this.cboxTipoPedido.SelectedIndexChanged += new System.EventHandler(this.cboxTipoPedido_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(731, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Facturar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(850, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 48);
            this.button2.TabIndex = 19;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1362, 710);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboxTipoPedido);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBoxMeseros);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEDIDOS";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProducto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblLista_Pedidos)).EndInit();
            this.groupBoxMeseros.ResumeLayout(false);
            this.groupBoxMeseros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarios)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblListaDePedidos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNombre_Producto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblTipo_Producto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView tblLista_Pedidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumero_Mesa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxMeseros;
        private System.Windows.Forms.TextBox txtNombre_Mesero;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPrecio_Producto;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.DataGridView tblUsuarios;
        private System.Windows.Forms.DataGridView tblProducto;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView tblListaDePedidos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboxTipoPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboxTipoProducto;
        private System.Windows.Forms.Label label12;

    }
}