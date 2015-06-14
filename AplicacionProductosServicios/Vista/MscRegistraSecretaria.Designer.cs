namespace AplicacionProductosServicios.Vista
{
    partial class MscRegistraSecretaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MscRegistraSecretaria));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtbusSecret = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboOpcionBus = new System.Windows.Forms.ComboBox();
            this.btnmodificarSecre = new System.Windows.Forms.Button();
            this.dgSecretaria = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsalir_Secret = new System.Windows.Forms.Button();
            this.btnregistrar_secret = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbdesactivo = new System.Windows.Forms.RadioButton();
            this.rdbactivo = new System.Windows.Forms.RadioButton();
            this.txtcedSecret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttelSecret = new System.Windows.Forms.TextBox();
            this.txtdirecSecret = new System.Windows.Forms.TextBox();
            this.btnguardar_Secret = new System.Windows.Forms.Button();
            this.txtnomsecret = new System.Windows.Forms.TextBox();
            this.txtapeSecret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cborol = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSecretaria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(599, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(29, 27);
            this.btnBuscar.TabIndex = 58;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtbusSecret
            // 
            this.txtbusSecret.Location = new System.Drawing.Point(493, 44);
            this.txtbusSecret.Name = "txtbusSecret";
            this.txtbusSecret.Size = new System.Drawing.Size(100, 20);
            this.txtbusSecret.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(294, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Buscar";
            // 
            // cboOpcionBus
            // 
            this.cboOpcionBus.FormattingEnabled = true;
            this.cboOpcionBus.Items.AddRange(new object[] {
            "Cédula",
            "Apellido"});
            this.cboOpcionBus.Location = new System.Drawing.Point(356, 41);
            this.cboOpcionBus.Name = "cboOpcionBus";
            this.cboOpcionBus.Size = new System.Drawing.Size(121, 21);
            this.cboOpcionBus.TabIndex = 55;
            this.cboOpcionBus.Text = "opcion de busqueda";
            // 
            // btnmodificarSecre
            // 
            this.btnmodificarSecre.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificarSecre.Location = new System.Drawing.Point(41, 377);
            this.btnmodificarSecre.Name = "btnmodificarSecre";
            this.btnmodificarSecre.Size = new System.Drawing.Size(103, 25);
            this.btnmodificarSecre.TabIndex = 54;
            this.btnmodificarSecre.Text = "Modificar";
            this.btnmodificarSecre.UseVisualStyleBackColor = true;
            // 
            // dgSecretaria
            // 
            this.dgSecretaria.AllowUserToAddRows = false;
            this.dgSecretaria.AllowUserToDeleteRows = false;
            this.dgSecretaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSecretaria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgSecretaria.Location = new System.Drawing.Point(10, 418);
            this.dgSecretaria.Name = "dgSecretaria";
            this.dgSecretaria.ReadOnly = true;
            this.dgSecretaria.Size = new System.Drawing.Size(646, 152);
            this.dgSecretaria.TabIndex = 53;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cédula";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellidos";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombres";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Dirección";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "teléfono";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Estado";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // dtp2
            // 
            this.dtp2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp2.Location = new System.Drawing.Point(566, 6);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(95, 20);
            this.dtp2.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(519, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Hora";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(390, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Fecha";
            // 
            // btnsalir_Secret
            // 
            this.btnsalir_Secret.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir_Secret.Location = new System.Drawing.Point(356, 376);
            this.btnsalir_Secret.Name = "btnsalir_Secret";
            this.btnsalir_Secret.Size = new System.Drawing.Size(103, 27);
            this.btnsalir_Secret.TabIndex = 48;
            this.btnsalir_Secret.Text = "&salir";
            this.btnsalir_Secret.UseVisualStyleBackColor = true;
            this.btnsalir_Secret.Click += new System.EventHandler(this.btnsalir_Secret_Click);
            // 
            // btnregistrar_secret
            // 
            this.btnregistrar_secret.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar_secret.Location = new System.Drawing.Point(28, 29);
            this.btnregistrar_secret.Name = "btnregistrar_secret";
            this.btnregistrar_secret.Size = new System.Drawing.Size(208, 35);
            this.btnregistrar_secret.TabIndex = 46;
            this.btnregistrar_secret.Text = "Registrar Secretaria";
            this.btnregistrar_secret.UseVisualStyleBackColor = true;
            this.btnregistrar_secret.Click += new System.EventHandler(this.btnregistrar_secret_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cborol);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtclave);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtcedSecret);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txttelSecret);
            this.groupBox1.Controls.Add(this.txtdirecSecret);
            this.groupBox1.Controls.Add(this.btnguardar_Secret);
            this.groupBox1.Controls.Add(this.txtnomsecret);
            this.groupBox1.Controls.Add(this.txtapeSecret);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 284);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales de la Secretaria";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbdesactivo);
            this.groupBox2.Controls.Add(this.rdbactivo);
            this.groupBox2.Location = new System.Drawing.Point(461, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 100);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            // 
            // rdbdesactivo
            // 
            this.rdbdesactivo.AutoSize = true;
            this.rdbdesactivo.Location = new System.Drawing.Point(6, 64);
            this.rdbdesactivo.Name = "rdbdesactivo";
            this.rdbdesactivo.Size = new System.Drawing.Size(91, 21);
            this.rdbdesactivo.TabIndex = 1;
            this.rdbdesactivo.TabStop = true;
            this.rdbdesactivo.Text = "Desactivo";
            this.rdbdesactivo.UseVisualStyleBackColor = true;
            // 
            // rdbactivo
            // 
            this.rdbactivo.AutoSize = true;
            this.rdbactivo.Location = new System.Drawing.Point(7, 37);
            this.rdbactivo.Name = "rdbactivo";
            this.rdbactivo.Size = new System.Drawing.Size(69, 21);
            this.rdbactivo.TabIndex = 0;
            this.rdbactivo.TabStop = true;
            this.rdbactivo.Text = "Activo";
            this.rdbactivo.UseVisualStyleBackColor = true;
            // 
            // txtcedSecret
            // 
            this.txtcedSecret.Location = new System.Drawing.Point(166, 38);
            this.txtcedSecret.Name = "txtcedSecret";
            this.txtcedSecret.Size = new System.Drawing.Size(240, 25);
            this.txtcedSecret.TabIndex = 21;
            this.txtcedSecret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedSecret_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cédula de Identidad";
            // 
            // txttelSecret
            // 
            this.txttelSecret.Location = new System.Drawing.Point(166, 184);
            this.txttelSecret.Name = "txttelSecret";
            this.txttelSecret.Size = new System.Drawing.Size(240, 25);
            this.txttelSecret.TabIndex = 19;
            this.txttelSecret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelSecret_KeyPress);
            // 
            // txtdirecSecret
            // 
            this.txtdirecSecret.Location = new System.Drawing.Point(166, 150);
            this.txtdirecSecret.Name = "txtdirecSecret";
            this.txtdirecSecret.Size = new System.Drawing.Size(240, 25);
            this.txtdirecSecret.TabIndex = 18;
            this.txtdirecSecret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdirecSecret_KeyPress);
            // 
            // btnguardar_Secret
            // 
            this.btnguardar_Secret.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar_Secret.Location = new System.Drawing.Point(440, 238);
            this.btnguardar_Secret.Name = "btnguardar_Secret";
            this.btnguardar_Secret.Size = new System.Drawing.Size(166, 27);
            this.btnguardar_Secret.TabIndex = 22;
            this.btnguardar_Secret.Text = "Guardar Secretaria";
            this.btnguardar_Secret.UseVisualStyleBackColor = true;
            this.btnguardar_Secret.Click += new System.EventHandler(this.btnguardar_Secret_Click);
            // 
            // txtnomsecret
            // 
            this.txtnomsecret.Location = new System.Drawing.Point(166, 111);
            this.txtnomsecret.Name = "txtnomsecret";
            this.txtnomsecret.Size = new System.Drawing.Size(240, 25);
            this.txtnomsecret.TabIndex = 16;
            this.txtnomsecret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnomsecret_KeyPress);
            // 
            // txtapeSecret
            // 
            this.txtapeSecret.Location = new System.Drawing.Point(166, 75);
            this.txtapeSecret.Name = "txtapeSecret";
            this.txtapeSecret.Size = new System.Drawing.Size(240, 25);
            this.txtapeSecret.TabIndex = 15;
            this.txtapeSecret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapeSecret_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombres";
            // 
            // cborol
            // 
            this.cborol.FormattingEnabled = true;
            this.cborol.Location = new System.Drawing.Point(166, 255);
            this.cborol.Name = "cborol";
            this.cborol.Size = new System.Drawing.Size(240, 25);
            this.cborol.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Rol";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(166, 212);
            this.txtclave.MaxLength = 16;
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(240, 25);
            this.txtclave.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Clave";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(543, 165);
            this.txtid.MaxLength = 10;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(62, 25);
            this.txtid.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(458, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Id Persona";
            // 
            // MscRegistraSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 582);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtbusSecret);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboOpcionBus);
            this.Controls.Add(this.btnmodificarSecre);
            this.Controls.Add(this.dgSecretaria);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnsalir_Secret);
            this.Controls.Add(this.btnregistrar_secret);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MscRegistraSecretaria";
            this.Text = "MscRegistraSecretaria";
            this.Load += new System.EventHandler(this.MscRegistraSecretaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSecretaria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtbusSecret;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboOpcionBus;
        private System.Windows.Forms.Button btnmodificarSecre;
        private System.Windows.Forms.DataGridView dgSecretaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsalir_Secret;
        private System.Windows.Forms.Button btnregistrar_secret;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcedSecret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttelSecret;
        private System.Windows.Forms.TextBox txtdirecSecret;
        private System.Windows.Forms.Button btnguardar_Secret;
        private System.Windows.Forms.TextBox txtnomsecret;
        private System.Windows.Forms.TextBox txtapeSecret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbdesactivo;
        private System.Windows.Forms.RadioButton rdbactivo;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cborol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label10;
    }
}