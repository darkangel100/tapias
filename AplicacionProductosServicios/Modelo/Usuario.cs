using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionProductosServicios.Modelo
{
    class Usuario
    {
        private int id_per;

        public int Idper
        {
            get { return id_per; }
            set { id_per = value; }
        }
        private string ced_per;

        public string Cedper
        {
            get { return ced_per; }
            set { ced_per = value; }
        }
        private string ape_per;

        public string Apeper
        {
            get { return ape_per; }
            set { ape_per = value; }
        }
        private string nom_per;

        public string Nomper
        {
            get { return nom_per; }
            set { nom_per = value; }
        }
        private string dir_per;

        public string Dirper
        {
            get { return dir_per; }
            set { dir_per = value; }
        }
        private string tel_per;

        public string Telper
        {
            get { return tel_per; }
            set { tel_per = value; }
        }
        private string est_per;

        public string Estper
        {
            get { return est_per; }
            set { est_per = value; }
        }
        private int id_rol;

        public int Idrol
        {
            get { return id_rol; }
            set { id_rol = value; }
        }
        private List<Usuario> listapersonas = new List<Usuario>();

        internal List<Usuario> ListaPersonas
        {
            get { return listapersonas; }
            set { listapersonas = value; }
        }
        private Rol nombre;

        internal Rol Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
