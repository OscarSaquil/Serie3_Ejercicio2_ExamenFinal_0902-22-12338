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
        public string nombreProducto { get; set; }
        public string categoría { get; set; }
        public SqlDateTime fechaRegistro { get; set; }
    }
}
