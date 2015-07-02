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
            this.btncancelar = new System.Windows.Forms.Button();
            this.btbaceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnobre = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(207, 211);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(81, 23);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btbaceptar
            // 
            this.btbaceptar.Location = new System.Drawing.Point(76, 211);
            this.btbaceptar.Name = "btbaceptar";
            this.btbaceptar.Size = new System.Drawing.Size(75, 23);
            this.btbaceptar.TabIndex = 12;
            this.btbaceptar.Text = "&Aceptar";
            this.btbaceptar.UseVisualStyleBackColor = true;
            this.btbaceptar.Click += new System.EventHandler(this.btbaceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 98);
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
            // txtnobre
            // 
            this.txtnobre.Location = new System.Drawing.Point(156, 98);
            this.txtnobre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnobre.Name = "txtnobre";
            this.txtnobre.Size = new System.Drawing.Size(148, 20);
            this.txtnobre.TabIndex = 14;
            this.txtnobre.Text = "Cinthia Yanina";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(156, 146);
            this.txtclave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(148, 20);
            this.txtclave.TabIndex = 16;
            this.txtclave.Text = "12345";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Clave";
            // 
            // MscAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 290);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnobre);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btbaceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MscAcceso";
            this.Text = "MscAcceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btbaceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnobre;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label4;
    }
}