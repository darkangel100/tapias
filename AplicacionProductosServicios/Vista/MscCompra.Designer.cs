namespace AplicacionProductosServicios.Vista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnbuscarComp = new System.Windows.Forms.Button();
            this.dgcompra = new System.Windows.Forms.DataGridView();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnregistrarComp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcantidadComp = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtvalorComp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnguardarComp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboprod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttot = new System.Windows.Forms.TextBox();
            this.idCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(120, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker2.TabIndex = 16;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
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
            this.btnbuscarComp.BackgroundImage = global::AplicacionProductosServicios.Properties.Resources.lupa_de_buscar;
            this.btnbuscarComp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscarComp.Location = new System.Drawing.Point(383, 13);
            this.btnbuscarComp.Name = "btnbuscarComp";
            this.btnbuscarComp.Size = new System.Drawing.Size(29, 27);
            this.btnbuscarComp.TabIndex = 9;
            this.btnbuscarComp.UseVisualStyleBackColor = true;
            this.btnbuscarComp.Click += new System.EventHandler(this.btnbuscarComp_Click);
            // 
            // dgcompra
            // 
            this.dgcompra.AllowUserToAddRows = false;
            this.dgcompra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgcompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgcompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgcompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgcompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompra,
            this.Column1,
            this.Column2,
            this.cantidad,
            this.Column3,
            this.tot});
            this.dgcompra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgcompra.Location = new System.Drawing.Point(36, 207);
            this.dgcompra.Name = "dgcompra";
            this.dgcompra.ReadOnly = true;
            this.dgcompra.Size = new System.Drawing.Size(627, 150);
            this.dgcompra.TabIndex = 24;
            this.dgcompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcompra_CellContentClick);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(474, 164);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(111, 26);
            this.btnsalir.TabIndex = 25;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnregistrarComp
            // 
            this.btnregistrarComp.Location = new System.Drawing.Point(113, 166);
            this.btnregistrarComp.Name = "btnregistrarComp";
            this.btnregistrarComp.Size = new System.Drawing.Size(111, 23);
            this.btnregistrarComp.TabIndex = 22;
            this.btnregistrarComp.Text = "Registar Compra";
            this.btnregistrarComp.UseVisualStyleBackColor = true;
            this.btnregistrarComp.Click += new System.EventHandler(this.btnregistrarComp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtcantidadComp);
            this.groupBox1.Controls.Add(this.txtcod);
            this.groupBox1.Controls.Add(this.txtvalorComp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnguardarComp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(82, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 53);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // txtcantidadComp
            // 
            this.txtcantidadComp.Location = new System.Drawing.Point(346, 16);
            this.txtcantidadComp.Name = "txtcantidadComp";
            this.txtcantidadComp.Size = new System.Drawing.Size(63, 20);
            this.txtcantidadComp.TabIndex = 6;
            this.txtcantidadComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidadComp_KeyPress);
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(81, 12);
            this.txtcod.Name = "txtcod";
            this.txtcod.ReadOnly = true;
            this.txtcod.Size = new System.Drawing.Size(40, 20);
            this.txtcod.TabIndex = 5;
            // 
            // txtvalorComp
            // 
            this.txtvalorComp.Location = new System.Drawing.Point(198, 16);
            this.txtvalorComp.Name = "txtvalorComp";
            this.txtvalorComp.Size = new System.Drawing.Size(71, 20);
            this.txtvalorComp.TabIndex = 3;
            this.txtvalorComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorComp_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(291, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad";
            // 
            // btnguardarComp
            // 
            this.btnguardarComp.Location = new System.Drawing.Point(422, 16);
            this.btnguardarComp.Name = "btnguardarComp";
            this.btnguardarComp.Size = new System.Drawing.Size(66, 26);
            this.btnguardarComp.TabIndex = 6;
            this.btnguardarComp.Text = "Guardar";
            this.btnguardarComp.UseVisualStyleBackColor = true;
            this.btnguardarComp.Click += new System.EventHandler(this.btnguardarComp_Click);
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
            this.label2.Location = new System.Drawing.Point(138, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor";
            // 
            // cboprod
            // 
            this.cboprod.FormattingEnabled = true;
            this.cboprod.Location = new System.Drawing.Point(24, 26);
            this.cboprod.Name = "cboprod";
            this.cboprod.Size = new System.Drawing.Size(133, 21);
            this.cboprod.TabIndex = 27;
            this.cboprod.Text = "Nomina";
            this.cboprod.SelectedIndexChanged += new System.EventHandler(this.cboprod_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Lista de Productos Registrados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Totales";
            // 
            // txttot
            // 
            this.txttot.Location = new System.Drawing.Point(575, 375);
            this.txttot.Name = "txttot";
            this.txttot.ReadOnly = true;
            this.txttot.Size = new System.Drawing.Size(71, 20);
            this.txttot.TabIndex = 7;
            // 
            // idCompra
            // 
            this.idCompra.HeaderText = "IdCompra";
            this.idCompra.Name = "idCompra";
            this.idCompra.ReadOnly = true;
            this.idCompra.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 185;
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
            // tot
            // 
            this.tot.HeaderText = "Total";
            this.tot.Name = "tot";
            this.tot.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboprod);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 60);
            this.panel1.TabIndex = 29;
            // 
            // MscCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(726, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txttot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgcompra);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnregistrarComp);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MscCompra";
            this.Text = "MscCompra";
            this.Load += new System.EventHandler(this.MscCompra_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnregistrarComp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnguardarComp;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtvalorComp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcantidadComp;
        private System.Windows.Forms.ComboBox cboprod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttot;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tot;
        private System.Windows.Forms.Panel panel1;
    }
}