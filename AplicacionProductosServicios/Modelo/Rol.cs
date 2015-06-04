using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionProductosServicios.Modelo
{
    class Rol
    {
        private int id_rol;       
        private String nombre;        
        private List<Rol> listaRol = new List<Rol>();

        internal List<Rol> ListaRol
        {
            get { return listaRol; }
            set { listaRol = value; }
        }
        public int Id_rol
        {
            get { return id_rol; }
            set { id_rol = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
