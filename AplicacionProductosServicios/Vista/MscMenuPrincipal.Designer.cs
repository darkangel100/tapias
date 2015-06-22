namespace AplicacionProductosServicios.Vista
{
    partial class MscMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MscMenuPrincipal));
            this.label2 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.tspines = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrecargas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsinternet = new System.Windows.Forms.ToolStripMenuItem();
            this.tscabinas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsegresos = new System.Windows.Forms.ToolStripMenuItem();
            this.tscompra = new System.Windows.Forms.ToolStripMenuItem();
            this.tsproducto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsventa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsreportes = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cabinasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.internetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.confiteriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tssecretarias = new System.Windows.Forms.ToolStripMenuItem();
            this.tssalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tscerrarsitema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsprincipal = new System.Windows.Forms.MenuStrip();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secretariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnsprincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(161, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "CLARO VANESSITA";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(621, 27);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(129, 20);
            this.dtpfecha.TabIndex = 5;
            // 
            // tspines
            // 
            this.tspines.Name = "tspines";
            this.tspines.Size = new System.Drawing.Size(47, 20);
            this.tspines.Text = "Pines";
            this.tspines.Click += new System.EventHandler(this.tspines_Click);
            // 
            // tsrecargas
            // 
            this.tsrecargas.Name = "tsrecargas";
            this.tsrecargas.Size = new System.Drawing.Size(66, 20);
            this.tsrecargas.Text = "Recargas";
            this.tsrecargas.Click += new System.EventHandler(this.tsrecargas_Click);
            // 
            // tsinternet
            // 
            this.tsinternet.Name = "tsinternet";
            this.tsinternet.Size = new System.Drawing.Size(60, 20);
            this.tsinternet.Text = "Internet";
            this.tsinternet.Click += new System.EventHandler(this.tsinternet_Click);
            // 
            // tscabinas
            // 
            this.tscabinas.Name = "tscabinas";
            this.tscabinas.Size = new System.Drawing.Size(61, 20);
            this.tscabinas.Text = "Cabinas";
            this.tscabinas.Click += new System.EventHandler(this.tscabinas_Click);
            // 
            // tsegresos
            // 
            this.tsegresos.Name = "tsegresos";
            this.tsegresos.Size = new System.Drawing.Size(59, 20);
            this.tsegresos.Text = "Egresos";
            this.tsegresos.Click += new System.EventHandler(this.tsegresos_Click);
            // 
            // tscompra
            // 
            this.tscompra.Name = "tscompra";
            this.tscompra.Size = new System.Drawing.Size(62, 20);
            this.tscompra.Text = "Compra";
            this.tscompra.Click += new System.EventHandler(this.tscompra_Click);
            // 
            // tsproducto
            // 
            this.tsproducto.Name = "tsproducto";
            this.tsproducto.Size = new System.Drawing.Size(68, 20);
            this.tsproducto.Text = "Producto";
            this.tsproducto.Click += new System.EventHandler(this.tsproducto_Click);
            // 
            // tsventa
            // 
            this.tsventa.Name = "tsventa";
            this.tsventa.Size = new System.Drawing.Size(49, 20);
            this.tsventa.Text = "Venta";
            this.tsventa.Click += new System.EventHandler(this.tsventa_Click);
            // 
            // tsreportes
            // 
            this.tsreportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cierreDeCajaToolStripMenuItem,
            this.cabinasToolStripMenuItem1,
            this.internetToolStripMenuItem,
            this.recargasToolStripMenuItem1,
            this.confiteriaToolStripMenuItem1});
            this.tsreportes.Name = "tsreportes";
            this.tsreportes.Size = new System.Drawing.Size(65, 20);
            this.tsreportes.Text = "Reportes";
            // 
            // cierreDeCajaToolStripMenuItem
            // 
            this.cierreDeCajaToolStripMenuItem.Name = "cierreDeCajaToolStripMenuItem";
            this.cierreDeCajaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.cierreDeCajaToolStripMenuItem.Text = "Cierre de caja ";
            // 
            // cabinasToolStripMenuItem1
            // 
            this.cabinasToolStripMenuItem1.Name = "cabinasToolStripMenuItem1";
            this.cabinasToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.cabinasToolStripMenuItem1.Text = "Cabinas";
            // 
            // internetToolStripMenuItem
            // 
            this.internetToolStripMenuItem.Name = "internetToolStripMenuItem";
            this.internetToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.internetToolStripMenuItem.Text = "Internet";
            // 
            // recargasToolStripMenuItem1
            // 
            this.recargasToolStripMenuItem1.Name = "recargasToolStripMenuItem1";
            this.recargasToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.recargasToolStripMenuItem1.Text = "Recargas";
            // 
            // confiteriaToolStripMenuItem1
            // 
            this.confiteriaToolStripMenuItem1.Name = "confiteriaToolStripMenuItem1";
            this.confiteriaToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.confiteriaToolStripMenuItem1.Text = "Confiteria";
            // 
            // tssecretarias
            // 
            this.tssecretarias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolToolStripMenuItem,
            this.secretariaToolStripMenuItem});
            this.tssecretarias.Name = "tssecretarias";
            this.tssecretarias.Size = new System.Drawing.Size(61, 20);
            this.tssecretarias.Text = "Persona";
           // this.tssecretarias.Click += new System.EventHandler(this.tssecretarias_Click);
            // 
            // tssalir
            // 
            this.tssalir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscerrarsitema});
            this.tssalir.Name = "tssalir";
            this.tssalir.Size = new System.Drawing.Size(41, 20);
            this.tssalir.Text = "Salir";
            // 
            // tscerrarsitema
            // 
            this.tscerrarsitema.Name = "tscerrarsitema";
            this.tscerrarsitema.Size = new System.Drawing.Size(162, 22);
            this.tscerrarsitema.Text = "Cerrar el Sistema";
            this.tscerrarsitema.Click += new System.EventHandler(this.tscerrarsitema_Click);
            // 
            // mnsprincipal
            // 
            this.mnsprincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspines,
            this.tsrecargas,
            this.tsinternet,
            this.tscabinas,
            this.tsegresos,
            this.tscompra,
            this.tsproducto,
            this.tsventa,
            this.tsreportes,
            this.tssecretarias,
            this.tssalir});
            this.mnsprincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsprincipal.Name = "mnsprincipal";
            this.mnsprincipal.Size = new System.Drawing.Size(750, 24);
            this.mnsprincipal.TabIndex = 8;
            this.mnsprincipal.Text = "menuStrip1";
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rolToolStripMenuItem.Text = "Rol";
            this.rolToolStripMenuItem.Click += new System.EventHandler(this.rolToolStripMenuItem_Click);
            // 
            // secretariaToolStripMenuItem
            // 
            this.secretariaToolStripMenuItem.Name = "secretariaToolStripMenuItem";
            this.secretariaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.secretariaToolStripMenuItem.Text = "Secretaria";
            this.secretariaToolStripMenuItem.Click += new System.EventHandler(this.secretariaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MscMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 353);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.mnsprincipal);
            this.IsMdiContainer = true;
            this.Name = "MscMenuPrincipal";
            this.Text = "MSC Menu Principal";
            this.mnsprincipal.ResumeLayout(false);
            this.mnsprincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.ToolStripMenuItem tspines;
        private System.Windows.Forms.ToolStripMenuItem tsrecargas;
        private System.Windows.Forms.ToolStripMenuItem tsinternet;
        private System.Windows.Forms.ToolStripMenuItem tscabinas;
        private System.Windows.Forms.ToolStripMenuItem tsegresos;
        private System.Windows.Forms.ToolStripMenuItem tscompra;
        private System.Windows.Forms.ToolStripMenuItem tsproducto;
        private System.Windows.Forms.ToolStripMenuItem tsventa;
        private System.Windows.Forms.ToolStripMenuItem tsreportes;
        private System.Windows.Forms.ToolStripMenuItem cierreDeCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cabinasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem internetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem confiteriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tssecretarias;
        private System.Windows.Forms.ToolStripMenuItem tssalir;
        private System.Windows.Forms.ToolStripMenuItem tscerrarsitema;
        private System.Windows.Forms.MenuStrip mnsprincipal;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secretariaToolStripMenuItem;
    }
}