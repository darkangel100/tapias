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
    public partial class MscRegistraSecretaria : Form
    {
        public MscRegistraSecretaria()
        {
            InitializeComponent();
        }
        //DEclaracion de variables a utilizar..
        string estado = "";
        int fila = 0;
        int num = 0;
        string tipo;

        private void btnsalir_Secret_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregistrar_secret_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtcedSecret.Focus();
            estado = "G";
        }

        private void genId()
        {
            int nro;
            UsuarioDB objusu = new UsuarioDB();
            nro = objusu.traeid();
            txtid.Text = Util.generarid(nro).ToString();
        }


        private void cargarol(string est)
        {
            try
            {

                rolDB objr = new rolDB();
                objr.getrol().ListaRol = objr.TraeRoles(est);
                if (objr.getrol().ListaRol.Count == 0)
                {
                    MessageBox.Show("No existen usuarios registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                cborol.DisplayMember = "Nombre";
                cborol.ValueMember = "Nombre";
                cborol.DataSource = objr.getrol().ListaRol;
                //aqui el código
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void llenar()
        {

            try
            {
                UsuarioDB objusu = new UsuarioDB();
                int resp;
                int resc;
                llenaUsuario(objusu);
                resp = objusu.InsertaUsuario(objusu.getUsuario());
                CuentaDB objc = new CuentaDB();
                llenacamcuen(objc);
                resc = objc.ingresacuenta(objc.getCuenta());

                if (resp == 0)
                {
                    MessageBox.Show("No se ingresaron datos del Usuario", "Productos y servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Usuario ingresado correctamente", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar datos," + ex.Message, "Productos y servicios", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private UsuarioDB llenaUsuario(UsuarioDB per)
        {
            rolDB r = new rolDB();
            per.getUsuario().Idper = Convert.ToInt32(txtid.Text.Trim());
            per.getUsuario().Cedper = txtcedSecret.Text.Trim();
            per.getUsuario().Apeper = txtnomsecret.Text.Trim();
            per.getUsuario().Nomper = txtapeSecret.Text.Trim();
            per.getUsuario().Dirper = txtdirecSecret.Text.Trim();
            per.getUsuario().Telper = txttelSecret.Text.Trim();

            if (rdbactivo.Checked == true)
                per.getUsuario().Estper = "A";
            else
                per.getUsuario().Estper = "D";
            /* if (rdnprpiet.Checked == true)
              per.getUsuario()*/

            per.getUsuario().Idrol = r.treidsefunnom(cborol.SelectedValue.ToString());

            return per;
        }
        public void llenarPersona(string estado)
        {
            try
            {
                dgSecretaria.Rows.Clear();
                UsuarioDB objU = new UsuarioDB();
                objU.getUsuario().ListaPersonas = objU.TraePersonas(estado);

                if (objU.getUsuario().ListaPersonas.Count == 0)
                {
                    MessageBox.Show("No existen usuarios ingresados", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objU.getUsuario().ListaPersonas.Count; i++)
                    {
                        dgSecretaria.Rows.Add(1);
                        dgSecretaria.Rows[i].Cells[0].Value = objU.getUsuario().ListaPersonas[i].Cedper;
                        dgSecretaria.Rows[i].Cells[1].Value = objU.getUsuario().ListaPersonas[i].Apeper;
                        dgSecretaria.Rows[i].Cells[2].Value = objU.getUsuario().ListaPersonas[i].Nomper;
                        dgSecretaria.Rows[i].Cells[3].Value = objU.getUsuario().ListaPersonas[i].Dirper;
                        dgSecretaria.Rows[i].Cells[4].Value = objU.getUsuario().ListaPersonas[i].Telper;
                        //dgSecretaria.Rows[i].Cells[5].Value = objU.getUsuario().ListaPersonas[i].Estper;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MscRegistraSecretaria_Load(object sender, EventArgs e)
        {
            llenarPersona("A");
            cargarol("A");
            genId();
        }

        private void btnguardar_Secret_Click(object sender, EventArgs e)
        {
            if (estado == "G")
            {
                llenar();
            }
        }

        private void txtcedSecret_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if ((letra < 48 || letra > 57) & letra != 8 & letra != 13)
            {
                e.Handled = true;
            }
            if (letra == 13)
            {
                txtapeSecret.Focus();
            }
        }
        //Validacion para el ingreso de datos
        private void txtnomSecret_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if ((letra < 'a' || letra > 'z') & (letra < 'A' || letra > 'Z') & letra != 8 & letra != 13 & letra != 32)
            {
                e.Handled = true;
            }
            if (letra == 13)
            {
                txtnomsecret.Focus();
            }
        }

        private void txtnomsecret_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if ((letra < 'a' || letra > 'z') & (letra < 'A' || letra > 'Z') & letra != 8 & letra != 13 & letra != 32)
            {
                e.Handled = true;
            }
            if (letra == 13)
            {
                txtdirecSecret.Focus();
            }
        }

        private void txtdirecSecret_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if ((letra < 'a' || letra > 'z') & (letra < 'A' || letra > 'Z') & letra != 8 & letra != 13 & letra != 32)
            {
                e.Handled = true;
            }
            if (letra == 13)
            {
                txttelSecret.Focus();
            }
        }

        private void txttelSecret_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if ((letra < 48 || letra > 57) & letra != 8 & letra != 13)
            {
                e.Handled = true;
            }
            if (letra == 13)
            {
                groupBox2.Focus();
            }
        }

        public void LimpiarCampos()
        {
            txtcedSecret.Text = null;
            txtapeSecret.Text = null;
            txtnomsecret.Text = null;
            txtdirecSecret.Text = null;
            txttelSecret.Text = null;
            txtclave.Text = null;
            rdbactivo.Checked = true;
            btnregistrar_secret.Focus();
            groupBox1.Enabled = false;
        }
        private CuentaDB llenacamcuen(CuentaDB cuen)
        {
            cuen.getCuenta().Idper = Convert.ToInt32(txtid.Text.Trim());
            cuen.getCuenta().Clave = txtclave.Text.Trim();
            cuen.getCuenta().Nomper = txtnomsecret.Text.Trim();
            if (rdbactivo.Checked == true)
                cuen.getCuenta().Estper = "A";
            else
                cuen.getCuenta().Estper = "D";
            return cuen;
        }
        private void btnmodificarSecre_Click(object sender, EventArgs e)
        {
            Modificar();
            groupBox1.Enabled = true;
        }
        private void Modificar()
        {
            UsuarioDB objSecre = new UsuarioDB();
            CuentaDB objC = new CuentaDB();
            objSecre.setUsuario(objSecre.Traepersona(dgSecretaria.Rows[fila].Cells[0].Value.ToString()));
            if (objSecre.getUsuario().Cedper == "")
            {
                MessageBox.Show("No existen Registros de Usuarios", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtcedSecret.Text = objSecre.getUsuario().Cedper;
                txtapeSecret.Text = objSecre.getUsuario().Nomper;
                txtnomsecret.Text = objSecre.getUsuario().Apeper;
                txtdirecSecret.Text = objSecre.getUsuario().Dirper;
                txttelSecret.Text = objSecre.getUsuario().Telper;
                txtclave.Text = objC.getCuenta().Clave;
                if (objSecre.getUsuario().Estper.Equals("A"))
                    rdbactivo.Checked = true;
                else
                    rdbdesactivo.Checked = true;
                estado = "E";

            }
        }
        /*private void CambiarDatos()
        {
            try
            {
                UsuarioDB objse = new UsuarioDB();
                int resp;
                //objse.getUsuario().Cedper = txtcedSecret.Text;
                llenaUsuario(objse);
                resp = objse.ActualizaUsuario(objse.getUsuario());
                if (resp == 0)
                {
                    MessageBox.Show("No se Modificaron los datos del Usuario", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Usuario Modificado exitosamente", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   llenarPersona("A");
                    estado = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar datos," + ex.Message, "Productos y Serviscios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }*/

        private void dgSecretaria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = dgSecretaria.CurrentRow.Index;

        }
    }
}

    
