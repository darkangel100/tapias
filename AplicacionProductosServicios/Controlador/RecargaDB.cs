using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using AplicacionProductosServicios.Modelo;
using System.Data;

namespace AplicacionProductosServicios.Controlador
{
    class RecargaDB
    {
        conexion con = new conexion();//se hace la coneccion con la base de datos
        Recarga rec = null;//se declara una variable propia d esiu clase para luego poderle asignarle valores...

        public Recarga GetRecarga()//este metodo me obtiene y me retorna un valor propio de su clase...
        {
            if (this.rec == null) //se pregunta y si esta variable esta nula se hace una instancia y se le da un valor...
            {
                this.rec = new Recarga(); //Se le aigna un valor a esta variable instanciando la clase..    
            }
            return rec;//Me retorna un valor aunq sea nulo...
        }
        public void SetReacarga(Recarga recar)//Este metodo me asigna los datos a la clase...
        {
            this.rec = recar;//lo lleno con los datos a la variable que estab vacia..
        }
        public int IngresaRecarga(Recarga re)//Metodo para ingresar valores a la base de datos recibiendome un valor propio de su tipo y retornandome un entero...
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;

            try
            {
                string sqlrec = "Insert recarga (id_per, num, valor,tot_rec) Values(" + re.IdPer + "," + re.Num + "," + re.Valor + "," + re.Valor + ")";
                cmd = new MySqlCommand(sqlrec, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();//Abre la coneccion con la base  de datos..
                resp = cmd.ExecuteNonQuery();//si esta bien la cadena de sql.me asigna un valor diferente a 0..
            }
            //Presenta exepciones....
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
            cn.Close();//Cierro la coneccion con la base de datos
            return resp;//Me retorna un valor de tipo entero si esta bien sera diferente de 0 y si esta mal..sera un 0..de retorno
        }
        public List<Recarga> TraeRecargas()//Metodo para presentar valores ordenados segun la cadena retonandome una lista de valores propios de su clase...
        {
            RecargaDB re = null;
            List<Recarga> ListaReacraga = new List<Recarga>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            try
            {
                string sqlrecar = "Select * from recarga order by fecha desc limit 30";
                cmd = new MySqlCommand(sqlrecar, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();//Me lee el contenido de la base de datos es solo para leer contenidos y me llena con el contenido...

                while (dr.Read())//leer el registro para segun eso realizar la funcion sino sale del bulce...
                {
                    re = new RecargaDB();
                    re.GetRecarga().IdRec = Convert.ToInt32(dr[0].ToString());
                    re.GetRecarga().IdPer = Convert.ToInt32(dr[1].ToString());
                    re.GetRecarga().Num = Convert.ToInt32(dr[2].ToString());
                    re.GetRecarga().Valor = Convert.ToDouble(dr[3].ToString());
                    re.GetRecarga().Fecha = dr[4].ToString();
                    ListaReacraga.Add(re.GetRecarga());//En esta lista guardo todos los datos de la entidad para que me los retorne...

                }
                dr.Close();//Ciera o sale lamcondicion del bucle...
            }
            //Presentar los errores cometidos,...
            catch (MySqlException ex)
            {
                re = null;
                throw ex;
            }
            catch (Exception ex)
            {
                re = null;
                throw ex;
            }
            cmd = null;
            cn.Close();
            return ListaReacraga;
        }
        public List<Recarga> BuscarRecarga(int num)//Metodo para buscar reciebiendo un parametro d etipo entero...y retornandome una lista de objetos..
        {
            RecargaDB rec = null;
            List<Recarga> ListaReac = new List<Recarga>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlbuscar = "Select * from recarga where num =" + num + "";
                cmd = new MySqlCommand(sqlbuscar, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();//ler el contenido de la base de datos para entrar o no entrar al bucle...

                while (dr.Read())//lee los contenidos y me realiza el bucle segun su funcion....
                {
                    rec = new RecargaDB();
                    rec.GetRecarga().IdRec = Convert.ToInt32(dr[0]);
                    rec.GetRecarga().IdPer = Convert.ToInt32(dr[1]);
                    rec.GetRecarga().Num = Convert.ToInt32(dr[2]);
                    rec.GetRecarga().Valor = Convert.ToDouble(dr[3]);
                    rec.GetRecarga().Fecha = dr[4].ToString();
                    ListaReac.Add(rec.GetRecarga());//me gauarda todos los valores obtenidos...para ser retornados,y presentados al usuario
                }
                dr.Close();//Fin se acaba el bucle....
            }
            //presenta excepciones o errores..
            catch (MySqlException ex)
            {
                rec = null;
                throw ex;
            }
            catch (Exception ex)
            {

                rec = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return ListaReac;
        }
        public List<Recarga> BuscarFechra(string fecha1, string fecha2)
        {
            RecargaDB re = null;
            List<Recarga> LisdeBusqueda = new List<Recarga>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlbuscar = "SELECT * FROM recarga WHERE CAST(fecha AS DATE) BETWEEN '" + fecha1 + "' AND '" + fecha2 + "'";
                cmd = new MySqlCommand(sqlbuscar, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    re = new RecargaDB();
                    re.GetRecarga().IdRec = Convert.ToInt32(dr[0].ToString());
                    re.GetRecarga().IdPer = Convert.ToInt32(dr[1].ToString());
                    re.GetRecarga().Num = Convert.ToInt32(dr[2].ToString());
                    re.GetRecarga().Valor = Convert.ToInt32(dr[3].ToString());
                    re.GetRecarga().Fecha = dr[4].ToString();
                    LisdeBusqueda.Add(re.GetRecarga());

                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                re = null;
                throw ex;
            }
            catch (Exception ex)
            {
                re = null;
                throw ex;
            }
            cmd = null;
            cn.Close();
            return LisdeBusqueda;

        }
        public List<Recarga> ListarTotalRecarga() 
        {
            RecargaDB rec = null;
            List<Recarga> ListdeBusqueda = new List<Recarga>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlrec = "SELECT * FROM recarga WHERE tot_rec > 0 order by id_rec desc";
                cmd = new MySqlCommand(sqlrec, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    rec = new RecargaDB();
                    rec.GetRecarga().IdRec = Convert.ToInt32(dr[0].ToString());
                    rec.GetRecarga().IdPer = Convert.ToInt32(dr[1].ToString());
                    rec.GetRecarga().Num = Convert.ToInt32( dr[2].ToString());
                    rec.GetRecarga().Valor = Convert.ToDouble(dr[3].ToString());
                    rec.GetRecarga().Totrec = Convert.ToDouble(dr[5].ToString());
                    ListdeBusqueda.Add(rec.GetRecarga());

                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                rec = null;
                throw ex;
            }
            catch (Exception ex)
            {
                rec = null;
                throw ex;
            }
            cmd = null;
            cn.Close();
            return ListdeBusqueda;
        }
        public int ActualizaTotales(double val, int id)//Metodo para actualizar la cantidad total restandole las recargas vendidas...
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {
                string sqlrec = "update recarga set tot_rec = (tot_rec -" + val + ") where id_rec = " + id;
                cmd = new MySqlCommand(sqlrec, cn);
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
        public double sumaCant2()//Metodo para realizar la suma de todos las cantidades ingresadas para la realizacion de cabinas retornandome un valor de tipo entero...
        {
            double va = 0;
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlrec = "SELECT SUM(tot_rec) AS total FROM recarga";
                cmd = new MySqlCommand(sqlrec, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    va = Convert.ToDouble(dr[0].ToString());

                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                va = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                va = 0;
                throw ex;
            }
            cmd = null;
            cn.Close();
            return va;
        }

    }
}
