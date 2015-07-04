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

        pinesDB pines = new pinesDB();
        RecargaDB objRec = new RecargaDB();
        string estado = "";
        int fila;

        private void btnregRecaRecarga_Click_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            estado = "G";
        }
        private void ListarRecargas()
        {
            try
            {
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
                    }
                }
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
                pinesDB objPines = new pinesDB();
                int resp, pines;
                CuentaDB objC = new CuentaDB();
                objRec.GetRecarga().IdPer = Sesiones.C.Idper;
                objRec.GetRecarga().Num = Convert.ToInt32(txtNumRecarga.Text);
                objRec.GetRecarga().Valor = Convert.ToDouble(cbovalor.Text.ToString());


                resp = objRec.IngresaRecarga(objRec.GetRecarga());

                if (resp == 0)
                {
                    MessageBox.Show("No se ingresaron datos de la Recarga", "Productos y Serrvicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("La Recarga se Ingreso Correctamente", "Productos y servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    ListarRecargas();
                    pines = objPines.getPines().Listapines[fila].Canpines;
                    txtpines.Text += pines.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguardarRecarga_Click(object sender, EventArgs e)
        {
            if (estado == "G")
            {
                RegistraRecarga();
            }
        }

        private void btnsalirRecarga_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MscRegargas_Load(object sender, EventArgs e)
        {
            ListarRecargas();
            cogervalores();
            txtpines.Text = pines.sumapines().ToString();
        }
        private void cogervalores()
        {
            pinesDB objpines = new pinesDB();
            txtpines.Text = objpines.getPines().Canpines.ToString();
        }
        private void BuscarRecarga()
        {
            int num = int.Parse(txtbusRecarga.Text);
            dgrecarga.Rows.Clear();
            objRec.GetRecarga().ListaRecarga = objRec.BuscarRecarga(num);
            if (objRec.GetRecarga().ListaRecarga.Count == 0)
            {
                MessageBox.Show("No se encuentra el nuemro");
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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarRecarga();
        }

        private void dgrecarga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = dgrecarga.CurrentRow.Index;
        }

    }
}
