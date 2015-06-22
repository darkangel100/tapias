using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionProductosServicios.Modelo
{
    class cuenta
    {
        private int id_cuenta;

        public int Idcuenta
        {
            get { return id_cuenta; }
            set { id_cuenta = value; }
        }
        private int id_per;

        public int Idper
        {
            get { return id_per; }
            set { id_per = value; }
        }
        private string clave;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        private string nom_per;

        public string Nomper
        {
            get { return nom_per; }
            set { nom_per = value; }
        }
        private string est_per;

        public string Estper
        {
            get { return est_per; }
            set { est_per = value; }
        }
        private DateTime ult_acceso;

        public DateTime Ultacceso
        {
            get { return ult_acceso; }
            set { ult_acceso = value; }
        }
    }
}
