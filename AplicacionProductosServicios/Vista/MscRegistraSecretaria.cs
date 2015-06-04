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
    public partial class MscRegistraSecretaria : Form
    {
        public MscRegistraSecretaria()
        {
            InitializeComponent();
        }

        private void btnsalir_Secret_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregistrar_secret_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

    }
}
