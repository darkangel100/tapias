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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtcantpedida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.Label();
            this.txtvaloruni = new System.Windows.Forms.TextBox();
            this.txtpro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnuevoVent = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgventa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbocod);
            this.groupBox3.Controls.Add(this.btnbuscardatos);
            this.groupBox3.Location = new System.Drawing.Point(12, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 43);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // cbocod
            // 
            this.cbocod.FormattingEnabled = true;
            this.cbocod.Location = new System.Drawing.Point(32, 11);
            this.cbocod.Name = "cbocod";
            this.cbocod.Size = new System.Drawing.Size(121, 21);
            this.cbocod.TabIndex = 21;
            // 
            // btnbuscardatos
            // 
            this.btnbuscardatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscardatos.Location = new System.Drawing.Point(162, 10);
            this.btnbuscardatos.Name = "btnbuscardatos";
            this.btnbuscardatos.Size = new System.Drawing.Size(29, 27);
            this.btnbuscardatos.TabIndex = 22;
            this.btnbuscardatos.UseVisualStyleBackColor = true;
            // 
            // btnmodivent
            // 
            this.btnmodivent.Location = new System.Drawing.Point(516, 22);
            this.btnmodivent.Name = "btnmodivent";
            this.btnmodivent.Size = new System.Drawing.Size(98, 26);
            this.btnmodivent.TabIndex = 31;
            this.btnmodivent.Text = "Modificar Venta";
            this.btnmodivent.UseVisualStyleBackColor = true;
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
            this.dgventa.Location = new System.Drawing.Point(21, 158);
            this.dgventa.Name = "dgventa";
            this.dgventa.ReadOnly = true;
            this.dgventa.Size = new System.Drawing.Size(738, 249);
            this.dgventa.TabIndex = 28;
            // 
            // idventa
            // 
            this.idventa.HeaderText = "IdVenta";
            this.idventa.Name = "idventa";
            this.idventa.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Codigo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            this.groupBox2.Location = new System.Drawing.Point(352, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 46);
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
            this.dtp2.Location = new System.Drawing.Point(280, 20);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(97, 20);
            this.dtp2.TabIndex = 18;
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(120, 20);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(97, 20);
            this.dtp1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hasta ";
            // 
            // btnbusvent
            // 
            this.btnbusvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbusvent.Location = new System.Drawing.Point(383, 13);
            this.btnbusvent.Name = "btnbusvent";
            this.btnbusvent.Size = new System.Drawing.Size(29, 27);
            this.btnbusvent.TabIndex = 9;
            this.btnbusvent.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(762, 412);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(98, 24);
            this.btnsalir.TabIndex = 29;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.btnmodivent);
            this.groupBox1.Controls.Add(this.txtcantpedida);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Cantidad);
            this.groupBox1.Controls.Add(this.txtvaloruni);
            this.groupBox1.Controls.Add(this.txtpro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 63);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Venta ";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(426, 19);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(58, 25);
            this.btnguardar.TabIndex = 23;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // txtcantpedida
            // 
            this.txtcantpedida.Location = new System.Drawing.Point(340, 21);
            this.txtcantpedida.Name = "txtcantpedida";
            this.txtcantpedida.Size = new System.Drawing.Size(62, 20);
            this.txtcantpedida.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(279, 25);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(49, 13);
            this.Cantidad.TabIndex = 2;
            this.Cantidad.Text = "Cantidad";
            // 
            // txtvaloruni
            // 
            this.txtvaloruni.Location = new System.Drawing.Point(209, 22);
            this.txtvaloruni.Name = "txtvaloruni";
            this.txtvaloruni.Size = new System.Drawing.Size(64, 20);
            this.txtvaloruni.TabIndex = 5;
            // 
            // txtpro
            // 
            this.txtpro.Location = new System.Drawing.Point(53, 21);
            this.txtpro.Name = "txtpro";
            this.txtpro.Size = new System.Drawing.Size(100, 20);
            this.txtpro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor";
            // 
            // btnnuevoVent
            // 
            this.btnnuevoVent.Location = new System.Drawing.Point(12, 9);
            this.btnnuevoVent.Name = "btnnuevoVent";
            this.btnnuevoVent.Size = new System.Drawing.Size(124, 25);
            this.btnnuevoVent.TabIndex = 26;
            this.btnnuevoVent.Text = "Nueva Venta";
            this.btnnuevoVent.UseVisualStyleBackColor = true;
            // 
            // MscVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 439);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgventa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnnuevoVent);
            this.Name = "MscVenta";
            this.Text = "MscVenta";
            this.Load += new System.EventHandler(this.MscVenta_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgventa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.TextBox txtpro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnuevoVent;
        private System.Windows.Forms.DataGridViewTextBoxColumn idventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}