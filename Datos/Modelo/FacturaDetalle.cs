using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    public class FacturaDetalle
    {
        public int FacturaDetalleld { get; set; }
        public int Facturald { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
    }
}
