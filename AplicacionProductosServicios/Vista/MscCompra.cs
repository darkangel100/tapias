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
    public partial class MscCompra : Form
    {
        double totc;
        public MscCompra()
        {
            InitializeComponent();
        }

        private void MscCompra_Load(object sender, EventArgs e)
        {
            traeproducto();
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
                    cboprod.DisplayMember = "NombrePro";
                    cboprod.ValueMember = "Codprod";
                    cboprod.DataSource = objp.getProductos().ListaProductos;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presenta datos" + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cboprod_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcod.Text = cboprod.SelectedValue.ToString();
        }
        private void registrar()
        {
            CompraDB objcomp = new CompraDB();
            ProductoDB objp = new ProductoDB();
            ProdcompraDB objcompra = new ProdcompraDB();

            int respc;
            int resprodc;
            int resp;
            try
            {
                objcomp.getcompra().Cant = Convert.ToInt32(txtcantidadComp.Text);
                //objcomp.getcompra().Nom_pro = cboprod.SelectedItem.ToString();
                objcomp.getcompra().Val_comp = Convert.ToDouble(txtvalorComp.Text);
                totc = Convert.ToDouble(txtcantidadComp.Text) * Convert.ToDouble(txtvalorComp.Text);
                objcomp.getcompra().Tot_comp = totc;
                respc = objcomp.insrtarcomp(objcomp.getcompra());
                if (respc == 0)
                {
                    MessageBox.Show("No se ingreso correctamente la compra", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    objcompra.getprocomp().Id_comp = objcomp.TraeCodigocompra();
                    objcompra.getprocomp().Cod_pro = Convert.ToInt32(cboprod.SelectedValue);
                    objcompra.getprocomp().Cantp_como = Convert.ToInt32(txtcantidadComp.Text);
                    objcompra.getprocomp().Pre_compra = Convert.ToDouble(txtvalorComp.Text);
                    objcompra.getprocomp().Tot_copm = totc;
                    resprodc = objcompra.registra(objcompra.getprocomp());
                    if (resprodc > 0)
                    {
                        resp = objp.sumastock(Convert.ToInt32(cboprod.SelectedValue), Convert.ToInt32(txtcantidadComp.Text));
                        if (resp == 0)
                        {
                            MessageBox.Show("Error al ingresar datos", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Datos ingresados correctamente", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datso" + ex.Message, "Productos y Servicipos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguardarComp_Click(object sender, EventArgs e)
        {
            registrar();
        }
            

    }
}
