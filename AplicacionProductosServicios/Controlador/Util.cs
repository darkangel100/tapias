using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

    }
}
