using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionProductosServicios.Modelo
{
    class Recarga
    {
        //METODOS DONDE SE DECLARA TODOS LOA ATRIBUTOS DE LA TABLA DE LA BASE DE DATOS
        // YA QUE ATRAVES DE SU PROPIEDAD SE PUEDE INGRESAR AL DATO Y ENVIARLE VALORES..
        //cUANDO HAY VARIOS VALORES SE LOS GUARDA EN UNA LISTA....
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
        private string fecha;

        public string Fecha
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
        private double tot_rec;

        public double Totrec
        {
            get { return tot_rec; }
            set { tot_rec = value; }
        }
    }
}
