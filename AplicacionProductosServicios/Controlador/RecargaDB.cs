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
        conexion con = new conexion();
        Recarga rec = null;

        public Recarga GetRecarga()
        {
            if (this.rec == null)
            {
                this.rec = new Recarga();
            }
            return rec;
        }
        public void SetReacarga(Recarga recar)
        {
            this.rec = recar;
        }
        public int IngresaRecarga(Recarga re)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            int resp;

            try
            {
                string sqlrec = "Insert recarga (id_per, num, valor) Values(" + re.IdPer + "," + re.Num + "," + re.Valor + ")";
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
        public List<Recarga> TraeRecargas()
        {
            RecargaDB re = null;
            List<Recarga> ListaReacraga = new List<Recarga>();
            MySqlCommand cmd;
            MySqlConnection cn = con.getconection();
            try
            {
                string sqlrecar = "Select * from recarga order by fecha desc limit 100";
                cmd = new MySqlCommand(sqlrecar, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    re = new RecargaDB();
                    re.GetRecarga().IdRec = Convert.ToInt32(dr[0].ToString());
                    re.GetRecarga().IdPer = Convert.ToInt32(dr[1].ToString());
                    re.GetRecarga().Num = Convert.ToInt32(dr[2].ToString());
                    re.GetRecarga().Valor = Convert.ToDouble(dr[3].ToString());
                    re.GetRecarga().Fecha = Convert.ToDateTime(dr[4].ToString());
                    ListaReacraga.Add(re.GetRecarga());
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
            return ListaReacraga;
        }
        public List<Recarga> BuscarRecarga(int num)
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
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    rec = new RecargaDB();
                    rec.GetRecarga().IdRec = Convert.ToInt32(dr[0]);
                    rec.GetRecarga().IdPer = Convert.ToInt32(dr[1]);
                    rec.GetRecarga().Num = Convert.ToInt32(dr[2]);
                    rec.GetRecarga().Valor = Convert.ToDouble(dr[3]);
                    rec.GetRecarga().Fecha = Convert.ToDateTime(dr[4]);
                    ListaReac.Add(rec.GetRecarga());
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
            cn.Close();
            cmd = null;
            return ListaReac;
        }
    }
}
