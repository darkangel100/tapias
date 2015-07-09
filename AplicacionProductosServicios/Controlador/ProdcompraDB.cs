using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using AplicacionProductosServicios.Modelo;

namespace AplicacionProductosServicios.Controlador
{
    class ProdcompraDB
    {
        prod_comp pc = null;
        conexion con = new conexion();

        public prod_comp getprocomp() //
        {
            if (pc == null)
            {
                this.pc = new prod_comp();
            }
            return pc;
        }
        public void setprocomp(prod_comp proc)
        {
            this.pc = proc;
        }

        public int registra(prod_comp procom)// metodo que permite registar datos  en la tabla prod_comp donde recibe un parametro de tipo prod_comp y retorna un dato de tipo entero y si se ingreso bein los datos en la tabla retorna 1 caso contaria retor 0
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {

                string sqlpc = "Insert prod_comp values(" + procom.Id_comp + "," + procom.Cod_pro+ "," + procom.Cantp_como+ "," + procom.Pre_compra + "," + procom.Tot_copm + ")";
                cmd = new MySqlCommand(sqlpc, cn);
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
        }// fin del metodo registar

        public prod_comp listacon(int id_comp)// metodo que permite trer un datos de la tabla prod_comp de tipo entero donde retorna la cantidad de productos comprados donde recibe un parametro de tipo entero  
        {

            ProdcompraDB pc = null;

            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            try
            {

                string sqlpventa = "Select * from prod_comp where id_com= " + id_comp + " ";
                cmd = new MySqlCommand(sqlpventa, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
               while (dr.Read())
                {
                    pc = new ProdcompraDB();
                    pc.getprocomp().Cantp_como = Convert.ToInt32(dr[2]);
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                pc = null;
                throw ex;

            }
            catch (Exception ex)
            {
                pc = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return pc.getprocomp();


        }// fin del metdo listacon
    }
}
