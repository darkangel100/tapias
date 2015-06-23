using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace AplicacionProductosServicios
{
    class conexion
    {
        string connectonString = "Database = productosyservicios;Data Source=localhost;UserId= root;Password= root";
        public MySqlConnection getconection()
        {

            MySqlConnection objcon = new MySqlConnection(connectonString);
            return objcon;
        }
    }
}
