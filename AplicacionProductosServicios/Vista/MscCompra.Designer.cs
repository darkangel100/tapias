﻿namespace AplicacionProductosServicios.Vista
{
    partial class MscCompra
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnbuscarComp = new System.Windows.Forms.Button();
            this.dgcompra = new System.Windows.Forms.DataGridView();
            this.idCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnmodificarComp = new System.Windows.Forms.Button();
            this.btnregistrarComp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcantidadComp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnguardarComp = new System.Windows.Forms.Button();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtvalorComp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboprod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnbuscarComp);
            this.groupBox2.Location = new System.Drawing.Point(224, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 46);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Buscar Venta Desde ";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(280, 20);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker3.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(120, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker2.TabIndex = 16;
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
            // btnbuscarComp
            // 
            this.btnbuscarComp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscarComp.Location = new System.Drawing.Point(383, 13);
            this.btnbuscarComp.Name = "btnbuscarComp";
            this.btnbuscarComp.Size = new System.Drawing.Size(29, 27);
            this.btnbuscarComp.TabIndex = 9;
            this.btnbuscarComp.UseVisualStyleBackColor = true;
            // 
            // dgcompra
            // 
            this.dgcompra.AllowUserToAddRows = false;
            this.dgcompra.AllowUserToDeleteRows = false;
            this.dgcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompra,
            this.Column1,
            this.Column2,
            this.cantidad,
            this.Column3});
            this.dgcompra.Location = new System.Drawing.Point(69, 247);
            this.dgcompra.Name = "dgcompra";
            this.dgcompra.ReadOnly = true;
            this.dgcompra.Size = new System.Drawing.Size(546, 150);
            this.dgcompra.TabIndex = 24;
            // 
            // idCompra
            // 
            this.idCompra.HeaderText = "IdCompra";
            this.idCompra.Name = "idCompra";
            this.idCompra.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Detalle";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(525, 199);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(111, 26);
            this.btnsalir.TabIndex = 25;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btnmodificarComp
            // 
            this.btnmodificarComp.Location = new System.Drawing.Point(282, 197);
            this.btnmodificarComp.Name = "btnmodificarComp";
            this.btnmodificarComp.Size = new System.Drawing.Size(111, 26);
            this.btnmodificarComp.TabIndex = 23;
            this.btnmodificarComp.Text = "Modificar Compra";
            this.btnmodificarComp.UseVisualStyleBackColor = true;
            this.btnmodificarComp.Click += new System.EventHandler(this.btnmodificarComp_Click);
            // 
            // btnregistrarComp
            // 
            this.btnregistrarComp.Location = new System.Drawing.Point(23, 199);
            this.btnregistrarComp.Name = "btnregistrarComp";
            this.btnregistrarComp.Size = new System.Drawing.Size(111, 23);
            this.btnregistrarComp.TabIndex = 22;
            this.btnregistrarComp.Text = "Registar Compra";
            this.btnregistrarComp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcantidadComp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnguardarComp);
            this.groupBox1.Controls.Add(this.txtcod);
            this.groupBox1.Controls.Add(this.txtvalorComp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 40);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // txtcantidadComp
            // 
            this.txtcantidadComp.Location = new System.Drawing.Point(352, 10);
            this.txtcantidadComp.Name = "txtcantidadComp";
            this.txtcantidadComp.Size = new System.Drawing.Size(100, 20);
            this.txtcantidadComp.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad";
            // 
            // btnguardarComp
            // 
            this.btnguardarComp.Location = new System.Drawing.Point(471, 8);
            this.btnguardarComp.Name = "btnguardarComp";
            this.btnguardarComp.Size = new System.Drawing.Size(66, 26);
            this.btnguardarComp.TabIndex = 6;
            this.btnguardarComp.Text = "Guardar";
            this.btnguardarComp.UseVisualStyleBackColor = true;
            this.btnguardarComp.Click += new System.EventHandler(this.btnguardarComp_Click);
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(54, 10);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 20);
            this.txtcod.TabIndex = 5;
            // 
            // txtvalorComp
            // 
            this.txtvalorComp.Location = new System.Drawing.Point(201, 10);
            this.txtvalorComp.Name = "txtvalorComp";
            this.txtvalorComp.Size = new System.Drawing.Size(100, 20);
            this.txtvalorComp.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CodProducto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor";
            // 
            // cboprod
            // 
            this.cboprod.FormattingEnabled = true;
            this.cboprod.Location = new System.Drawing.Point(24, 71);
            this.cboprod.Name = "cboprod";
            this.cboprod.Size = new System.Drawing.Size(93, 21);
            this.cboprod.TabIndex = 27;
            this.cboprod.SelectedIndexChanged += new System.EventHandler(this.cboprod_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Lista de Productos Registrados";
            // 
            // MscCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 471);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboprod);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgcompra);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnmodificarComp);
            this.Controls.Add(this.btnregistrarComp);
            this.Controls.Add(this.groupBox1);
            this.Name = "MscCompra";
            this.Text = "MscCompra";
            this.Load += new System.EventHandler(this.MscCompra_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnbuscarComp;
        private System.Windows.Forms.DataGridView dgcompra;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnmodificarComp;
        private System.Windows.Forms.Button btnregistrarComp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnguardarComp;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtvalorComp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcantidadComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox cboprod;
        private System.Windows.Forms.Label label6;
    }
}