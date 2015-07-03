using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionProductosServicios.Modelo
{
    class pro_vent
    {
        private int id_venta; // declaracion del atributo de la entidad pro_venta

        public int Id_venta// metodo constructor
        {
            get { return id_venta; }
            set { id_venta = value; }
        }
        private int cod_pro; // declaracion del atibuto de la entidad pro_venta

        public int Cod_pro// metdodo constructor
        {
            get { return cod_pro; }
            set { cod_pro = value; }
        }
        private int can_vent; // declaracion del atributo de la entidad pro_venta

        public int Can_vent// metodo constructor 
        {
            get { return can_vent; }
            set { can_vent = value; }
        }
        private double val_unit; // declaracion del atributo de la entidad pro_venta

        public double Val_unit// metodo constructor 
        {
            get { return val_unit; }
            set { val_unit = value; }
        }
        private double tot_vent; // declaracion del atributo de la entidada pro_venta

        public double Tot_vent// metodod contructor 
        {
            get { return tot_vent; }
            set { tot_vent = value; }
        }
        private List<pro_vent> listaproventa = new List<pro_vent>();// declaracion de una lista para listar pro_venta

        internal List<pro_vent> Listaproventa // metdodo constructor
        {
            get { return listaproventa; }
            set { listaproventa = value; }
        }


    }
}
