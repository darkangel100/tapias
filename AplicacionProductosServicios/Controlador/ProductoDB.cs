using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using AplicacionProductosServicios.Modelo;

namespace AplicacionProductosServicios.Controlador
{
    class ProductoDB
    {
        conexion con = new conexion();
        Producto pro = null;
        public Producto getProductos()
        {
            if (this.pro == null)
            {
                this.pro = new Producto();
            }
            return this.pro;
        }
        public void setProductos(Producto prod)
        {
            this.pro = prod;
        }
        public void limpiar()
        {
            this.pro = null;
        }

        public int InsertaProducto(Producto prod)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {
                string sqlcad = "Insert producto values(" + prod.Codprod + ",'" + prod.NombrePro + "'," + prod.Precom + "," + prod.Prevent + "," + prod.Stock + "," + prod.Cantgan + ",'" + prod.Estprod + "')";
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
            cn.Close();
            cmd = null;
            prod = null;
            return resp;
        }
        public List<Producto> TraeProductos()
        {
            ProductoDB pro = new ProductoDB();
            List<Producto> ListaPro = new List<Producto>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlcad = "Select * From producto order by cod_prod";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pro = new ProductoDB();
                    pro.getProductos().Codprod = Convert.ToInt32(dr[0].ToString());
                    pro.getProductos().NombrePro = dr[1].ToString();
                    pro.getProductos().Precom = Convert.ToDouble(dr[2].ToString());
                    pro.getProductos().Prevent = Convert.ToDouble(dr[3].ToString());
                    pro.getProductos().Stock = Convert.ToInt32(dr[4].ToString());
                    pro.getProductos().Cantgan = Convert.ToDouble(dr[5].ToString());
                    ListaPro.Add(pro.getProductos());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                pro = null;
                throw ex;
            }
            catch (Exception ex)
            {
                pro = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return ListaPro;
        }
    }

}
