﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AplicacionProductosServicios.Modelo;
using MySql.Data.MySqlClient;
using System.Data;

namespace AplicacionProductosServicios.Controlador
{
    class VentaDB
    {
        venta ven = null;
        conexion con = new conexion();
        public venta getventa()
        {
            if (ven == null)
            {
                ven = new venta();
            }
            return ven;
        }

        public void setventa(venta vent)
        {
            this.ven = vent;
        }


        public int Insertaventa(venta ven)// METODO llamado insertaveta al cual se lo utiliza para insertar datos ala tabla benta de la base de datos, debuelbe un datos de tipo in y recive un parametro de tipo veta
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {

                 string sqlven = "Insert venta (id_per,nom_pro,tot_vent) Values(" + ven.Id_per + ",'" + ven.Nom_pro + "'," +ven.Tot_vent+")";
                cmd = new MySqlCommand(sqlven, cn);
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
        public int TraeCodigoventa()// metodo llamado trecodiogo el cual sireve para traer el codigo de venta y retorna un dato de tipo entero 
        {
            int nro = 0;
            MySqlConnection cn = con.getconection();
            MySqlCommand cmd;
            try
            {
                string sqlpro = "Select max(id_vent) as nro from venta";
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

        public List<venta> listaventa(string fecha1,string fecha2) // metodo llamado listaventa el cual me permite listar los datos por fecha  dela tabla venta de la base de datos endon recive dos parameros de tipo string y retorna una lista de tipo venta
        {

            VentaDB ven = null;
            List<venta> venta = new List<venta>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            try
            {
                // string sqlinter = "SELECT * FROM internet WHERE CAST(fecha AS DATE) BETWEEN '" + fechas1 + "' AND '" + fechas2 + "'";
                string sqlinter = "SELECT * FROM venta WHERE CAST(fecha AS DATE) BETWEEN '" + fecha1 + "' AND '" + fecha2 + "'";
                cmd = new MySqlCommand(sqlinter, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ven = new VentaDB();
                    ven.getventa().Id_vent = Convert.ToInt32(dr[0]);
                    ven.getventa().Nom_pro = dr[2].ToString();
                    ven.getventa().Fecha=dr[3].ToString();
                    venta.Add(ven.getventa());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                ven = null;
                throw ex;

            }
            catch (Exception ex)
            {
                ven= null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return venta;


        }
        public int modificaventa(venta v)// metodo llamado modificaventa el cual permite modificar datos en la tabla venta y recibe un parametro de tipo venta y retorna un dato entero
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;
            try
            {

                string sqlven = "UPDATE venta SET tot_vent=" + v.Tot_vent + " WHERE id_vent=" + v.Id_vent + "";
                cmd = new MySqlCommand(sqlven, cn);
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

    }
}
