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
    public partial class MscRegargas : Form
    {
        public MscRegargas()
        {
            InitializeComponent();
        }

        private void btnregRecaRecarga_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }
    }
}
