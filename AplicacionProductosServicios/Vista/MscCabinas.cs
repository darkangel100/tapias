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
    public partial class MscCabinas : Form
    {
        public MscCabinas()
        {
            InitializeComponent();
        }
        //Declaracion de las variables...

        string estado = "";
        int fila;
        //string fecha;

        private void MscCabinas_Load(object sender, EventArgs e)
        {
            dtpdes.Value = DateTime.Now;
            dtphast.Value = DateTime.Now;
            listaCabinas();

            estado = "N";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (estado == "N")
            {
                guardar();
                
            }
            if (estado == "E")
            {
                editar();
            }
        }
        private void guardar()
        {
            try
            {

                CabinasDB objC = new CabinasDB();
                
                int resp = 0;
             
                objC.getcabinas().Valor = Convert.ToDouble(txtconsumocab.Text.Trim());
                objC.getcabinas().Idper = Sesiones.C.Idper;
                objC.getcabinas().Totcab = Convert.ToDouble(txtconsumocab.Text.ToString());
                resp = objC.InsertaCabinas(objC.getcabinas());

                if (resp == 0)
                {
                    MessageBox.Show("No se ingreso datos de Cabinas", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Datos Ingresados", "productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listaCabinas();
                    estado = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar datos, " + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listaCabinas()
        {

            CabinasDB objC = new CabinasDB();
            double totval = 0;

            try
            {

                string fecha1, fecha2;
                fecha1 = Util.girafecha(dtpdes.Value.ToShortDateString());
                fecha2 = Util.girafecha(dtphast.Value.ToShortDateString());
                objC.getcabinas().ListaCab = objC.BuscarCab(fecha1, fecha2);
                if (objC.getcabinas().ListaCab.Count == 0)
                {
                    MessageBox.Show("No exixten registros", "Productoy Y servicios", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    dgCabinas.Rows.Clear();
                    for (int i = 0; i < objC.getcabinas().ListaCab.Count; i++)
                    {
                        dgCabinas.Rows.Add(1);
                        dgCabinas.Rows[i].Cells[0].Value = objC.getcabinas().ListaCab[i].Idcab;
                        dgCabinas.Rows[i].Cells[1].Value = objC.getcabinas().ListaCab[i].Fecha;
                        dgCabinas.Rows[i].Cells[2].Value = objC.getcabinas().ListaCab[i].Valor;
                        totval += objC.getcabinas().ListaCab[i].Valor;

                    }
                }
                txttotcab.Text = totval.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al presentar los datos" + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgCabinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = dgCabinas.CurrentRow.Index;
        }
        private void modificar()
        {
            try
            {
                txtconsumocab.Text = dgCabinas.Rows[fila].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            modificar();
            estado = "E";
        }
        private void editar()
        {
            try
            {
                CabinasDB objC = new CabinasDB();
                int resp;
                objC.getcabinas().Idcab = Convert.ToInt32(dgCabinas.Rows[fila].Cells[0].Value.ToString());
                
                objC.getcabinas().Valor = Convert.ToDouble(txtconsumocab.Text);
                resp = objC.ActualizaCabinas(objC.getcabinas());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingreso datos de Cabinas", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Datos modificados", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listaCabinas();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCabinas();
        }
        private void BuscarCabinas()
        {
            try
            {
                dgCabinas.Rows.Clear();
                CabinasDB objC = new CabinasDB();
                string fecha1, fecha2;
                fecha1 = Util.girafecha(dtpdes.Value.ToShortDateString());
                fecha2 = Util.girafecha(dtphast.Value.ToShortDateString());
                objC.getcabinas().ListaCab = objC.BuscarCab(fecha1, fecha2);

                if (objC.getcabinas().ListaCab.Count == 0)
                {
                    MessageBox.Show("No se encuentra datos de esas fechas", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    dgCabinas.Rows.Add(objC.getcabinas().ListaCab.Count);
                    for (int i = 0; i < objC.getcabinas().ListaCab.Count; i++)
                    {
                        dgCabinas.Rows[i].Cells[1].Value = objC.getcabinas().ListaCab[i].Fecha;
                        dgCabinas.Rows[i].Cells[2].Value = objC.getcabinas().ListaCab[i].Valor;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar lod datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txtconsumocab_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;

            if ((letra < 48 || letra > 57) & letra != 8 & letra != 46)
            {
                e.Handled = true;
            }

            if (letra == 46)
            {
                if (txtconsumocab.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            if (letra == 13)
            {
                btnguardar.Focus();
            }
        }
   
    }
}
