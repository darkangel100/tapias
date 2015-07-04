using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionProductosServicios.Modelo
{
    class compra
    {
        private string nom_pro;

        public string Nom_pro
        {
            get { return nom_pro; }
            set { nom_pro = value; }
        }
        private int id_comp;

        public int Id_comp
        {
            get { return id_comp; }
            set { id_comp = value; }
        }
        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private double val_comp;

        public double Val_comp
        {
            get { return val_comp; }
            set { val_comp = value; }
        }
        private int cant;

        public int Cant
        {
            get { return cant; }
            set { cant = value; }
        }
        private double tot_comp;

        public double Tot_comp
        {
            get { return tot_comp; }
            set { tot_comp = value; }
        }

        private List<compra> listcompra = new List<compra>();

        internal List<compra> Listcompra
        {
            get { return listcompra; }
            set { listcompra = value; }
        }
    }
}
