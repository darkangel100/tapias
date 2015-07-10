using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AplicacionProductosServicios.Modelo
{
    class Egresos
    {
        private int id_egre;

        public int Idegre
        {
            get { return id_egre; }
            set { id_egre = value; }
        }
        private int id_per;

        public int Idper
        {
            get { return id_per; }
            set { id_per = value; }
        }
        private string tip_egre;

        public string Tipegre
        {
            get { return tip_egre; }
            set { tip_egre = value; }
        }
        private string detalle;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        private double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private List<Egresos> listaegresos = new List<Egresos>();

        internal List<Egresos> Listaegresos
        {
            get { return listaegresos; }
            set { listaegresos = value; }
        }
    }
}
