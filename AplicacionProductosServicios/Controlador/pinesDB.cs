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
        public Pines setPines(Pines pins)
        {
            pin = pins;
            return pins;
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
            pin = null;
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
                    pi.getPines().Fecha = dr[2].ToString();
                    pi.getPines().Canpines = Convert.ToInt32(dr[3].ToString());
                    lisPines.Add(pi.getPines());
                }
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
        public Pines TraePin(Pines id)
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
                    pin.getPines().Fecha = dr[2].ToString();
                    pin.getPines().Canpines = Convert.ToInt32(dr[3].ToString());
                }
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
       
    }
}
