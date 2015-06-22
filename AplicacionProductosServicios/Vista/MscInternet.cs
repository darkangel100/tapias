using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AplicacionProductosServicios.Controlador;


namespace AplicacionProductosServicios.Vista
{
    public partial class MscInternet : Form
    {
        public MscInternet()
        {
            InitializeComponent();
        }
       
        
        private void btnregistar_Click(object sender, EventArgs e)
        {
            txtconsumointernet.Enabled = true;
            btnguardar.Enabled = true;
            txtconsumointernet.Focus();

        }

        private void registra()
        {
            InternetDB obji = new InternetDB();
            obji.getInternet().Valor =Convert.ToDouble( txtconsumointernet.Text.Trim());
          



          

        }

    }
}
