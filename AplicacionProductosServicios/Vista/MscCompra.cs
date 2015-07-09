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
        string fecha1, fecha2;
        public MscCompra()
        {
            InitializeComponent();
        }

        private void MscCompra_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
            listarxfecha();
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
            if (cboprod.SelectedIndex > 0)
            {
               
                txtvalorComp.Focus();
            }
            
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
                            listarxfecha();
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
            panel1.Enabled = false;
            groupBox1.Enabled = false;
            registrar();
        }

        private void listarxfecha()
        {
            CompraDB objcomp = new CompraDB();
            ProdcompraDB objpc = new ProdcompraDB();
            double totcomp = 0;
            try
            {
                fecha1 = Util.girafecha(dateTimePicker2.Value.ToShortDateString());
                fecha2 = Util.girafecha(dateTimePicker3.Value.ToShortDateString());
                objcomp.getcompra().Listcompra = objcomp.listacompra(fecha1, fecha2);
                if (objcomp.getcompra().Listcompra.Count == 0)
                {
                    MessageBox.Show("No hay registros ", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else

                    dgcompra.Rows.Clear();
                for (int i = 0; i < objcomp.getcompra().Listcompra.Count; i++)
                {
                    dgcompra.Rows.Add(1);
                    dgcompra.Rows[i].Cells[0].Value = objcomp.getcompra().Listcompra[i].Id_comp;
                    dgcompra.Rows[i].Cells[1].Value = objcomp.getcompra().Listcompra[i].Fecha;
                    dgcompra.Rows[i].Cells[2].Value = objcomp.getcompra().Listcompra[i].Nom_pro;
                    objpc.setprocomp(objpc.listacon(Convert.ToInt32(dgcompra.Rows[i].Cells[0].Value)));
                    dgcompra.Rows[i].Cells[3].Value = objpc.getprocomp().Cantp_como;
                    dgcompra.Rows[i].Cells[4].Value = objcomp.getcompra().Listcompra[i].Val_comp;
                    dgcompra.Rows[i].Cells[5].Value = objcomp.getcompra().Listcompra[i].Tot_comp;
                    totcomp += objcomp.getcompra().Listcompra[i].Tot_comp;

                }
                txttot.Text = "$ " + totcomp.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar datos" + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            
        

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            fecha1 = dateTimePicker2.Value.ToShortDateString();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            fecha2 = dateTimePicker3.Value.ToShortDateString();
        }

        private void btnbuscarComp_Click(object sender, EventArgs e)
        {
            listarxfecha();
        }

        private void txtvalorComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;

            if ((letra < 48 || letra > 57) & letra != 8 & letra != 46)
            {
                e.Handled = true;
            }

            if (letra == 46)
            {
                if (txtvalorComp.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            if (letra == 13)
            {
                txtcantidadComp.Focus();
            }

        }

        private void txtcantidadComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;

            if ((letra < 48 || letra > 57) & letra != 8)
            {
                e.Handled = true;
            }
            if (letra == 13)
            {
                btnguardarComp.Focus();
            }

        }

        private void dgcompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnregistrarComp_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            groupBox1.Enabled = true;
        }

      
       
        
            

    }
}
