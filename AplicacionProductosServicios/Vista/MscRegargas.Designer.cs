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
            this.txtpines = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsalirRecarga = new System.Windows.Forms.Button();
            this.btnregRecaRecarga = new System.Windows.Forms.Button();
            this.txtbusRecarga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgrecarga = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbovalor = new System.Windows.Forms.ComboBox();
            this.txtNumRecarga = new System.Windows.Forms.TextBox();
            this.btnguardarRecarga = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrecarga)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtpines
            // 
            this.txtpines.BackColor = System.Drawing.SystemColors.Control;
            this.txtpines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpines.Enabled = false;
            this.txtpines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpines.ForeColor = System.Drawing.Color.Crimson;
            this.txtpines.Location = new System.Drawing.Point(576, 7);
            this.txtpines.Multiline = true;
            this.txtpines.Name = "txtpines";
            this.txtpines.Size = new System.Drawing.Size(76, 30);
            this.txtpines.TabIndex = 48;
            this.txtpines.Text = "800";
            this.txtpines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Image = global::AplicacionProductosServicios.Properties.Resources.lupa_de_buscar1;
            this.btnbuscar.Location = new System.Drawing.Point(439, 9);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(29, 27);
            this.btnbuscar.TabIndex = 47;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(523, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Pines";
            // 
            // btnsalirRecarga
            // 
            this.btnsalirRecarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirRecarga.Location = new System.Drawing.Point(539, 117);
            this.btnsalirRecarga.Name = "btnsalirRecarga";
            this.btnsalirRecarga.Size = new System.Drawing.Size(113, 23);
            this.btnsalirRecarga.TabIndex = 46;
            this.btnsalirRecarga.Text = "Salir";
            this.btnsalirRecarga.UseVisualStyleBackColor = true;
            this.btnsalirRecarga.Click += new System.EventHandler(this.btnsalirRecarga_Click);
            // 
            // btnregRecaRecarga
            // 
            this.btnregRecaRecarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregRecaRecarga.Location = new System.Drawing.Point(26, 32);
            this.btnregRecaRecarga.Name = "btnregRecaRecarga";
            this.btnregRecaRecarga.Size = new System.Drawing.Size(113, 24);
            this.btnregRecaRecarga.TabIndex = 41;
            this.btnregRecaRecarga.Text = "&Registrar ";
            this.btnregRecaRecarga.UseVisualStyleBackColor = true;
            this.btnregRecaRecarga.Click += new System.EventHandler(this.btnregRecaRecarga_Click_1);
            // 
            // txtbusRecarga
            // 
            this.txtbusRecarga.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusRecarga.Location = new System.Drawing.Point(292, 10);
            this.txtbusRecarga.Name = "txtbusRecarga";
            this.txtbusRecarga.Size = new System.Drawing.Size(141, 21);
            this.txtbusRecarga.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Buscar Número";
            // 
            // dgrecarga
            // 
            this.dgrecarga.AllowUserToAddRows = false;
            this.dgrecarga.AllowUserToDeleteRows = false;
            this.dgrecarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrecarga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column5,
            this.Column2});
            this.dgrecarga.Location = new System.Drawing.Point(52, 202);
            this.dgrecarga.Name = "dgrecarga";
            this.dgrecarga.ReadOnly = true;
            this.dgrecarga.Size = new System.Drawing.Size(416, 178);
            this.dgrecarga.TabIndex = 43;
            this.dgrecarga.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrecarga_CellClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "idRecarga";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Valor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbovalor);
            this.groupBox1.Controls.Add(this.txtNumRecarga);
            this.groupBox1.Controls.Add(this.btnguardarRecarga);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 109);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Recarga";
            // 
            // cbovalor
            // 
            this.cbovalor.FormattingEnabled = true;
            this.cbovalor.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "6",
            "10",
            "20",
            "100"});
            this.cbovalor.Location = new System.Drawing.Point(329, 30);
            this.cbovalor.Name = "cbovalor";
            this.cbovalor.Size = new System.Drawing.Size(73, 24);
            this.cbovalor.TabIndex = 4;
            // 
            // txtNumRecarga
            // 
            this.txtNumRecarga.Location = new System.Drawing.Point(90, 30);
            this.txtNumRecarga.Name = "txtNumRecarga";
            this.txtNumRecarga.Size = new System.Drawing.Size(157, 22);
            this.txtNumRecarga.TabIndex = 3;
            // 
            // btnguardarRecarga
            // 
            this.btnguardarRecarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarRecarga.Location = new System.Drawing.Point(290, 70);
            this.btnguardarRecarga.Name = "btnguardarRecarga";
            this.btnguardarRecarga.Size = new System.Drawing.Size(135, 31);
            this.btnguardarRecarga.TabIndex = 3;
            this.btnguardarRecarga.Text = "&Guardar";
            this.btnguardarRecarga.UseVisualStyleBackColor = true;
            this.btnguardarRecarga.Click += new System.EventHandler(this.btnguardarRecarga_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 33);
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
            // MscRegargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 394);
            this.Controls.Add(this.txtpines);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsalirRecarga);
            this.Controls.Add(this.btnregRecaRecarga);
            this.Controls.Add(this.txtbusRecarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgrecarga);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MscRegargas";
            this.Text = "MscRegargas";
            this.Load += new System.EventHandler(this.MscRegargas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrecarga)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpines;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsalirRecarga;
        private System.Windows.Forms.Button btnregRecaRecarga;
        private System.Windows.Forms.TextBox txtbusRecarga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgrecarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbovalor;
        private System.Windows.Forms.TextBox txtNumRecarga;
        private System.Windows.Forms.Button btnguardarRecarga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}