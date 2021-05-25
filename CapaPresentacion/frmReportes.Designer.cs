
namespace CapaPresentacion
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Mesas = new System.Windows.Forms.TabPage();
            this.btnImprimirM = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pickerMesas = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBuscarM = new System.Windows.Forms.Button();
            this.txtIdMesaR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMesasR = new System.Windows.Forms.DataGridView();
            this.Ventas = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImprimirV = new System.Windows.Forms.Button();
            this.dgvVentasR = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarV = new System.Windows.Forms.Button();
            this.txtIdVentasR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pickerVenta = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Mesas.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesasR)).BeginInit();
            this.Ventas.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasR)).BeginInit();
            this.panel1.SuspendLayout();
            this.pickerVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.SeaGreen;
            this.btnVolver.Image = global::CapaPresentacion.Properties.Resources.regresar;
            this.btnVolver.Location = new System.Drawing.Point(616, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(20, 20);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolver.TabIndex = 29;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMinimizar.Image = global::CapaPresentacion.Properties.Resources.mini;
            this.btnMinimizar.Location = new System.Drawing.Point(642, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 28;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCerrar.Image = global::CapaPresentacion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(668, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 27;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Logo_CLUB_BILLAR;
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SeaGreen;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(690, 56);
            this.label4.TabIndex = 25;
            this.label4.Text = "REPORTES";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mesas
            // 
            this.Mesas.BackgroundImage = global::CapaPresentacion.Properties.Resources.OIP;
            this.Mesas.Controls.Add(this.btnImprimirM);
            this.Mesas.Controls.Add(this.panel6);
            this.Mesas.Controls.Add(this.dgvMesasR);
            this.Mesas.Location = new System.Drawing.Point(4, 29);
            this.Mesas.Name = "Mesas";
            this.Mesas.Padding = new System.Windows.Forms.Padding(3);
            this.Mesas.Size = new System.Drawing.Size(658, 327);
            this.Mesas.TabIndex = 2;
            this.Mesas.Text = "Mesas";
            this.Mesas.UseVisualStyleBackColor = true;
            // 
            // btnImprimirM
            // 
            this.btnImprimirM.BackColor = System.Drawing.Color.Navy;
            this.btnImprimirM.FlatAppearance.BorderSize = 0;
            this.btnImprimirM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimirM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirM.Location = new System.Drawing.Point(410, 281);
            this.btnImprimirM.Name = "btnImprimirM";
            this.btnImprimirM.Size = new System.Drawing.Size(153, 38);
            this.btnImprimirM.TabIndex = 27;
            this.btnImprimirM.Text = "Imprimir";
            this.btnImprimirM.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.IndianRed;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.pickerMesas);
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Controls.Add(this.btnBuscarM);
            this.panel6.Controls.Add(this.txtIdMesaR);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(32, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(588, 81);
            this.panel6.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Elige el filtro que deseas ejecutar o la mesa que deseas ver";
            // 
            // pickerMesas
            // 
            this.pickerMesas.Location = new System.Drawing.Point(376, 40);
            this.pickerMesas.Name = "pickerMesas";
            this.pickerMesas.Size = new System.Drawing.Size(200, 26);
            this.pickerMesas.TabIndex = 29;
            this.pickerMesas.ValueChanged += new System.EventHandler(this.pickerMesas_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tiempo de uso",
            "Tipo de mesas"});
            this.comboBox1.Location = new System.Drawing.Point(249, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.Text = "Filtro";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // btnBuscarM
            // 
            this.btnBuscarM.BackColor = System.Drawing.Color.Navy;
            this.btnBuscarM.FlatAppearance.BorderSize = 0;
            this.btnBuscarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarM.Image = global::CapaPresentacion.Properties.Resources.lupachica;
            this.btnBuscarM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarM.Location = new System.Drawing.Point(191, 31);
            this.btnBuscarM.Name = "btnBuscarM";
            this.btnBuscarM.Size = new System.Drawing.Size(38, 38);
            this.btnBuscarM.TabIndex = 27;
            this.btnBuscarM.UseVisualStyleBackColor = false;
            this.btnBuscarM.Click += new System.EventHandler(this.btnBuscarM_Click);
            // 
            // txtIdMesaR
            // 
            this.txtIdMesaR.Location = new System.Drawing.Point(90, 37);
            this.txtIdMesaR.Name = "txtIdMesaR";
            this.txtIdMesaR.Size = new System.Drawing.Size(95, 26);
            this.txtIdMesaR.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Id mesa:";
            // 
            // dgvMesasR
            // 
            this.dgvMesasR.AllowUserToAddRows = false;
            this.dgvMesasR.AllowUserToDeleteRows = false;
            this.dgvMesasR.AllowUserToResizeRows = false;
            this.dgvMesasR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMesasR.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dgvMesasR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesasR.Location = new System.Drawing.Point(32, 93);
            this.dgvMesasR.Name = "dgvMesasR";
            this.dgvMesasR.Size = new System.Drawing.Size(588, 182);
            this.dgvMesasR.TabIndex = 24;
            // 
            // Ventas
            // 
            this.Ventas.Controls.Add(this.panel2);
            this.Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ventas.Location = new System.Drawing.Point(4, 29);
            this.Ventas.Name = "Ventas";
            this.Ventas.Padding = new System.Windows.Forms.Padding(3);
            this.Ventas.Size = new System.Drawing.Size(658, 327);
            this.Ventas.TabIndex = 0;
            this.Ventas.Text = "Ventas";
            this.Ventas.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CapaPresentacion.Properties.Resources.OIP;
            this.panel2.Controls.Add(this.btnImprimirV);
            this.panel2.Controls.Add(this.dgvVentasR);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 321);
            this.panel2.TabIndex = 0;
            // 
            // btnImprimirV
            // 
            this.btnImprimirV.BackColor = System.Drawing.Color.Navy;
            this.btnImprimirV.FlatAppearance.BorderSize = 0;
            this.btnImprimirV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimirV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirV.Location = new System.Drawing.Point(407, 270);
            this.btnImprimirV.Name = "btnImprimirV";
            this.btnImprimirV.Size = new System.Drawing.Size(165, 38);
            this.btnImprimirV.TabIndex = 23;
            this.btnImprimirV.Text = "Imprimir";
            this.btnImprimirV.UseVisualStyleBackColor = false;
            this.btnImprimirV.Click += new System.EventHandler(this.btnImprimirV_Click);
            // 
            // dgvVentasR
            // 
            this.dgvVentasR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVentasR.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dgvVentasR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasR.Location = new System.Drawing.Point(44, 96);
            this.dgvVentasR.Name = "dgvVentasR";
            this.dgvVentasR.Size = new System.Drawing.Size(528, 150);
            this.dgvVentasR.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnBuscarV);
            this.panel1.Controls.Add(this.txtIdVentasR);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(44, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 76);
            this.panel1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Elige el filtro que deseas ejecutar o la venta que deseas ver";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(312, 33);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 23, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Filtro:";
            // 
            // btnBuscarV
            // 
            this.btnBuscarV.BackColor = System.Drawing.Color.Navy;
            this.btnBuscarV.FlatAppearance.BorderSize = 0;
            this.btnBuscarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarV.Image = global::CapaPresentacion.Properties.Resources.lupachica;
            this.btnBuscarV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarV.Location = new System.Drawing.Point(197, 28);
            this.btnBuscarV.Name = "btnBuscarV";
            this.btnBuscarV.Size = new System.Drawing.Size(38, 38);
            this.btnBuscarV.TabIndex = 15;
            this.btnBuscarV.UseVisualStyleBackColor = false;
            this.btnBuscarV.Click += new System.EventHandler(this.btnBuscarV_Click);
            // 
            // txtIdVentasR
            // 
            this.txtIdVentasR.Location = new System.Drawing.Point(91, 35);
            this.txtIdVentasR.Name = "txtIdVentasR";
            this.txtIdVentasR.Size = new System.Drawing.Size(100, 24);
            this.txtIdVentasR.TabIndex = 0;
            this.txtIdVentasR.TextChanged += new System.EventHandler(this.txtIdVentasR_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id venta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // pickerVenta
            // 
            this.pickerVenta.Controls.Add(this.Ventas);
            this.pickerVenta.Controls.Add(this.Mesas);
            this.pickerVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerVenta.Location = new System.Drawing.Point(12, 75);
            this.pickerVenta.Name = "pickerVenta";
            this.pickerVenta.SelectedIndex = 0;
            this.pickerVenta.Size = new System.Drawing.Size(666, 360);
            this.pickerVenta.TabIndex = 30;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(690, 460);
            this.Controls.Add(this.pickerVenta);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Mesas.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesasR)).EndInit();
            this.Ventas.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pickerVenta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnVolver;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage Mesas;
        private System.Windows.Forms.Button btnImprimirM;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBuscarM;
        private System.Windows.Forms.TextBox txtIdMesaR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMesasR;
        private System.Windows.Forms.TabPage Ventas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnImprimirV;
        private System.Windows.Forms.DataGridView dgvVentasR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarV;
        private System.Windows.Forms.TextBox txtIdVentasR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl pickerVenta;
        private System.Windows.Forms.DateTimePicker pickerMesas;
    }
}