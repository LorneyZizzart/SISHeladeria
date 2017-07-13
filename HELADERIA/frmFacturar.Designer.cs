namespace HELADERIA
{
    partial class frmFacturar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturar));
            this.label1 = new System.Windows.Forms.Label();
            this.tblListaPedidos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QRcodeFacturas = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCancelar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoDomicilio = new System.Windows.Forms.RadioButton();
            this.rdoPaLlevar = new System.Windows.Forms.RadioButton();
            this.rdoPaMesa = new System.Windows.Forms.RadioButton();
            this.txtBuscarPedido = new System.Windows.Forms.TextBox();
            this.btnBuscarPedido = new System.Windows.Forms.Button();
            this.tblFacturas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblListaPedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRcodeFacturas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA DE PEDIDOS";
            // 
            // tblListaPedidos
            // 
            this.tblListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblListaPedidos.Location = new System.Drawing.Point(19, 157);
            this.tblListaPedidos.Name = "tblListaPedidos";
            this.tblListaPedidos.Size = new System.Drawing.Size(820, 153);
            this.tblListaPedidos.TabIndex = 1;
            this.tblListaPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblListaPedidos_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "FACTURACIONES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QRcodeFacturas);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCancelar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtApellidoPaterno);
            this.groupBox1.Controls.Add(this.txtApellidoMaterno);
            this.groupBox1.Controls.Add(this.txtCarnet);
            this.groupBox1.Controls.Add(this.txtNIT);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 173);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL CLIENTE";
            // 
            // QRcodeFacturas
            // 
            this.QRcodeFacturas.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.QRcodeFacturas.Image = ((System.Drawing.Image)(resources.GetObject("QRcodeFacturas.Image")));
            this.QRcodeFacturas.Location = new System.Drawing.Point(655, 77);
            this.QRcodeFacturas.Name = "QRcodeFacturas";
            this.QRcodeFacturas.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
            this.QRcodeFacturas.Size = new System.Drawing.Size(102, 97);
            this.QRcodeFacturas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QRcodeFacturas.TabIndex = 36;
            this.QRcodeFacturas.TabStop = false;
            this.QRcodeFacturas.Text = "qrCodeImgControl1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(318, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "Bolivianos";
            // 
            // txtCancelar
            // 
            this.txtCancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancelar.Location = new System.Drawing.Point(159, 134);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.Size = new System.Drawing.Size(153, 26);
            this.txtCancelar.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = "Pago total:";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.Location = new System.Drawing.Point(159, 72);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(197, 26);
            this.txtApellidoPaterno.TabIndex = 29;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.Location = new System.Drawing.Point(159, 102);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(197, 26);
            this.txtApellidoMaterno.TabIndex = 28;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.Location = new System.Drawing.Point(549, 16);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(208, 26);
            this.txtCarnet.TabIndex = 26;
            this.txtCarnet.TextChanged += new System.EventHandler(this.txtCarnet_TextChanged);
            // 
            // txtNIT
            // 
            this.txtNIT.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIT.Location = new System.Drawing.Point(549, 46);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(208, 26);
            this.txtNIT.TabIndex = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(159, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 26);
            this.txtNombre.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(502, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "NIT. :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Apellido materno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cedula de Identidiad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apellido paterno:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(698, 506);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 35);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoDomicilio);
            this.groupBox2.Controls.Add(this.rdoPaLlevar);
            this.groupBox2.Controls.Add(this.rdoPaMesa);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 46);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTAR POR:";
            // 
            // rdoDomicilio
            // 
            this.rdoDomicilio.AutoSize = true;
            this.rdoDomicilio.Location = new System.Drawing.Point(377, 17);
            this.rdoDomicilio.Name = "rdoDomicilio";
            this.rdoDomicilio.Size = new System.Drawing.Size(67, 23);
            this.rdoDomicilio.TabIndex = 2;
            this.rdoDomicilio.TabStop = true;
            this.rdoDomicilio.Text = "Todos";
            this.rdoDomicilio.UseVisualStyleBackColor = true;
            this.rdoDomicilio.CheckedChanged += new System.EventHandler(this.rdoDomicilio_CheckedChanged);
            // 
            // rdoPaLlevar
            // 
            this.rdoPaLlevar.AutoSize = true;
            this.rdoPaLlevar.Location = new System.Drawing.Point(253, 17);
            this.rdoPaLlevar.Name = "rdoPaLlevar";
            this.rdoPaLlevar.Size = new System.Drawing.Size(100, 23);
            this.rdoPaLlevar.TabIndex = 1;
            this.rdoPaLlevar.TabStop = true;
            this.rdoPaLlevar.Text = "Para llevar";
            this.rdoPaLlevar.UseVisualStyleBackColor = true;
            this.rdoPaLlevar.CheckedChanged += new System.EventHandler(this.rdoPaLlevar_CheckedChanged);
            // 
            // rdoPaMesa
            // 
            this.rdoPaMesa.AutoSize = true;
            this.rdoPaMesa.Location = new System.Drawing.Point(129, 17);
            this.rdoPaMesa.Name = "rdoPaMesa";
            this.rdoPaMesa.Size = new System.Drawing.Size(113, 23);
            this.rdoPaMesa.TabIndex = 0;
            this.rdoPaMesa.TabStop = true;
            this.rdoPaMesa.Text = "Para la mesa";
            this.rdoPaMesa.UseVisualStyleBackColor = true;
            this.rdoPaMesa.CheckedChanged += new System.EventHandler(this.rdoPaMesa_CheckedChanged);
            // 
            // txtBuscarPedido
            // 
            this.txtBuscarPedido.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPedido.Location = new System.Drawing.Point(557, 120);
            this.txtBuscarPedido.Name = "txtBuscarPedido";
            this.txtBuscarPedido.Size = new System.Drawing.Size(197, 26);
            this.txtBuscarPedido.TabIndex = 30;
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPedido.Location = new System.Drawing.Point(758, 116);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Size = new System.Drawing.Size(81, 35);
            this.btnBuscarPedido.TabIndex = 31;
            this.btnBuscarPedido.Text = "BUSCAR";
            this.btnBuscarPedido.UseVisualStyleBackColor = true;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
            // 
            // tblFacturas
            // 
            this.tblFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFacturas.Location = new System.Drawing.Point(19, 550);
            this.tblFacturas.Name = "tblFacturas";
            this.tblFacturas.Size = new System.Drawing.Size(820, 104);
            this.tblFacturas.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(538, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 35);
            this.button1.TabIndex = 33;
            this.button1.Text = "VOLVER A PEDIDOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(378, 506);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(154, 35);
            this.btnFacturar.TabIndex = 34;
            this.btnFacturar.Text = "FACTURAR";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // frmFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 666);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tblFacturas);
            this.Controls.Add(this.btnBuscarPedido);
            this.Controls.Add(this.txtBuscarPedido);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tblListaPedidos);
            this.Controls.Add(this.label1);
            this.Name = "frmFacturar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFACTURAR";
            ((System.ComponentModel.ISupportInitialize)(this.tblListaPedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRcodeFacturas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblListaPedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoDomicilio;
        private System.Windows.Forms.RadioButton rdoPaLlevar;
        private System.Windows.Forms.RadioButton rdoPaMesa;
        private System.Windows.Forms.TextBox txtBuscarPedido;
        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.TextBox txtCancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView tblFacturas;
        private System.Windows.Forms.Button button1;
        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl QRcodeFacturas;
        private System.Windows.Forms.Button btnFacturar;

    }
}