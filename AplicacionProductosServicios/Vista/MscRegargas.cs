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
    public partial class MscRegargas : Form
    {
        public MscRegargas()
        {
            InitializeComponent();
        }

        PinesDB pines = new PinesDB();
        RecargaDB objRec = new RecargaDB();
        string estado = "";
        int fila;

        
        private void ListarRecargas()
        {
            try
            {
                double valor = 0;
                dgrecarga.Rows.Clear();

                objRec.GetRecarga().ListaRecarga = objRec.TraeRecargas();
                if (objRec.GetRecarga().ListaRecarga.Count == 0)
                {
                    MessageBox.Show("No existen Registros de Recarga", "Productos y servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    dgrecarga.Rows.Add(objRec.GetRecarga().ListaRecarga.Count);
                    for (int i = 0; i < objRec.GetRecarga().ListaRecarga.Count; i++)
                    {

                        dgrecarga.Rows[i].Cells[0].Value = objRec.GetRecarga().ListaRecarga[i].IdRec;
                        dgrecarga.Rows[i].Cells[1].Value = objRec.GetRecarga().ListaRecarga[i].Num;
                        dgrecarga.Rows[i].Cells[2].Value = objRec.GetRecarga().ListaRecarga[i].Fecha;
                        dgrecarga.Rows[i].Cells[3].Value = objRec.GetRecarga().ListaRecarga[i].Valor;
                        valor += objRec.GetRecarga().ListaRecarga[i].Valor;

                    }
                }
                txttotal.Text = valor.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("error al Presentar datos," + ex.Message, "Productos y Srervicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RegistraRecarga()
        {
            try
            {
                PinesDB objPines = new PinesDB();
                int resp, pines;
                CuentaDB objC = new CuentaDB();
                objRec.GetRecarga().IdPer = Sesiones.C.Idper;
                objRec.GetRecarga().Num = Convert.ToInt32(txtNumRecarga.Text);
                objRec.GetRecarga().Valor = Convert.ToInt32(cbovalor.Text.ToString());
                pines = int.Parse(txtpines.Text);
                int val = int.Parse(cbovalor.Text);
         
                resp = objRec.IngresaRecarga(objRec.GetRecarga());

                if (resp == 0)
                {
                    MessageBox.Show("No se ingresaron datos de la Recarga", "Productos y Serrvicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }               
                    
                
                else if (pines > val)
                {
                    MessageBox.Show("La Recarga se Ingreso Correctamente", "Productos y servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    ListarRecargas();
                    reducirPines();
                    Limpiarcampos();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnsalirRecarga_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MscRegargas_Load(object sender, EventArgs e)
        {
            ListarRecargas();
            //cogervalores();
            txtpines.Text = pines.sumapines().ToString();
            int pin = int.Parse(txtpines.Text);
            if (pin == 5)
            {
                MessageBox.Show("Usted solo cuenta con un Valor de 5 Pines", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (pin == 0)
            {
                MessageBox.Show("No hay Recargas", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        private void BuscarRecarga()
        {
            int num = int.Parse(txtbusRecarga.Text);
            dgrecarga.Rows.Clear();
            objRec.GetRecarga().ListaRecarga = objRec.BuscarRecarga(num);
            if (objRec.GetRecarga().ListaRecarga.Count == 0)
            {
                MessageBox.Show("No se encuentra el nuemero, Ingrese nuevamente","Producutos y Servicios",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                dgrecarga.Rows.Add(objRec.GetRecarga().ListaRecarga.Count);
                
                for (int i = 0; i < objRec.GetRecarga().ListaRecarga.Count; i++)
                {
                    dgrecarga.Rows[i].Cells[0].Value = objRec.GetRecarga().ListaRecarga[i].IdRec;
                    dgrecarga.Rows[i].Cells[1].Value = objRec.GetRecarga().ListaRecarga[i].Num;
                    dgrecarga.Rows[i].Cells[2].Value = objRec.GetRecarga().ListaRecarga[i].Fecha;
                    dgrecarga.Rows[i].Cells[3].Value = objRec.GetRecarga().ListaRecarga[i].Valor;
                }
            }
        }
        private void Limpiarcampos()
        {
            txtNumRecarga.Text = null;
            groupBox1.Enabled = false;
            cbovalor.Text = null;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarRecarga();
        }

        private void dgrecarga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = dgrecarga.CurrentRow.Index;
        }

        private void btnregRecaRecarga_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            estado = "G";
            txtNumRecarga.Focus();          

        }

        private void btnguardarRecarga_Click_1(object sender, EventArgs e)
        {
            int pin = Convert.ToInt32(txtpines.Text);
            double valor = Convert.ToDouble(cbovalor.Text);
            if (estado == "G")
            {
                if (valor < pin)
                {

                    RegistraRecarga();
                }
                else
                {
                    MessageBox.Show("No hay Recargas, No cuenta con un Registro de Pines Suficientes", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            BuscarRecarga();
        }

        private void BuscarFecha()
        {
            try
            {
                double tot = 0;
                string fecha1, fecha2;
                dgrecarga.Rows.Clear();
                fecha1 =Util.girafecha( dtpdesde.Value.ToShortDateString());
                fecha2 = Util.girafecha(dtphasta.Value.ToShortDateString());
                objRec.GetRecarga().ListaRecarga = objRec.BuscarFechra(fecha1, fecha2);
               
                if (objRec.GetRecarga().ListaRecarga.Count == 0)
                {
                    MessageBox.Show("No se encuentra la busqueda, No hay Registros en las fechas Seleccionadas", "Productos y Servcios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dgrecarga.Rows.Add(objRec.GetRecarga().ListaRecarga.Count);

                    for (int i = 0; i < objRec.GetRecarga().ListaRecarga.Count; i++)
                    {
                        dgrecarga.Rows[i].Cells[0].Value = objRec.GetRecarga().ListaRecarga[i].IdRec;
                        dgrecarga.Rows[i].Cells[1].Value = objRec.GetRecarga().ListaRecarga[i].Num;
                        dgrecarga.Rows[i].Cells[2].Value = objRec.GetRecarga().ListaRecarga[i].Fecha;
                        dgrecarga.Rows[i].Cells[3].Value = objRec.GetRecarga().ListaRecarga[i].Valor;
                        tot += objRec.GetRecarga().ListaRecarga[i].Valor;
                    }
                    txttotal.Text = tot.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnbusFecha_Click(object sender, EventArgs e)
        {
            BuscarFecha();
        }
        private void reducirPines()
        {
            int recarga = Convert.ToInt32(cbovalor.Text);
            int aux = recarga;
            if(pines.ListarPinesTotalMayorCero().Count>0)
            {
                int to = int.Parse(txtpines.Text);
                to -= aux;
                txtpines.Text = to.ToString();
                for (int i = 0; i < pines.ListarPinesTotalMayorCero().Count ;i++ )
                {
                    if (pines.ListarPinesTotalMayorCero()[i].Total_pines >= aux)
                    {
                        pines.ActualizaCantidad(aux, pines.ListarPinesTotalMayorCero()[i].Idpines);
                        //MessageBox.Show(aux+" 1 "+ pines.ListarPinesTotalMayorCero()[i].Idpines);
                        break;
                    }
                    else
                    {
                        //pines.ActualizaCantidad(aux, pines.ListarPinesTotalMayorCero()[i].Idpines);
                        aux = aux - pines.ListarPinesTotalMayorCero()[i].Total_pines;
                        //MessageBox.Show(aux + " 1 " + pines.ListarPinesTotalMayorCero()[i].Idpines);
                        pines.ActualizaCantidad(pines.ListarPinesTotalMayorCero()[i].Total_pines, pines.ListarPinesTotalMayorCero()[i].Idpines);
                    }
                }
            }
        }

        private void btnsalirRecarga_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
