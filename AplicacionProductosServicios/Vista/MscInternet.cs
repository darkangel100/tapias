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
        string fecha,estado;
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

        }

        private void registra()
        {

            try
            {
                int res = 0;
                InternetDB obji = new InternetDB();
                int num;
                num = obji.TraeCodigo();
                obji.getInternet().Idinter = Util.generarid(num);
                obji.getInternet().Valor = Convert.ToDouble(txtconsumointernet.Text.Trim());
                obji.getInternet().Fecha = Util.girafecha(dtpingr.Value.ToShortDateString());
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
            
        }

        private void listaprofecha()
        {
            InternetDB obji=new InternetDB();
            try
            {
                string fecha = Util.girafecha(dtpingr.Value.ToShortDateString());
                obji.getInternet().ListaInternet = obji.listacon(fecha);
                if (obji.getInternet().ListaInternet.Count == 0)
                {
                    MessageBox.Show("No exixten registro en el dia de hoy", "Productoy Y servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al presentar datos" + ex.Message,"Productos y Srvicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MscInternet_Load(object sender, EventArgs e)
        {
       
            listaprofecha();
            lblsnombre.Text ="Usuario  "+ Sesiones.C.Nomper+"  ";
            lblfacha.Text = Util.girafecha(dtpingr.Value.ToShortDateString());
            estado = "n";
                    
            
            
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
            

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            txtconsumointernet.Text = dginternet.Rows[fila].Cells[2].Value.ToString();
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

    }
}
