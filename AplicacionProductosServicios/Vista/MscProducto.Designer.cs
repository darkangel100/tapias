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
            this.btnbuscaProd = new System.Windows.Forms.Button();
            this.txtbusProd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboOpcionBusProd = new System.Windows.Forms.ComboBox();
            this.btnguardarProd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcodigoProd = new System.Windows.Forms.TextBox();
            this.txtstockProd = new System.Windows.Forms.TextBox();
            this.txtvalorUnitProd = new System.Windows.Forms.TextBox();
            this.txtnombreProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalirProd = new System.Windows.Forms.Button();
            this.btnmodificarProd = new System.Windows.Forms.Button();
            this.btningresaProd = new System.Windows.Forms.Button();
            this.dgProducto = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbactivoProd = new System.Windows.Forms.RadioButton();
            this.rdbpasivoProd = new System.Windows.Forms.RadioButton();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnbuscaProd
            // 
            this.btnbuscaProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscaProd.Location = new System.Drawing.Point(591, 21);
            this.btnbuscaProd.Name = "btnbuscaProd";
            this.btnbuscaProd.Size = new System.Drawing.Size(29, 27);
            this.btnbuscaProd.TabIndex = 60;
            this.btnbuscaProd.UseVisualStyleBackColor = true;
            // 
            // txtbusProd
            // 
            this.txtbusProd.Location = new System.Drawing.Point(485, 24);
            this.txtbusProd.Name = "txtbusProd";
            this.txtbusProd.Size = new System.Drawing.Size(100, 20);
            this.txtbusProd.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(286, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Buscar";
            // 
            // cboOpcionBusProd
            // 
            this.cboOpcionBusProd.FormattingEnabled = true;
            this.cboOpcionBusProd.Items.AddRange(new object[] {
            "Nombre",
            "Còdigo"});
            this.cboOpcionBusProd.Location = new System.Drawing.Point(348, 21);
            this.cboOpcionBusProd.Name = "cboOpcionBusProd";
            this.cboOpcionBusProd.Size = new System.Drawing.Size(121, 21);
            this.cboOpcionBusProd.TabIndex = 57;
            this.cboOpcionBusProd.Text = "opcion de busqueda";
            // 
            // btnguardarProd
            // 
            this.btnguardarProd.Location = new System.Drawing.Point(43, 225);
            this.btnguardarProd.Name = "btnguardarProd";
            this.btnguardarProd.Size = new System.Drawing.Size(75, 23);
            this.btnguardarProd.TabIndex = 56;
            this.btnguardarProd.Text = "Guardar";
            this.btnguardarProd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.txtcodigoProd);
            this.groupBox2.Controls.Add(this.txtstockProd);
            this.groupBox2.Controls.Add(this.txtvalorUnitProd);
            this.groupBox2.Controls.Add(this.txtnombreProd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(26, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 150);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Producto";
            // 
            // txtcodigoProd
            // 
            this.txtcodigoProd.Location = new System.Drawing.Point(74, 117);
            this.txtcodigoProd.Name = "txtcodigoProd";
            this.txtcodigoProd.Size = new System.Drawing.Size(80, 20);
            this.txtcodigoProd.TabIndex = 7;
            // 
            // txtstockProd
            // 
            this.txtstockProd.Location = new System.Drawing.Point(74, 83);
            this.txtstockProd.Name = "txtstockProd";
            this.txtstockProd.Size = new System.Drawing.Size(80, 20);
            this.txtstockProd.TabIndex = 6;
            // 
            // txtvalorUnitProd
            // 
            this.txtvalorUnitProd.Location = new System.Drawing.Point(74, 52);
            this.txtvalorUnitProd.Name = "txtvalorUnitProd";
            this.txtvalorUnitProd.Size = new System.Drawing.Size(80, 20);
            this.txtvalorUnitProd.TabIndex = 5;
            // 
            // txtnombreProd
            // 
            this.txtnombreProd.Location = new System.Drawing.Point(74, 24);
            this.txtnombreProd.Name = "txtnombreProd";
            this.txtnombreProd.Size = new System.Drawing.Size(80, 20);
            this.txtnombreProd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "v/u";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // btnsalirProd
            // 
            this.btnsalirProd.Location = new System.Drawing.Point(276, 225);
            this.btnsalirProd.Name = "btnsalirProd";
            this.btnsalirProd.Size = new System.Drawing.Size(98, 23);
            this.btnsalirProd.TabIndex = 54;
            this.btnsalirProd.Text = "Salir";
            this.btnsalirProd.UseVisualStyleBackColor = true;
            // 
            // btnmodificarProd
            // 
            this.btnmodificarProd.Location = new System.Drawing.Point(146, 225);
            this.btnmodificarProd.Name = "btnmodificarProd";
            this.btnmodificarProd.Size = new System.Drawing.Size(75, 23);
            this.btnmodificarProd.TabIndex = 53;
            this.btnmodificarProd.Text = "Modificar";
            this.btnmodificarProd.UseVisualStyleBackColor = true;
            // 
            // btningresaProd
            // 
            this.btningresaProd.Location = new System.Drawing.Point(26, 36);
            this.btningresaProd.Name = "btningresaProd";
            this.btningresaProd.Size = new System.Drawing.Size(117, 27);
            this.btningresaProd.TabIndex = 52;
            this.btningresaProd.Text = "Ingresar Producto ";
            this.btningresaProd.UseVisualStyleBackColor = true;
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
            this.Column1,
            this.Tot});
            this.dgProducto.Location = new System.Drawing.Point(43, 258);
            this.dgProducto.Name = "dgProducto";
            this.dgProducto.ReadOnly = true;
            this.dgProducto.Size = new System.Drawing.Size(542, 181);
            this.dgProducto.TabIndex = 51;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbpasivoProd);
            this.groupBox1.Controls.Add(this.rdbactivoProd);
            this.groupBox1.Location = new System.Drawing.Point(326, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 100);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado del Producto";
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
            // idproducto
            // 
            this.idproducto.HeaderText = "IdProducto";
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
            this.ssss.HeaderText = "v/u";
            this.ssss.Name = "ssss";
            this.ssss.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Stock";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Tot
            // 
            this.Tot.HeaderText = "Valor Total";
            this.Tot.Name = "Tot";
            this.Tot.ReadOnly = true;
            // 
            // MscProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnbuscaProd);
            this.Controls.Add(this.txtbusProd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboOpcionBusProd);
            this.Controls.Add(this.btnguardarProd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnsalirProd);
            this.Controls.Add(this.btnmodificarProd);
            this.Controls.Add(this.btningresaProd);
            this.Controls.Add(this.dgProducto);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "MscProducto";
            this.Text = "MscProducto";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscaProd;
        private System.Windows.Forms.TextBox txtbusProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboOpcionBusProd;
        private System.Windows.Forms.Button btnguardarProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcodigoProd;
        private System.Windows.Forms.TextBox txtstockProd;
        private System.Windows.Forms.TextBox txtvalorUnitProd;
        private System.Windows.Forms.TextBox txtnombreProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsalirProd;
        private System.Windows.Forms.Button btnmodificarProd;
        private System.Windows.Forms.Button btningresaProd;
        private System.Windows.Forms.DataGridView dgProducto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbpasivoProd;
        private System.Windows.Forms.RadioButton rdbactivoProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tot;
    }
}