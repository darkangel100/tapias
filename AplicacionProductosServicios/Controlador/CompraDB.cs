using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using AplicacionProductosServicios.Modelo;

namespace AplicacionProductosServicios.Controlador
{
    class CompraDB
    {
        compra comp = null;
        conexion con = new conexion();
        public compra getcompra()
        {
            if (comp == null)
            {
                this.comp = new compra();
            }
            return comp;
        }
        public void setcompra(compra compro)
        {
            this.comp = compro;
        }
        public int insrtarcomp( compra cp)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {
                string sqlcomp = "Insert compra (cant,nom_pro,pre_com,tot_com) Values(" + cp.Cant+ ",'" + cp.Nom_pro + "'," +cp.Val_comp+","+cp.Tot_comp+")";
                cmd = new MySqlCommand(sqlcomp, cn);
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
        public int TraeCodigocompra()
        {
            int nro = 0;
            MySqlConnection cn = con.getconection();
            MySqlCommand cmd;
            try
            {
                string sqlpro = "Select max(id_com) as nro from compra";
                cmd = new MySqlCommand(sqlpro, cn);
                cn.Open();
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
            cn.Close();
            cmd = null;
            return nro;
        }

    }
}
