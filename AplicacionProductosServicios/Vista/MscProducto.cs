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
            if (estado == "E")
            {
                editar();
            }
        }

        private void MscProducto_Load_1(object sender, EventArgs e)
        {
            llenaProducto();
        }

        private void btnmodificarProd_Click_1(object sender, EventArgs e)
        {
            modifica();
            panel1.Enabled = true;
            estado = "E";
        }
        private void modifica()
        {
            try
            {
                txtCodProd.Text = dgProducto.Rows[fila].Cells[0].Value.ToString();
                txtnompro.Text = dgProducto.Rows[fila].Cells[1].Value.ToString();
                txtpreComp.Text = dgProducto.Rows[fila].Cells[2].Value.ToString();
                txtpreciovent.Text = dgProducto.Rows[fila].Cells[3].Value.ToString();
                txtstock.Text = dgProducto.Rows[fila].Cells[4].Value.ToString();
                txtcantgan.Text = dgProducto.Rows[fila].Cells[5].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error la presentar datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void editar()
        {
            try
            {
                ProductoDB objP = new ProductoDB();
                int resp;
                objP.getProductos().Codprod = Convert.ToInt32(txtCodProd.Text.Trim());
                objP.getProductos().NombrePro = txtnompro.Text.Trim();
                objP.getProductos().Precom = Convert.ToDouble(txtpreComp.Text.Trim());
                objP.getProductos().Prevent = Convert.ToDouble(txtpreciovent.Text);
                objP.getProductos().Stock = Convert.ToInt32(txtstock.Text.Trim());
                objP.getProductos().Cantgan = Convert.ToDouble(txtcantgan.Text.Trim());
                resp = objP.ActualizaProducto(objP.getProductos());
                if (resp == 0)
                {
                    MessageBox.Show("No se modificaron datos del Producto", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Producto Modificado", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenaProducto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error la presentar datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = dgProducto.CurrentRow.Index;
        }

        private void BuscarProd()
        {
            try
            {
                ProductoDB objP = new ProductoDB();
                dgProducto.Rows.Clear();
                if (cboOpcionBusProd.SelectedIndex == 0)
                {
                    objP.getProductos().ListaProductos = objP.BuscarProdCod(txtbusqProd.Text);
                    if (objP.getProductos().ListaProductos.Count == 0)
                    {
                        MessageBox.Show("No existe el producto", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        dgProducto.Rows.Add(objP.getProductos().ListaProductos.Count);
                        for (int i = 0; i < objP.getProductos().ListaProductos.Count; i++)
                        {
                            dgProducto.Rows[fila].Cells[0].Value = objP.getProductos().ListaProductos[fila].Codprod;
                            dgProducto.Rows[fila].Cells[1].Value = objP.getProductos().ListaProductos[fila].NombrePro;
                            dgProducto.Rows[fila].Cells[2].Value = objP.getProductos().ListaProductos[fila].Precom;
                            dgProducto.Rows[fila].Cells[3].Value = objP.getProductos().ListaProductos[fila].Prevent;
                            dgProducto.Rows[fila].Cells[4].Value = objP.getProductos().ListaProductos[fila].Stock;
                            dgProducto.Rows[fila].Cells[5].Value = objP.getProductos().ListaProductos[fila].Cantgan;

                        }
                    }
                }
                else if (cboOpcionBusProd.SelectedIndex > 0)
                {
                    objP.getProductos().ListaProductos = objP.BuscarProdNom(txtbusqProd.Text);
                    if (objP.getProductos().ListaProductos.Count == 0)
                    {
                        MessageBox.Show("No existe el producto", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        dgProducto.Rows.Add(objP.getProductos().ListaProductos.Count);
                        dgProducto.DataSource = objP.getProductos().ListaProductos;
                        dgProducto.Rows[fila].Cells[1].Value = objP.getProductos().ListaProductos[fila].NombrePro;
                        dgProducto.Rows[fila].Cells[2].Value = objP.getProductos().ListaProductos[fila].Precom;
                        dgProducto.Rows[fila].Cells[3].Value = objP.getProductos().ListaProductos[fila].Prevent;
                        dgProducto.Rows[fila].Cells[4].Value = objP.getProductos().ListaProductos[fila].Stock;
                        dgProducto.Rows[fila].Cells[5].Value = objP.getProductos().ListaProductos[fila].Cantgan;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgProducto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            fila = dgProducto.CurrentRow.Index;
        }

        private void btnsalirProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            BuscarProd();
        }

        private void txtCodProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if ((letra < 48 || letra > 57) & letra != 8 & letra != 13)
            {
                e.Handled = true;
            }
        }

        private void txtnompro_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if ((letra < 'a' || letra > 'z') & (letra < 'A' || letra > 'Z') & letra != 8 & letra != 13 & letra != 32)
            {
                e.Handled = true;
            }
            if (letra == 13)
            {
                txtstock.Focus();
            }
        }

        private void txtstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if ((letra < 48 || letra > 57) & letra != 8 & letra != 13)
            {
                e.Handled = true;
            }
            if (letra == 13)
            {
                txtpreComp.Focus();
            }

        }

        private void txtpreComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;

            if ((letra < 48 || letra > 57) & letra != 8 & letra != 46)
            {
                e.Handled = true;
            }

            if (letra == 46)
            {
                if (txtpreComp.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            if (letra == 13)
            {
                txtcantgan.Focus();
            }
        }

        private void txtcantgan_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;

            if ((letra < 48 || letra > 57) & letra != 8 & letra != 46)
            {
                e.Handled = true;
            }

            if (letra == 46)
            {
                if (txtcantgan.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            if (letra == 13)
            {
                txtpreciovent.Focus();
            }
        }

        private void txtpreciovent_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;

            if ((letra < 48 || letra > 57) & letra != 8 & letra != 46)
            {
                e.Handled = true;
            }

            if (letra == 46)
            {
                if (txtpreciovent.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            if (letra == 13)
            {
                btnguardarProd.Enabled = true;
                btnguardarProd.Focus();
            }
        }

    }
}
