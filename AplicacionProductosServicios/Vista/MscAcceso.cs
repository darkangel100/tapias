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
    public partial class MscAcceso : Form
    {
        public MscAcceso()
        {
            InitializeComponent();
        }
        
        private void btbaceptar_Click(object sender, EventArgs e)
        {
            verifica();
        }
        public void verifica()
        {
            
            try
            {
                if (txtnobre.Text.Trim().Length > 0 && txtclave.Text.Trim().Length > 0)
                {
                    Sesiones.C = new CuentaDB().treacunta(txtnobre.Text, txtclave.Text);
                    if (Sesiones.C != null)
                    {
                        MscMenuPrincipal mc = new MscMenuPrincipal();
                        mc.Show();
                        this.Dispose(false);
                     
                    }
                    else
                    {
                        MessageBox.Show("Usted no esta registrado en el sistema");
                    }
                }
                else {
                    MessageBox.Show("Llene todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Clave o nombre incorrecto," + ex.Message, "Pruductos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtnobre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MscAcceso_Load(object sender, EventArgs e)
        {

        }

        
       

        
    }
}
