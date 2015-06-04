namespace AplicacionProductosServicios.Vista
{
    partial class MscRegargas
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
            this.btnsalirRecarga = new System.Windows.Forms.Button();
            this.btnregRecaRecarga = new System.Windows.Forms.Button();
            this.btnmodifRecarga = new System.Windows.Forms.Button();
            this.txtbusRecarga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgregarga = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbvalor = new System.Windows.Forms.ComboBox();
            this.txttransRecarga = new System.Windows.Forms.TextBox();
            this.txtNumRecarga = new System.Windows.Forms.TextBox();
            this.btnguardarRecarga = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgregarga)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalirRecarga
            // 
            this.btnsalirRecarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirRecarga.Location = new System.Drawing.Point(309, 174);
            this.btnsalirRecarga.Name = "btnsalirRecarga";
            this.btnsalirRecarga.Size = new System.Drawing.Size(113, 23);
            this.btnsalirRecarga.TabIndex = 28;
            this.btnsalirRecarga.Text = "Salir";
            this.btnsalirRecarga.UseVisualStyleBackColor = true;
            // 
            // btnregRecaRecarga
            // 
            this.btnregRecaRecarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregRecaRecarga.Location = new System.Drawing.Point(309, 68);
            this.btnregRecaRecarga.Name = "btnregRecaRecarga";
            this.btnregRecaRecarga.Size = new System.Drawing.Size(113, 24);
            this.btnregRecaRecarga.TabIndex = 22;
            this.btnregRecaRecarga.Text = "&Registrar ";
            this.btnregRecaRecarga.UseVisualStyleBackColor = true;
            this.btnregRecaRecarga.Click += new System.EventHandler(this.btnregRecaRecarga_Click);
            // 
            // btnmodifRecarga
            // 
            this.btnmodifRecarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifRecarga.Location = new System.Drawing.Point(309, 125);
            this.btnmodifRecarga.Name = "btnmodifRecarga";
            this.btnmodifRecarga.Size = new System.Drawing.Size(113, 23);
            this.btnmodifRecarga.TabIndex = 27;
            this.btnmodifRecarga.Text = "&Modificar";
            this.btnmodifRecarga.UseVisualStyleBackColor = true;
            // 
            // txtbusRecarga
            // 
            this.txtbusRecarga.Font = new System.Drawing.Font("Perpetua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusRecarga.Location = new System.Drawing.Point(451, 10);
            this.txtbusRecarga.Name = "txtbusRecarga";
            this.txtbusRecarga.Size = new System.Drawing.Size(141, 20);
            this.txtbusRecarga.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Buscar Número";
            // 
            // dgregarga
            // 
            this.dgregarga.AllowUserToAddRows = false;
            this.dgregarga.AllowUserToDeleteRows = false;
            this.dgregarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgregarga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dgregarga.Location = new System.Drawing.Point(22, 256);
            this.dgregarga.Name = "dgregarga";
            this.dgregarga.ReadOnly = true;
            this.dgregarga.Size = new System.Drawing.Size(542, 147);
            this.dgregarga.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Valor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Transferencia";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Valor Adicional";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbvalor);
            this.groupBox1.Controls.Add(this.txttransRecarga);
            this.groupBox1.Controls.Add(this.txtNumRecarga);
            this.groupBox1.Controls.Add(this.btnguardarRecarga);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 171);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Recarga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transferencia";
            // 
            // cmbvalor
            // 
            this.cmbvalor.FormattingEnabled = true;
            this.cmbvalor.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "6",
            "10",
            "20",
            "100"});
            this.cmbvalor.Location = new System.Drawing.Point(117, 62);
            this.cmbvalor.Name = "cmbvalor";
            this.cmbvalor.Size = new System.Drawing.Size(73, 24);
            this.cmbvalor.TabIndex = 4;
            // 
            // txttransRecarga
            // 
            this.txttransRecarga.Location = new System.Drawing.Point(117, 102);
            this.txttransRecarga.Name = "txttransRecarga";
            this.txttransRecarga.Size = new System.Drawing.Size(98, 22);
            this.txttransRecarga.TabIndex = 3;
            // 
            // txtNumRecarga
            // 
            this.txtNumRecarga.Location = new System.Drawing.Point(117, 30);
            this.txtNumRecarga.Name = "txtNumRecarga";
            this.txtNumRecarga.Size = new System.Drawing.Size(130, 22);
            this.txtNumRecarga.TabIndex = 3;
            // 
            // btnguardarRecarga
            // 
            this.btnguardarRecarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarRecarga.Location = new System.Drawing.Point(92, 139);
            this.btnguardarRecarga.Name = "btnguardarRecarga";
            this.btnguardarRecarga.Size = new System.Drawing.Size(135, 23);
            this.btnguardarRecarga.TabIndex = 3;
            this.btnguardarRecarga.Text = "&Guardar";
            this.btnguardarRecarga.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Image = global::AplicacionProductosServicios.Properties.Resources.lupa_de_buscar1;
            this.btnbuscar.Location = new System.Drawing.Point(598, 9);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(29, 27);
            this.btnbuscar.TabIndex = 29;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // MscRegargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 449);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnsalirRecarga);
            this.Controls.Add(this.btnregRecaRecarga);
            this.Controls.Add(this.btnmodifRecarga);
            this.Controls.Add(this.txtbusRecarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgregarga);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MscRegargas";
            this.Text = "MscRegargas";
            ((System.ComponentModel.ISupportInitialize)(this.dgregarga)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnsalirRecarga;
        private System.Windows.Forms.Button btnregRecaRecarga;
        private System.Windows.Forms.Button btnmodifRecarga;
        private System.Windows.Forms.TextBox txtbusRecarga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgregarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbvalor;
        private System.Windows.Forms.TextBox txttransRecarga;
        private System.Windows.Forms.TextBox txtNumRecarga;
        private System.Windows.Forms.Button btnguardarRecarga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}