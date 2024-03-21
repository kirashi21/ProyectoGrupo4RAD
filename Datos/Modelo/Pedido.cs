using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    public class Pedido
    {
        
            public int PedidoId { get; set; }
            public int ClienteId { get; set; }
            public DateTime FechaCreacion { get; set; }
            public DateTime FechaPedido { get; set; }
            public int Estado { get; set; }
            public decimal Total { get; set; }
            public decimal Subtotal { get; set; }
            public decimal Descuento { get; set; }

            
            public Cliente Cliente { get; set; }
            public List<PedidoDetalle> DetallePedidos { get; set; }
        }
}

