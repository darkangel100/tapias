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
        

        private void btnsalir_Secret_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregistrar_secret_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtcedSecret.Focus();
            estado = "G";
            rdbactivo.Checked = true;
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
                cborol.ValueMember = "Idrol";
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
            
            per.getUsuario().Idper = Convert.ToInt32(txtid.Text.Trim());
            per.getUsuario().Cedper = txtcedSecret.Text.Trim();
            per.getUsuario().Apeper = txtapeSecret.Text.Trim();
            per.getUsuario().Nomper =  txtnomsecret.Text.Trim();
            per.getUsuario().Dirper = txtdirecSecret.Text.Trim();
            per.getUsuario().Telper = txttelSecret.Text.Trim();

            if (rdbactivo.Checked == true)
                per.getUsuario().Estper = "A";
            else
                per.getUsuario().Estper = "D";
            /* if (rdnprpiet.Checked == true)
              per.getUsuario()*/

            per.getUsuario().Idrol = Convert.ToInt32(cborol.SelectedValue.ToString());

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
                        dgSecretaria.Rows[i].Cells[0].Value = objU.getUsuario().ListaPersonas[i].Idper;
                        dgSecretaria.Rows[i].Cells[1].Value = objU.getUsuario().ListaPersonas[i].Cedper;
                        dgSecretaria.Rows[i].Cells[2].Value = objU.getUsuario().ListaPersonas[i].Nomper;
                        dgSecretaria.Rows[i].Cells[3].Value = objU.getUsuario().ListaPersonas[i].Apeper;
                        dgSecretaria.Rows[i].Cells[4].Value = objU.getUsuario().ListaPersonas[i].Dirper;
                        dgSecretaria.Rows[i].Cells[5].Value = objU.getUsuario().ListaPersonas[i].Telper;
                        //dgSecretaria.Rows[i].Cells[6].Value = objU.getUsuario().ListaPersonas[i].Estper;
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
            cborol.Text = "Seleccione el rol";
        }

        private void btnguardar_Secret_Click(object sender, EventArgs e)
        {
            //validacion
            if (txtcedSecret.Text.Trim().Length > 0 && txtdirecSecret.Text.Trim().Length > 0 & txtapeSecret.Text.Trim().Length > 0 & txtnomsecret.Text.Trim().Length > 0 & txttelSecret.Text.Trim().Length > 0 & txtclave.Text.Trim().Length > 0 & cborol.Text.Trim().Length > 0)
            {
                if (estado == "G")
                {
                    llenar();
                }
                if (estado == "E")
                {
                    CambiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Algunos campos estan vacíos", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
        private void validarLetras(KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if ((letra < 'a' || letra > 'z') & (letra < 'A' || letra > 'Z') & letra != 8 & letra != 13 & letra != 32)
            {
                e.Handled = true;
            }
        }

        private void ValidarNumeros(KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if ((letra < 48 || letra > 57) & letra != 8 & letra != 13)
            {
                e.Handled = true;
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
            cborol.Text = null;
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
  
        private void Modificar()
        {
            UsuarioDB objSecre = new UsuarioDB();           

            objSecre.setUsuario(objSecre.Traepersona(dgSecretaria.Rows[fila].Cells[1].Value.ToString()));
            if (objSecre.getUsuario().Cedper == "")
            {
                MessageBox.Show("No existen Registros de Usuarios", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtid.Text = objSecre.getUsuario().Idper.ToString();
                txtcedSecret.Text = objSecre.getUsuario().Cedper;
                txtapeSecret.Text = objSecre.getUsuario().Nomper;
                txtnomsecret.Text = objSecre.getUsuario().Apeper;
                txtdirecSecret.Text = objSecre.getUsuario().Dirper;
                txttelSecret.Text = objSecre.getUsuario().Telper;
                
                if (objSecre.getUsuario().Estper.Equals("A"))
                    rdbactivo.Checked = true;
                else
                    rdbdesactivo.Checked = true;
                estado = "E";
                if (objSecre.getUsuario().Idrol.Equals(1))
                    cborol.Text = "Propietario";
                else if (objSecre.getUsuario().Idrol.Equals(2))
                    cborol.Text = "Secretaria1";
                else
                    cborol.Text = "Secretaria2";
            }
        }
        private void CambiarDatos()
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
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar datos," + ex.Message, "Productos y Serviscios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnmodificarSecre_Click_1(object sender, EventArgs e)
        {
            Modificar();
            groupBox1.Enabled = true;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscaPer();
        }

        private void dgSecretaria_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            fila = dgSecretaria.CurrentRow.Index;
        }
        private void BuscaPer()
        {
            try
            {
                UsuarioDB objU = new UsuarioDB();
                dgSecretaria.Rows.Clear();
                if (cboOpcionBus.SelectedIndex == 0)
                {
                    objU.getUsuario().ListaPersonas = objU.Buscarusuario(txtbusSecret.Text);
                    if (objU.getUsuario().ListaPersonas.Count == 0)
                    {
                        MessageBox.Show("No existe el Usuario");
                    }
                    else
                    {
                        dgSecretaria.Rows.Add(objU.getUsuario().ListaPersonas.Count);
                        for (int i = 0; i < objU.getUsuario().ListaPersonas.Count; i++)
                        {

                            dgSecretaria.Rows[fila].Cells[1].Value = objU.getUsuario().ListaPersonas[fila].Cedper;
                            dgSecretaria.Rows[fila].Cells[2].Value = objU.getUsuario().ListaPersonas[fila].Apeper;
                            dgSecretaria.Rows[fila].Cells[3].Value = objU.getUsuario().ListaPersonas[fila].Nomper;
                            dgSecretaria.Rows[fila].Cells[4].Value = objU.getUsuario().ListaPersonas[fila].Dirper;
                            dgSecretaria.Rows[fila].Cells[5].Value = objU.getUsuario().ListaPersonas[fila].Telper;
                        }
                    }

                }
                else if (cboOpcionBus.SelectedIndex > 0)
                {
                    objU.getUsuario().ListaPersonas = objU.BuscarPorApellido(txtbusSecret.Text);
                    if (objU.getUsuario().ListaPersonas.Count == 0)
                    {
                        MessageBox.Show("No existe el Usuario");
                    }
                    else
                    {
                        dgSecretaria.Rows.Add(objU.getUsuario().ListaPersonas.Count);
                        for (int i = 0; i < objU.getUsuario().ListaPersonas.Count; i++)
                        {

                            dgSecretaria.Rows[fila].Cells[1].Value = objU.getUsuario().ListaPersonas[fila].Cedper;
                            dgSecretaria.Rows[fila].Cells[2].Value = objU.getUsuario().ListaPersonas[fila].Apeper;
                            dgSecretaria.Rows[fila].Cells[3].Value = objU.getUsuario().ListaPersonas[fila].Nomper;
                            dgSecretaria.Rows[fila].Cells[4].Value = objU.getUsuario().ListaPersonas[fila].Dirper;
                            dgSecretaria.Rows[fila].Cells[5].Value = objU.getUsuario().ListaPersonas[fila].Telper;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar datos," + ex.Message, "Productos y Serrvicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtcedSecret_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeros(e);
        }

        private void txtapeSecret_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarLetras(e);
        }

        private void txtnomsecret_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarLetras(e);
        }

        private void txttelSecret_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeros(e);
        }
    }
}

    
