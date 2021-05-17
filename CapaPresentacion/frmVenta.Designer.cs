
namespace CapaPresentacion
{
    partial class frmVenta
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvVentasACT = new System.Windows.Forms.DataGridView();
            this.btnImprimirACT = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelarACT = new System.Windows.Forms.Button();
            this.btnEliminarACT = new System.Windows.Forms.Button();
            this.txtIdACT = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvVentasELI = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblFolioELI = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCancelarELI = new System.Windows.Forms.Button();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.txtIdELI = new System.Windows.Forms.TextBox();
            this.Registrar = new System.Windows.Forms.TabPage();
            this.dgvELI = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIdVenta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblTotalINS = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.cbxCantidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasACT)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasELI)).BeginInit();
            this.Registrar.SuspendLayout();
            this.dgvELI.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(910, 424);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Modificar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::CapaPresentacion.Properties.Resources.OIP_verdeBandera;
            this.panel5.Controls.Add(this.dgvVentasACT);
            this.panel5.Controls.Add(this.btnImprimirACT);
            this.panel5.Controls.Add(this.btnActualizar);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.btnCancelarACT);
            this.panel5.Controls.Add(this.btnEliminarACT);
            this.panel5.Controls.Add(this.txtIdACT);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(910, 424);
            this.panel5.TabIndex = 0;
            // 
            // dgvVentasACT
            // 
            this.dgvVentasACT.AllowUserToAddRows = false;
            this.dgvVentasACT.AllowUserToDeleteRows = false;
            this.dgvVentasACT.AllowUserToOrderColumns = true;
            this.dgvVentasACT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVentasACT.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dgvVentasACT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasACT.Location = new System.Drawing.Point(31, 55);
            this.dgvVentasACT.Name = "dgvVentasACT";
            this.dgvVentasACT.ReadOnly = true;
            this.dgvVentasACT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentasACT.Size = new System.Drawing.Size(853, 272);
            this.dgvVentasACT.TabIndex = 36;
            // 
            // btnImprimirACT
            // 
            this.btnImprimirACT.BackColor = System.Drawing.Color.Navy;
            this.btnImprimirACT.FlatAppearance.BorderSize = 0;
            this.btnImprimirACT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirACT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimirACT.Location = new System.Drawing.Point(500, 374);
            this.btnImprimirACT.Name = "btnImprimirACT";
            this.btnImprimirACT.Size = new System.Drawing.Size(124, 38);
            this.btnImprimirACT.TabIndex = 35;
            this.btnImprimirACT.Text = "Imprimir";
            this.btnImprimirACT.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Navy;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizar.Location = new System.Drawing.Point(370, 374);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(124, 38);
            this.btnActualizar.TabIndex = 33;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(828, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 19);
            this.label12.TabIndex = 32;
            this.label12.Text = "000000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(774, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(817, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "0000---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(758, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Folio:";
            // 
            // btnCancelarACT
            // 
            this.btnCancelarACT.BackColor = System.Drawing.Color.Navy;
            this.btnCancelarACT.FlatAppearance.BorderSize = 0;
            this.btnCancelarACT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarACT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarACT.Location = new System.Drawing.Point(760, 374);
            this.btnCancelarACT.Name = "btnCancelarACT";
            this.btnCancelarACT.Size = new System.Drawing.Size(124, 38);
            this.btnCancelarACT.TabIndex = 25;
            this.btnCancelarACT.Text = "Cancelar";
            this.btnCancelarACT.UseVisualStyleBackColor = false;
            this.btnCancelarACT.Click += new System.EventHandler(this.btnCancelarACT_Click);
            // 
            // btnEliminarACT
            // 
            this.btnEliminarACT.BackColor = System.Drawing.Color.Navy;
            this.btnEliminarACT.FlatAppearance.BorderSize = 0;
            this.btnEliminarACT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarACT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarACT.Location = new System.Drawing.Point(630, 374);
            this.btnEliminarACT.Name = "btnEliminarACT";
            this.btnEliminarACT.Size = new System.Drawing.Size(124, 38);
            this.btnEliminarACT.TabIndex = 23;
            this.btnEliminarACT.Text = "Eliminar";
            this.btnEliminarACT.UseVisualStyleBackColor = false;
            // 
            // txtIdACT
            // 
            this.txtIdACT.Location = new System.Drawing.Point(31, 16);
            this.txtIdACT.Name = "txtIdACT";
            this.txtIdACT.Size = new System.Drawing.Size(677, 27);
            this.txtIdACT.TabIndex = 19;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::CapaPresentacion.Properties.Resources.OIP_verdeBandera;
            this.tabPage3.Controls.Add(this.dgvVentasELI);
            this.tabPage3.Controls.Add(this.lblTotal);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.lblFolioELI);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.btnCancelarELI);
            this.tabPage3.Controls.Add(this.btnEliminarVenta);
            this.tabPage3.Controls.Add(this.txtIdELI);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(910, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvVentasELI
            // 
            this.dgvVentasELI.AllowUserToAddRows = false;
            this.dgvVentasELI.AllowUserToDeleteRows = false;
            this.dgvVentasELI.AllowUserToOrderColumns = true;
            this.dgvVentasELI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVentasELI.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dgvVentasELI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasELI.Location = new System.Drawing.Point(29, 58);
            this.dgvVentasELI.Name = "dgvVentasELI";
            this.dgvVentasELI.ReadOnly = true;
            this.dgvVentasELI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentasELI.Size = new System.Drawing.Size(853, 272);
            this.dgvVentasELI.TabIndex = 44;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(826, 346);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 19);
            this.lblTotal.TabIndex = 43;
            this.lblTotal.Text = "000000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(772, 346);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 19);
            this.label15.TabIndex = 42;
            this.label15.Text = "Total:";
            // 
            // lblFolioELI
            // 
            this.lblFolioELI.AutoSize = true;
            this.lblFolioELI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolioELI.ForeColor = System.Drawing.Color.Black;
            this.lblFolioELI.Location = new System.Drawing.Point(815, 19);
            this.lblFolioELI.Name = "lblFolioELI";
            this.lblFolioELI.Size = new System.Drawing.Size(66, 19);
            this.lblFolioELI.TabIndex = 39;
            this.lblFolioELI.Text = "0000---";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(756, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 19);
            this.label17.TabIndex = 40;
            this.label17.Text = "Folio:";
            // 
            // btnCancelarELI
            // 
            this.btnCancelarELI.BackColor = System.Drawing.Color.Navy;
            this.btnCancelarELI.FlatAppearance.BorderSize = 0;
            this.btnCancelarELI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarELI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarELI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarELI.Location = new System.Drawing.Point(758, 374);
            this.btnCancelarELI.Name = "btnCancelarELI";
            this.btnCancelarELI.Size = new System.Drawing.Size(124, 38);
            this.btnCancelarELI.TabIndex = 38;
            this.btnCancelarELI.Text = "Cancelar";
            this.btnCancelarELI.UseVisualStyleBackColor = false;
            this.btnCancelarELI.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.BackColor = System.Drawing.Color.Navy;
            this.btnEliminarVenta.FlatAppearance.BorderSize = 0;
            this.btnEliminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarVenta.Location = new System.Drawing.Point(628, 374);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(124, 38);
            this.btnEliminarVenta.TabIndex = 37;
            this.btnEliminarVenta.Text = "Eliminar";
            this.btnEliminarVenta.UseVisualStyleBackColor = false;
            this.btnEliminarVenta.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtIdELI
            // 
            this.txtIdELI.Location = new System.Drawing.Point(29, 19);
            this.txtIdELI.Name = "txtIdELI";
            this.txtIdELI.Size = new System.Drawing.Size(677, 27);
            this.txtIdELI.TabIndex = 36;
            this.txtIdELI.TextChanged += new System.EventHandler(this.txtIdELI_TextChanged);
            // 
            // Registrar
            // 
            this.Registrar.Controls.Add(this.panel2);
            this.Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.Location = new System.Drawing.Point(4, 28);
            this.Registrar.Name = "Registrar";
            this.Registrar.Padding = new System.Windows.Forms.Padding(3);
            this.Registrar.Size = new System.Drawing.Size(910, 424);
            this.Registrar.TabIndex = 0;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            // 
            // dgvELI
            // 
            this.dgvELI.Controls.Add(this.Registrar);
            this.dgvELI.Controls.Add(this.tabPage1);
            this.dgvELI.Controls.Add(this.tabPage3);
            this.dgvELI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvELI.Location = new System.Drawing.Point(0, 68);
            this.dgvELI.Name = "dgvELI";
            this.dgvELI.SelectedIndex = 0;
            this.dgvELI.Size = new System.Drawing.Size(918, 456);
            this.dgvELI.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblIdVenta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 62);
            this.panel1.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(764, 25);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 19);
            this.lblUsuario.TabIndex = 24;
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(622, 25);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(103, 19);
            this.lblFecha.TabIndex = 23;
            this.lblFecha.Text = "DD/MM/YYY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(552, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Fecha:";
            // 
            // lblIdVenta
            // 
            this.lblIdVenta.AutoSize = true;
            this.lblIdVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVenta.ForeColor = System.Drawing.Color.White;
            this.lblIdVenta.Location = new System.Drawing.Point(139, 26);
            this.lblIdVenta.Name = "lblIdVenta";
            this.lblIdVenta.Size = new System.Drawing.Size(66, 19);
            this.lblIdVenta.TabIndex = 20;
            this.lblIdVenta.Text = "0000---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Folio:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Logo_CLUB_BILLAR;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CapaPresentacion.Properties.Resources.OIP_verdeBandera;
            this.panel2.Controls.Add(this.dgvVenta);
            this.panel2.Controls.Add(this.lblTotalINS);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 418);
            this.panel2.TabIndex = 0;
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.AllowUserToDeleteRows = false;
            this.dgvVenta.AllowUserToOrderColumns = true;
            this.dgvVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVenta.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvVenta.Location = new System.Drawing.Point(325, 28);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.RowHeadersVisible = false;
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvVenta.Size = new System.Drawing.Size(560, 272);
            this.dgvVenta.TabIndex = 24;
            this.dgvVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellClick);
            this.dgvVenta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellEndEdit);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "   ";
            this.Eliminar.Image = global::CapaPresentacion.Properties.Resources._019_close;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 23;
            // 
            // lblTotalINS
            // 
            this.lblTotalINS.AutoSize = true;
            this.lblTotalINS.Location = new System.Drawing.Point(829, 324);
            this.lblTotalINS.Name = "lblTotalINS";
            this.lblTotalINS.Size = new System.Drawing.Size(36, 16);
            this.lblTotalINS.TabIndex = 24;
            this.lblTotalINS.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(775, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Total: $";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Controls.Add(this.dgvProductos);
            this.groupBox1.Controls.Add(this.cbxCantidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 279);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Productos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(17, 93);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(270, 172);
            this.dgvProductos.TabIndex = 20;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // cbxCantidad
            // 
            this.cbxCantidad.FormattingEnabled = true;
            this.cbxCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxCantidad.Location = new System.Drawing.Point(94, 55);
            this.cbxCantidad.Name = "cbxCantidad";
            this.cbxCantidad.Size = new System.Drawing.Size(193, 27);
            this.cbxCantidad.TabIndex = 23;
            this.cbxCantidad.Text = "1";
            this.cbxCantidad.TextChanged += new System.EventHandler(this.cbxCantidad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cantidad:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(17, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(270, 27);
            this.txtBuscar.TabIndex = 20;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Navy;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimir.Location = new System.Drawing.Point(631, 366);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(124, 38);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Navy;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(761, 366);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 38);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Navy;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(501, 366);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 38);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Registrar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "   ";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources._019_close;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 20;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.SeaGreen;
            this.btnVolver.Image = global::CapaPresentacion.Properties.Resources.regresar;
            this.btnVolver.Location = new System.Drawing.Point(846, 3);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(20, 20);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolver.TabIndex = 27;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMinimizar.Image = global::CapaPresentacion.Properties.Resources.mini;
            this.btnMinimizar.Location = new System.Drawing.Point(872, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 26;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCerrar.Image = global::CapaPresentacion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(898, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(922, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvELI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVenta";
            this.Text = "Venta de Productos";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasACT)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasELI)).EndInit();
            this.Registrar.ResumeLayout(false);
            this.dgvELI.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCancelarACT;
        private System.Windows.Forms.Button btnEliminarACT;
        private System.Windows.Forms.TextBox txtIdACT;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage Registrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl dgvELI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIdVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbxCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimirACT;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblFolioELI;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.TextBox txtIdELI;
        private System.Windows.Forms.Label lblTotalINS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvVentasACT;
        private System.Windows.Forms.DataGridView dgvVentasELI;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnCancelarELI;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.PictureBox btnVolver;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}