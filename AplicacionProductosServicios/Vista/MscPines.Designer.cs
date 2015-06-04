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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnguardarPines = new System.Windows.Forms.Button();
            this.txtregPines = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnmodifpines = new System.Windows.Forms.Button();
            this.btnsalirPines = new System.Windows.Forms.Button();
            this.btnregistarpines = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnguardarPines);
            this.groupBox1.Controls.Add(this.txtregPines);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 86);
            this.groupBox1.TabIndex = 30;
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
            // 
            // txtregPines
            // 
            this.txtregPines.Location = new System.Drawing.Point(121, 37);
            this.txtregPines.Name = "txtregPines";
            this.txtregPines.Size = new System.Drawing.Size(89, 20);
            this.txtregPines.TabIndex = 25;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Buscar";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Image = global::AplicacionProductosServicios.Properties.Resources.lupa_de_buscar;
            this.btnbuscar.Location = new System.Drawing.Point(407, 3);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(29, 27);
            this.btnbuscar.TabIndex = 28;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btnmodifpines
            // 
            this.btnmodifpines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifpines.Location = new System.Drawing.Point(13, 178);
            this.btnmodifpines.Name = "btnmodifpines";
            this.btnmodifpines.Size = new System.Drawing.Size(137, 23);
            this.btnmodifpines.TabIndex = 27;
            this.btnmodifpines.Text = "Modificar";
            this.btnmodifpines.UseVisualStyleBackColor = true;
            // 
            // btnsalirPines
            // 
            this.btnsalirPines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirPines.Location = new System.Drawing.Point(175, 178);
            this.btnsalirPines.Name = "btnsalirPines";
            this.btnsalirPines.Size = new System.Drawing.Size(124, 23);
            this.btnsalirPines.TabIndex = 26;
            this.btnsalirPines.Text = "Salir";
            this.btnsalirPines.UseVisualStyleBackColor = true;
            this.btnsalirPines.Click += new System.EventHandler(this.btnsalirPines_Click);
            // 
            // btnregistarpines
            // 
            this.btnregistarpines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistarpines.Location = new System.Drawing.Point(12, 37);
            this.btnregistarpines.Name = "btnregistarpines";
            this.btnregistarpines.Size = new System.Drawing.Size(106, 23);
            this.btnregistarpines.TabIndex = 23;
            this.btnregistarpines.Text = "Registrar";
            this.btnregistarpines.UseVisualStyleBackColor = true;
            this.btnregistarpines.Click += new System.EventHandler(this.btnregistarpines_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Fecha,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(40, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(347, 197);
            this.dataGridView1.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id_Pines";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            this.ClientSize = new System.Drawing.Size(440, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnmodifpines);
            this.Controls.Add(this.btnsalirPines);
            this.Controls.Add(this.btnregistarpines);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MscPines";
            this.Text = "MscPines";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnguardarPines;
        private System.Windows.Forms.TextBox txtregPines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnmodifpines;
        private System.Windows.Forms.Button btnsalirPines;
        private System.Windows.Forms.Button btnregistarpines;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;

    }
}