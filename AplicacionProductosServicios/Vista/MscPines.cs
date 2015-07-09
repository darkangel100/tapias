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
    public partial class MscPines : Form
    {
        public MscPines()
        {
            InitializeComponent();
        }
        string estado = "";
        int fila;

        private void btnsalirPines_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmodifpines_Click(object sender, EventArgs e)
        {
            estado = "E";
            Modificar();
            txtregPines.Focus(); 
        }

        private void btnregistarpines_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            estado = "G";
            txtregPines.Text = null;
            txtregPines.Focus();
        }
        private void llenar()
        {
            try
            {
                PinesDB objpin = new PinesDB();
                int resp;

                objpin.getPines().Canpines = Convert.ToInt32(txtregPines.Text.Trim());
                objpin.getPines().Idper = Sesiones.C.Idper;
                resp = objpin.InsertePines(objpin.getPines());

                if (resp == 0)
                {
                    MessageBox.Show("No se Ingresaron datos", "productos y servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Los datos se han ingresado correctamente", "Productos y Servicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    llenaPines();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos," + ex.Message, "Productos Y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void llenaPines()
        {

            try
            {
                dtgPines.Rows.Clear();
                PinesDB objP = new PinesDB();
                objP.getPines().Listapines = objP.TraePines();
                if (objP.getPines().Listapines.Count == 0)
                {
                    MessageBox.Show("No existen registros ingresados", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    for (int i = 0; i < objP.getPines().Listapines.Count; i++)
                    {
                        dtgPines.Rows.Add(1);
                        dtgPines.Rows[i].Cells[0].Value = objP.getPines().Listapines[i].Idpines;
                        dtgPines.Rows[i].Cells[1].Value = objP.getPines().Listapines[i].Fecha;
                        dtgPines.Rows[i].Cells[2].Value = objP.getPines().Listapines[i].Canpines;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presenatr datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguardarPines_Click(object sender, EventArgs e)
        {
            if (estado == "G")
            {
                llenar();
            }
            if (estado == "E")
            {
                Editar();
            }
        }
        private void Limpiar()
        {
            txtregPines.Text = null;
            groupBox1.Enabled = false;
            btnmodifpines.Enabled = false;
        }
        private void Modificar()
        {
            try
            {
                txtregPines.Text = dtgPines.Rows[fila].Cells[2].Value.ToString();
                groupBox1.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Presenatr Datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Editar()
        {

            try
            {
                PinesDB objP = new PinesDB();
                int resp;
                objP.getPines().Idpines = Convert.ToInt32(dtgPines.Rows[fila].Cells[0].Value);
                objP.getPines().Canpines = Convert.ToInt32(txtregPines.Text);
                resp = objP.ActualizaPines(objP.getPines());

                if (resp == 0)
                {
                    MessageBox.Show("No se Modifico datos de los Pines", "productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Los datos se modificaron Correctamente", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    Limpiar();
                    llenaPines();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BuscarFecha()
        {
            try
            {
                dtgPines.Rows.Clear();
                PinesDB objP = new PinesDB();
                string fec1, fec2;
                fec1 = Util.girafecha(dtDesde.Value.ToShortDateString());
                fec2 = Util.girafecha(dtHasta.Value.ToShortDateString());

                objP.getPines().Listapines = objP.BuscarPines(fec1, fec2);

                if (objP.getPines().Listapines.Count == 0)
                {
                    MessageBox.Show("No existen registros de la fecha seleccionada", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    llenaPines();
                }
                else
                {
                    dtgPines.Rows.Add(objP.getPines().Listapines.Count);
                    for (int i = 0; i < objP.getPines().Listapines.Count; i++)
                    {
                        dtgPines.Rows[i].Cells[1].Value = objP.getPines().Listapines[i].Fecha;
                        dtgPines.Rows[i].Cells[2].Value = objP.getPines().Listapines[i].Canpines;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgPines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = dtgPines.CurrentRow.Index;
            btnmodifpines.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void MscPines_Load(object sender, EventArgs e)
        {
            llenaPines();
            btnmodifpines.Enabled = false;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarFecha();
        }

        private void txtregPines_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if ((letra < 48 || letra > 57) & letra != 8 & letra != 13)
            {
                e.Handled = true;
            }
            if (letra == 13)
            {
                btnguardarPines.Focus();
            }
        }

        private void btnsalirPines_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
