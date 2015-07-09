namespace AplicacionProductosServicios.Vista
{
    partial class MscEgresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MscEgresos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbuscarEgre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtphast = new System.Windows.Forms.DateTimePicker();
            this.dtpdes = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsalirE = new System.Windows.Forms.Button();
            this.dgegresos = new System.Windows.Forms.DataGridView();
            this.idegresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbinternet = new System.Windows.Forms.RadioButton();
            this.rdbcabina = new System.Windows.Forms.RadioButton();
            this.rdbrecarga = new System.Windows.Forms.RadioButton();
            this.btnguardarE = new System.Windows.Forms.Button();
            this.txtdetalleE = new System.Windows.Forms.TextBox();
            this.txtvalorE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnmodificarE = new System.Windows.Forms.Button();
            this.btnregistrarE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotrec = new System.Windows.Forms.TextBox();
            this.txttotint = new System.Windows.Forms.TextBox();
            this.txttotcab = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgegresos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnbuscarEgre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtphast);
            this.groupBox2.Controls.Add(this.dtpdes);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 46);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de busqueda";
            // 
            // btnbuscarEgre
            // 
            this.btnbuscarEgre.BackgroundImage = global::AplicacionProductosServicios.Properties.Resources.lupa_de_buscar;
            this.btnbuscarEgre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscarEgre.Location = new System.Drawing.Point(383, 12);
            this.btnbuscarEgre.Name = "btnbuscarEgre";
            this.btnbuscarEgre.Size = new System.Drawing.Size(29, 27);
            this.btnbuscarEgre.TabIndex = 28;
            this.btnbuscarEgre.UseVisualStyleBackColor = true;
            this.btnbuscarEgre.Click += new System.EventHandler(this.btnbuscarEgre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Buscar Desde ";
            // 
            // dtphast
            // 
            this.dtphast.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtphast.Location = new System.Drawing.Point(280, 20);
            this.dtphast.Name = "dtphast";
            this.dtphast.Size = new System.Drawing.Size(97, 20);
            this.dtphast.TabIndex = 18;
            // 
            // dtpdes
            // 
            this.dtpdes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdes.Location = new System.Drawing.Point(120, 20);
            this.dtpdes.Name = "dtpdes";
            this.dtpdes.Size = new System.Drawing.Size(97, 20);
            this.dtpdes.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hasta ";
            // 
            // btnsalirE
            // 
            this.btnsalirE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirE.Location = new System.Drawing.Point(426, 241);
            this.btnsalirE.Name = "btnsalirE";
            this.btnsalirE.Size = new System.Drawing.Size(111, 26);
            this.btnsalirE.TabIndex = 26;
            this.btnsalirE.Text = "Salir";
            this.btnsalirE.UseVisualStyleBackColor = true;
            this.btnsalirE.Click += new System.EventHandler(this.btnsalirE_Click);
            // 
            // dgegresos
            // 
            this.dgegresos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgegresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgegresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idegresos,
            this.Column1,
            this.Column2,
            this.Column3,
            this.categoria});
            this.dgegresos.Location = new System.Drawing.Point(51, 278);
            this.dgegresos.Name = "dgegresos";
            this.dgegresos.Size = new System.Drawing.Size(445, 150);
            this.dgegresos.TabIndex = 25;
            this.dgegresos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgegresos_CellClick);
            // 
            // idegresos
            // 
            this.idegresos.HeaderText = "Id Egresos";
            this.idegresos.Name = "idegresos";
            this.idegresos.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Detalle";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor";
            this.Column3.Name = "Column3";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.rdbinternet);
            this.groupBox1.Controls.Add(this.rdbcabina);
            this.groupBox1.Controls.Add(this.rdbrecarga);
            this.groupBox1.Controls.Add(this.btnguardarE);
            this.groupBox1.Controls.Add(this.txtdetalleE);
            this.groupBox1.Controls.Add(this.txtvalorE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 94);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // rdbinternet
            // 
            this.rdbinternet.AutoSize = true;
            this.rdbinternet.Location = new System.Drawing.Point(258, 63);
            this.rdbinternet.Name = "rdbinternet";
            this.rdbinternet.Size = new System.Drawing.Size(69, 17);
            this.rdbinternet.TabIndex = 9;
            this.rdbinternet.TabStop = true;
            this.rdbinternet.Text = "Internet";
            this.rdbinternet.UseVisualStyleBackColor = true;
            // 
            // rdbcabina
            // 
            this.rdbcabina.AutoSize = true;
            this.rdbcabina.Location = new System.Drawing.Point(122, 63);
            this.rdbcabina.Name = "rdbcabina";
            this.rdbcabina.Size = new System.Drawing.Size(70, 17);
            this.rdbcabina.TabIndex = 8;
            this.rdbcabina.TabStop = true;
            this.rdbcabina.Text = "Cabinas";
            this.rdbcabina.UseVisualStyleBackColor = true;
            // 
            // rdbrecarga
            // 
            this.rdbrecarga.AutoSize = true;
            this.rdbrecarga.Location = new System.Drawing.Point(9, 63);
            this.rdbrecarga.Name = "rdbrecarga";
            this.rdbrecarga.Size = new System.Drawing.Size(73, 17);
            this.rdbrecarga.TabIndex = 7;
            this.rdbrecarga.TabStop = true;
            this.rdbrecarga.Text = "Recarga";
            this.rdbrecarga.UseVisualStyleBackColor = true;
            // 
            // btnguardarE
            // 
            this.btnguardarE.Location = new System.Drawing.Point(425, 25);
            this.btnguardarE.Name = "btnguardarE";
            this.btnguardarE.Size = new System.Drawing.Size(66, 26);
            this.btnguardarE.TabIndex = 6;
            this.btnguardarE.Text = "Guardar";
            this.btnguardarE.UseVisualStyleBackColor = true;
            this.btnguardarE.Click += new System.EventHandler(this.btnguardarE_Click);
            // 
            // txtdetalleE
            // 
            this.txtdetalleE.Location = new System.Drawing.Point(288, 22);
            this.txtdetalleE.Name = "txtdetalleE";
            this.txtdetalleE.Size = new System.Drawing.Size(100, 20);
            this.txtdetalleE.TabIndex = 5;
            this.txtdetalleE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdetalleE_KeyPress);
            // 
            // txtvalorE
            // 
            this.txtvalorE.Location = new System.Drawing.Point(73, 22);
            this.txtvalorE.Name = "txtvalorE";
            this.txtvalorE.Size = new System.Drawing.Size(100, 20);
            this.txtvalorE.TabIndex = 3;
            this.txtvalorE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorE_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Detalle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor";
            // 
            // btnmodificarE
            // 
            this.btnmodificarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificarE.Location = new System.Drawing.Point(265, 241);
            this.btnmodificarE.Name = "btnmodificarE";
            this.btnmodificarE.Size = new System.Drawing.Size(111, 26);
            this.btnmodificarE.TabIndex = 23;
            this.btnmodificarE.Text = "Modificar Egresoso";
            this.btnmodificarE.UseVisualStyleBackColor = true;
            this.btnmodificarE.Click += new System.EventHandler(this.btnmodificarE_Click);
            // 
            // btnregistrarE
            // 
            this.btnregistrarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrarE.Location = new System.Drawing.Point(23, 109);
            this.btnregistrarE.Name = "btnregistrarE";
            this.btnregistrarE.Size = new System.Drawing.Size(111, 26);
            this.btnregistrarE.TabIndex = 22;
            this.btnregistrarE.Text = "Registar Egresos";
            this.btnregistrarE.UseVisualStyleBackColor = true;
            this.btnregistrarE.Click += new System.EventHandler(this.btnregistrarE_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "R";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "I";
            // 
            // txttotrec
            // 
            this.txttotrec.Location = new System.Drawing.Point(471, 42);
            this.txttotrec.Name = "txttotrec";
            this.txttotrec.Size = new System.Drawing.Size(66, 20);
            this.txttotrec.TabIndex = 31;
            // 
            // txttotint
            // 
            this.txttotint.Location = new System.Drawing.Point(471, 110);
            this.txttotint.Name = "txttotint";
            this.txttotint.Size = new System.Drawing.Size(66, 20);
            this.txttotint.TabIndex = 32;
            // 
            // txttotcab
            // 
            this.txttotcab.Location = new System.Drawing.Point(471, 80);
            this.txttotcab.Name = "txttotcab";
            this.txttotcab.Size = new System.Drawing.Size(66, 20);
            this.txttotcab.TabIndex = 33;
            // 
            // MscEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(583, 438);
            this.Controls.Add(this.txttotcab);
            this.Controls.Add(this.txttotint);
            this.Controls.Add(this.txttotrec);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnsalirE);
            this.Controls.Add(this.dgegresos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnmodificarE);
            this.Controls.Add(this.btnregistrarE);
            this.Name = "MscEgresos";
            this.Text = "MscEgresos";
            this.Load += new System.EventHandler(this.MscEgresos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgegresos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtphast;
        private System.Windows.Forms.DateTimePicker dtpdes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsalirE;
        private System.Windows.Forms.DataGridView dgegresos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnguardarE;
        private System.Windows.Forms.TextBox txtdetalleE;
        private System.Windows.Forms.TextBox txtvalorE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmodificarE;
        private System.Windows.Forms.Button btnregistrarE;
        private System.Windows.Forms.RadioButton rdbinternet;
        private System.Windows.Forms.RadioButton rdbcabina;
        private System.Windows.Forms.RadioButton rdbrecarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn idegresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.Button btnbuscarEgre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttotrec;
        private System.Windows.Forms.TextBox txttotint;
        private System.Windows.Forms.TextBox txttotcab;
    }
}