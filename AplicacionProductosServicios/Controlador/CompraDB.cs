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
        public List<compra> listacompra(string fechac1, string fechac2) // metodo llamado listaventa el cual me permite listar los datos por fecha  dela tabla venta de la base de datos endon recive dos parameros de tipo string y retorna una lista de tipo venta
        {

            CompraDB comp = null;
            List<compra> compra = new List<compra>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            try
            {
                // string sqlinter = "SELECT * FROM internet WHERE CAST(fecha AS DATE) BETWEEN '" + fechas1 + "' AND '" + fechas2 + "'";
                string sqlinter = "SELECT * FROM compra WHERE CAST(fecha AS DATE) BETWEEN '" + fechac1 + "' AND '" + fechac2 + "'";
                cmd = new MySqlCommand(sqlinter, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comp = new CompraDB();
                    comp.getcompra().Id_comp = Convert.ToInt32(dr[0]);
                    comp.getcompra().Nom_pro = dr[2].ToString();
                    comp.getcompra().Val_comp=Convert.ToDouble(dr[3]);
                    comp.getcompra().Cant = Convert.ToInt32(dr[1]);
                    comp.getcompra().Tot_comp = Convert.ToDouble(dr[4]);
                    comp.getcompra().Fecha = dr[5].ToString();
                    compra.Add(comp.getcompra());
                   
                 
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                comp = null;
                throw ex;

            }
            catch (Exception ex)
            {
                comp = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return compra;


        }

    }
}
