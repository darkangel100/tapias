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
        public Producto listaunprounPro(int cod_pro)
        {
            ProductoDB pro = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            try
            {
                string sqlp = "Select * from producto where cod_prod='" + cod_pro + "'";
                cmd = new MySqlCommand(sqlp, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pro = new ProductoDB();
                    pro.getProductos().Codprod = Convert.ToInt32(dr[0]);
                    pro.getProductos().NombrePro = dr[1].ToString();
                    pro.getProductos().Precom = Convert.ToDouble(dr[2]);
                    pro.getProductos().Prevent = Convert.ToDouble(dr[3]);
                    pro.getProductos().Stock = Convert.ToInt32(dr[4]);
                    pro.getProductos().Cantgan = Convert.ToDouble(dr[5]);



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
            return pro.getProductos();
        }



        
        public int Actualizacantidad(int co, int can)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;

            try
            {
                string sqlcad = "Update producto set stock=stock-" + can + " where cod_prod='" + co + "'";
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
            cmd = null;
            cn.Close();
            return resp;

        }
        public int sumastock(int co, int can)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;

            try
            {
                string sqlcad = "Update producto set stock=stock+" + can + " where cod_prod='" + co + "'";
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
            cmd = null;
            cn.Close();
            return resp;

        }
        public int ActualizaProducto(Producto pro)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;

            try
            {
                string sqlprod = "update producto set nombre='" + pro.NombrePro + "',pre_com=" + pro.Precom + ",pre_vent=" + pro.Prevent + ",stock=" + pro.Stock + ",cant_gan=" + pro.Cantgan + ", est_pro='" + pro.Estprod + "' Where cod_prod=" + pro.Codprod + "";
                cmd = new MySqlCommand(sqlprod, cn);
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
            cmd = null;
            cn.Close();
            return resp;
        }
        public List<Producto> BuscarProdCod(string cod)
        {
            ProductoDB pro = null;
            List<Producto> BuscaProducto = new List<Producto>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlprod = "select * from producto Where cod_prod='" + cod + "' And est_pro='A'";
                cmd = new MySqlCommand(sqlprod, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    pro = new ProductoDB();
                    pro.getProductos().Codprod = Convert.ToInt32(dr[0]);
                    pro.getProductos().NombrePro = dr[1].ToString();
                    pro.getProductos().Precom = Convert.ToDouble(dr[2].ToString());
                    pro.getProductos().Prevent = Convert.ToDouble(dr[3].ToString());
                    pro.getProductos().Stock = Convert.ToInt32(dr[4].ToString());
                    pro.getProductos().Cantgan = Convert.ToDouble(dr[5].ToString());
                    pro.getProductos().Estprod = dr[6].ToString();
                    BuscaProducto.Add(pro.getProductos());

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
            cmd = null;
            cn.Close();
            return BuscaProducto;
        }
        public List<Producto> BuscarProdNom(string nombre)
        {
            ProductoDB pro = null;
            List<Producto> BuscaProducto = new List<Producto>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlprod = "Select * from producto WHERE nombre LIKE '%" + nombre + "%' and est_pro='A'";
                cmd = new MySqlCommand(sqlprod, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    pro = new ProductoDB();
                    pro.getProductos().Codprod = Convert.ToInt32(dr[0]);
                    pro.getProductos().NombrePro = dr[1].ToString();
                    pro.getProductos().Precom = Convert.ToDouble(dr[2].ToString());
                    pro.getProductos().Prevent = Convert.ToDouble(dr[3].ToString());
                    pro.getProductos().Stock = Convert.ToInt32(dr[4].ToString());
                    pro.getProductos().Cantgan = Convert.ToDouble(dr[5].ToString());
                    pro.getProductos().Estprod = dr[6].ToString();
                    BuscaProducto.Add(pro.getProductos());

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
            cmd = null;
            cn.Close();
            return BuscaProducto;
        }
        
    }
        

}
