namespace CapaPresentacion
{
    partial class frmConsultaVenta
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
            this.dgvHistorialVentas = new System.Windows.Forms.DataGridView();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label50 = new System.Windows.Forms.Label();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTotalUtilidades = new System.Windows.Forms.Label();
            this.lblImporteInversion = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbldeposito = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblContrarembolso = new System.Windows.Forms.Label();
            this.lblTarjetacredito = new System.Windows.Forms.Label();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbldolares = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblsoles = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbldescuento = new System.Windows.Forms.Label();
            this.lblNotaventa = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblBoleta = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHistorialVentas
            // 
            this.dgvHistorialVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvHistorialVentas.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvHistorialVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialVentas.GridColor = System.Drawing.Color.Teal;
            this.dgvHistorialVentas.Location = new System.Drawing.Point(9, 188);
            this.dgvHistorialVentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvHistorialVentas.Name = "dgvHistorialVentas";
            this.dgvHistorialVentas.Size = new System.Drawing.Size(715, 370);
            this.dgvHistorialVentas.TabIndex = 0;
            this.dgvHistorialVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialVentas_CellClick);
            // 
            // dtpDesde
            // 
            this.dtpDesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDesde.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(26, 37);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(105, 22);
            this.dtpDesde.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label50);
            this.groupBox1.Controls.Add(this.cboSucursal);
            this.groupBox1.Controls.Add(this.btnMostrar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Location = new System.Drawing.Point(9, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(365, 116);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(23, 68);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(56, 15);
            this.label50.TabIndex = 43;
            this.label50.Text = "Sucursal";
            // 
            // cboSucursal
            // 
            this.cboSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(26, 86);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(328, 23);
            this.cboSucursal.TabIndex = 42;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(278, 33);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(76, 26);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha inicio";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(163, 37);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(105, 22);
            this.dtpHasta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1125, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "HISTORIAL DE VENTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.lbldolares);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblsoles);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(734, 64);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(381, 493);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reporte";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTotalUtilidades);
            this.groupBox6.Controls.Add(this.lblImporteInversion);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Location = new System.Drawing.Point(17, 359);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(344, 126);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Utilidades s/";
            // 
            // lblTotalUtilidades
            // 
            this.lblTotalUtilidades.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalUtilidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalUtilidades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotalUtilidades.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUtilidades.Location = new System.Drawing.Point(141, 72);
            this.lblTotalUtilidades.Name = "lblTotalUtilidades";
            this.lblTotalUtilidades.Size = new System.Drawing.Size(136, 25);
            this.lblTotalUtilidades.TabIndex = 12;
            this.lblTotalUtilidades.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblImporteInversion
            // 
            this.lblImporteInversion.BackColor = System.Drawing.SystemColors.Control;
            this.lblImporteInversion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblImporteInversion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblImporteInversion.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteInversion.Location = new System.Drawing.Point(141, 35);
            this.lblImporteInversion.Name = "lblImporteInversion";
            this.lblImporteInversion.Size = new System.Drawing.Size(136, 25);
            this.lblImporteInversion.TabIndex = 11;
            this.lblImporteInversion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 182);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 15);
            this.label18.TabIndex = 9;
            this.label18.Text = "Total";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(19, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 15);
            this.label19.TabIndex = 9;
            this.label19.Text = "Utilidades:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 225);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 15);
            this.label20.TabIndex = 8;
            this.label20.Text = "Total";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(19, 45);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(105, 15);
            this.label28.TabIndex = 7;
            this.label28.Text = "Importe inversion:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbldeposito);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.lblContrarembolso);
            this.groupBox4.Controls.Add(this.lblTarjetacredito);
            this.groupBox4.Controls.Add(this.lblEfectivo);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Location = new System.Drawing.Point(17, 184);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(344, 126);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo pago";
            // 
            // lbldeposito
            // 
            this.lbldeposito.BackColor = System.Drawing.SystemColors.Control;
            this.lbldeposito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldeposito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbldeposito.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeposito.Location = new System.Drawing.Point(141, 90);
            this.lbldeposito.Name = "lbldeposito";
            this.lbldeposito.Size = new System.Drawing.Size(136, 25);
            this.lbldeposito.TabIndex = 15;
            this.lbldeposito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(19, 100);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(109, 15);
            this.label27.TabIndex = 14;
            this.label27.Text = "Ingreso en cuenta:";
            // 
            // lblContrarembolso
            // 
            this.lblContrarembolso.BackColor = System.Drawing.SystemColors.Control;
            this.lblContrarembolso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContrarembolso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblContrarembolso.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrarembolso.Location = new System.Drawing.Point(141, 64);
            this.lblContrarembolso.Name = "lblContrarembolso";
            this.lblContrarembolso.Size = new System.Drawing.Size(136, 25);
            this.lblContrarembolso.TabIndex = 13;
            this.lblContrarembolso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTarjetacredito
            // 
            this.lblTarjetacredito.BackColor = System.Drawing.SystemColors.Control;
            this.lblTarjetacredito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTarjetacredito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTarjetacredito.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjetacredito.Location = new System.Drawing.Point(141, 38);
            this.lblTarjetacredito.Name = "lblTarjetacredito";
            this.lblTarjetacredito.Size = new System.Drawing.Size(136, 25);
            this.lblTarjetacredito.TabIndex = 12;
            this.lblTarjetacredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.BackColor = System.Drawing.SystemColors.Control;
            this.lblEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEfectivo.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivo.Location = new System.Drawing.Point(141, 12);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(136, 25);
            this.lblEfectivo.TabIndex = 11;
            this.lblEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 182);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 15);
            this.label21.TabIndex = 9;
            this.label21.Text = "Total";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(19, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 15);
            this.label22.TabIndex = 9;
            this.label22.Text = "Tarjeta credito:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 225);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 15);
            this.label23.TabIndex = 8;
            this.label23.Text = "Total";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(19, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(110, 15);
            this.label24.TabIndex = 8;
            this.label24.Text = "Contra reembolso:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(19, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 15);
            this.label25.TabIndex = 7;
            this.label25.Text = "Efectivo:";
            // 
            // lbldolares
            // 
            this.lbldolares.BackColor = System.Drawing.Color.AliceBlue;
            this.lbldolares.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldolares.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbldolares.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldolares.Location = new System.Drawing.Point(296, 313);
            this.lbldolares.Name = "lbldolares";
            this.lbldolares.Size = new System.Drawing.Size(65, 25);
            this.lbldolares.TabIndex = 17;
            this.lbldolares.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(240, 320);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 15);
            this.label17.TabIndex = 16;
            this.label17.Text = "Dolares:";
            // 
            // lblsoles
            // 
            this.lblsoles.BackColor = System.Drawing.Color.PowderBlue;
            this.lblsoles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblsoles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblsoles.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoles.Location = new System.Drawing.Point(47, 313);
            this.lblsoles.Name = "lblsoles";
            this.lblsoles.Size = new System.Drawing.Size(146, 25);
            this.lblsoles.TabIndex = 15;
            this.lblsoles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 320);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "Soles:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lbldescuento);
            this.groupBox3.Controls.Add(this.lblNotaventa);
            this.groupBox3.Controls.Add(this.lblFactura);
            this.groupBox3.Controls.Add(this.lblBoleta);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(17, 70);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(344, 106);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comprobantes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(303, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Desc";
            // 
            // lbldescuento
            // 
            this.lbldescuento.BackColor = System.Drawing.SystemColors.Control;
            this.lbldescuento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldescuento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbldescuento.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescuento.Location = new System.Drawing.Point(283, 67);
            this.lbldescuento.Name = "lbldescuento";
            this.lbldescuento.Size = new System.Drawing.Size(56, 25);
            this.lbldescuento.TabIndex = 14;
            this.lbldescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNotaventa
            // 
            this.lblNotaventa.BackColor = System.Drawing.SystemColors.Control;
            this.lblNotaventa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNotaventa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNotaventa.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaventa.Location = new System.Drawing.Point(140, 68);
            this.lblNotaventa.Name = "lblNotaventa";
            this.lblNotaventa.Size = new System.Drawing.Size(137, 25);
            this.lblNotaventa.TabIndex = 13;
            this.lblNotaventa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFactura
            // 
            this.lblFactura.BackColor = System.Drawing.SystemColors.Control;
            this.lblFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFactura.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(140, 42);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(137, 25);
            this.lblFactura.TabIndex = 12;
            this.lblFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBoleta
            // 
            this.lblBoleta.BackColor = System.Drawing.SystemColors.Control;
            this.lblBoleta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBoleta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblBoleta.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoleta.Location = new System.Drawing.Point(140, 16);
            this.lblBoleta.Name = "lblBoleta";
            this.lblBoleta.Size = new System.Drawing.Size(137, 25);
            this.lblBoleta.TabIndex = 11;
            this.lblBoleta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Factura:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nota de venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Boleta:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Chartreuse;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotal.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(159, 30);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 24);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAnular);
            this.groupBox5.Controls.Add(this.btnDetalle);
            this.groupBox5.Location = new System.Drawing.Point(381, 64);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(201, 116);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controles";
            // 
            // btnAnular
            // 
            this.btnAnular.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Image = global::CapaPresentacion.Properties.Resources.anular_ico;
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnular.Location = new System.Drawing.Point(103, 33);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(90, 60);
            this.btnAnular.TabIndex = 8;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.Image = global::CapaPresentacion.Properties.Resources.Shopping_cart_32x32_32;
            this.btnDetalle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDetalle.Location = new System.Drawing.Point(7, 34);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(90, 60);
            this.btnDetalle.TabIndex = 7;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // frmConsultaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1124, 562);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHistorialVentas);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1140, 600);
            this.Name = "frmConsultaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de venta";
            this.Load += new System.EventHandler(this.frmConsultaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorialVentas;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblBoleta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbldeposito;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblContrarembolso;
        private System.Windows.Forms.Label lblTarjetacredito;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbldolares;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblsoles;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblNotaventa;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbldescuento;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTotalUtilidades;
        private System.Windows.Forms.Label lblImporteInversion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label28;
    }
}