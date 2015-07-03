using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AplicacionProductosServicios.Modelo;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AplicacionProductosServicios.Controlador
{
    class ProVentaDB
    {
        pro_vent prodVenta = null;
        conexion con = new conexion();

        public pro_vent getprodventa()
        {
            if (prodVenta == null)
            {
                prodVenta = new pro_vent();
            }
            return prodVenta;
        }

        public void setprodventa(pro_vent pv)
        {
            this.prodVenta = pv;
        }
        public int InseraPV(pro_vent Pvent)// metodo de tipo de dato int donde recibe un parametro de tipo venta y retorna un dato de tipo int y sirve para insertar datos en la  tabla venta 
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {

               // string sqlcuenta = "Insert cuenta values(" + cuen.Idcuenta + "," + cuen.Idper + ",'" + cuen.Clave + "','" + cuen.Nomper + "','" + cuen.Estper + "','" + cuen.Ultacceso + "')";
                string sqlven = "Insert prod_vent values(" +Pvent.Id_venta+ "," +Pvent.Cod_pro+ "," +Pvent.Can_vent+ "," +Pvent.Val_unit+ "," +Pvent.Tot_vent+ ")"; 
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
