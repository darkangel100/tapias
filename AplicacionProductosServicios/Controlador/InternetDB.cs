using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AplicacionProductosServicios.Modelo;
using System.Data;
using MySql.Data.MySqlClient;

namespace AplicacionProductosServicios.Controlador
{
    class InternetDB
    {
        conexion cn = new conexion();
        internet inter = null;

        public internet getInternet()
        {
            if (this.inter == null)
            {
                this.inter = new internet();
            }

            return this.inter;
        }
        public void setInternet(internet inte)
        {
            inter = inte;
        }


        public int TraeCodigo()
        {
            int nro = 0;
            MySqlConnection con = cn.getconection();
            MySqlCommand cmd;
            try
            {
                string sqlpro = "Select max(id_inter) as nro from internet ";
                cmd = new MySqlCommand(sqlpro, con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (DBNull.Value == dr["nro"])
                        nro = 0;
                    else
                        nro = Convert.ToInt32(dr["nro"]);


                }
                dr.Close();

            }
            catch (MySqlException ex)
            {
                nro = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                nro = 0;
                throw ex;
            }
            con.Close();
            cmd = null;
            return nro;

        }

        public int InsertaInter(internet inte)
        {
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();
            int resp;
            try
            {
                string sqlinter = "Insert internet values(" + inte.Idinter + "," + inte.Idper + ",'" + inte.Fecha + "'," + inte.Valor + ")";
                cmd = new MySqlCommand(sqlinter, con);
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
            con.Close();
            cmd = null;
            return resp;
        }

        public List<internet> listacon(string fecha)
        {

            InternetDB inter=null;
            List<internet> listin = new List<internet>();
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();
            try
            {
                string sqlinter = "Select * from internet where fecha='" + fecha + "'";
                cmd = new MySqlCommand(sqlinter, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
               
                
                while (dr.Read())
                {
                    inter = new InternetDB();
                    inter.getInternet().Idinter = Convert.ToInt32(dr[0]);
                    inter.getInternet().Idper = Convert.ToInt32(dr[1]);
                    inter.getInternet().Fecha = dr[2].ToString();
                    inter.getInternet().Valor = Convert.ToDouble(dr[3]);
                    listin.Add(inter.getInternet());
                }
                dr.Close();
            }
             catch(MySqlException ex)
            {
              inter=null;
              throw ex;

             }
            catch(Exception ex)
            {
                inter=null;
                throw ex;
            }
            con.Close();
            cmd=null;
           return listin;
             
            
            }



        public int modificaValor(int id ,double val)
        {
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();
            int resp;
            try
            {
                string sqlinter = "Update internet set valor= " + val + " Where id_inter=" + id + "";
                cmd = new MySqlCommand(sqlinter, con);
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
            con.Close();
            cmd = null;
            return resp;
        }


          

          
    }

    }

      

  



    

