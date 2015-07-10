using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using AplicacionProductosServicios.Modelo;

namespace AplicacionProductosServicios.Controlador
{
    class EgresosDB
    {
        conexion con = new conexion();
        Egresos egre = null;
        public Egresos getEgresos()
        {
            if (this.egre == null)
            {
                this.egre = new Egresos();
            }
            return this.egre;
        }
        public void setEgresos(Egresos egr)
        {
            this.egre = egr;
        }
        public void limpiar()
        {
            this.egre = null;
        }
        public int InsertaEgresos(Egresos egr)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;

            try
            {
                string sqlegre = "Insert egresos(id_per,tip_egre,detalle,valor) values(" + egr.Idper + ",'" + egr.Tipegre + "','" + egr.Detalle + "'," + egr.Valor + ")";
                cmd = new MySqlCommand(sqlegre, cn);
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
        public List<Egresos> TraeEgresos()
        {
            EgresosDB egre = null;
            List<Egresos> listEgre = new List<Egresos>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();

            try
            {
                string sqlegre = "select * from egresos order by fecha";
                cmd = new MySqlCommand(sqlegre, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    egre = new EgresosDB();
                    egre.getEgresos().Idegre = Convert.ToInt32(dr[0].ToString());
                    egre.getEgresos().Idper = Convert.ToInt32(dr[1].ToString());
                    egre.getEgresos().Tipegre = dr[2].ToString();
                    egre.getEgresos().Detalle = dr[3].ToString();
                    egre.getEgresos().Valor = Convert.ToDouble(dr[4].ToString());
                    egre.getEgresos().Fecha = dr[5].ToString();

                    listEgre.Add(egre.getEgresos());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                egre = null;
                throw ex;
            }
            catch (Exception ex)
            {
                egre = null;
                throw ex;
            }
            cmd = null;
            cn.Close();
            return listEgre;
        }
        public int ActualizaEgresos(Egresos eg)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {
                string sqlegre = "Update egresos set id_egre=" + eg.Idegre + ",'" + eg.Tipegre + "','" + eg.Detalle + "'," + eg.Valor + " Where id_egre=" + eg.Idegre + "";
                cmd = new MySqlCommand(sqlegre, cn);
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
        public List<Egresos> BuscarEgre(string fec1, string fec2)//metodo para realizar la busqueda en este caso es for fechas ,, desde y hasta
        {
            EgresosDB egre = null;
            List<Egresos> listaBusqEgre = new List<Egresos>();
            MySqlCommand cmd;//declaracion d euna variabñpe para comandos
            MySqlConnection cn = con.getconection();//coneccion con la base de datos ,, con el metodo de coneccion

            try
            {
                //cadena sql que nos permite realizar la busqueda segun las fechas que hayan sido seleccionas para la busqueda
                string sqlcab = "SELECT * FROM egresos WHERE CAST(fecha AS DATE) BETWEEN '" + fec1 + "' AND '" + fec2 + "'";
                cmd = new MySqlCommand(sqlcab, cn);//se envia la cadena y coneccion creando una instancia
                cmd.CommandType = CommandType.Text;
                cn.Open();//abre la coneccion a la base de datos
                MySqlDataReader dr = cmd.ExecuteReader();//lee todo el contendo de ña base de datos para poder realizar el bucle

                while (dr.Read())//realiza el biuclwe segun el contenido
                {
                    egre = new EgresosDB();//le asignamos un nuevo valor a la variabñe instanciada de la entidad
                    //convierte los datos a su respectivo valor para guardarlos
                    egre.getEgresos().Idegre = Convert.ToInt32(dr[0].ToString());
                    egre.getEgresos().Idper = Convert.ToInt32(dr[1].ToString());
                    egre.getEgresos().Tipegre = dr[2].ToString();
                    egre.getEgresos().Detalle = dr[3].ToString();
                    egre.getEgresos().Valor = Convert.ToDouble(dr[4].ToString());
                    egre.getEgresos().Fecha = dr[5].ToString();


                    listaBusqEgre.Add(egre.getEgresos());//agrega a la tabla todos los datos de la lista que son buscados

                }
                dr.Close();//finalizacion del bucle
            }
            catch (MySqlException ex)//presentacion d eposibles errores 
            {
                egre = null;
                throw ex;

            }
            catch (Exception ex)
            {
                egre = null;
                throw ex;
            }
            cmd = null;//anulacion d elos comandos
            cn.Close();//se cierra la coneccion
            return listaBusqEgre;//retora una lista con los oberos obtenidos
        }
    }
}
