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


                string sqlinter = "Insert internet (id_per,valor,tot_int) Values(" + inte.Idper + "," + inte.Valor + ","+inte.Valor+")"; // sentencia sql que permite  insertar datos en la tabla internet
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
        }// fin del metodo insertaInter

        public List<internet> listacon(string fechas1,string fechas2) // metodo que me permite listar el consumo de internet donde recibe dos parametros de tipo strin  y me retorna una lista de tipo internet
        {

            InternetDB inter=null;
            List<internet> listin = new List<internet>();
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();
            try
            {
                string sqlinter = "SELECT * FROM internet WHERE CAST(fecha AS DATE) BETWEEN '" + fechas1 + "' AND '" + fechas2 + "'";// sentancia sql que permite selecionar datos de la tabla internet que esten dentro de un rango de fechas especificado donde recibe dos parametros de tipo strin  
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
             
            
            }// fin del metodo listacom



        public int modificaValor(int id ,double val) // metodo que permite modificar el valor de consumo de internet donde recive dos parametros uno de tipo decimal  y otro de tipo entero el los cualkes 
        {
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();
            int resp;
            try
            {
                string sqlinter = "Update internet set valor= " + val + " Where id_inter=" + id + ""; // sentencia sql que permite actualizar el valos de consumo de la tabla internet 
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
        }// fin del metodo modificar valor

        public List<internet> ListarTotalInternet()//Metodo para buscar enviando una fecha y por su puesto retornandome una lista de objetos... 
        {
            InternetDB inte = null;
            List<internet> ListdeBusqueda = new List<internet>();
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();

            try
            {
                string sqlint = "SELECT * FROM internet WHERE tot_int > 0 order by id_inter desc";
                cmd = new MySqlCommand(sqlint, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    inte = new InternetDB();
                    inte.getInternet().Idinter = Convert.ToInt32(dr[0].ToString());
                    inte.getInternet().Idper = Convert.ToInt32(dr[1].ToString());
                    inte.getInternet().Fecha = dr[2].ToString();
                    inte.getInternet().Valor = Convert.ToDouble(dr[3].ToString());
                    inte.getInternet().Totint = Convert.ToDouble(dr[4].ToString());
                    ListdeBusqueda.Add(inte.getInternet());

                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                inte = null;
                throw ex;
            }
            catch (Exception ex)
            {
                inte = null;
                throw ex;
            }
            cmd = null;
            con.Close();
            return ListdeBusqueda;
        }
        public int ActualizaTotales(double val, int id)//Metodo para actualizar la cantidad total restandole las recargas vendidas...
        {
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();
            int resp;
            try
            {
                string sqlint = "update internet set tot_int = (tot_int -" + val + ") where id_inter = " + id;
                cmd = new MySqlCommand(sqlint, con);
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
        public double sumaCant3()//Metodo para realizar la suma de todos las cantidades ingresadas para la realizacion de cabinas retornandome un valor de tipo entero...
        {
            double va = 0;
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();

            try
            {
                string sqlint = "SELECT SUM(tot_int) AS total FROM internet";
                cmd = new MySqlCommand(sqlint, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    va = Convert.ToDouble(dr[0].ToString());

                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                va = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                va = 0;
                throw ex;
            }
            cmd = null;
            con.Close();
            return va;
        }

          

          
    }

    }

      

  



    

