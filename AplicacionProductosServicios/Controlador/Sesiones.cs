using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AplicacionProductosServicios.Modelo;
namespace AplicacionProductosServicios.Controlador
{
    class Sesiones
    {
        private static cuenta c;

        internal static cuenta C
        {
            get { return Sesiones.c; }
            set { Sesiones.c = value; }
        }

    }
}
