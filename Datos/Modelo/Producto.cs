using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    public class Producto
    {
            public int ProductoId { get; set; }
            public string Codigo { get; set; }
            public string Descripcion { get; set; }
            public int CategoriaId { get; set; }
            public int UnidadMedidaId { get; set; }
            public decimal PrecioCompra { get; set; }
            public decimal PrecioVenta { get; set; }
            public int Stock { get; set; }
            public bool Estado { get; set; }
            public DateTime FechaCreacion { get; set; }

          
            public Categoria Categoria { get; set; }
            public UnidadMedida UnidadMedida { get; set; }
            public List<PedidoDetalle> DetallePedidos { get; set; }
            public List<FacturaDetalle> DetalleFacturas { get; set; }
        }
}

