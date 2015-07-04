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
    public partial class MscInternet : Form
    {
        string fecha1,fecha2,estado;
        int fila;
        public MscInternet()
        {
            InitializeComponent();
        }
       
        
        private void btnregistar_Click(object sender, EventArgs e)
        {
            txtconsumointernet.Enabled = true;
            btnguardar.Enabled = true;
            txtconsumointernet.Focus();
            estado = "n";
            btnregistar.Enabled = false;
        }

        private void registra()
        {

            try
            {
                int res = 0;
                InternetDB obji = new InternetDB();
                obji.getInternet().Valor = Convert.ToDouble(txtconsumointernet.Text.Trim());
                obji.getInternet().Idper = Sesiones.C.Idper;
                res = obji.InsertaInter(obji.getInternet());

                if (res == 0)
                {
                    MessageBox.Show("Los datos no se rergistraron correctamente", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Los datos  se rergistraron correctamente", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    listaprofecha();
                    estado= null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al ingresar DATOS "+ ex.Message,"Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


             

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (estado == "n")
            {
             registra();
            }
            if (estado == "m")
            {
                modificar();
            }
            txtconsumointernet.Enabled = false;
            txtconsumointernet.Text = null;
            btnregistar.Enabled = true;
        }

        private void listaprofecha()
        {
            InternetDB obji=new InternetDB();
            double totcom = 0;
            try
            {
                fecha1 = Util.girafecha(dtp1.Value.ToShortDateString());
                fecha2 = Util.girafecha(dt2.Value.ToShortDateString());
                obji.getInternet().ListaInternet = obji.listacon(fecha1,fecha2);
                if (obji.getInternet().ListaInternet.Count == 0)
                {
                    MessageBox.Show("No exixten registro en el dia de hoy", "Productoy Y servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dginternet.Rows.Clear();
                    
                }
                else
                {
                    dginternet.Rows.Clear();
                    for (int i = 0; i < obji.getInternet().ListaInternet.Count; i++)
                    {
                        dginternet.Rows.Add(1);
                        dginternet.Rows[i].Cells[0].Value = obji.getInternet().ListaInternet[i].Idinter;
                        dginternet.Rows[i].Cells[1].Value = obji.getInternet().ListaInternet[i].Fecha;
                        dginternet.Rows[i].Cells[2].Value = obji.getInternet().ListaInternet[i].Valor;
                        totcom += obji.getInternet().ListaInternet[i].Valor;

                    }
                }
                txttotcon.Text = totcom.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al presentar datos" + ex.Message,"Productos y Srvicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MscInternet_Load(object sender, EventArgs e)
        {
            dt2.Value = DateTime.Now;
            dtp1.Value = DateTime.Now;
            listaprofecha();
            lblsnombre.Text ="Usuario  "+ Sesiones.C.Nomper+"  ";
            lblfacha.Text = Util.girafecha( dtpbus.Value.ToShortDateString());
                             
            
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void dginternet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnmodificar.Enabled = true;
            btnmodificar.Focus();
            fila =dginternet.CurrentRow.Index;
            btnmodificar.Enabled = true;
            btnmodificar.Focus();
            

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            txtconsumointernet.Enabled = true;
            txtconsumointernet.Text = dginternet.Rows[fila].Cells[2].Value.ToString();
            txtconsumointernet.Focus();
            estado = "m";
        }

        private void modificar()
        {

            try
            {
                InternetDB obji = new InternetDB();
                int resp;
                resp = obji.modificaValor(Convert.ToInt32(dginternet.Rows[fila].Cells[0].Value),Convert.ToDouble(txtconsumointernet.Text));

                if (resp == 0)
                {
                    MessageBox.Show("No se modificaron correctamente los valores ", "Productos y Servicios", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Modificacion exitosa ", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    listaprofecha();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void dt2_CloseUp(object sender, EventArgs e)
        {
            fecha2 = Util.girafecha(dt2.Value.ToShortDateString());
        }
        
        private void dtp1_CloseUp(object sender, EventArgs e)
        {
            fecha1 = Util.girafecha(dtp1.Value.ToShortDateString());
       }
     
        private void btnBuscar_Click(object sender, EventArgs e)
        {
         
            listaprofecha();
        }
        private void limpiatxbox()
        {
            txtconsumointernet.Text = null;
        }

        private void txtconsumointernet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;

            if ((letra < 48 || letra > 57) & letra != 8 & letra != 46)
            {
                e.Handled = true;
            }

            if (letra == 46)
            {
                if (txtconsumointernet.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            if (letra == 13)
            {
                btnguardar.Focus();
            }
        }

        private void dginternet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        

    }
}
