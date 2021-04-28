namespace CapaPresentacion
{
    partial class frmInventario
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.tbcMaterial = new System.Windows.Forms.TabPage();
            this.btnCargarMarca = new System.Windows.Forms.Button();
            this.btnGrabarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.btnSalirMarca = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnNuevoMarca = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.txtCodigoMarca = new System.Windows.Forms.TextBox();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.tbcUnidMedida = new System.Windows.Forms.TabPage();
            this.txtidUM = new System.Windows.Forms.TextBox();
            this.txtDescripcionUM = new System.Windows.Forms.TextBox();
            this.txtAbrev = new System.Windows.Forms.TextBox();
            this.txtCodigoUM = new System.Windows.Forms.TextBox();
            this.btnCargarUM = new System.Windows.Forms.Button();
            this.dgvUnidadMedida = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnGuardarUM = new System.Windows.Forms.Button();
            this.btnEliminarUM = new System.Windows.Forms.Button();
            this.btnCancelarUM = new System.Windows.Forms.Button();
            this.btnSalirUM = new System.Windows.Forms.Button();
            this.btnNuevoUM = new System.Windows.Forms.Button();
            this.btnEditarUM = new System.Windows.Forms.Button();
            this.tbcProducto = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtIdP = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnCancelarP = new System.Windows.Forms.Button();
            this.btnSalirP = new System.Windows.Forms.Button();
            this.btnNuevoP = new System.Windows.Forms.Button();
            this.btnEditarP = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.cboUnidMed = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbcMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.tbcUnidMedida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidadMedida)).BeginInit();
            this.tbcProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tbcPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(885, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "INVENTARIO DE PRODUCTOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarP.Image = global::CapaPresentacion.Properties.Resources.search_add_24x24_32;
            this.btnBuscarP.Location = new System.Drawing.Point(649, 194);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(40, 30);
            this.btnBuscarP.TabIndex = 39;
            this.toolTip1.SetToolTip(this.btnBuscarP, "Bucar");
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // tbcMaterial
            // 
            this.tbcMaterial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbcMaterial.Controls.Add(this.btnCargarMarca);
            this.tbcMaterial.Controls.Add(this.btnGrabarMarca);
            this.tbcMaterial.Controls.Add(this.btnEliminarMarca);
            this.tbcMaterial.Controls.Add(this.btnCancelarMarca);
            this.tbcMaterial.Controls.Add(this.btnSalirMarca);
            this.tbcMaterial.Controls.Add(this.btnEditarMarca);
            this.tbcMaterial.Controls.Add(this.btnNuevoMarca);
            this.tbcMaterial.Controls.Add(this.label9);
            this.tbcMaterial.Controls.Add(this.label10);
            this.tbcMaterial.Controls.Add(this.txtIdMarca);
            this.tbcMaterial.Controls.Add(this.txtNombreMarca);
            this.tbcMaterial.Controls.Add(this.txtCodigoMarca);
            this.tbcMaterial.Controls.Add(this.dgvMarca);
            this.tbcMaterial.Location = new System.Drawing.Point(4, 28);
            this.tbcMaterial.Name = "tbcMaterial";
            this.tbcMaterial.Padding = new System.Windows.Forms.Padding(3);
            this.tbcMaterial.Size = new System.Drawing.Size(847, 458);
            this.tbcMaterial.TabIndex = 4;
            this.tbcMaterial.Text = "Marca";
            // 
            // btnCargarMarca
            // 
            this.btnCargarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarMarca.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCargarMarca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCargarMarca.Location = new System.Drawing.Point(739, 72);
            this.btnCargarMarca.Name = "btnCargarMarca";
            this.btnCargarMarca.Size = new System.Drawing.Size(90, 24);
            this.btnCargarMarca.TabIndex = 115;
            this.btnCargarMarca.Text = "Cargar...";
            this.btnCargarMarca.UseVisualStyleBackColor = false;
            // 
            // btnGrabarMarca
            // 
            this.btnGrabarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabarMarca.Image = global::CapaPresentacion.Properties.Resources.accept_24x24_32;
            this.btnGrabarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabarMarca.Location = new System.Drawing.Point(739, 230);
            this.btnGrabarMarca.Name = "btnGrabarMarca";
            this.btnGrabarMarca.Size = new System.Drawing.Size(90, 45);
            this.btnGrabarMarca.TabIndex = 114;
            this.btnGrabarMarca.Text = "Grabar";
            this.btnGrabarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabarMarca.UseVisualStyleBackColor = true;
            this.btnGrabarMarca.Click += new System.EventHandler(this.btnGrabarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarMarca.Image = global::CapaPresentacion.Properties.Resources.remove_24x24_32;
            this.btnEliminarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarMarca.Location = new System.Drawing.Point(739, 281);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(90, 45);
            this.btnEliminarMarca.TabIndex = 113;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarMarca.Image = global::CapaPresentacion.Properties.Resources.window_remove_24x24_32;
            this.btnCancelarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarMarca.Location = new System.Drawing.Point(739, 332);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(90, 45);
            this.btnCancelarMarca.TabIndex = 112;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // btnSalirMarca
            // 
            this.btnSalirMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirMarca.Image = global::CapaPresentacion.Properties.Resources.back_24x24_32;
            this.btnSalirMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirMarca.Location = new System.Drawing.Point(739, 383);
            this.btnSalirMarca.Name = "btnSalirMarca";
            this.btnSalirMarca.Size = new System.Drawing.Size(90, 45);
            this.btnSalirMarca.TabIndex = 111;
            this.btnSalirMarca.Text = "Salir";
            this.btnSalirMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirMarca.UseVisualStyleBackColor = true;
            this.btnSalirMarca.Click += new System.EventHandler(this.btnSalirMarca_Click);
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarMarca.Image = global::CapaPresentacion.Properties.Resources.app_edit_32x32_32;
            this.btnEditarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarMarca.Location = new System.Drawing.Point(739, 180);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(90, 45);
            this.btnEditarMarca.TabIndex = 109;
            this.btnEditarMarca.Text = "Editar";
            this.btnEditarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            this.btnEditarMarca.Click += new System.EventHandler(this.btnEditarMarca_Click);
            // 
            // btnNuevoMarca
            // 
            this.btnNuevoMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoMarca.Image = global::CapaPresentacion.Properties.Resources._new;
            this.btnNuevoMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoMarca.Location = new System.Drawing.Point(739, 130);
            this.btnNuevoMarca.Name = "btnNuevoMarca";
            this.btnNuevoMarca.Size = new System.Drawing.Size(90, 45);
            this.btnNuevoMarca.TabIndex = 110;
            this.btnNuevoMarca.Text = "Nuevo";
            this.btnNuevoMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoMarca.UseVisualStyleBackColor = true;
            this.btnNuevoMarca.Click += new System.EventHandler(this.btnNuevoMarca_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 108;
            this.label9.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 107;
            this.label10.Text = "Codigo:";
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdMarca.Location = new System.Drawing.Point(243, 21);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(363, 21);
            this.txtIdMarca.TabIndex = 106;
            this.txtIdMarca.Visible = false;
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreMarca.Enabled = false;
            this.txtNombreMarca.Location = new System.Drawing.Point(137, 50);
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(469, 21);
            this.txtNombreMarca.TabIndex = 92;
            // 
            // txtCodigoMarca
            // 
            this.txtCodigoMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoMarca.Location = new System.Drawing.Point(137, 21);
            this.txtCodigoMarca.Name = "txtCodigoMarca";
            this.txtCodigoMarca.ReadOnly = true;
            this.txtCodigoMarca.Size = new System.Drawing.Size(264, 21);
            this.txtCodigoMarca.TabIndex = 95;
            // 
            // dgvMarca
            // 
            this.dgvMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(32, 130);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.Size = new System.Drawing.Size(661, 298);
            this.dgvMarca.TabIndex = 98;
            this.dgvMarca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarca_CellClick);
            // 
            // tbcUnidMedida
            // 
            this.tbcUnidMedida.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbcUnidMedida.Controls.Add(this.txtidUM);
            this.tbcUnidMedida.Controls.Add(this.txtDescripcionUM);
            this.tbcUnidMedida.Controls.Add(this.txtAbrev);
            this.tbcUnidMedida.Controls.Add(this.txtCodigoUM);
            this.tbcUnidMedida.Controls.Add(this.btnCargarUM);
            this.tbcUnidMedida.Controls.Add(this.dgvUnidadMedida);
            this.tbcUnidMedida.Controls.Add(this.label20);
            this.tbcUnidMedida.Controls.Add(this.label21);
            this.tbcUnidMedida.Controls.Add(this.label22);
            this.tbcUnidMedida.Controls.Add(this.btnGuardarUM);
            this.tbcUnidMedida.Controls.Add(this.btnEliminarUM);
            this.tbcUnidMedida.Controls.Add(this.btnCancelarUM);
            this.tbcUnidMedida.Controls.Add(this.btnSalirUM);
            this.tbcUnidMedida.Controls.Add(this.btnNuevoUM);
            this.tbcUnidMedida.Controls.Add(this.btnEditarUM);
            this.tbcUnidMedida.Location = new System.Drawing.Point(4, 28);
            this.tbcUnidMedida.Name = "tbcUnidMedida";
            this.tbcUnidMedida.Padding = new System.Windows.Forms.Padding(3);
            this.tbcUnidMedida.Size = new System.Drawing.Size(847, 458);
            this.tbcUnidMedida.TabIndex = 2;
            this.tbcUnidMedida.Text = "Unidades de Medida";
            // 
            // txtidUM
            // 
            this.txtidUM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtidUM.Location = new System.Drawing.Point(256, 24);
            this.txtidUM.Name = "txtidUM";
            this.txtidUM.Size = new System.Drawing.Size(444, 21);
            this.txtidUM.TabIndex = 92;
            this.txtidUM.Visible = false;
            // 
            // txtDescripcionUM
            // 
            this.txtDescripcionUM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionUM.Location = new System.Drawing.Point(150, 53);
            this.txtDescripcionUM.Name = "txtDescripcionUM";
            this.txtDescripcionUM.Size = new System.Drawing.Size(550, 21);
            this.txtDescripcionUM.TabIndex = 1;
            // 
            // txtAbrev
            // 
            this.txtAbrev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAbrev.Location = new System.Drawing.Point(150, 82);
            this.txtAbrev.Name = "txtAbrev";
            this.txtAbrev.Size = new System.Drawing.Size(264, 21);
            this.txtAbrev.TabIndex = 2;
            // 
            // txtCodigoUM
            // 
            this.txtCodigoUM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoUM.Location = new System.Drawing.Point(150, 24);
            this.txtCodigoUM.Name = "txtCodigoUM";
            this.txtCodigoUM.ReadOnly = true;
            this.txtCodigoUM.Size = new System.Drawing.Size(264, 21);
            this.txtCodigoUM.TabIndex = 63;
            // 
            // btnCargarUM
            // 
            this.btnCargarUM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarUM.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCargarUM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCargarUM.Location = new System.Drawing.Point(732, 57);
            this.btnCargarUM.Name = "btnCargarUM";
            this.btnCargarUM.Size = new System.Drawing.Size(90, 24);
            this.btnCargarUM.TabIndex = 91;
            this.btnCargarUM.Text = "Cargar...";
            this.btnCargarUM.UseVisualStyleBackColor = false;
            this.btnCargarUM.Click += new System.EventHandler(this.btnCargarUM_Click);
            // 
            // dgvUnidadMedida
            // 
            this.dgvUnidadMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnidadMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidadMedida.Location = new System.Drawing.Point(39, 123);
            this.dgvUnidadMedida.Name = "dgvUnidadMedida";
            this.dgvUnidadMedida.Size = new System.Drawing.Size(661, 281);
            this.dgvUnidadMedida.TabIndex = 68;
            this.dgvUnidadMedida.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnidadMedida_CellClick);
             
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(36, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 15);
            this.label20.TabIndex = 65;
            this.label20.Text = "Abreviatura:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(36, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 15);
            this.label21.TabIndex = 64;
            this.label21.Text = "Descripción:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(36, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 15);
            this.label22.TabIndex = 62;
            this.label22.Text = "Codigo:";
            // 
            // btnGuardarUM
            // 
            this.btnGuardarUM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarUM.Image = global::CapaPresentacion.Properties.Resources.accept_24x24_32;
            this.btnGuardarUM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarUM.Location = new System.Drawing.Point(732, 206);
            this.btnGuardarUM.Name = "btnGuardarUM";
            this.btnGuardarUM.Size = new System.Drawing.Size(90, 45);
            this.btnGuardarUM.TabIndex = 74;
            this.btnGuardarUM.Text = "Grabar";
            this.btnGuardarUM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarUM.UseVisualStyleBackColor = true;
            this.btnGuardarUM.Click += new System.EventHandler(this.btnGuardarUM_Click);
            // 
            // btnEliminarUM
            // 
            this.btnEliminarUM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarUM.Image = global::CapaPresentacion.Properties.Resources.remove_24x24_32;
            this.btnEliminarUM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarUM.Location = new System.Drawing.Point(732, 257);
            this.btnEliminarUM.Name = "btnEliminarUM";
            this.btnEliminarUM.Size = new System.Drawing.Size(90, 45);
            this.btnEliminarUM.TabIndex = 73;
            this.btnEliminarUM.Text = "Eliminar";
            this.btnEliminarUM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarUM.UseVisualStyleBackColor = true;
            this.btnEliminarUM.Click += new System.EventHandler(this.btnEliminarUM_Click);
            // 
            // btnCancelarUM
            // 
            this.btnCancelarUM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarUM.Image = global::CapaPresentacion.Properties.Resources.window_remove_24x24_32;
            this.btnCancelarUM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarUM.Location = new System.Drawing.Point(732, 308);
            this.btnCancelarUM.Name = "btnCancelarUM";
            this.btnCancelarUM.Size = new System.Drawing.Size(90, 45);
            this.btnCancelarUM.TabIndex = 72;
            this.btnCancelarUM.Text = "Cancelar";
            this.btnCancelarUM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarUM.UseVisualStyleBackColor = true;
            this.btnCancelarUM.Click += new System.EventHandler(this.btnCancelarUM_Click);
            // 
            // btnSalirUM
            // 
            this.btnSalirUM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirUM.Image = global::CapaPresentacion.Properties.Resources.back_24x24_32;
            this.btnSalirUM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirUM.Location = new System.Drawing.Point(732, 359);
            this.btnSalirUM.Name = "btnSalirUM";
            this.btnSalirUM.Size = new System.Drawing.Size(90, 45);
            this.btnSalirUM.TabIndex = 71;
            this.btnSalirUM.Text = "Salir";
            this.btnSalirUM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirUM.UseVisualStyleBackColor = true;
            this.btnSalirUM.Click += new System.EventHandler(this.btnSalirUM_Click);
            // 
            // btnNuevoUM
            // 
            this.btnNuevoUM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoUM.Image = global::CapaPresentacion.Properties.Resources._new;
            this.btnNuevoUM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoUM.Location = new System.Drawing.Point(732, 106);
            this.btnNuevoUM.Name = "btnNuevoUM";
            this.btnNuevoUM.Size = new System.Drawing.Size(90, 45);
            this.btnNuevoUM.TabIndex = 70;
            this.btnNuevoUM.Text = "Nuevo";
            this.btnNuevoUM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoUM.UseVisualStyleBackColor = true;
            this.btnNuevoUM.Click += new System.EventHandler(this.btnNuevoUM_Click);
            // 
            // btnEditarUM
            // 
            this.btnEditarUM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarUM.Image = global::CapaPresentacion.Properties.Resources.app_edit_32x32_32;
            this.btnEditarUM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarUM.Location = new System.Drawing.Point(732, 156);
            this.btnEditarUM.Name = "btnEditarUM";
            this.btnEditarUM.Size = new System.Drawing.Size(90, 45);
            this.btnEditarUM.TabIndex = 69;
            this.btnEditarUM.Text = "Editar";
            this.btnEditarUM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarUM.UseVisualStyleBackColor = true;
            this.btnEditarUM.Click += new System.EventHandler(this.btnEditarUM_Click);
            // 
            // tbcProducto
            // 
            this.tbcProducto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbcProducto.Controls.Add(this.textBox1);
            this.tbcProducto.Controls.Add(this.txtIdP);
            this.tbcProducto.Controls.Add(this.txtPrecioVenta);
            this.tbcProducto.Controls.Add(this.txtStock);
            this.tbcProducto.Controls.Add(this.txtNombre);
            this.tbcProducto.Controls.Add(this.txtPrecioCompra);
            this.tbcProducto.Controls.Add(this.txtCodigoP);
            this.tbcProducto.Controls.Add(this.label4);
            this.tbcProducto.Controls.Add(this.cboMarca);
            this.tbcProducto.Controls.Add(this.btnBuscarP);
            this.tbcProducto.Controls.Add(this.btnGuardarP);
            this.tbcProducto.Controls.Add(this.btnEliminarP);
            this.tbcProducto.Controls.Add(this.btnCancelarP);
            this.tbcProducto.Controls.Add(this.btnSalirP);
            this.tbcProducto.Controls.Add(this.btnNuevoP);
            this.tbcProducto.Controls.Add(this.btnEditarP);
            this.tbcProducto.Controls.Add(this.dgvProductos);
            this.tbcProducto.Controls.Add(this.label16);
            this.tbcProducto.Controls.Add(this.cboUnidMed);
            this.tbcProducto.Controls.Add(this.label14);
            this.tbcProducto.Controls.Add(this.label7);
            this.tbcProducto.Controls.Add(this.label6);
            this.tbcProducto.Controls.Add(this.label5);
            this.tbcProducto.Controls.Add(this.label2);
            this.tbcProducto.Controls.Add(this.label3);
            this.tbcProducto.Location = new System.Drawing.Point(4, 28);
            this.tbcProducto.Name = "tbcProducto";
            this.tbcProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tbcProducto.Size = new System.Drawing.Size(847, 458);
            this.tbcProducto.TabIndex = 0;
            this.tbcProducto.Text = "Productos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 47);
            this.textBox1.TabIndex = 43;
            // 
            // txtIdP
            // 
            this.txtIdP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdP.Location = new System.Drawing.Point(218, 10);
            this.txtIdP.Name = "txtIdP";
            this.txtIdP.Size = new System.Drawing.Size(253, 21);
            this.txtIdP.TabIndex = 40;
            this.txtIdP.Visible = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioVenta.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtPrecioVenta.Location = new System.Drawing.Point(149, 196);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(50, 21);
            this.txtPrecioVenta.TabIndex = 4;
            this.txtPrecioVenta.Text = "0,00";
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(402, 157);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(69, 21);
            this.txtStock.TabIndex = 5;
            this.txtStock.Text = "0";
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(149, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(322, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtPrecioCompra.Location = new System.Drawing.Point(149, 157);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(50, 21);
            this.txtPrecioCompra.TabIndex = 3;
            this.txtPrecioCompra.Text = "0,00";
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoP.Location = new System.Drawing.Point(149, 10);
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.ReadOnly = true;
            this.txtCodigoP.Size = new System.Drawing.Size(72, 21);
            this.txtCodigoP.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Descripción:";
            // 
            // cboMarca
            // 
            this.cboMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(149, 120);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(322, 23);
            this.cboMarca.TabIndex = 41;
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarP.Image = global::CapaPresentacion.Properties.Resources.accept_24x24_32;
            this.btnGuardarP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarP.Location = new System.Drawing.Point(721, 169);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(90, 45);
            this.btnGuardarP.TabIndex = 38;
            this.btnGuardarP.Text = "Grabar";
            this.btnGuardarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarP.UseVisualStyleBackColor = true;
            this.btnGuardarP.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarP.Image = global::CapaPresentacion.Properties.Resources.remove_24x24_32;
            this.btnEliminarP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarP.Location = new System.Drawing.Point(721, 220);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(90, 45);
            this.btnEliminarP.TabIndex = 37;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarP.UseVisualStyleBackColor = true;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelarP
            // 
            this.btnCancelarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarP.Image = global::CapaPresentacion.Properties.Resources.window_remove_24x24_32;
            this.btnCancelarP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarP.Location = new System.Drawing.Point(721, 271);
            this.btnCancelarP.Name = "btnCancelarP";
            this.btnCancelarP.Size = new System.Drawing.Size(90, 45);
            this.btnCancelarP.TabIndex = 36;
            this.btnCancelarP.Text = "Cancelar";
            this.btnCancelarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarP.UseVisualStyleBackColor = true;
            this.btnCancelarP.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalirP
            // 
            this.btnSalirP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirP.Image = global::CapaPresentacion.Properties.Resources.back_24x24_32;
            this.btnSalirP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirP.Location = new System.Drawing.Point(721, 322);
            this.btnSalirP.Name = "btnSalirP";
            this.btnSalirP.Size = new System.Drawing.Size(90, 45);
            this.btnSalirP.TabIndex = 35;
            this.btnSalirP.Text = "Salir";
            this.btnSalirP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirP.UseVisualStyleBackColor = true;
            this.btnSalirP.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevoP
            // 
            this.btnNuevoP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoP.Image = global::CapaPresentacion.Properties.Resources._new;
            this.btnNuevoP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoP.Location = new System.Drawing.Point(721, 69);
            this.btnNuevoP.Name = "btnNuevoP";
            this.btnNuevoP.Size = new System.Drawing.Size(90, 45);
            this.btnNuevoP.TabIndex = 34;
            this.btnNuevoP.Text = "Nuevo";
            this.btnNuevoP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoP.UseVisualStyleBackColor = true;
            this.btnNuevoP.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditarP
            // 
            this.btnEditarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarP.Image = global::CapaPresentacion.Properties.Resources.app_edit_32x32_32;
            this.btnEditarP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarP.Location = new System.Drawing.Point(721, 119);
            this.btnEditarP.Name = "btnEditarP";
            this.btnEditarP.Size = new System.Drawing.Size(90, 45);
            this.btnEditarP.TabIndex = 33;
            this.btnEditarP.Text = "Editar";
            this.btnEditarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarP.UseVisualStyleBackColor = true;
            this.btnEditarP.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(38, 236);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(651, 207);
            this.dgvProductos.TabIndex = 32;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(48, 199);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 30;
            this.label16.Text = "Precio Venta:";
            // 
            // cboUnidMed
            // 
            this.cboUnidMed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUnidMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidMed.FormattingEnabled = true;
            this.cboUnidMed.Location = new System.Drawing.Point(402, 194);
            this.cboUnidMed.Name = "cboUnidMed";
            this.cboUnidMed.Size = new System.Drawing.Size(69, 23);
            this.cboUnidMed.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(321, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 15);
            this.label14.TabIndex = 26;
            this.label14.Text = "Unid. Med:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio Compra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Existencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Codigo:";
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcPrincipal.Controls.Add(this.tbcProducto);
            this.tbcPrincipal.Controls.Add(this.tbcUnidMedida);
            this.tbcPrincipal.Controls.Add(this.tbcMaterial);
            this.tbcPrincipal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcPrincipal.Location = new System.Drawing.Point(14, 50);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.Padding = new System.Drawing.Point(12, 5);
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(855, 490);
            this.tbcPrincipal.TabIndex = 2;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.tbcPrincipal);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.tbcMaterial.ResumeLayout(false);
            this.tbcMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.tbcUnidMedida.ResumeLayout(false);
            this.tbcUnidMedida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidadMedida)).EndInit();
            this.tbcProducto.ResumeLayout(false);
            this.tbcProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tbcPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tbcMaterial;
        private System.Windows.Forms.Button btnCargarMarca;
        private System.Windows.Forms.Button btnGrabarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Button btnSalirMarca;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnNuevoMarca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.TextBox txtCodigoMarca;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.TabPage tbcUnidMedida;
        private System.Windows.Forms.TextBox txtidUM;
        private System.Windows.Forms.TextBox txtDescripcionUM;
        private System.Windows.Forms.TextBox txtAbrev;
        private System.Windows.Forms.TextBox txtCodigoUM;
        private System.Windows.Forms.Button btnCargarUM;
        private System.Windows.Forms.DataGridView dgvUnidadMedida;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnGuardarUM;
        private System.Windows.Forms.Button btnEliminarUM;
        private System.Windows.Forms.Button btnCancelarUM;
        private System.Windows.Forms.Button btnSalirUM;
        private System.Windows.Forms.Button btnNuevoUM;
        private System.Windows.Forms.Button btnEditarUM;
        private System.Windows.Forms.TabPage tbcProducto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtIdP;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtCodigoP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.Button btnGuardarP;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Button btnCancelarP;
        private System.Windows.Forms.Button btnSalirP;
        private System.Windows.Forms.Button btnNuevoP;
        private System.Windows.Forms.Button btnEditarP;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboUnidMed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tbcPrincipal;
    }
}