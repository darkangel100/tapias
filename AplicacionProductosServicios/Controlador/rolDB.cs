using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AplicacionProductosServicios.Modelo;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace AplicacionProductosServicios.Controlador
{
    class rolDB
    {
        conexion cn = new conexion();
        Rol rols=null;

        public Rol getrol()
        {
            if (this.rols == null)
            {
                rols = new Rol();
            }
            return rols;
        }
        public void setrol(Rol r)
        {
            rols = r;
        }

        public int insertarol(Rol rol)
        {
            int res;
            MySqlCommand cm;
            MySqlConnection con = cn.getconection();
            try
            {
                string sqlrol = "Insert rol Values(" + rol.Idrol + ",'" + rol.Nombre + "','"+rol.Estrol+"')";
                cm = new MySqlCommand(sqlrol, con);
                cm.CommandType = CommandType.Text;
                con.Open();
                res = cm.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                res = 0;
                throw ex;

            }
            catch (Exception ex)
            {
                res = 0;
                throw ex;
            }
            con.Close();
            cm = null;
            return res;
        }
        public int traeid()
        {
            int num = 0;
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();
            try
            {
                string sqlrol = "Select max(SUBSTRING(id_rol,1)) as num from rol";
                cmd = new MySqlCommand(sqlrol, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
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
            con.Close();
            cmd = null;
            return num;
        }
        public List<Rol> TraeRoles(string est)
        {
            Rol rol = null;
            List<Rol> LisRol = new List<Rol>();
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();
            try
            {
                string sqlrol = "Select * from rol where est_rol='"+est+"' order by nombre_rol";
                cmd = new MySqlCommand(sqlrol, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    rol = new Rol();
                    rol.Idrol = Convert.ToInt32(dr["id_rol"]);
                    rol.Nombre = dr["nombre_rol"].ToString();
                    LisRol.Add(rol);
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                rol = null;
                throw ex;
            }
            catch (Exception ex)
            {
                rol = null;
                throw ex;
            }
            cmd = null;
            con.Close();
            return LisRol;

        }
        public Rol TraeRol(int id)
        {
            rolDB r = null;
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();
            try
            {
                string sqlrol = "Select * from rol where est_rol="+id+"";
                cmd = new MySqlCommand(sqlrol, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    r = new rolDB();
                    r.getrol().Idrol = Convert.ToInt32(dr["id_rol"]);
                    r.getrol().Nombre = dr["nombre_rol"].ToString();
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                r = null;
                throw ex;
            }
            catch (Exception ex)
            {
                r = null;
                throw ex;
            }
            cmd = null;
            con.Close();
            return r.getrol();
        }
        public int ActulizarRol(Rol r)
        {
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();
            int resp;
            try
            {
                string sqlrol = "Update rol set nombre_rol='" + r.Nombre + "'WHERE id_rol=" + r.Idrol + "";
                cmd = new MySqlCommand(sqlrol, con);
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

        public int EliminarRol(int id)
        {
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();
            int resp;
            try
            {
                string sqlrol = "Update rol where id_rol=" + id + " ";
                cmd = new MySqlCommand(sqlrol, con);
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

        public int treidsefunnom( string nom)
        {
            int num=0;
             rolDB r = null;
            MySqlCommand cmd;
            MySqlConnection con = cn.getconection();
            try
            {
                string sqlrol = "Select * from rol where nombre_rol='" + nom + "' AND est_rol= 'A'";
                cmd = new MySqlCommand(sqlrol, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    r = new rolDB();
                    num = Convert.ToInt32(dr["id_rol"]);
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
            con.Close();
            cmd = null;
            return num;

        }
    }
}
