using Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Base_de_Dato
{
    public class Exaconection: DbContext
    {
        public Exaconection() : base("name=ProyectoRad")
        {

        }
        public DbSet<Categoria> Categorias { get; set; } 
        public DbSet<Cliente> Clientes { get; set; } 
        public DbSet<CondiccionPago> CondicionPagos { get; set; } 
        public DbSet<Factura> Facturas { get; set; }   
        public DbSet<FacturaDetalle> FacturaDetalles { get; set; } 
        public DbSet<GrupoDescuento> GrupoDescuentos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }    
        public DbSet<PedidoDetalle> PedidoDetalles { get; set; } 
        public DbSet<Producto> Productos { get; set; }
        public DbSet<UnidadMedida> UnidadMedidas { get; set; } 
    }
}
