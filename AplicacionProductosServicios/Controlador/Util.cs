using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AplicacionProductosServicios.Modelo;

namespace AplicacionProductosServicios.Controlador
{
    class Util
    {

        public static int generarid(int nro)
        {
            int id = nro;
            id++;
            return id; 
        }
        public static string girafecha(string f)
        {
            string fec = "";
            fec = f.Substring(6, 4) + "-" + f.Substring(3, 2) + "-" + f.Substring(0, 2);
            return fec;
        }
        public Usuario ValidarCedula(string ced)
        {
            Usuario per = null;
            return per;
        }

    }
}
