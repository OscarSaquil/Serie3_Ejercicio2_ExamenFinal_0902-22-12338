using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Producto
    {
        public int codigoDeProducto { get; set; }
        public int nombreProducto { get; set; }
        public int categoría { get; set; }
        public SqlDateTime fechaRegistro { get; set; }
    }
}
