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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnbuscarE = new System.Windows.Forms.Button();
            this.btnsalirE = new System.Windows.Forms.Button();
            this.dgegresos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnguardarE = new System.Windows.Forms.Button();
            this.txtdetalleE = new System.Windows.Forms.TextBox();
            this.txtvalorE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnmodificarE = new System.Windows.Forms.Button();
            this.btnregistrarE = new System.Windows.Forms.Button();
            this.rdbrecarga = new System.Windows.Forms.RadioButton();
            this.rdbcabina = new System.Windows.Forms.RadioButton();
            this.rdbinternet = new System.Windows.Forms.RadioButton();
            this.idegresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgegresos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnbuscarE);
            this.groupBox2.Location = new System.Drawing.Point(110, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 46);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Buscar Desde ";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(280, 20);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker3.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(120, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hasta ";
            // 
            // btnbuscarE
            // 
            this.btnbuscarE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscarE.Location = new System.Drawing.Point(383, 13);
            this.btnbuscarE.Name = "btnbuscarE";
            this.btnbuscarE.Size = new System.Drawing.Size(29, 27);
            this.btnbuscarE.TabIndex = 9;
            this.btnbuscarE.UseVisualStyleBackColor = true;
            // 
            // btnsalirE
            // 
            this.btnsalirE.Location = new System.Drawing.Point(434, 197);
            this.btnsalirE.Name = "btnsalirE";
            this.btnsalirE.Size = new System.Drawing.Size(111, 26);
            this.btnsalirE.TabIndex = 26;
            this.btnsalirE.Text = "Salir";
            this.btnsalirE.UseVisualStyleBackColor = true;
            // 
            // dgegresos
            // 
            this.dgegresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgegresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idegresos,
            this.Column1,
            this.Column2,
            this.Column3,
            this.categoria});
            this.dgegresos.Location = new System.Drawing.Point(12, 235);
            this.dgegresos.Name = "dgegresos";
            this.dgegresos.Size = new System.Drawing.Size(544, 150);
            this.dgegresos.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbinternet);
            this.groupBox1.Controls.Add(this.rdbcabina);
            this.groupBox1.Controls.Add(this.rdbrecarga);
            this.groupBox1.Controls.Add(this.btnguardarE);
            this.groupBox1.Controls.Add(this.txtdetalleE);
            this.groupBox1.Controls.Add(this.txtvalorE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 94);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // btnguardarE
            // 
            this.btnguardarE.Location = new System.Drawing.Point(425, 25);
            this.btnguardarE.Name = "btnguardarE";
            this.btnguardarE.Size = new System.Drawing.Size(66, 26);
            this.btnguardarE.TabIndex = 6;
            this.btnguardarE.Text = "Guardar";
            this.btnguardarE.UseVisualStyleBackColor = true;
            // 
            // txtdetalleE
            // 
            this.txtdetalleE.Location = new System.Drawing.Point(288, 22);
            this.txtdetalleE.Name = "txtdetalleE";
            this.txtdetalleE.Size = new System.Drawing.Size(100, 20);
            this.txtdetalleE.TabIndex = 5;
            // 
            // txtvalorE
            // 
            this.txtvalorE.Location = new System.Drawing.Point(73, 22);
            this.txtvalorE.Name = "txtvalorE";
            this.txtvalorE.Size = new System.Drawing.Size(100, 20);
            this.txtvalorE.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Detalle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor";
            // 
            // btnmodificarE
            // 
            this.btnmodificarE.Location = new System.Drawing.Point(273, 197);
            this.btnmodificarE.Name = "btnmodificarE";
            this.btnmodificarE.Size = new System.Drawing.Size(111, 26);
            this.btnmodificarE.TabIndex = 23;
            this.btnmodificarE.Text = "Modificar Egresoso";
            this.btnmodificarE.UseVisualStyleBackColor = true;
            // 
            // btnregistrarE
            // 
            this.btnregistrarE.Location = new System.Drawing.Point(31, 65);
            this.btnregistrarE.Name = "btnregistrarE";
            this.btnregistrarE.Size = new System.Drawing.Size(111, 26);
            this.btnregistrarE.TabIndex = 22;
            this.btnregistrarE.Text = "Registar Egresos";
            this.btnregistrarE.UseVisualStyleBackColor = true;
            // 
            // rdbrecarga
            // 
            this.rdbrecarga.AutoSize = true;
            this.rdbrecarga.Location = new System.Drawing.Point(9, 63);
            this.rdbrecarga.Name = "rdbrecarga";
            this.rdbrecarga.Size = new System.Drawing.Size(66, 17);
            this.rdbrecarga.TabIndex = 7;
            this.rdbrecarga.TabStop = true;
            this.rdbrecarga.Text = "Recarga";
            this.rdbrecarga.UseVisualStyleBackColor = true;
            // 
            // rdbcabina
            // 
            this.rdbcabina.AutoSize = true;
            this.rdbcabina.Location = new System.Drawing.Point(122, 63);
            this.rdbcabina.Name = "rdbcabina";
            this.rdbcabina.Size = new System.Drawing.Size(63, 17);
            this.rdbcabina.TabIndex = 8;
            this.rdbcabina.TabStop = true;
            this.rdbcabina.Text = "Cabinas";
            this.rdbcabina.UseVisualStyleBackColor = true;
            // 
            // rdbinternet
            // 
            this.rdbinternet.AutoSize = true;
            this.rdbinternet.Location = new System.Drawing.Point(258, 63);
            this.rdbinternet.Name = "rdbinternet";
            this.rdbinternet.Size = new System.Drawing.Size(61, 17);
            this.rdbinternet.TabIndex = 9;
            this.rdbinternet.TabStop = true;
            this.rdbinternet.Text = "Internet";
            this.rdbinternet.UseVisualStyleBackColor = true;
            // 
            // idegresos
            // 
            this.idegresos.HeaderText = "Id Egresos";
            this.idegresos.Name = "idegresos";
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
            // MscEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 396);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnsalirE);
            this.Controls.Add(this.dgegresos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnmodificarE);
            this.Controls.Add(this.btnregistrarE);
            this.Name = "MscEgresos";
            this.Text = "MscEgresos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgegresos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnbuscarE;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idegresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.RadioButton rdbinternet;
        private System.Windows.Forms.RadioButton rdbcabina;
        private System.Windows.Forms.RadioButton rdbrecarga;
    }
}