using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace LogicaNegocio
{
    public class NegocioBD
    {
        private MetodosBD objetoCD = new MetodosBD();
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarDatos(Producto objproducto)
        {
            objetoCD.Insertar(objproducto);
        }
        public void EliminarDatos()
        {
            objetoCD.Eliminar();
        }
    }
}
