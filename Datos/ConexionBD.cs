using Datos.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ConexionBD
    {
        // Conexion con la cadena de conexion declarada en el archivo config
        private SqlConnection Conexion = new SqlConnection(Settings.Default.ConexionBD);

        public SqlConnection GetConexion()
        {
            return Conexion;
        }

        public SqlConnection AbrirConexion(SqlConnection conexion)
        {
            if (Conexion.State == ConnectionState.Closed)
                conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
