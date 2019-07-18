using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class BaseDatos
    {
        string cadenaconexion;
        SqlConnection conexion;

        public BaseDatos()
        {
            cadenaconexion = "Server=myServerName\myInstanceName;Database=myDataBase;User Id=sa;Password = 123456; ";
            conexion = new SqlConnection(cadenaconexion);
        }

        public string abrir()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                cerrar();
                conexion.Open();
                return "abierta";
            }
            return conexion.Open();
            

        }

        public string cerrar()
        {
            conexion.Close();
            return "cerrada";
        }
    }
}
