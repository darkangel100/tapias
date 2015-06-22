using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionProductosServicios.Modelo
{
    class Producto
    {
        private int cod_prod;

        public int Codprod
        {
            get { return cod_prod; }
            set { cod_prod = value; }
        }
        private string nombre;

        public string NombrePro
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private double pre_com;

        public double Precom
        {
            get { return pre_com; }
            set { pre_com = value; }
        }
        private double pre_vent;

        public double Prevent
        {
            get { return pre_vent; }
            set { pre_vent = value; }
        }
        private int stock;

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        private double cant_gan;

        public double Cantgan
        {
            get { return cant_gan; }
            set { cant_gan = value; }
        }

        private string est_prod;

        public string Estprod
        {
            get { return est_prod; }
            set { est_prod = value; }
        }

        private List<Producto> listaProductos = new List<Producto>();

        internal List<Producto> ListaProductos
        {
            get { return listaProductos; }
            set { listaProductos = value; }
        }
    }
}
