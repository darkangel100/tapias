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
    public partial class MscRol : Form
    {
        public MscRol()
        {
            InitializeComponent();
        }
        string estado = "";

        private void MscRol_Load(object sender, EventArgs e)
        {
            llenaRoles("A");
            genId();
        }
        public  void Adiciona()
        {
            try
            {
                rolDB objro = new rolDB();
                int resp;
                objro.getrol().Idrol = Convert.ToInt32(txtidrol.Text.Trim());
                objro.getrol().Nombre = txtnomrol.Text.Trim();
                if (rdbac.Checked == true)
                    objro.getrol().Estrol = "A";
                else
                    objro.getrol().Estrol = "P";

                resp = objro.insertarol(objro.getrol());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingresaron datos", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Rol Ingresado", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void llenaRoles(string est)
        {
            try
            {
                rolDB objR = new rolDB();
                objR.getrol().ListaRol = objR.TraeRoles(est);
                if (objR.getrol().ListaRol.Count == 0)
                {
                    MessageBox.Show("No hay registro de Roles", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                lstroles.DisplayMember = "Nombre";
                lstroles.ValueMember = "Nombre";
                lstroles.DataSource = objR.getrol().ListaRol;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar datos,"+ex.Message,"Productos y Servicios",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void genId()
        {
            int nro;
            rolDB objr = new rolDB();
            nro = objr.traeid();
            txtidrol.Text = Util.generarid(nro).ToString();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Adiciona();
        }

        

    }
}
