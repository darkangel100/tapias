using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionProductosServicios.Modelo
{
    class Cabinas
    {
        //Metodos que me permite declrarr todos los atributos de la base de datos
        private int id_cab;

        public int Idcab
        {
            get { return id_cab; }
            set { id_cab = value; }
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

        private List<Cabinas> listaCab = new List<Cabinas>();//A una lista edeclarada le asigno otra lista..para guardar en esa lusta cunado hay varios valores,,

        internal List<Cabinas> ListaCab
        {
            get { return listaCab; }
            set { listaCab = value; }
        }
        private double tot_cab;

        public double Totcab
        {
            get { return tot_cab; }
            set { tot_cab = value; }
        }

    }
}
