using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using AplicacionProductosServicios.Modelo;

namespace AplicacionProductosServicios.Controlador
{
    class CabinasDB
    {
        conexion con = new conexion();//se realiza la coneccion con la base de datos,
        Cabinas cab = null;//se declra una variable nula,, en esta variable, luego se le asigna valores propios d esta variable
        public Cabinas getcabinas()//metodo que me permite obtener los valores k son propios de su clase y a la ves retornar
        {
            if (this.cab == null)//Realizo una condicion para verificar si si la variable esta nula,,
            {
                this.cab = new Cabinas();//si la variable esta nula,, se le asigna un valor instanciando la clase

            }
            return this.cab;//retorna el valor de la clase, 
        }
        public void setcabinas(Cabinas cabi)//metod que permite asignarle valores a las entidades,,
        {
            this.cab = cabi;//le asigana un valor a la variable que se la declaro nula,,
        }
        /*public void limpiar()
        {
            this.cab = null;
        }*/

        /// <summary>
        /// metodo que me permite insertar los datos los cuales voy a ingresar a la base de datos,,,
        /// </summary>
        /// <param name="cabi"></param>recibe un parametro de tipo entero
        /// <returns></returns> retorna la variable,, para ralizar el mismo procedimiento,,
        public int InsertaCabinas(Cabinas cabi)//metodo que me permite insertar los datos los cuales voy a ingresar a la base de datos,,,
        {
            MySqlCommand cmd;//ejecuta los comandos`para trabajar en la base de datos
            MySqlConnection cn = con.getconection();//se realiza la coneccion con la base de datos,, lla,mando al respectivo metodo para la conceccion
            int resp;//declaracion de una variable 
            try
            {
                string sqlcab = "Insert cabinas(id_per,valor, tot_cab) values(" + cabi.Idper + "," + cabi.Valor + "," + cabi.Valor + ")";//cadena de entrada para la base de datos,,
                cmd = new MySqlCommand(sqlcab, cn);//se envia la cadena y coneccion , creando una instancia
                cn.Open();//se abre la coneccion con la base de datos
                resp = cmd.ExecuteNonQuery();//asigna un valor a la variable, el cual debe ser diferente de cero,, esta parte es para realizar ya sea el modificar o insertar,, pero no se utilizza para buscar,

            }
            catch (MySqlException ex)//Deteccta posibles errores o ecepcioes que existe en la coneccion y los presenta
            {
                resp = 0;//la variable declrad VUELVE  a ocupar un valor de cero,
                throw ex;
            }
            catch (Exception ex)
            {
                resp = 0;
                throw ex;
            }
            cn.Close();//se cierre laconecion con la  base de datos
            cmd = null; //los comandos que se estuvieron ejecutando se hacen nulos,,
            return resp;//retorna la variable,, para ralizar el mismo procedimiento,,
        }

        public int ActualizaCabinas(Cabinas ca)//metodo que me permite actualizar la base de datos y la tabla una ves q se aya modificado algun dato
        {
            MySqlCommand cmd;//declaracion de una variable para ejecutar comandos
            MySqlConnection cn = con.getconection();//se trae el metodo para realizarla conceccion con la base de datos
            int resp;//declaracion d euna variable

            try
            {
                string sqlcab = "update cabinas set valor=" + ca.Valor + " Where id_cab=" + ca.Idcab + "";//cadena que permite actualizar lña base de datos,, segun la condicion que se desea
                cmd = new MySqlCommand(sqlcab, cn);//se envia la cadena y coneccion creando una instancia
                cmd.CommandType = CommandType.Text;//realiza los comandos cuando el comand type sea de tipo texto,
                cn.Open();//abre la coneccion con la base de datos
                resp = cmd.ExecuteNonQuery();//asigana un valor a la variable el cual debe ser diferente de cero
            }
            catch (MySqlException ex)//presenta posibles errores o ecepciones encontradas
            {
                resp = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                resp = 0;
                throw ex;
            }
            cmd = null;//Los comandos de ejecucion se hacen nulos,,
            cn.Close();//cierra la coneccion cpn la base de datos
            return resp;//retorna la variable,,
        }
        public List<Cabinas> BuscarCab(string fec1, string fec2)//metodo para realizar la busqueda en este caso es for fechas ,, desde y hasta
        {
            CabinasDB cabi = null;
            List<Cabinas> listaBusqCab = new List<Cabinas>();
            MySqlCommand cmd;//declaracion d euna variabñpe para comandos
            MySqlConnection cn = con.getconection();//coneccion con la base de datos ,, con el metodo de coneccion

            try
            {
                //cadena sql que nos permite realizar la busqueda segun las fechas que hayan sido seleccionas para la busqueda
                string sqlcab = "SELECT * FROM cabinas WHERE CAST(fecha AS DATE) BETWEEN '" + fec1 + "' AND '" + fec2 + "'";
                cmd = new MySqlCommand(sqlcab, cn);//se envia la cadena y coneccion creando una instancia
                cmd.CommandType = CommandType.Text;
                cn.Open();//abre la coneccion a la base de datos
                MySqlDataReader dr = cmd.ExecuteReader();//lee todo el contendo de ña base de datos para poder realizar el bucle

                while (dr.Read())//realiza el biuclwe segun el contenido
                {
                    cabi = new CabinasDB();//le asignamos un nuevo valor a la variabñe instanciada de la entidad
                    //convierte los datos a su respectivo valor para guardarlos
                    cabi.getcabinas().Idcab = Convert.ToInt32(dr[0].ToString());
                    cabi.getcabinas().Idper = Convert.ToInt32(dr[1].ToString());
                    cabi.getcabinas().Fecha = dr[2].ToString();
                    cabi.getcabinas().Valor = Convert.ToDouble(dr[3].ToString());

                    listaBusqCab.Add(cabi.getcabinas());//agrega a la tabla todos los datos de la lista que son buscados

                }
                dr.Close();//finalizacion del bucle
            }
            catch (MySqlException ex)//presentacion d eposibles errores 
            {
                cabi = null;
                throw ex;

            }
            catch (Exception ex)
            {
                cabi = null;
                throw ex;
            }
            cmd = null;//anulacion d elos comandos
            cn.Close();//se cierra la coneccion
            return listaBusqCab;//retora una lista con los oberos obtenidos
        }
        public List<Cabinas> ListarTotalCabinas()
        {
            CabinasDB cab = null;
            List<Cabinas> ListdeBusqueda = new List<Cabinas>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlcab = "SELECT * FROM cabinas WHERE tot_cab > 0 order by id_cab desc";
                cmd = new MySqlCommand(sqlcab, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cab = new CabinasDB();
                    cab.getcabinas().Idcab = Convert.ToInt32(dr[0].ToString());
                    cab.getcabinas().Idper = Convert.ToInt32(dr[1].ToString());
                    cab.getcabinas().Fecha = dr[2].ToString();
                    cab.getcabinas().Valor = Convert.ToDouble(dr[3].ToString());
                    cab.getcabinas().Totcab = Convert.ToDouble(dr[4].ToString());
                    ListdeBusqueda.Add(cab.getcabinas());

                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                cab = null;
                throw ex;
            }
            catch (Exception ex)
            {
                cab = null;
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
                string sqlcab = "update cabinas set tot_cab = (tot_cab -" + val + ") where id_cab = " + id;
                cmd = new MySqlCommand(sqlcab, cn);
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
        public double sumaCant1()//Metodo para realizar la suma de todos las cantidades ingresadas para la realizacion de cabinas retornandome un valor de tipo entero...
        {
            double va = 0;
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlcab = "SELECT SUM(tot_cab) AS total FROM cabinas";
                cmd = new MySqlCommand(sqlcab, cn);
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
