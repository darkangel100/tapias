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
        double totvent;
        string fecha1v ,fecha2v;
        int fila;
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
        private void buscarpro()
        {
            ProductoDB objp = new ProductoDB();
            try
            {
                objp.setProductos(objp.listaunprounPro(Convert.ToInt32(cbocod.SelectedValue)));
                if (objp.getProductos().Stock == 0)
                {
                    MessageBox.Show("No cuenta con " + cbocod.SelectedText.ToString() + "en stokc", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox1.Enabled = false;
                    panel1.Enabled = true;
                }
                else
                {
                    txtnompro.Text = objp.getProductos().NombrePro;
                    txtvaloruni.Text = objp.getProductos().Prevent.ToString();
                    txtstock.Text = objp.getProductos().Stock.ToString();
                    txtcantpedida.Focus();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errro al presenta datos " + ex.Message, "Productos y servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void registrar()
        {
            if(Convert.ToInt32(txtcantpedida.Text.Trim())<=Convert.ToInt32(txtstock.Text.Trim()))
            {
            VentaDB objv = new VentaDB();
            ProductoDB objp = new ProductoDB();
            ProVentaDB objpv = new ProVentaDB();
            int respv;
            int resppv;
            int resp;
            try
            {
                totvent = Convert.ToDouble(txtcantpedida.Text.Trim()) * Convert.ToDouble(txtvaloruni.Text.Trim());
                objv.getventa().Tot_vent = totvent;
                objv.getventa().Id_per = Sesiones.C.Idper;
                objv.getventa().Nom_pro = txtnompro.Text;
                respv = objv.Insertaventa(objv.getventa());
                if (respv == 0)
                {
                    MessageBox.Show("No se ingreso correctamente la venta", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    objpv.getprodventa().Id_venta = objv.TraeCodigoventa();
                    objpv.getprodventa().Val_unit = Convert.ToDouble(txtvaloruni.Text);
                    objpv.getprodventa().Cod_pro = Convert.ToInt32(cbocod.SelectedValue);
                    objpv.getprodventa().Can_vent = Convert.ToInt32(txtcantpedida.Text);
                    objpv.getprodventa().Tot_vent = totvent;
                    resppv = objpv.InseraPV(objpv.getprodventa());
                    if (resppv > 0)
                    {
                       resp= objp.restastork(Convert.ToInt32(cbocod.SelectedValue), Convert.ToInt32(txtcantpedida.Text));
                       if (resp == 0)
                       {
                           MessageBox.Show("Error al ingresar datos", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       }
                       else
                       {
                           MessageBox.Show("Datos ingresados correctamente", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           listarventasxfeca();
                       }
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datso" + ex.Message, "Productos y Servicipos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            else{

                MessageBox.Show("Debe ingresar un valor menor o igual al stock no puede vender mas de lo que no tiene", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }

        private void listarventasxfeca()
        {
     
            VentaDB objv = new VentaDB();
            ProVentaDB objpv = new ProVentaDB();
            try
            {
                fecha1v =Util.girafecha( dtp1.Value.ToShortDateString());
                fecha2v = Util.girafecha(dtp2.Value.ToShortDateString());
                objv.getventa().Listavent = objv.listaventa(fecha1v,fecha2v);
                if (objv.getventa().Listavent.Count == 0)
                {
                     MessageBox.Show("No se se han realizado ventas el dia de hoy", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     dgventa.Rows.Clear();
                }
                else
                {
                    dgventa.Rows.Clear();
                    for (int i = 0; i < objv.getventa().Listavent.Count; i++)
                    {
                        dgventa.Rows.Add(1);
                        dgventa.Rows[i].Cells[0].Value = objv.getventa().Listavent[i].Id_vent;
                        dgventa.Rows[i].Cells[1].Value = objv.getventa().Listavent[i].Fecha;
                       // dgventa.Rows[i].Cells[2].Value = objv.getventa().Listavent[i].Id_vent;
                        //objp.setProducto(objp.Traeproducto(dgit.Rows[i].Cells[1].Value.ToString()));
                        objpv.setprodventa(objpv.listacon(Convert.ToInt32(objv.getventa().Listavent[i].Id_vent)));
                        dgventa.Rows[i].Cells[2].Value = objpv.getprodventa().Cod_pro;
                        dgventa.Rows[i].Cells[3].Value = objv.getventa().Listavent[i].Nom_pro;
                        dgventa.Rows[i].Cells[4].Value = objpv.getprodventa().Val_unit;
                        dgventa.Rows[i].Cells[5].Value = objpv.getprodventa().Can_vent;
                        dgventa.Rows[i].Cells[6].Value = objpv.getprodventa().Tot_vent;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void modificar()
        {
            ProductoDB objp = new ProductoDB();
           
            int respven;
            //int resp;
            int repv;
            
            try
            {
                VentaDB objven = new VentaDB();
                objven.getventa().Id_vent =Convert.ToInt32( dgventa.Rows[fila].Cells[0].Value);
                totvent = Convert.ToInt32(txtcantpedida.Text.Trim()) * Convert.ToDouble(txtvaloruni.Text.Trim());
                objven.getventa().Tot_vent = totvent;
                respven = objven.modificaventa(objven.getventa());
                if (respven == 0)
                {
                    MessageBox.Show("No se modifico correctamente la venta", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ProVentaDB objpv = new ProVentaDB();
                    objpv.getprodventa().Id_venta = Convert.ToInt32(dgventa.Rows[fila].Cells[0].Value);
                    objpv.getprodventa().Val_unit = Convert.ToDouble(txtvaloruni.Text.Trim());
                    objpv.getprodventa().Tot_vent = totvent;
                    repv = objpv.modifcapv(objpv.getprodventa());
                    if (repv > 0)
                    {
                        //if(cantpe<Convert.ToInt32(txtcantpedida.Text.Trim())
                        

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar datos"+ex.Message,"Productos y Servicios",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void MscVenta_Load(object sender, EventArgs e)
        {
            dtp2.Value = DateTime.Now;
            dtp1.Value = DateTime.Now;
            traeproducto();
            listarventasxfeca();
       
        }

        private void btnbuscardatos_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            buscarpro();
            panel1.Enabled = false;
        }

        private void btnmodivent_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            registrar();
            limpiaCampos();
            groupBox1.Enabled = false;
        }

        private void btnnuevoVent_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            limpiaCampos();
        }

        private void cbocod_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiaCampos();
        }

        private void dgventa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = dgventa.CurrentRow.Index;
             
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            fecha1v = dtp1.Value.ToShortDateString();
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            fecha2v = dtp2.Value.ToShortDateString();
        }


        private void btnbusvent_Click(object sender, EventArgs e)
        {
            listarventasxfeca();
        }

        private void limpiaCampos()
        {
            txtcantpedida.Text = null;
            txtnompro.Text = null;
            txtstock.Text = null;
            txtvaloruni.Text = null;

        }

        private void txtcantpedida_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;

            if ((letra < 48 || letra > 57) & letra != 8)
            {
                e.Handled = true;
            }
            if (letra == 13)
            {
                btnguardar.Focus();
            }
        }

        private void txtvaloruni_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;

            if ((letra < 48 || letra > 57) & letra != 8 & letra != 46)
            {
                e.Handled = true;
            }

            if (letra == 46)
            {
                if (txtvaloruni.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
       
                  }

        
       

        
     


    }
}
