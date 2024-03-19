using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    public class Factura
    {
        public int Facturald { get; set; }
        public int Clienteld { get; set; }
        public int Pedidold { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaFactura { get; set; }
        public bool Estado { get; set; }
        public decimal Total { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
    }
}
