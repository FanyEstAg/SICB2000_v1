namespace CapaPresentacion
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMesas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCobrarMesa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.lblUsuario1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnVentaProd = new System.Windows.Forms.Button();
            this.btnCobroMesa = new System.Windows.Forms.Button();
            this.btnMesas = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.tsmReportes,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 62);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.AutoSize = false;
            this.inicioToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSeguridad,
            this.tsmInventario,
            this.toolStripMenuItem1,
            this.tsmSalir});
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.inicioToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.home_48x48_32;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(122, 40);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // tsmSeguridad
            // 
            this.tsmSeguridad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSeguridad.Image = global::CapaPresentacion.Properties.Resources.Security_1_24x24_32;
            this.tsmSeguridad.Name = "tsmSeguridad";
            this.tsmSeguridad.Size = new System.Drawing.Size(129, 24);
            this.tsmSeguridad.Text = "Usuarios";
            this.tsmSeguridad.Click += new System.EventHandler(this.tsmSeguridad_Click);
            // 
            // tsmInventario
            // 
            this.tsmInventario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmInventario.Image = global::CapaPresentacion.Properties.Resources.producto_16x16;
            this.tsmInventario.Name = "tsmInventario";
            this.tsmInventario.Size = new System.Drawing.Size(129, 24);
            this.tsmInventario.Text = "Inventario";
            this.tsmInventario.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(126, 6);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(129, 24);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVentas,
            this.tsmMesas,
            this.tsmCobrarMesa});
            this.ventasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventasToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.ventasToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.app_edit_32x32_32;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(136, 58);
            this.ventasToolStripMenuItem.Text = "Movimientos";
            // 
            // tsmVentas
            // 
            this.tsmVentas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmVentas.Image = global::CapaPresentacion.Properties.Resources.Shopping_cart_24x24;
            this.tsmVentas.Name = "tsmVentas";
            this.tsmVentas.Size = new System.Drawing.Size(169, 22);
            this.tsmVentas.Text = "Vender";
            this.tsmVentas.Click += new System.EventHandler(this.tsmVentas_Click);
            // 
            // tsmMesas
            // 
            this.tsmMesas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmMesas.Image = global::CapaPresentacion.Properties.Resources._new;
            this.tsmMesas.Name = "tsmMesas";
            this.tsmMesas.Size = new System.Drawing.Size(169, 22);
            this.tsmMesas.Text = "Mesas";
            this.tsmMesas.Click += new System.EventHandler(this.tsmMesas_Click);
            // 
            // tsmCobrarMesa
            // 
            this.tsmCobrarMesa.Font = new System.Drawing.Font("Arial", 9F);
            this.tsmCobrarMesa.Name = "tsmCobrarMesa";
            this.tsmCobrarMesa.Size = new System.Drawing.Size(169, 22);
            this.tsmCobrarMesa.Text = "Cobro de mesas";
            this.tsmCobrarMesa.Click += new System.EventHandler(this.tsmCobrarMesa_Click);
            // 
            // tsmReportes
            // 
            this.tsmReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmReportes.ForeColor = System.Drawing.Color.Navy;
            this.tsmReportes.Image = global::CapaPresentacion.Properties.Resources.chart_accept_32x32_32;
            this.tsmReportes.Name = "tsmReportes";
            this.tsmReportes.Size = new System.Drawing.Size(111, 58);
            this.tsmReportes.Text = "Reportes";
            this.tsmReportes.Click += new System.EventHandler(this.tsmReportes_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem1});
            this.acercaDeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.acercaDeToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.user_comment_32x32_32;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(87, 58);
            this.acercaDeToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acercaDeToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.acercaDeToolStripMenuItem1.Text = "Acerca de";
            this.acercaDeToolStripMenuItem1.Click += new System.EventHandler(this.acercaDeToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 62);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblUsuario1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 62);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Controls.Add(this.btnVolver);
            this.panel4.Controls.Add(this.btnCerrar);
            this.panel4.Controls.Add(this.btnMinimizar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(716, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(106, 62);
            this.panel4.TabIndex = 19;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.SeaGreen;
            this.btnVolver.Image = global::CapaPresentacion.Properties.Resources.regresar;
            this.btnVolver.Location = new System.Drawing.Point(22, 8);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(20, 20);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolver.TabIndex = 21;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCerrar.Image = global::CapaPresentacion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(74, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMinimizar.Image = global::CapaPresentacion.Properties.Resources.mini;
            this.btnMinimizar.Location = new System.Drawing.Point(48, 8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            // 
            // lblUsuario1
            // 
            this.lblUsuario1.AutoSize = true;
            this.lblUsuario1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario1.Location = new System.Drawing.Point(674, 26);
            this.lblUsuario1.Name = "lblUsuario1";
            this.lblUsuario1.Size = new System.Drawing.Size(0, 13);
            this.lblUsuario1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnConfig);
            this.panel3.Controls.Add(this.btnReporte);
            this.panel3.Controls.Add(this.btnInventario);
            this.panel3.Controls.Add(this.btnVentaProd);
            this.panel3.Controls.Add(this.btnCobroMesa);
            this.panel3.Controls.Add(this.btnMesas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 403);
            this.panel3.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Image = global::CapaPresentacion.Properties.Resources.b71;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Acerca de";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnConfig
            // 
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.Navy;
            this.btnConfig.Image = global::CapaPresentacion.Properties.Resources.b11;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 285);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(200, 57);
            this.btnConfig.TabIndex = 5;
            this.btnConfig.Text = "       Configuración";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.Navy;
            this.btnReporte.Image = global::CapaPresentacion.Properties.Resources.b8;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(0, 228);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(200, 57);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.Navy;
            this.btnInventario.Image = global::CapaPresentacion.Properties.Resources.b1;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 171);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(200, 57);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnVentaProd
            // 
            this.btnVentaProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentaProd.FlatAppearance.BorderSize = 0;
            this.btnVentaProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnVentaProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnVentaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaProd.ForeColor = System.Drawing.Color.Navy;
            this.btnVentaProd.Image = global::CapaPresentacion.Properties.Resources.b4;
            this.btnVentaProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaProd.Location = new System.Drawing.Point(0, 114);
            this.btnVentaProd.Name = "btnVentaProd";
            this.btnVentaProd.Size = new System.Drawing.Size(200, 57);
            this.btnVentaProd.TabIndex = 2;
            this.btnVentaProd.Text = "Ventas";
            this.btnVentaProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentaProd.UseVisualStyleBackColor = true;
            this.btnVentaProd.Click += new System.EventHandler(this.btnVentaProd_Click);
            // 
            // btnCobroMesa
            // 
            this.btnCobroMesa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCobroMesa.FlatAppearance.BorderSize = 0;
            this.btnCobroMesa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnCobroMesa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnCobroMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobroMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobroMesa.ForeColor = System.Drawing.Color.Navy;
            this.btnCobroMesa.Image = global::CapaPresentacion.Properties.Resources.b6;
            this.btnCobroMesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobroMesa.Location = new System.Drawing.Point(0, 57);
            this.btnCobroMesa.Name = "btnCobroMesa";
            this.btnCobroMesa.Size = new System.Drawing.Size(200, 57);
            this.btnCobroMesa.TabIndex = 1;
            this.btnCobroMesa.Text = "Cobro";
            this.btnCobroMesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCobroMesa.UseVisualStyleBackColor = true;
            this.btnCobroMesa.Click += new System.EventHandler(this.btnCobroMesa_Click);
            // 
            // btnMesas
            // 
            this.btnMesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMesas.FlatAppearance.BorderSize = 0;
            this.btnMesas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnMesas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesas.ForeColor = System.Drawing.Color.Navy;
            this.btnMesas.Image = global::CapaPresentacion.Properties.Resources.b5;
            this.btnMesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesas.Location = new System.Drawing.Point(0, 0);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(200, 57);
            this.btnMesas.TabIndex = 0;
            this.btnMesas.Text = "Mesas";
            this.btnMesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMesas.UseVisualStyleBackColor = true;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsuario.Location = new System.Drawing.Point(685, 83);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(20, 16);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "---";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Logo_CLUB_BILLAR;
            this.pictureBox1.Location = new System.Drawing.Point(200, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(158)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(822, 465);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSeguridad;
        private System.Windows.Forms.ToolStripMenuItem tsmInventario;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmVentas;
        private System.Windows.Forms.ToolStripMenuItem tsmReportes;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmMesas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUsuario1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMesas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnVentaProd;
        private System.Windows.Forms.Button btnCobroMesa;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem tsmCobrarMesa;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox btnVolver;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
    }
}