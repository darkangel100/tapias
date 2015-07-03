using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AplicacionProductosServicios.Modelo;
using MySql.Data.MySqlClient;

namespace AplicacionProductosServicios.Controlador
{
    class pinesDB
    {
        conexion con = new conexion();
        Pines pin = null;
        public Pines getPines()
        {
            if (this.pin == null)
            {
                this.pin = new Pines();
            }
            return this.pin;
        }
        public void setPines(Pines pins)
        {
            pin = pins;
           // return pins;
        }
        public int InsertePines(Pines pin)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {
                string sqlcad = "Insert pines Values(" + pin.Idpines + "," + pin.Idper + ",'" + pin.Fecha + "'," + pin.Canpines + ")";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
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
            cmd = null;
            cn.Close();
            return resp;
        }
        public List<Pines> TraePines()
        {
            pinesDB pi = null;
            List<Pines> lisPines = new List<Pines>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlcad = "Select * from pines order by can_pines";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    pi = new pinesDB();
                    pi.getPines().Idpines = Convert.ToInt32(dr[0].ToString());
                    pi.getPines().Idper = Convert.ToInt32(dr[1].ToString());
                    pi.getPines().Fecha = Convert.ToDateTime(dr[2].ToString());
                    pi.getPines().Canpines = Convert.ToInt32(dr[3].ToString());
                    lisPines.Add(pi.getPines());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                pi = null;
                throw ex;
            }
            catch(Exception ex)
            {
                pi=null;
                throw ex;
            }           
            cmd = null;
            cn.Close();
            return lisPines;
        }
        public Pines TraePin(int id)
        {
            pinesDB pin = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlcad = "Select * from pines where id_pines=" + id + "";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pin = new pinesDB();
                    pin.getPines().Idpines = Convert.ToInt32(dr[0].ToString());
                    pin.getPines().Idper = Convert.ToInt32(dr[1].ToString());
                    pin.getPines().Fecha = Convert.ToDateTime(dr[2].ToString());
                    pin.getPines().Canpines = Convert.ToInt32(dr[3].ToString());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                pin = null;
                throw ex;
            }
            catch (Exception ex)
            {
                pin = null;
                throw ex;
            }
            cmd = null;
            cn.Close();
            return pin.getPines();
        }
        public int ActualizaPines(Pines id)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {
                string sqlpines = "Update pines set id_per=" + id.Idper + ",fecha='" + id.Fecha + "',can_pines=" + id.Canpines + " Where id_pines=" + id.Idpines + "";
                cmd = new MySqlCommand(sqlpines, cn);
                cmd.CommandType = CommandType.Text;
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
            cmd = null;
            cn.Close();
            return resp;
        }
    }
}
