namespace AplicacionProductosServicios.Vista
{
    partial class MscVenta
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
            this.cbocod = new System.Windows.Forms.ComboBox();
            this.btnbuscardatos = new System.Windows.Forms.Button();
            this.btnmodivent = new System.Windows.Forms.Button();
            this.dgventa = new System.Windows.Forms.DataGridView();
            this.idventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnbusvent = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtcantpedida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.Label();
            this.txtvaloruni = new System.Windows.Forms.TextBox();
            this.txtnompro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnuevoVent = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgventa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbocod
            // 
            this.cbocod.FormattingEnabled = true;
            this.cbocod.Location = new System.Drawing.Point(9, 30);
            this.cbocod.Name = "cbocod";
            this.cbocod.Size = new System.Drawing.Size(121, 21);
            this.cbocod.TabIndex = 21;
            this.cbocod.SelectedIndexChanged += new System.EventHandler(this.cbocod_SelectedIndexChanged);
            // 
            // btnbuscardatos
            // 
            this.btnbuscardatos.BackgroundImage = global::AplicacionProductosServicios.Properties.Resources.lupa_de_buscar;
            this.btnbuscardatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnbuscardatos.Location = new System.Drawing.Point(154, 26);
            this.btnbuscardatos.Name = "btnbuscardatos";
            this.btnbuscardatos.Size = new System.Drawing.Size(81, 27);
            this.btnbuscardatos.TabIndex = 22;
            this.btnbuscardatos.Text = "Buscar";
            this.btnbuscardatos.UseVisualStyleBackColor = true;
            this.btnbuscardatos.Click += new System.EventHandler(this.btnbuscardatos_Click);
            // 
            // btnmodivent
            // 
            this.btnmodivent.Location = new System.Drawing.Point(362, 159);
            this.btnmodivent.Name = "btnmodivent";
            this.btnmodivent.Size = new System.Drawing.Size(98, 26);
            this.btnmodivent.TabIndex = 31;
            this.btnmodivent.Text = "Modificar Venta";
            this.btnmodivent.UseVisualStyleBackColor = true;
            this.btnmodivent.Click += new System.EventHandler(this.btnmodivent_Click);
            // 
            // dgventa
            // 
            this.dgventa.AllowUserToAddRows = false;
            this.dgventa.AllowUserToDeleteRows = false;
            this.dgventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idventa,
            this.Column1,
            this.Column2,
            this.Column3,
            this.nombre,
            this.Column4,
            this.Column5});
            this.dgventa.Location = new System.Drawing.Point(132, 220);
            this.dgventa.Name = "dgventa";
            this.dgventa.ReadOnly = true;
            this.dgventa.Size = new System.Drawing.Size(593, 185);
            this.dgventa.TabIndex = 28;
            this.dgventa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgventa_CellClick);
            // 
            // idventa
            // 
            this.idventa.HeaderText = "IdVenta";
            this.idventa.Name = "idventa";
            this.idventa.ReadOnly = true;
            this.idventa.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Codigo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "v/u";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ValorTotal";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtp2);
            this.groupBox2.Controls.Add(this.dtp1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnbusvent);
            this.groupBox2.Location = new System.Drawing.Point(12, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(859, 46);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de busqueda";
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Buscar Venta Desde ";
            // 
            // dtp2
            // 
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp2.Location = new System.Drawing.Point(703, 19);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(97, 20);
            this.dtp2.TabIndex = 18;
            this.dtp2.ValueChanged += new System.EventHandler(this.dtp2_ValueChanged);
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(120, 20);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(97, 20);
            this.dtp1.TabIndex = 16;
        
            this.dtp1.ValueChanged += new System.EventHandler(this.dtp1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hasta ";
            // 
            // btnbusvent
            // 
            this.btnbusvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbusvent.Location = new System.Drawing.Point(806, 13);
            this.btnbusvent.Name = "btnbusvent";
            this.btnbusvent.Size = new System.Drawing.Size(29, 27);
            this.btnbusvent.TabIndex = 9;
            this.btnbusvent.UseVisualStyleBackColor = true;
            this.btnbusvent.Click += new System.EventHandler(this.btnbusvent_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(627, 159);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(98, 26);
            this.btnsalir.TabIndex = 29;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.txtcantpedida);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Cantidad);
            this.groupBox1.Controls.Add(this.txtvaloruni);
            this.groupBox1.Controls.Add(this.txtnompro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(275, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 64);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Venta ";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(314, 30);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(64, 20);
            this.txtstock.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "stock";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(507, 30);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(58, 25);
            this.btnguardar.TabIndex = 23;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtcantpedida
            // 
            this.txtcantpedida.Location = new System.Drawing.Point(439, 31);
            this.txtcantpedida.Name = "txtcantpedida";
            this.txtcantpedida.Size = new System.Drawing.Size(62, 20);
            this.txtcantpedida.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(384, 34);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(49, 13);
            this.Cantidad.TabIndex = 2;
            this.Cantidad.Text = "Cantidad";
            // 
            // txtvaloruni
            // 
            this.txtvaloruni.Location = new System.Drawing.Point(205, 30);
            this.txtvaloruni.Name = "txtvaloruni";
            this.txtvaloruni.Size = new System.Drawing.Size(64, 20);
            this.txtvaloruni.TabIndex = 5;
            // 
            // txtnompro
            // 
            this.txtnompro.Location = new System.Drawing.Point(56, 30);
            this.txtnompro.Name = "txtnompro";
            this.txtnompro.Size = new System.Drawing.Size(100, 20);
            this.txtnompro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Precio";
            // 
            // btnnuevoVent
            // 
            this.btnnuevoVent.Location = new System.Drawing.Point(119, 159);
            this.btnnuevoVent.Name = "btnnuevoVent";
            this.btnnuevoVent.Size = new System.Drawing.Size(98, 26);
            this.btnnuevoVent.TabIndex = 26;
            this.btnnuevoVent.Text = "Nueva Venta";
            this.btnnuevoVent.UseVisualStyleBackColor = true;
            this.btnnuevoVent.Click += new System.EventHandler(this.btnnuevoVent_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Productos ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbocod);
            this.panel1.Controls.Add(this.btnbuscardatos);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 64);
            this.panel1.TabIndex = 19;
            // 
            // MscVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(872, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgventa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnmodivent);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnnuevoVent);
            this.Name = "MscVenta";
            this.Text = "MscVenta";
            this.Load += new System.EventHandler(this.MscVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgventa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbocod;
        private System.Windows.Forms.Button btnbuscardatos;
        private System.Windows.Forms.Button btnmodivent;
        private System.Windows.Forms.DataGridView dgventa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnbusvent;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtcantpedida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.TextBox txtvaloruni;
        private System.Windows.Forms.TextBox txtnompro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnuevoVent;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}