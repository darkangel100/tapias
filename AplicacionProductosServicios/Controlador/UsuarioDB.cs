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
        conexion con = new conexion();//Coneccion con la base de datos...
        Usuario per = null;//declaracion de una variable nula para despues asinarle valores propios de su clase..
        public Usuario getUsuario()//metodo que me obtiene y me retorna un valor propio de su clase
        {
            if (this.per == null)
            {
                this.per = new Usuario();//le asigno un valor ala variable que estab nula..instanciando la clase..

            }
            return this.per;//me retorna un valor propio d esu clase aunq sea nulo..
        }
        public Usuario setUsuario(Usuario pers)//Metodo que me permite asignarle valores a las entidades recibiendome un objeto propio de su clase..
        {
            per = pers;//la asina un valor a la varuable que estaba nula...
            return pers;
        }

        public int traeid()//metodo que me permite generar un id...como llave primaria para esta clase...

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
                MySqlDataReader dr = cmd.ExecuteReader();//lee el contenido de la base de datos para hacer la condicion...

                while (dr.Read())//lee el contenido segun eso para realizar el bucle....
                {
                    if (DBNull.Value == dr["num"])//es una condicion que me representa un valor que no existe 
                    {
                        num = 0;
                    }
                    else
                    {
                        num = Convert.ToInt32(dr["num"]);
                    }
                }
                dr.Close();//Fin del bucle,...
            }
                //Presenta excepciones o errores...
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

        public int InsertaUsuario(Usuario per)//Metodo para insertar en la base de datos recibiendome un valor propio del modelo y me retorna un entero...
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {
                string sqlcad = "Insert persona Values(" + per.Idper + ",'" + per.Cedper + "','" + per.Apeper + "','" + per.Nomper + "','" + per.Dirper + "','" + per.Telper + "','" + per.Estper + "'," + per.Idrol + ")";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();//Abre la coneccion  con la base de datos 
                resp = cmd.ExecuteNonQuery();//me asigna un valor a esta variable si esta bien sera un valor diferente de 0..
            }
                //Presenta excepciones o errores...
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
        public List<Usuario> TraePersonas(string estado)//Metodo para que me traiga una lista de personas para listarme en la tabla de su entidad..
        {
            UsuarioDB persona = null;
            List<Usuario> listper = new List<Usuario>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlcad = "Select * from persona where est_per='" + estado + "' order by ape_per des limit 30";
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
        public Usuario Traepersona(string ced)//Metodo que me trae los atributos de la base de datos para modificarlos y volverlos a enviar..
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
        public int ActualizaUsuario(Usuario secre)//Metodo que me permite modificar el usuario..recibiendome un valor propio de su clase y me retorna un entero..

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
        public List<Usuario> Buscarusuario(string ced)//Metodo que me permite realizar una busqueda por cedula..
        {
            UsuarioDB usu = null;
            List<Usuario> BuscaUsuario = new List<Usuario>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlsecretaria = "Select * from persona WHERE ce_per='" + ced + "' AND est_per='A'";
                cmd = new MySqlCommand(sqlsecretaria, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    usu = new UsuarioDB();
                    usu.getUsuario().Idper = Convert.ToInt32(dr[0]);
                    usu.getUsuario().Cedper = dr[1].ToString();
                    usu.getUsuario().Apeper = dr[2].ToString();
                    usu.getUsuario().Nomper = dr[3].ToString();
                    usu.getUsuario().Dirper = dr[4].ToString();
                    usu.getUsuario().Telper = dr[5].ToString();
                    usu.getUsuario().Estper = dr[6].ToString();
                    usu.getUsuario().Idrol = Convert.ToInt32(dr[7]);
                    BuscaUsuario.Add(usu.getUsuario());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                usu = null;
                throw ex;
            }
            catch (Exception ex)
            {
                usu = null;
                throw ex;
            }
            cmd = null;
            cn.Close();
            return BuscaUsuario;
        }
        public List<Usuario> BuscarPorApellido(string ape)//Metodo para realizar la busqueda por apellido...
        {
            UsuarioDB usu = null;
            List<Usuario> BuscaUsuario = new List<Usuario>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlsecretaria = "Select * from persona WHERE ape_per LIKE '%" + ape + "%' and est_per='A'";
                cmd = new MySqlCommand(sqlsecretaria, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    usu = new UsuarioDB();
                    usu.getUsuario().Idper = Convert.ToInt32(dr[0]);
                    usu.getUsuario().Cedper = dr[1].ToString();
                    usu.getUsuario().Apeper = dr[2].ToString();
                    usu.getUsuario().Nomper = dr[3].ToString();
                    usu.getUsuario().Dirper = dr[4].ToString();
                    usu.getUsuario().Telper = dr[5].ToString();
                    usu.getUsuario().Estper = dr[6].ToString();
                    usu.getUsuario().Idrol = Convert.ToInt32(dr[7]);
                    BuscaUsuario.Add(usu.getUsuario());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                usu = null;
                throw ex;
            }
            catch (Exception ex)
            {
                usu = null;
                throw ex;
            }
            cmd = null;
            cn.Close();
            return BuscaUsuario;
        }

    }
}
