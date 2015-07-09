using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionProductosServicios.Modelo
{
    class Pines
    {

        //METODOS DONDE SE DECLARA TODOS LOA ATRIBUTOS DE LA TABLA DE LA BASE DE DATOS
        // YA QUE ATRAVES DE SU PROPIEDAD SE PUEDE INGRESAR AL DATO Y ENVIARLE VALORES..
        //cUANDO HAY VARIOS VALORES SE LOS GUARDA EN UNA LISTA....
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
        private string fecha;

        public string Fecha
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
        private int total_pines;

        public int Total_pines
        {
            get { return total_pines; }
            set { total_pines = value; }
        }
    }
}
