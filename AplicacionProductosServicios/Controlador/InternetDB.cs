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
        public int InsertaInter(internet inte)
        {
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();
            int resp;
            try
            {
                string sqlinter = "Insert internet values(" + inte.Idinter + "," + inte.Idper + ",'" + inte.Fecha + "'," + inte.Valor + "";
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
       /* public int modifica(internet inte)
        {
            MySqlCommand cmd;
            MySqlConnection cn;
            string sqlinter = "Update categoria set Des_Cat='" + inte.Idinter + "," + inte.Idper + ",'" + inte.Fecha + "'," + inte.Valor + "";

        }*/
    }

    }

      

  



    

