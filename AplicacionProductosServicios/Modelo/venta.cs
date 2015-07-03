using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionProductosServicios.Modelo
{
    class venta
    {
        private int id_vent; // declaracion del atributo de la entidada venta

        public int Id_vent// metdodo contructor 
        {
            get { return id_vent; }
            set { id_vent = value; }
        }
        private int id_per;// decalracion del atributo de al entidada venta

        public int Id_per// metodo contructor
        {
            get { return id_per; }
            set { id_per = value; }
        }
        private string fecha;// declaracion del atributo de la entiadad venta

        public string Fecha // metodo constructor 
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private double tot_vent;// declaracio  del atributo de la entiadad venta

        public double Tot_vent// metodo constructor
        {
            get { return tot_vent; }
            set { tot_vent = value; }
        }

        private List<venta> listavent = new List<venta>();// declaracion de una lista para listar venta 

        internal List<venta> Listavent
        {
            get { return listavent; }
            set { listavent = value; }
        }


    }
}
