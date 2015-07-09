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
    public partial class MscEgresos : Form
    {
        public MscEgresos()
        {
            InitializeComponent();
        }
        //declaracion de variables,,
        EgresosDB objE =  new EgresosDB();
        RecargaDB objRec = new RecargaDB();
        InternetDB objInt = new InternetDB();
        CabinasDB objCab = new CabinasDB();
        string estado;
        int fila;

        private void MscEgresos_Load(object sender, EventArgs e)
        {
            LlenaEgresos();
            txttotcab.Text = objCab.sumaCant1().ToString();
            txttotint.Text = objInt.sumaCant3().ToString();
            txttotrec.Text = objRec.sumaCant2().ToString();
            

            
        }
        
        private void btnregistrarE_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            estado = "n";
            txtdetalleE.Text = null;
            txtvalorE.Text = null;
            rdbcabina.Checked = false;
            rdbinternet.Checked = false;
            rdbrecarga.Checked = false;
            txtvalorE.Focus();
        }

        private void btnguardarE_Click(object sender, EventArgs e)
        {
            if (estado == "n")
            {
                if (rdbcabina.Checked == false && rdbinternet.Checked == false && rdbrecarga.Checked == false)
                    MessageBox.Show("Por favor llene todos lo campos");
                else
                {
                    if (Convert.ToDouble(txttotcab.Text) > Convert.ToDouble(txtvalorE.Text) && Convert.ToDouble(txttotint.Text)>Convert.ToDouble(txtvalorE.Text)&& Convert.ToDouble(txttotrec.Text)>Convert.ToDouble(txtvalorE.Text))
                    {

                        guardar();
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente dinero de sabinas para hacer esta transaccion", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    
                }


            }
            if (estado == "E")
            {
                editarEgre();
            }
        }
        private void Limpiar()
        {
            txtdetalleE.Text = null;
            txtvalorE.Text = null;
            groupBox1.Enabled = false;
            rdbcabina.Checked = false;
            rdbinternet.Checked = false;
            rdbrecarga.Checked = false;
        }
        private void guardar()
        {
            try
            {
                CabinasDB objC = new CabinasDB();
                InternetDB objI = new InternetDB();
                RecargaDB objR = new RecargaDB();
                EgresosDB objE = new EgresosDB();
                int resp = 0; 
                double cab=0;
                double inter = 0;
                double rec=0;

                objE.getEgresos().Detalle = txtdetalleE.Text.Trim();
                objE.getEgresos().Valor = Convert.ToDouble(txtvalorE.Text.Trim());
                objE.getEgresos().Idper = Sesiones.C.Idper;

                if (rdbcabina.Checked == true)
                    objE.getEgresos().Tipegre = "C";
                else if (rdbinternet.Checked == true)
                    objE.getEgresos().Tipegre = "I";
                else if (rdbrecarga.Checked == true)
                    objE.getEgresos().Tipegre = "R";

                cab = double.Parse(txttotcab.Text);
                inter = double.Parse(txttotint.Text);
                rec = double.Parse(txttotrec.Text);//.........................................................

                resp = objE.InsertaEgresos(objE.getEgresos());

                if (resp == 0)
                {
                    MessageBox.Show("No se registraron los datos de Egresos", "productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Datos de Egresos ingresados", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenaEgresos();
                    reducirValores();
                    estado = "";
                    Limpiar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LlenaEgresos()
        {
            try
            {
                dgegresos.Rows.Clear();
                EgresosDB objE = new EgresosDB();
                objE.getEgresos().Listaegresos = objE.TraeEgresos();
                if (objE.getEgresos().Listaegresos.Count == 0)
                {
                    MessageBox.Show("No existen datos de Egresos", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    for (int i = 0; i < objE.getEgresos().Listaegresos.Count; i++)
                    {
                        dgegresos.Rows.Add(1);
                        dgegresos.Rows[i].Cells[0].Value = objE.getEgresos().Listaegresos[i].Idegre;
                        dgegresos.Rows[i].Cells[1].Value = objE.getEgresos().Listaegresos[i].Fecha;
                        dgegresos.Rows[i].Cells[2].Value = objE.getEgresos().Listaegresos[i].Detalle;
                        dgegresos.Rows[i].Cells[3].Value = objE.getEgresos().Listaegresos[i].Valor;
                        dgegresos.Rows[i].Cells[4].Value = objE.getEgresos().Listaegresos[i].Tipegre;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnmodificarE_Click(object sender, EventArgs e)
        {
            modificarEgre();
            estado = "E";
            txtvalorE.Focus();
        }
        private void modificarEgre()
        {
            try
            {
                txtdetalleE.Text = dgegresos.Rows[fila].Cells[2].Value.ToString();
                txtvalorE.Text = dgegresos.Rows[fila].Cells[3].Value.ToString();
                groupBox1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al prsentar los datos," + ex.Message, "productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void editarEgre()
        {
            try
            {
                EgresosDB objE = new EgresosDB();
                int resp;
                objE.getEgresos().Idegre = Convert.ToInt32(dgegresos.Rows[fila].Cells[0].Value);
                objE.getEgresos().Detalle = txtdetalleE.Text.Trim();
                objE.getEgresos().Valor = Convert.ToDouble(txtvalorE.Text.Trim());

                if (rdbcabina.Checked == true)
                    objE.getEgresos().Tipegre = "C";
                else if (rdbinternet.Checked == true)
                    objE.getEgresos().Tipegre = "I";
                else if (rdbrecarga.Checked == true)
                    objE.getEgresos().Tipegre = "R";
                resp = objE.ActualizaEgresos(objE.getEgresos());

                if (resp == 0)
                {
                    MessageBox.Show("No se actrualizaron datos de egresos", "productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Datos de egresos Modificado", "productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenaEgresos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al prsentar los datos," + ex.Message, "productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgegresos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = dgegresos.CurrentRow.Index;
        }

        private void btnsalirE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscarEgre_Click(object sender, EventArgs e)
        {
            BuscarEgre();
        }
        private void BuscarEgre()
        {
            try
            {
                dgegresos.Rows.Clear();
                EgresosDB objE = new EgresosDB();
                string fecha1, fecha2;
                fecha1 = Util.girafecha(dtpdes.Value.ToShortDateString());
                fecha2 = Util.girafecha(dtphast.Value.ToShortDateString());
                objE.getEgresos().Listaegresos = objE.BuscarEgre(fecha1, fecha2);

                if (objE.getEgresos().Listaegresos.Count == 0)
                {
                    MessageBox.Show("No se encuentra datos de esas fechas", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    dgegresos.Rows.Add(objE.getEgresos().Listaegresos.Count);
                    for (int i = 0; i < objE.getEgresos().Listaegresos.Count; i++)
                    {
                        dgegresos.Rows[i].Cells[1].Value = objE.getEgresos().Listaegresos[i].Fecha;
                        dgegresos.Rows[i].Cells[2].Value = objE.getEgresos().Listaegresos[i].Detalle;
                        dgegresos.Rows[i].Cells[3].Value = objE.getEgresos().Listaegresos[i].Valor;
                        dgegresos.Rows[i].Cells[4].Value = objE.getEgresos().Listaegresos[i].Tipegre;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar lod datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void reducirValores()
        {
            double valorEgre = double.Parse(txtvalorE.Text);
            double auxi = valorEgre;
            if (rdbcabina.Checked == true)
            {

                if (objCab.ListarTotalCabinas().Count > 0)
                {
                    double totCabi = double.Parse(txttotcab.Text);
                    totCabi -= auxi;
                    txttotcab.Text = totCabi.ToString();
                    for (int i = 0; i < objCab.ListarTotalCabinas().Count; i++)
                    {
                        if (objCab.ListarTotalCabinas()[i].Totcab >= auxi)
                        {
                            objCab.ActualizaTotales(auxi, objCab.ListarTotalCabinas()[i].Idcab);
                            break;
                        }
                        else
                        {
                            auxi = auxi - objCab.ListarTotalCabinas()[i].Totcab;
                            objCab.ActualizaTotales(objCab.ListarTotalCabinas()[i].Totcab, objCab.ListarTotalCabinas()[i].Idcab);
                        }
                    }
                }
            }
            else if (rdbinternet.Checked == true)
            {
                if (objInt.ListarTotalInternet().Count > 0)
                {
                    double totInter = double.Parse(txttotint.Text); 
                    totInter -= auxi;
                    txttotint.Text = totInter.ToString();
                    for (int i = 0; i < objInt.ListarTotalInternet().Count; i++)
                    {
                        if (objInt.ListarTotalInternet()[i].Totint >= auxi)
                        {
                            objInt.ActualizaTotales(auxi, objInt.ListarTotalInternet()[i].Idinter);
                            break;
                        }
                        else
                        {
                            auxi = auxi - objInt.ListarTotalInternet()[i].Totint;
                            objInt.ActualizaTotales(objInt.ListarTotalInternet()[i].Totint, objInt.ListarTotalInternet()[i].Idinter);


                        }
                    }

                }
            }
            else if(rdbrecarga.Checked == true)
            {
                if (objRec.ListarTotalRecarga().Count>0)
                {
                    double totRec = double.Parse(txttotrec.Text); ;
                    totRec -= auxi;
                    txttotrec.Text = totRec.ToString();
                    for (int i = 0; i < objRec.ListarTotalRecarga().Count; i++)
                    {
                        if (objRec.ListarTotalRecarga()[i].Totrec >= auxi)
                        {
                            objRec.ActualizaTotales(auxi, objRec.ListarTotalRecarga()[i].IdRec);
                            break;
                        }
                        else
                        {
                            auxi = auxi - objRec.ListarTotalRecarga()[i].Totrec;
                            objRec.ActualizaTotales(objRec.ListarTotalRecarga()[i].Totrec, objRec.ListarTotalRecarga()[i].IdRec);
                            
                        }
                    }
                }
            }
        }

        private void txtvalorE_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;

            if ((letra < 48 || letra > 57) & letra != 8 & letra != 46)
            {
                e.Handled = true;
            }

            if (letra == 46)
            {
                if (txtvalorE.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            if (letra == 13)
            {
                txtdetalleE.Focus();
            }
        }

        private void txtdetalleE_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if ((letra < 'a' || letra > 'z') & (letra < 'A' || letra > 'Z') & letra != 8 & letra != 13 & letra != 32)
            {
                e.Handled = true;
            }
            if (letra == 13)
            {
                btnguardarE.Focus();
            }
        }
    }
}
