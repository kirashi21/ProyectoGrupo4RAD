using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    public class PedidoDetalle
    {
        public int PedidoDetalleId { get; set; }
        public int PedidoId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal Descuento { get; set; }

       
        public Pedido Pedido { get; set; }
        public Producto Producto { get; set; }
    }
}
