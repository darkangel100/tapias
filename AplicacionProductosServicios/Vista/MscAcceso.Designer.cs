namespace AplicacionProductosServicios.Vista
{
    partial class MscAcceso
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
            this.cbotipousu = new System.Windows.Forms.ComboBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btbaceptar = new System.Windows.Forms.Button();
            this.txtcontrseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbotipousu
            // 
            this.cbotipousu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipousu.FormattingEnabled = true;
            this.cbotipousu.Items.AddRange(new object[] {
            "Propietario",
            "Secretaria 1",
            "Secretaria 2"});
            this.cbotipousu.Location = new System.Drawing.Point(148, 62);
            this.cbotipousu.Name = "cbotipousu";
            this.cbotipousu.Size = new System.Drawing.Size(140, 21);
            this.cbotipousu.TabIndex = 14;
            this.cbotipousu.Text = "Seleccione el Usuario";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(182, 174);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(81, 23);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btbaceptar
            // 
            this.btbaceptar.Location = new System.Drawing.Point(55, 174);
            this.btbaceptar.Name = "btbaceptar";
            this.btbaceptar.Size = new System.Drawing.Size(75, 23);
            this.btbaceptar.TabIndex = 12;
            this.btbaceptar.Text = "&Aceptar";
            this.btbaceptar.UseVisualStyleBackColor = true;
            this.btbaceptar.Click += new System.EventHandler(this.btbaceptar_Click);
            // 
            // txtcontrseña
            // 
            this.txtcontrseña.Location = new System.Drawing.Point(148, 115);
            this.txtcontrseña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcontrseña.Name = "txtcontrseña";
            this.txtcontrseña.Size = new System.Drawing.Size(148, 20);
            this.txtcontrseña.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese la Clave para tener Acceso al Sistema";
            // 
            // MscAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 219);
            this.Controls.Add(this.cbotipousu);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btbaceptar);
            this.Controls.Add(this.txtcontrseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MscAcceso";
            this.Text = "MscAcceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbotipousu;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btbaceptar;
        private System.Windows.Forms.TextBox txtcontrseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}