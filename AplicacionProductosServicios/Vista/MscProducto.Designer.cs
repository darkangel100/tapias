namespace AplicacionProductosServicios.Vista
{
    partial class MscProducto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbpasivoProd = new System.Windows.Forms.RadioButton();
            this.rdbactivoProd = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtpreciovent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtcantgan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpreComp = new System.Windows.Forms.TextBox();
            this.txtnompro = new System.Windows.Forms.TextBox();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscaProd = new System.Windows.Forms.Button();
            this.txtbusqProd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboOpcionBusProd = new System.Windows.Forms.ComboBox();
            this.btnguardarProd = new System.Windows.Forms.Button();
            this.btnsalirProd = new System.Windows.Forms.Button();
            this.btnmodificarProd = new System.Windows.Forms.Button();
            this.btningresaProd = new System.Windows.Forms.Button();
            this.dgProducto = new System.Windows.Forms.DataGridView();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(58, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 252);
            this.panel1.TabIndex = 72;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbpasivoProd);
            this.groupBox1.Controls.Add(this.rdbactivoProd);
            this.groupBox1.Location = new System.Drawing.Point(336, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 100);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado del Producto";
            // 
            // rdbpasivoProd
            // 
            this.rdbpasivoProd.AutoSize = true;
            this.rdbpasivoProd.Location = new System.Drawing.Point(7, 63);
            this.rdbpasivoProd.Name = "rdbpasivoProd";
            this.rdbpasivoProd.Size = new System.Drawing.Size(57, 17);
            this.rdbpasivoProd.TabIndex = 1;
            this.rdbpasivoProd.TabStop = true;
            this.rdbpasivoProd.Text = "Pasivo";
            this.rdbpasivoProd.UseVisualStyleBackColor = true;
            // 
            // rdbactivoProd
            // 
            this.rdbactivoProd.AutoSize = true;
            this.rdbactivoProd.Location = new System.Drawing.Point(7, 27);
            this.rdbactivoProd.Name = "rdbactivoProd";
            this.rdbactivoProd.Size = new System.Drawing.Size(55, 17);
            this.rdbactivoProd.TabIndex = 0;
            this.rdbactivoProd.TabStop = true;
            this.rdbactivoProd.Text = "Activo";
            this.rdbactivoProd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.txtpreciovent);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtstock);
            this.groupBox2.Controls.Add(this.txtcantgan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtpreComp);
            this.groupBox2.Controls.Add(this.txtnompro);
            this.groupBox2.Controls.Add(this.txtCodProd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(36, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 232);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Producto";
            // 
            // txtpreciovent
            // 
            this.txtpreciovent.Location = new System.Drawing.Point(85, 204);
            this.txtpreciovent.Name = "txtpreciovent";
            this.txtpreciovent.Size = new System.Drawing.Size(100, 20);
            this.txtpreciovent.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Precio Venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(74, 81);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(80, 20);
            this.txtstock.TabIndex = 7;
            // 
            // txtcantgan
            // 
            this.txtcantgan.Location = new System.Drawing.Point(91, 156);
            this.txtcantgan.Name = "txtcantgan";
            this.txtcantgan.Size = new System.Drawing.Size(80, 20);
            this.txtcantgan.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cant Ganancia";
            // 
            // txtpreComp
            // 
            this.txtpreComp.Location = new System.Drawing.Point(89, 112);
            this.txtpreComp.Name = "txtpreComp";
            this.txtpreComp.Size = new System.Drawing.Size(80, 20);
            this.txtpreComp.TabIndex = 6;
            // 
            // txtnompro
            // 
            this.txtnompro.Location = new System.Drawing.Point(74, 52);
            this.txtnompro.Name = "txtnompro";
            this.txtnompro.Size = new System.Drawing.Size(80, 20);
            this.txtnompro.TabIndex = 5;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(74, 24);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(80, 20);
            this.txtCodProd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // btnbuscaProd
            // 
            this.btnbuscaProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscaProd.Location = new System.Drawing.Point(600, 21);
            this.btnbuscaProd.Name = "btnbuscaProd";
            this.btnbuscaProd.Size = new System.Drawing.Size(29, 27);
            this.btnbuscaProd.TabIndex = 71;
            this.btnbuscaProd.UseVisualStyleBackColor = true;
            // 
            // txtbusqProd
            // 
            this.txtbusqProd.Location = new System.Drawing.Point(494, 24);
            this.txtbusqProd.Name = "txtbusqProd";
            this.txtbusqProd.Size = new System.Drawing.Size(100, 20);
            this.txtbusqProd.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(295, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Buscar";
            // 
            // cboOpcionBusProd
            // 
            this.cboOpcionBusProd.FormattingEnabled = true;
            this.cboOpcionBusProd.Items.AddRange(new object[] {
            "Nombre",
            "Còdigo"});
            this.cboOpcionBusProd.Location = new System.Drawing.Point(357, 21);
            this.cboOpcionBusProd.Name = "cboOpcionBusProd";
            this.cboOpcionBusProd.Size = new System.Drawing.Size(121, 21);
            this.cboOpcionBusProd.TabIndex = 68;
            this.cboOpcionBusProd.Text = "opcion de busqueda";
            // 
            // btnguardarProd
            // 
            this.btnguardarProd.Location = new System.Drawing.Point(82, 327);
            this.btnguardarProd.Name = "btnguardarProd";
            this.btnguardarProd.Size = new System.Drawing.Size(75, 23);
            this.btnguardarProd.TabIndex = 67;
            this.btnguardarProd.Text = "Guardar";
            this.btnguardarProd.UseVisualStyleBackColor = true;
            this.btnguardarProd.Click += new System.EventHandler(this.btnguardarProd_Click);
            // 
            // btnsalirProd
            // 
            this.btnsalirProd.Location = new System.Drawing.Point(315, 327);
            this.btnsalirProd.Name = "btnsalirProd";
            this.btnsalirProd.Size = new System.Drawing.Size(98, 23);
            this.btnsalirProd.TabIndex = 66;
            this.btnsalirProd.Text = "Salir";
            this.btnsalirProd.UseVisualStyleBackColor = true;
            // 
            // btnmodificarProd
            // 
            this.btnmodificarProd.Location = new System.Drawing.Point(185, 327);
            this.btnmodificarProd.Name = "btnmodificarProd";
            this.btnmodificarProd.Size = new System.Drawing.Size(75, 23);
            this.btnmodificarProd.TabIndex = 65;
            this.btnmodificarProd.Text = "Modificar";
            this.btnmodificarProd.UseVisualStyleBackColor = true;
            this.btnmodificarProd.Click += new System.EventHandler(this.btnmodificarProd_Click_1);
            // 
            // btningresaProd
            // 
            this.btningresaProd.Location = new System.Drawing.Point(35, 36);
            this.btningresaProd.Name = "btningresaProd";
            this.btningresaProd.Size = new System.Drawing.Size(117, 27);
            this.btningresaProd.TabIndex = 64;
            this.btningresaProd.Text = "Ingresar Producto ";
            this.btningresaProd.UseVisualStyleBackColor = true;
            this.btningresaProd.Click += new System.EventHandler(this.btningresaProd_Click_1);
            // 
            // dgProducto
            // 
            this.dgProducto.AllowUserToAddRows = false;
            this.dgProducto.AllowUserToDeleteRows = false;
            this.dgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproducto,
            this.Nombre,
            this.ssss,
            this.Column2,
            this.Column1,
            this.Tot});
            this.dgProducto.Location = new System.Drawing.Point(35, 374);
            this.dgProducto.Name = "dgProducto";
            this.dgProducto.ReadOnly = true;
            this.dgProducto.Size = new System.Drawing.Size(645, 153);
            this.dgProducto.TabIndex = 63;
            // 
            // idproducto
            // 
            this.idproducto.HeaderText = "CodProducto";
            this.idproducto.Name = "idproducto";
            this.idproducto.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // ssss
            // 
            this.ssss.HeaderText = "PreCompra";
            this.ssss.Name = "ssss";
            this.ssss.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio Venta";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Stock";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Tot
            // 
            this.Tot.HeaderText = "Cant Ganancia";
            this.Tot.Name = "Tot";
            this.Tot.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 62;
            // 
            // MscProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnbuscaProd);
            this.Controls.Add(this.txtbusqProd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboOpcionBusProd);
            this.Controls.Add(this.btnguardarProd);
            this.Controls.Add(this.btnsalirProd);
            this.Controls.Add(this.btnmodificarProd);
            this.Controls.Add(this.btningresaProd);
            this.Controls.Add(this.dgProducto);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "MscProducto";
            this.Text = "MscProducto";
            this.Load += new System.EventHandler(this.MscProducto_Load_1);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbpasivoProd;
        private System.Windows.Forms.RadioButton rdbactivoProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtpreciovent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtcantgan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpreComp;
        private System.Windows.Forms.TextBox txtnompro;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscaProd;
        private System.Windows.Forms.TextBox txtbusqProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboOpcionBusProd;
        private System.Windows.Forms.Button btnguardarProd;
        private System.Windows.Forms.Button btnsalirProd;
        private System.Windows.Forms.Button btnmodificarProd;
        private System.Windows.Forms.Button btningresaProd;
        private System.Windows.Forms.DataGridView dgProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tot;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;

    }
}