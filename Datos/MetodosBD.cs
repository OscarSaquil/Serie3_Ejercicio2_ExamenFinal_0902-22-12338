using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class MetodosBD
    {
        private ConexionBD conexion = new ConexionBD();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        Producto producto = new Producto();
        public DataTable Mostrar()
        {
            SqlCommand comando = new SqlCommand();
            //Transacr sql
            comando.Connection = conexion.AbrirConexion(conexion.GetConexion());
            comando.CommandText = "MostrarDatos";
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void Insertar(Producto producto)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion(conexion.GetConexion());
            comando.CommandText = "InsertarDatos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigoDeProducto", producto.codigoDeProducto);
            comando.Parameters.AddWithValue("@nombreProducto", producto.nombreProducto);
            comando.Parameters.AddWithValue("@categoría", producto.categoría);
            comando.Parameters.AddWithValue("@fechaRegistro", producto.fechaRegistro);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        //Eliminar datos
        public void Eliminar()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion(conexion.GetConexion());
            comando.CommandText = "EliminarDatos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            //Limpiamos los datos
            comando.Parameters.Clear();

        }
    }
}
