using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AplicacionProductosServicios.Vista
{
    public partial class MscAcceso : Form
    {
        public MscAcceso()
        {
            InitializeComponent();
        }

        private void btbaceptar_Click(object sender, EventArgs e)
        {
            MscMenuPrincipal objM = new MscMenuPrincipal();
            objM.Show();
        }
    }
}
