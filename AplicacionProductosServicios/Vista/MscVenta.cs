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
    public partial class MscVenta : Form
    {
        public MscVenta()
        {
            InitializeComponent();
        }

        private void traeproducto()
        {
            try
            {

                ProductoDB objp = new ProductoDB();
                objp.getProductos().ListaProductos = objp.TraeProductos();
                if (objp.getProductos().ListaProductos.Count == 0)
                {
                    MessageBox.Show("No exixten productos registrados", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    cbocod.DisplayMember = "NombrePro";
                    cbocod.ValueMember = "Codprod";
                    cbocod.DataSource = objp.getProductos().ListaProductos;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presenta datos"+ex.Message,"Productos y Servicios",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        

        private void MscVenta_Load(object sender, EventArgs e)
        {
            traeproducto();
        }


    }
}
