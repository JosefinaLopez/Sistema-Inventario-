using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Datos
{
    public class Conexion
    {
        private SqlConnection conexion = new SqlConnection("server = JOSEFINALOPEZ; database = Inventario; integrated security = true");

        public SqlConnection OpenConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();

            return conexion;
        }
        public SqlConnection CloseConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
        
    }
}
