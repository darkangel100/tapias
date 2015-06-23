using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AplicacionProductosServicios.Vista;
namespace AplicacionProductosServicios.Vista
{
    public partial class MscMenuPrincipal : Form
    {
        public MscMenuPrincipal()
        {
            InitializeComponent();
        }

        private void tspines_Click(object sender, EventArgs e)
        {
            MscPines objp = new MscPines();
            objp.Show();
        }

        private void tsrecargas_Click(object sender, EventArgs e)
        {
            MscRegargas objR = new MscRegargas();
            objR.Show();
        }

        private void tsinternet_Click(object sender, EventArgs e)
        {
            MscInternet objI = new MscInternet();
            objI.Show();
        }

        private void tscabinas_Click(object sender, EventArgs e)
        {
            MscCabinas objC = new MscCabinas();
            objC.Show();
        }

        private void tsegresos_Click(object sender, EventArgs e)
        {
            MscEgresos objE = new MscEgresos();
            objE.Show();

        }

        private void tscompra_Click(object sender, EventArgs e)
        {
            MscCompra objComp = new MscCompra();
            objComp.Show();
        }

        private void tsventa_Click(object sender, EventArgs e)
        {
            MscVenta objV = new MscVenta();
            objV.Show();
        }
        private void tsproducto_Click(object sender, EventArgs e)
        {
            MscProducto objP = new MscProducto();
            objP.Show();
        }

        private void tscerrarsitema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MscRol objr = new MscRol();
            objr.Show();
        }

        private void tssecretarias_Click(object sender, EventArgs e)
        {

            MscRegistraSecretaria objRS = new MscRegistraSecretaria();
            objRS.Show();
        }


       
    }
}
