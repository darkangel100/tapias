namespace AplicacionProductosServicios.Vista
{
    partial class MscPines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MscPines));
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnguardarPines = new System.Windows.Forms.Button();
            this.txtregPines = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmodifpines = new System.Windows.Forms.Button();
            this.btnsalirPines = new System.Windows.Forms.Button();
            this.btnregistarpines = new System.Windows.Forms.Button();
            this.dtgPines = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPines)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(464, 299);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(87, 20);
            this.dtFecha.TabIndex = 60;
            this.dtFecha.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtHasta);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnbuscar);
            this.groupBox2.Controls.Add(this.dtDesde);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(148, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 60);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione las fechas para BUSCAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Hasta";
            // 
            // dtHasta
            // 
            this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHasta.Location = new System.Drawing.Point(227, 27);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(121, 21);
            this.dtHasta.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Desde";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Image = global::AplicacionProductosServicios.Properties.Resources.lupa_de_buscar;
            this.btnbuscar.Location = new System.Drawing.Point(354, 26);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(32, 27);
            this.btnbuscar.TabIndex = 41;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dtDesde
            // 
            this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesde.Location = new System.Drawing.Point(54, 27);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(121, 21);
            this.dtDesde.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnguardarPines);
            this.groupBox1.Controls.Add(this.txtregPines);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 86);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Pines";
            // 
            // btnguardarPines
            // 
            this.btnguardarPines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarPines.Location = new System.Drawing.Point(239, 48);
            this.btnguardarPines.Name = "btnguardarPines";
            this.btnguardarPines.Size = new System.Drawing.Size(97, 23);
            this.btnguardarPines.TabIndex = 23;
            this.btnguardarPines.Text = "Guardar";
            this.btnguardarPines.UseVisualStyleBackColor = true;
            this.btnguardarPines.Click += new System.EventHandler(this.btnguardarPines_Click);
            // 
            // txtregPines
            // 
            this.txtregPines.Location = new System.Drawing.Point(121, 37);
            this.txtregPines.Name = "txtregPines";
            this.txtregPines.Size = new System.Drawing.Size(89, 20);
            this.txtregPines.TabIndex = 25;
            this.txtregPines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtregPines_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ingrese los Pines";
            // 
            // btnmodifpines
            // 
            this.btnmodifpines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifpines.Location = new System.Drawing.Point(291, 189);
            this.btnmodifpines.Name = "btnmodifpines";
            this.btnmodifpines.Size = new System.Drawing.Size(126, 41);
            this.btnmodifpines.TabIndex = 57;
            this.btnmodifpines.Text = "Modificar";
            this.btnmodifpines.UseVisualStyleBackColor = true;
            this.btnmodifpines.Click += new System.EventHandler(this.btnmodifpines_Click);
            // 
            // btnsalirPines
            // 
            this.btnsalirPines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirPines.Location = new System.Drawing.Point(446, 189);
            this.btnsalirPines.Name = "btnsalirPines";
            this.btnsalirPines.Size = new System.Drawing.Size(105, 41);
            this.btnsalirPines.TabIndex = 56;
            this.btnsalirPines.Text = "Salir";
            this.btnsalirPines.UseVisualStyleBackColor = true;
            this.btnsalirPines.Click += new System.EventHandler(this.btnsalirPines_Click);
            // 
            // btnregistarpines
            // 
            this.btnregistarpines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistarpines.Location = new System.Drawing.Point(12, 40);
            this.btnregistarpines.Name = "btnregistarpines";
            this.btnregistarpines.Size = new System.Drawing.Size(106, 33);
            this.btnregistarpines.TabIndex = 54;
            this.btnregistarpines.Text = "Registrar";
            this.btnregistarpines.UseVisualStyleBackColor = true;
            this.btnregistarpines.Click += new System.EventHandler(this.btnregistarpines_Click);
            // 
            // dtgPines
            // 
            this.dtgPines.AllowUserToAddRows = false;
            this.dtgPines.AllowUserToDeleteRows = false;
            this.dtgPines.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dtgPines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Fecha,
            this.Column2});
            this.dtgPines.Location = new System.Drawing.Point(29, 189);
            this.dtgPines.Name = "dtgPines";
            this.dtgPines.ReadOnly = true;
            this.dtgPines.Size = new System.Drawing.Size(247, 197);
            this.dtgPines.TabIndex = 55;
            this.dtgPines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPines_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id_Pines";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "cantidad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // MscPines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 405);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnmodifpines);
            this.Controls.Add(this.btnsalirPines);
            this.Controls.Add(this.btnregistarpines);
            this.Controls.Add(this.dtgPines);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MscPines";
            this.Text = "MscPines";
            this.Load += new System.EventHandler(this.MscPines_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnguardarPines;
        private System.Windows.Forms.TextBox txtregPines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmodifpines;
        private System.Windows.Forms.Button btnsalirPines;
        private System.Windows.Forms.Button btnregistarpines;
        private System.Windows.Forms.DataGridView dtgPines;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;


    }
}