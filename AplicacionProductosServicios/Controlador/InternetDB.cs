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

        public internet getInternet() // metodo de nombre getinternet de tipo interternet donde retorna un dato del mismo tipo
        {
            if (this.inter == null)
            {
                this.inter = new internet();
            }

            return this.inter;
        }
        public void setInternet(internet inte)// metdod que recibe un paramerto de tipo internet y no retorna nada 
        {
            inter = inte;
        }


        public int InsertaInter(internet inte)// metodo de tipo de dato int donde recibe un parametro de tipo internet y retorna un dato de tipo int y sirve para insertar ala tabla internet los valores de valor y el id de persona
        {
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();
            int resp;
            try
            {

            
                string sqlinter = "Insert internet (id_per,valor) Values(" + inte.Idper + "," + inte.Valor + ")";
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

        public List<internet> listacon(string fechas1,string fechas2)
        {

            InternetDB inter=null;
            List<internet> listin = new List<internet>();
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();
            try
            {
                string sqlinter = "SELECT * FROM internet WHERE CAST(fecha AS DATE) BETWEEN '" + fechas1 + "' AND '" + fechas2 + "'";
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



        public int modificaValor(int id ,double val) // metoso 
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

      

  



    

