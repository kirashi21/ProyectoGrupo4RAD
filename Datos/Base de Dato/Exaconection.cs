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
        public DbSet<Categoria>categorias { get; set; }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<CondiccionPago> condicionPago { get; set; }
        public DbSet<Factura> factura { get; set; }
        public DbSet<FacturaDetalle> facturaDetalle { get; set; }
        public DbSet<GrupoDescuento> grupoDescuentos { get; set; }
        public DbSet<Pedido> pedido { get; set; }
        public DbSet<PedidoDetalle> pedidoDetalle { get;set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<UnidadMedida> unidadMedida { get; set; }
    }
}
