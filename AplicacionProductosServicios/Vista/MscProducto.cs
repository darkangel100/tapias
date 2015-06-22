using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AplicacionProductosServicios.Controlador;
using AplicacionProductosServicios.Modelo;

namespace AplicacionProductosServicios.Vista
{
    public partial class MscProducto : Form
    {
        public MscProducto()
        {
            InitializeComponent();
        }
        //declracion de las variables..
        int fila;
        string estado = "";

        private void adiciona()
        {
            try
            {

                ProductoDB objP = new ProductoDB();
                int resp = 0;

                objP.getProductos().Codprod = Convert.ToInt32(txtCodProd.Text.Trim());
                objP.getProductos().NombrePro = txtnompro.Text.Trim();
                objP.getProductos().Precom = Convert.ToDouble(txtpreComp.Text.Trim());
                objP.getProductos().Prevent = Convert.ToDouble(txtpreciovent.Text.Trim());
                objP.getProductos().Stock = Convert.ToInt32(txtstock.Text.Trim());
                objP.getProductos().Cantgan = Convert.ToDouble(txtcantgan.Text.Trim());


                if (rdbactivoProd.Checked == true)
                    objP.getProductos().Estprod = "A";
                else
                    objP.getProductos().Estprod = "P";

                resp = objP.InsertaProducto(objP.getProductos());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingreso los datos del producto", "Prodcutos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Producto Ingresado", "Prodcutos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos," + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void llenaProducto()
        {
            try
            {
                dgProducto.Rows.Clear();
                ProductoDB objP = new ProductoDB();
                objP.getProductos().ListaProductos = objP.TraeProductos();

                if (objP.getProductos().ListaProductos.Count == 0)
                {
                    MessageBox.Show("No existen productos registrados", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objP.getProductos().ListaProductos.Count; i++)
                    {
                        dgProducto.Rows.Add(1);
                        dgProducto.Rows[i].Cells[0].Value = objP.getProductos().ListaProductos[i].Codprod;
                        dgProducto.Rows[i].Cells[1].Value = objP.getProductos().ListaProductos[i].NombrePro;
                        dgProducto.Rows[i].Cells[2].Value = objP.getProductos().ListaProductos[i].Precom;
                        dgProducto.Rows[i].Cells[3].Value = objP.getProductos().ListaProductos[i].Prevent;
                        dgProducto.Rows[i].Cells[4].Value = objP.getProductos().ListaProductos[i].Stock;
                        dgProducto.Rows[i].Cells[5].Value = objP.getProductos().ListaProductos[i].Cantgan;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos," + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void modificar()
        {
            try
            {               
                ProductoDB objP = new ProductoDB();
                // objP.setProductos(objP.TraeProductos(dgProducto.Rows[fila].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos," + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btningresaProd_Click_1(object sender, EventArgs e)
        {
            estado = "N";
            panel1.Enabled = true;
            txtCodProd.Text = "";
            txtnompro.Text = "";
            txtpreComp.Text = "";
            txtstock.Text = "";
            txtcantgan.Text = "";
            txtpreciovent.Text = "";
            txtCodProd.Focus();
        }

        private void btnguardarProd_Click(object sender, EventArgs e)
        {

            if (estado == "N")
            {
                adiciona();
            }
        }

        private void MscProducto_Load_1(object sender, EventArgs e)
        {
            llenaProducto();
        }

        private void btnmodificarProd_Click_1(object sender, EventArgs e)
        {
            modificar();
            panel1.Enabled = true;
        }
    }
}
