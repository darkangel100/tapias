using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using AplicacionProductosServicios.Modelo;
using System.Data;


namespace AplicacionProductosServicios.Controlador
{
    class CuentaDB
    {
        conexion cn = new conexion();
        cuenta cuent = null;
        public cuenta getCuenta()
        {
            if (this.cuent == null)
            {
                this.cuent = new cuenta();
            }
            return this.cuent;
        }
        public void setcuenta(cuenta cuenta)
        {
            this.cuent = cuenta;
        }

        public int ingresacuenta(cuenta cuen)
        {
            int resp;
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();
            try
            {
                string sqlcuenta = "Insert cuenta values(" + cuen.Idcuenta + "," + cuen.Idper + ",'" + cuen.Clave + "','" + cuen.Nomper + "','" + cuen.Estper + "','" + cuen.Ultacceso + "')";
                cmd = new MySqlCommand(sqlcuenta, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
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
            cmd = null;
            con.Close();
            return resp;

        }
        public cuenta treacunta(string nombre, String clave)
        {
            CuentaDB q=null;
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();
       
            try
            {
                string sqlcuen = "Select * from cuenta where nom_per='" + nombre + "' and clave = '" + clave+"'"; 
                cmd = new MySqlCommand(sqlcuen, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    q = new CuentaDB();
                    q.getCuenta().Idper = Convert.ToInt32(rd[1]);
                    q.getCuenta().Nomper = rd[3].ToString();
                   //.getCuenta().Clave = rd[2].ToString();
                    q.getCuenta().Estper = rd[4].ToString();
                  

                }
                rd.Close();

            }
            catch (Exception ex)
            {
                q = null;
                throw ex;
          }
            return q.getCuenta();
        }



    }
}
