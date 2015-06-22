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
        string estado = "G";
        int fila;

        private void btnsalirPines_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregistarpines_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }
        private void llenaPines()
        {
            try
            {
                dataGridView1.Rows.Clear();
                pinesDB objP = new pinesDB();
                objP.getPines().Listapines = objP.TraePines();
                if (objP.getPines().Listapines.Count == 0)
                {
                    MessageBox.Show("No existen registros ingresados", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objP.getPines().Listapines.Count; i++)
                    {
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[i].Cells[0].Value = objP.getPines().Listapines[i].Idpines;
                        dataGridView1.Rows[i].Cells[1].Value = objP.getPines().Listapines[i].Fecha;
                        dataGridView1.Rows[i].Cells[2].Value = objP.getPines().Listapines[i].Canpines;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presenatr datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llenar()
        {
            try
            {
                pinesDB objpin = new pinesDB();
                int resp;
                llenaPines();
                resp = objpin.InsertePines(objpin.getPines());
                if (resp == 0)
                {
                    MessageBox.Show("No se Ingresaron datos", "productos y servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Los datos se han ingresado correctamente", "Productos y Servicos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    estado = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos," + ex.Message, "Productos Y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguardarPines_Click(object sender, EventArgs e)
        {
            if (estado =="G")
            {
                llenar();
            }
        }

        private void MscPines_Load(object sender, EventArgs e)
        {
            llenaPines();
        }
       
    }
}
