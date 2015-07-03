using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionProductosServicios.Modelo
{
    class Pines
    {
        private int id_pines;

        public int Idpines
        {
            get { return id_pines; }
            set { id_pines = value; }
        }
        private int id_per;

        public int Idper
        {
            get { return id_per; }
            set { id_per = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int can_pines;

        public int Canpines
        {
            get { return can_pines; }
            set { can_pines = value; }
        }
        private List<Pines> listapines = new List<Pines>();

        internal List<Pines> Listapines
        {
            get { return listapines; }
            set { listapines = value; }
        }
    }
}
