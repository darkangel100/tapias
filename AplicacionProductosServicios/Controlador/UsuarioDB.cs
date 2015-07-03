using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AplicacionProductosServicios.Modelo;
using MySql.Data.MySqlClient;

namespace AplicacionProductosServicios.Controlador
{
    class UsuarioDB
    {
        conexion con = new conexion();
        Usuario per = null;
        public Usuario getUsuario()
        {
            if (this.per == null)
            {
                this.per = new Usuario();

            }
            return this.per;
        }
        public Usuario setUsuario(Usuario pers)
        {
            per = pers;
            return pers;
        }

        public int traeid()
        {
            int num = 0;
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            try
            {
                string sqlrol = "Select max(SUBSTRING(id_per,1)) as num from persona";
                cmd = new MySqlCommand(sqlrol, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (DBNull.Value == dr["num"])
                    {
                        num = 0;
                    }
                    else
                    {
                        num = Convert.ToInt32(dr["num"]);
                    }
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                num = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                num = 0;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return num;
        }

        public int InsertaUsuario(Usuario per)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {
                string sqlcad = "Insert persona Values(" + per.Idper + ",'" + per.Cedper + "','" + per.Apeper + "','" + per.Nomper + "','" + per.Dirper + "','" + per.Telper + "','" + per.Estper + "'," + per.Idrol + ")";
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
            per = null;
            cmd = null;
            cn.Close();
            return resp;
        }
        public List<Usuario> TraePersonas(string estado)
        {
            UsuarioDB persona = null;
            List<Usuario> listper = new List<Usuario>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlcad = "Select * from persona where est_per='" + estado + "' order by ape_per";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader mdr = cmd.ExecuteReader();

                while (mdr.Read())
                {
                    persona = new UsuarioDB();
                    persona.getUsuario().Idper = Convert.ToInt32(mdr[0]);
                    persona.getUsuario().Cedper = mdr[1].ToString();
                    persona.getUsuario().Apeper = mdr[3].ToString();
                    persona.getUsuario().Nomper = mdr[2].ToString();
                    persona.getUsuario().Dirper = mdr[4].ToString();
                    persona.getUsuario().Telper = mdr[5].ToString();
                    //persona.getUsuario().Estper = mdr["est_per"].ToString();
                    // persona.getUsuario().Idrol = Convert.ToInt32(mdr[7]);

                    listper.Add(persona.getUsuario());
                }
                mdr.Close();
            }
            catch (MySqlException ex)
            {
                persona = null;
                throw ex;
            }
            catch (Exception ex)
            {
                persona = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return listper;
        }
        public Usuario Traepersona(string ced)
        {
            UsuarioDB persona = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlecad = "Select * from persona where ce_per='" + ced + "'";
                cmd = new MySqlCommand(sqlecad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader mdr = cmd.ExecuteReader();

                while (mdr.Read())
                {
                    persona = new UsuarioDB();
                    persona.getUsuario().Idper = Convert.ToInt32(mdr[0]);
                    persona.getUsuario().Cedper = mdr[1].ToString();
                    persona.getUsuario().Apeper = mdr[2].ToString();
                    persona.getUsuario().Nomper = mdr[3].ToString();
                    persona.getUsuario().Dirper = mdr[4].ToString();
                    persona.getUsuario().Telper = mdr[5].ToString();
                    persona.getUsuario().Estper = mdr[6].ToString();
                    persona.getUsuario().Idrol = Convert.ToInt32(mdr[7]);
                }
                mdr.Close();
            }
            catch (MySqlException ex)
            {
                persona = null;
                throw ex;
            }
            catch (Exception ex)
            {
                persona = null;
                throw ex;
            }
            cmd = null;
            cn.Close();
            return persona.getUsuario();
        }
        public int ActualizaUsuario(Usuario secre)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {
                string sqlsecret = "Update persona set ce_per='" + secre.Cedper + "',ape_per='" + secre.Apeper + "',nom_per='" + secre.Nomper + "',dir_per='" + secre.Dirper + "',tel_per=" + secre.Telper + " Where id_per= " + secre.Idper + "";
                cmd = new MySqlCommand(sqlsecret, cn);
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

    }
}
