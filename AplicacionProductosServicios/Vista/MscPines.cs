﻿using System;
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

        private void btnsalirPines_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnregistarpines_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            estado = "G";
            txtregPines.Focus();
        }
        private void llenaPines()
        {
            try
            {
                dtgPines.Rows.Clear();
                pinesDB objP = new pinesDB();
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

        private void llenar()
        {
            try
            {
                pinesDB objpin = new pinesDB();
                CuentaDB objC = new CuentaDB();
                int resp;

                objpin.getPines().Canpines = Convert.ToInt32(txtregPines.Text.Trim());
                objpin.getPines().Idper = Sesiones.C.Idper;
                resp = objpin.InsertePines(objpin.getPines());
                //objpin.getPines().Fecha = Util.girafecha(dateTimePicker1.Value.ToShortDateString);
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

        private void dtgPines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = dtgPines.CurrentRow.Index;
            btnmodifpines.Enabled = true;
            groupBox1.Enabled = false;
        }
        private void Modificar()
        {
            try
            {
                pinesDB objP = new pinesDB();

                objP.setPines(objP.TraePin(Convert.ToInt32(dtgPines.Rows[fila].Cells[0].Value.ToString())));
                if (objP.getPines().Idpines == 0)
                {
                    MessageBox.Show("No existe Registro de Pines", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtregPines.Text = objP.getPines().Canpines.ToString();
                    groupBox1.Enabled = true;
                }
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
                pinesDB objP = new pinesDB();
                int resp;
                objP.getPines().Idpines = Convert.ToInt32(dtgPines.Rows[fila].Cells[0].Value.ToString());
                objP.getPines().Idper = Sesiones.C.Idper;
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

        private void btnmodifpines_Click(object sender, EventArgs e)
        {
            estado = "E";
            Modificar();
            txtregPines.Focus();
        }
        private void Limpiar()
        {
            txtregPines.Text = null;
            groupBox1.Enabled = false;
            btnmodifpines.Enabled = false;
        }
       
    }
}
