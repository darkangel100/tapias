using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionProductosServicios.Modelo
{
    class Rol
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int id_rol;

        public int Idrol
        {
            get { return id_rol; }
            set { id_rol = value; }
        }

        private List<Rol> listaRol = new List<Rol>();

        internal List<Rol> ListaRol
        {
            get { return listaRol; }
            set { listaRol = value; }
        }
        private string est_rol;

        public string Estrol
        {
            get { return est_rol; }
            set { est_rol = value; }
        }

    }
}
