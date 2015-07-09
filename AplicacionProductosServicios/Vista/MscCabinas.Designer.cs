namespace AplicacionProductosServicios.Vista
{
    partial class MscCabinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MscCabinas));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtphast = new System.Windows.Forms.DateTimePicker();
            this.dtpdes = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txttotcab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgCabinas = new System.Windows.Forms.DataGridView();
            this.idcabinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtconsumocab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCabinas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtphast);
            this.groupBox2.Controls.Add(this.dtpdes);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 46);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de busqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(383, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(29, 27);
            this.btnBuscar.TabIndex = 60;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Buscar  Desde ";
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
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(256, 102);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 28;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(144, 102);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 27;
            this.btnmodificar.Text = "&Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(21, 102);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 26;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txttotcab
            // 
            this.txttotcab.Location = new System.Drawing.Point(256, 308);
            this.txttotcab.Name = "txttotcab";
            this.txttotcab.Size = new System.Drawing.Size(100, 20);
            this.txttotcab.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Total";
            // 
            // dgCabinas
            // 
            this.dgCabinas.AllowUserToAddRows = false;
            this.dgCabinas.AllowUserToDeleteRows = false;
            this.dgCabinas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgCabinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCabinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcabinas,
            this.Column1,
            this.Column2});
            this.dgCabinas.Location = new System.Drawing.Point(110, 154);
            this.dgCabinas.Name = "dgCabinas";
            this.dgCabinas.ReadOnly = true;
            this.dgCabinas.Size = new System.Drawing.Size(246, 148);
            this.dgCabinas.TabIndex = 23;
            this.dgCabinas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCabinas_CellClick);
            // 
            // idcabinas
            // 
            this.idcabinas.HeaderText = "IdCabinas";
            this.idcabinas.Name = "idcabinas";
            this.idcabinas.ReadOnly = true;
            this.idcabinas.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Consumo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // txtconsumocab
            // 
            this.txtconsumocab.Location = new System.Drawing.Point(231, 76);
            this.txtconsumocab.Name = "txtconsumocab";
            this.txtconsumocab.Size = new System.Drawing.Size(100, 20);
            this.txtconsumocab.TabIndex = 22;
            this.txtconsumocab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtconsumocab_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ingrese el consumo de cabinas";
            // 
            // MscCabinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(444, 334);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txttotcab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgCabinas);
            this.Controls.Add(this.txtconsumocab);
            this.Controls.Add(this.label1);
            this.Name = "MscCabinas";
            this.Text = "MscCabinas";
            this.Load += new System.EventHandler(this.MscCabinas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCabinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtphast;
        private System.Windows.Forms.DateTimePicker dtpdes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txttotcab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgCabinas;
        private System.Windows.Forms.TextBox txtconsumocab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcabinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnBuscar;
    }
}