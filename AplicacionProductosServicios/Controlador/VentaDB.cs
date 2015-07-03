using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AplicacionProductosServicios.Modelo;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AplicacionProductosServicios.Controlador
{
    class VentaDB
    {
        venta ven = null;
        conexion con = new conexion();
        public venta getventa()
        {
            if (ven == null)
            {
                ven = new venta();
            }
            return ven;
        }

        public void setventa(venta vent)
        {
            this.ven = vent;
        }


        public int Insertaventa(venta ven)// metodo de tipo de dato int donde recibe un parametro de tipo venta y retorna un dato de tipo int y sirve para insertar datos en la  tabla venta 
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {


                string sqlven = "Insert venta (id_per,tot_vent) Values(" + ven.Id_per + "," + ven.Tot_vent + ")";
                cmd = new MySqlCommand(sqlven, cn);
                cn.Open();
                resp = cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                resp = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                resp = 0;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return resp;
        }
    }
}
