using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionProductosServicios.Modelo
{
    class Recarga
    {
        private int id_rec;

        public int IdRec
        {
            get { return id_rec; }
            set { id_rec = value; }
        }
        private int id_per;

        public int IdPer
        {
            get { return id_per; }
            set { id_per = value; }
        }
        private int num;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        private double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private List<Recarga> listarecarga = new List<Recarga>();

        internal List<Recarga> ListaRecarga
        {
            get { return listarecarga; }
            set { listarecarga = value; }
        }
    }
}
