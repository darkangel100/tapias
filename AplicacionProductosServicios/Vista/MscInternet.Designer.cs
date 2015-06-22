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
            this.label4 = new System.Windows.Forms.Label();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtconsumointernet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.dginternet = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnregistar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dginternet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dt2);
            this.groupBox2.Controls.Add(this.dtp1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(3, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 53);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de busqueda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
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
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(55, 20);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(97, 20);
            this.dtp1.TabIndex = 16;
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
            this.txtconsumointernet.Location = new System.Drawing.Point(230, 84);
            this.txtconsumointernet.Name = "txtconsumointernet";
            this.txtconsumointernet.Size = new System.Drawing.Size(145, 20);
            this.txtconsumointernet.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ingresar Consumo\r\n";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(37, 296);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(109, 24);
            this.btnsalir.TabIndex = 24;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(37, 245);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(109, 21);
            this.btnmodificar.TabIndex = 23;
            this.btnmodificar.Text = "Modificar valor";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // dginternet
            // 
            this.dginternet.AllowUserToAddRows = false;
            this.dginternet.AllowUserToDeleteRows = false;
            this.dginternet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dginternet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.VALOR});
            this.dginternet.Location = new System.Drawing.Point(203, 132);
            this.dginternet.Name = "dginternet";
            this.dginternet.ReadOnly = true;
            this.dginternet.Size = new System.Drawing.Size(246, 142);
            this.dginternet.TabIndex = 21;
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
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "Valor";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(37, 188);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(109, 23);
            this.btnguardar.TabIndex = 28;
            this.btnguardar.Text = "Guardar Datos";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btnregistar
            // 
            this.btnregistar.Location = new System.Drawing.Point(37, 132);
            this.btnregistar.Name = "btnregistar";
            this.btnregistar.Size = new System.Drawing.Size(109, 23);
            this.btnregistar.TabIndex = 29;
            this.btnregistar.Text = "Registrar Consumo";
            this.btnregistar.UseVisualStyleBackColor = true;
            this.btnregistar.Click += new System.EventHandler(this.btnregistar_Click);
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
           
            // 
            // MscInternet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 385);
            this.Controls.Add(this.btnregistar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtconsumointernet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.dginternet);
            this.Name = "MscInternet";
            this.Text = "MscInternet";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dginternet)).EndInit();
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
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.DataGridView dginternet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnregistar;
        private System.Windows.Forms.Button btnBuscar;
    }
}