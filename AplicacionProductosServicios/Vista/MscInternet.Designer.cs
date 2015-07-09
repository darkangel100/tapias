namespace AplicacionProductosServicios.Vista
{
    partial class MscInternet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MscInternet));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtconsumointernet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.dginternet = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnregistar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblsnombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblfacha = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtpbus = new System.Windows.Forms.DateTimePicker();
            this.txttotcon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dginternet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dt2);
            this.groupBox2.Controls.Add(this.dtp1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(74, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 53);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de busqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(495, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(29, 27);
            this.btnBuscar.TabIndex = 59;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Buscar ";
            // 
            // dt2
            // 
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt2.Location = new System.Drawing.Point(380, 20);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(97, 20);
            this.dt2.TabIndex = 18;
            this.dt2.Value = new System.DateTime(2015, 7, 3, 0, 0, 0, 0);
            this.dt2.CloseUp += new System.EventHandler(this.dt2_CloseUp);
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(55, 20);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(97, 20);
            this.dtp1.TabIndex = 16;
            this.dtp1.Value = new System.DateTime(2015, 7, 3, 0, 0, 0, 0);
            this.dtp1.CloseUp += new System.EventHandler(this.dtp1_CloseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hasta ";
            // 
            // txtconsumointernet
            // 
            this.txtconsumointernet.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtconsumointernet.Enabled = false;
            this.txtconsumointernet.Location = new System.Drawing.Point(362, 78);
            this.txtconsumointernet.MaxLength = 6;
            this.txtconsumointernet.Name = "txtconsumointernet";
            this.txtconsumointernet.Size = new System.Drawing.Size(127, 20);
            this.txtconsumointernet.TabIndex = 26;
            this.txtconsumointernet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtconsumointernet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtconsumointernet_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(204, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ingresar Consumo\r\n";
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Font = new System.Drawing.Font("Corbel", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(37, 234);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(137, 29);
            this.btnmodificar.TabIndex = 23;
            this.btnmodificar.Text = "Modificar valor";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // dginternet
            // 
            this.dginternet.AllowUserToAddRows = false;
            this.dginternet.AllowUserToDeleteRows = false;
            this.dginternet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dginternet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dginternet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.VALOR});
            this.dginternet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dginternet.Location = new System.Drawing.Point(227, 144);
            this.dginternet.Name = "dginternet";
            this.dginternet.ReadOnly = true;
            this.dginternet.Size = new System.Drawing.Size(294, 167);
            this.dginternet.TabIndex = 21;
            this.dginternet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dginternet_CellClick);
            this.dginternet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dginternet_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "Valor";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnguardar.Enabled = false;
            this.btnguardar.Font = new System.Drawing.Font("Corbel", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(37, 174);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(137, 29);
            this.btnguardar.TabIndex = 28;
            this.btnguardar.Text = "Guardar Datos";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnregistar
            // 
            this.btnregistar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnregistar.Font = new System.Drawing.Font("Corbel", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistar.Location = new System.Drawing.Point(37, 114);
            this.btnregistar.Name = "btnregistar";
            this.btnregistar.Size = new System.Drawing.Size(137, 29);
            this.btnregistar.TabIndex = 29;
            this.btnregistar.Text = "Registrar Consumo";
            this.btnregistar.UseVisualStyleBackColor = false;
            this.btnregistar.Click += new System.EventHandler(this.btnregistar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnsalir.Font = new System.Drawing.Font("Corbel", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(37, 294);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(137, 29);
            this.btnsalir.TabIndex = 24;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblsnombre,
            this.lblfacha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 367);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(706, 22);
            this.statusStrip1.TabIndex = 66;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblsnombre
            // 
            this.lblsnombre.Name = "lblsnombre";
            this.lblsnombre.Size = new System.Drawing.Size(0, 17);
            // 
            // lblfacha
            // 
            this.lblfacha.Name = "lblfacha";
            this.lblfacha.Size = new System.Drawing.Size(0, 17);
            // 
            // dtpbus
            // 
            this.dtpbus.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpbus.Location = new System.Drawing.Point(686, 344);
            this.dtpbus.Name = "dtpbus";
            this.dtpbus.Size = new System.Drawing.Size(20, 20);
            this.dtpbus.TabIndex = 60;
            this.dtpbus.Visible = false;
            // 
            // txttotcon
            // 
            this.txttotcon.BackColor = System.Drawing.Color.LawnGreen;
            this.txttotcon.Enabled = false;
            this.txttotcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotcon.ForeColor = System.Drawing.Color.Black;
            this.txttotcon.Location = new System.Drawing.Point(411, 333);
            this.txttotcon.MaxLength = 6;
            this.txttotcon.Name = "txttotcon";
            this.txttotcon.ReadOnly = true;
            this.txttotcon.Size = new System.Drawing.Size(95, 24);
            this.txttotcon.TabIndex = 67;
            this.txttotcon.Text = "$";
            this.txttotcon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(223, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 68;
            this.label1.Text = "Total de Consumo";
            // 
            // MscInternet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttotcon);
            this.Controls.Add(this.dtpbus);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnregistar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtconsumointernet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.dginternet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MscInternet";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "MscInternet";
            this.Load += new System.EventHandler(this.MscInternet_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dginternet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtconsumointernet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.DataGridView dginternet;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnregistar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblsnombre;
        private System.Windows.Forms.ToolStripStatusLabel lblfacha;
        private System.Windows.Forms.DateTimePicker dtpbus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.TextBox txttotcon;
        private System.Windows.Forms.Label label1;
    }
}