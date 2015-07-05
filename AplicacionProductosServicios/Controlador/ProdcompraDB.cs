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

        public prod_comp getprocomp()
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

        public int registra(prod_comp procom)
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
        }
    }
}
