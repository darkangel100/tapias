using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionProductosServicios.Modelo
{
    class prod_comp
    {

        private int id_comp;// declaracion del atributo de la entidada prod_compra

        public int Id_comp
        {
            get { return id_comp; }
            set { id_comp = value; }
        }
        private int cod_pro; // declaracion del atributo de la entidada prod_compra

        public int Cod_pro
        {
            get { return cod_pro; }
            set { cod_pro = value; }
        }
        private double pre_compra;// declaracion del atributo de la entidada prod_compra

        public double Pre_compra
        {
            get { return pre_compra; }
            set { pre_compra = value; }
        }
        private double tot_copm;// declaracion del atributo de la entidada prod_compra

        public double Tot_copm
        {
            get { return tot_copm; }
            set { tot_copm = value; }
        }

        private List<prod_comp> listaprocopm = new List<prod_comp>(); // declaracion de una lista para listar todo lo referido al prod_compra

        internal List<prod_comp> Listaprocopm
        {
            get { return listaprocopm; }
            set { listaprocopm = value; }
        }


    }
}
