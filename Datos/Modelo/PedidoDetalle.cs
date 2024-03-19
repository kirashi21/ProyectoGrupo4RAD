using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    public class PedidoDetalle
    {
        public int PedidoDetalleld { get; set; }
        public int Pedidold { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Productold { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
    }
}
