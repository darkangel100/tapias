using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionProductosServicios.Modelo
{
    class internet
    {
        private int id_inter;

        public int Idinter
        {
            get { return id_inter; }
            set { id_inter = value; }
        }
        private int id_per;

        public int Idper
        {
            get { return id_per; }
            set { id_per = value; }
        }
        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        private List<internet> listainternet = new List<internet>();

        internal List<internet> ListaInternet
        {
            get { return listainternet; }
            set { listainternet = value; }
        }
    }
}
