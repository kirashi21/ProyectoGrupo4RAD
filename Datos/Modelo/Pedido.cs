using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    public class Pedido
    {
        public int Pedidold { get; set; }
        public int Clienteld { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaPedido { get; set; }
        public bool Estado { get; set; }
        public decimal Total {get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
    }
}
