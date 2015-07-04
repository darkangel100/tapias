using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AplicacionProductosServicios.Modelo;
using System.Data;
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
                string sqlven = "Insert pro_vent values(" + Pvent.Id_venta + "," + Pvent.Cod_pro + "," + Pvent.Can_vent + "," + Pvent.Val_unit + "," + Pvent.Tot_vent + ")";
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
        public pro_vent listacon(int id_ven)
        {

            ProVentaDB pv = null;
     
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            try
            {
               
                string sqlpventa = "Select * from pro_vent where id_vent= " + id_ven + " ";
                cmd = new MySqlCommand(sqlpventa, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    pv = new ProVentaDB();
                    pv.getprodventa().Cod_pro = Convert.ToInt32(dr[1]);
                    pv.getprodventa().Can_vent = Convert.ToInt32(dr[2]);
                    pv.getprodventa().Val_unit = Convert.ToDouble(dr[3]);
                    pv.getprodventa().Tot_vent = Convert.ToDouble(dr[4]);
                
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                pv = null;
                throw ex;

            }
            catch (Exception ex)
            {
                pv = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return pv.getprodventa();


        }
        public int modifcapv(pro_vent Pvent)// metodo de tipo de dato int donde recibe un parametro de tipo venta y retorna un dato de tipo int y sirve para insertar datos en la  tabla venta 
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {

               
                string sqlven = "UPDATE pro_vent SET cant_vent=" + Pvent.Can_vent + ",val_unit=" +Pvent.Val_unit+",val_tot="+Pvent.Tot_vent+" WHERE id_vent=" + Pvent.Id_venta + "";
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
