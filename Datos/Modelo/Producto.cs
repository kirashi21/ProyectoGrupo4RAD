using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    public class Producto
    {
        public int Productold { get; set; }
        public int Categoriald { get; set; }
        public int UnidadMedidald { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set;}
        public decimal PrecioCompra { get; set;}
    }
}
