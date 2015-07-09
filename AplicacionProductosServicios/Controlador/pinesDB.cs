using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AplicacionProductosServicios.Modelo;
using MySql.Data.MySqlClient;

namespace AplicacionProductosServicios.Controlador
{
    class PinesDB
    {
        conexion con = new conexion();
        Pines pin = null;
        public Pines getPines()//metodo para get me sirve para tener acceso a los atributos de la clase obteniendomo un valor y retornandome un valor de su mismo tipo..
        {
            if (this.pin == null)
            {
                this.pin = new Pines();// si esta vacio se crea un nuevo y ya esta listo para recibir datos
            }
            return this.pin; //Se lo retorna al ya creado....
        }
        public void setPines(Pines pins)//Metodo set que me permite asiganarle datos a esa entidad....
        {
            pin = pins; //Llena con datos a la clase vacia.....
            // return pins;
        }
        public int InsertePines(Pines pin)//Metodo para insertar los valores, reciebiendome un valor propio de su clase y me retorna un valor de tipo entero  porque siempre me retornara un valor diferente de 0..
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {
                string sqlcad = "Insert pines (id_per,can_pines,total_pines) Values(" + pin.Idper + "," + pin.Canpines +"," + pin.Canpines +")";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();//Abro la conexion con la base de datos,....
                resp = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                resp = 0;
                throw ex;//Aqui me envia la excepcion a otro lado.....
            }
            catch (Exception ex)
            {
                resp = 0;
                throw ex;//Aqui me envia la excepcion a otro lado.....
            }
            cmd = null;
            cn.Close();//cierro la conexion con la base de datos
            return resp;//Me retorna un valor listo para utilizarse en un metodo de la vista paar guardar los datao ingresados
            //si le hizo bien devolvera un valor diferente de 0 sino sera un 0 y no se realizara la funcion...
        }
        public List<Pines> TraePines()//Metodo para listar en la tabla que se muestra al usuario de una forma ordenada, retornandome una lista de valores...
        {
            PinesDB pi = null;//variable de su propio tipo que me va a serb¡vir para guardar los datos
            List<Pines> lisPines = new List<Pines>();//Variable en la que me guarda una lista la cual va hacer retornada....
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlcad = "Select * from pines order by fecha desc limit 20";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();//Abris la base de datos..
                MySqlDataReader dr = cmd.ExecuteReader();//leer el contenido de la bd en una variable dr. Executereader es solo para leer como una consulta dr se llena con el contenido

                while (dr.Read())//Lee el registro segun eso realiza su funcion si no hay nada sale del bucle...
                {
                    pi = new PinesDB();
                    //Guardo los datos convirtiendolos a su respectivo valor...
                    pi.getPines().Idpines = Convert.ToInt32(dr[0].ToString());
                    pi.getPines().Idper = Convert.ToInt32(dr[1].ToString());
                    pi.getPines().Fecha = dr[2].ToString();
                    pi.getPines().Canpines = Convert.ToInt32(dr[3].ToString());
                    pi.getPines().Total_pines = Convert.ToInt32(dr[4].ToString());
                    lisPines.Add(pi.getPines());//En esta lista guardo todos los datos de la entidad para que me los retorne...
                }
                dr.Close();//Cierra la lectura y sale de el bucle..
            }
            //Presenta errores...
            catch (MySqlException ex)
            {
                pi = null;
                throw ex;//Aqui me envia la excepcion a otro lado.....
            }
            catch (Exception ex)
            {
                pi = null;
                throw ex;//Aqui me envia la excepcion a otro lado.....
            }
            cmd = null;
            cn.Close();//Cierro la conexion con la base de datos..
            return lisPines;//Retorna una lista de objetos que sera utilizado en una clase de su mismo tipo....
        }

        public int ActualizaPines(Pines id)//Metodo que es utilizado para modificar....
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {
                string sqlpines = "Update pines set  can_pines=" + id.Canpines + " Where id_pines=" + id.Idpines + "";
                cmd = new MySqlCommand(sqlpines, cn);
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
        public List<Pines> BuscarPines(string fecha1, string fecha2)//Metodo para buscar enviando una fecha y por su puesto retornandome una lista d eonjetos... 
        {
            PinesDB pi = null;
            List<Pines> LisdeBusqueda = new List<Pines>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlbuscar = "SELECT * FROM pines WHERE CAST(fecha AS DATE) BETWEEN '" + fecha1 + "' AND '" + fecha2 + "'";
                cmd = new MySqlCommand(sqlbuscar, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    pi = new PinesDB();
                    pi.getPines().Idpines = Convert.ToInt32(dr[0].ToString());
                    pi.getPines().Idper = Convert.ToInt32(dr[1].ToString());
                    pi.getPines().Fecha = dr[2].ToString();
                    pi.getPines().Canpines = Convert.ToInt32(dr[3].ToString());

                    LisdeBusqueda.Add(pi.getPines());

                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                pi = null;
                throw ex;
            }
            catch (Exception ex)
            {
                pi = null;
                throw ex;
            }
            cmd = null;
            cn.Close();
            return LisdeBusqueda;
        }
        public int sumapines()//Metodo para realizar la suma de todos las cantidades ingresadas para la realizacion de recarga retornandome un valor de tipo entero...
        {
            int pines = 0;
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlcad = "SELECT SUM(total_pines) AS total FROM pines";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    pines = Convert.ToInt32(dr[0].ToString());

                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                pines = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                pines = 0;
                throw ex;
            }
            cmd = null;
            cn.Close();
            return pines;
        }
        public int ActualizaCantidad(int can, int id)//Metodo para actualizar la cantidad total restandole las recargas vendidas...
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {
                string sqlpines = "update pines set total_pines = (total_pines -" + can + ") where id_pines = "+id;
                cmd = new MySqlCommand(sqlpines, cn);
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


        public List<Pines> ListarPinesTotalMayorCero()
        {
            PinesDB pi = null;
            List<Pines> LisdeBusqueda = new List<Pines>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlbuscar = "SELECT * FROM pines WHERE total_pines > 0 order by id_pines desc";
                cmd = new MySqlCommand(sqlbuscar, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    pi = new PinesDB();
                    pi.getPines().Idpines = Convert.ToInt32(dr[0].ToString());
                    pi.getPines().Idper = Convert.ToInt32(dr[1].ToString());
                    pi.getPines().Fecha = dr[2].ToString();
                    pi.getPines().Canpines = Convert.ToInt32(dr[3].ToString());
                    pi.getPines().Total_pines = Convert.ToInt32(dr[4].ToString());
                    LisdeBusqueda.Add(pi.getPines());

                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                pi = null;
                throw ex;
            }
            catch (Exception ex)
            {
                pi = null;
                throw ex;
            }
            cmd = null;
            cn.Close();
            return LisdeBusqueda;
        }
    }
}
