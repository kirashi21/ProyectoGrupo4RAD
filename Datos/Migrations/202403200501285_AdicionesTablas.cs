namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionesTablas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Descripcion = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        TipoDocumento = c.String(),
                        NumeroDocumento = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        Email = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        CondicionPago_CondicionPagoId = c.Int(),
                        GrupoDescuento_GrupoDescuentoId = c.Int(),
                    })
            .PrimaryKey(t => t.ClienteId)
            .ForeignKey("dbo.CondiccionPagoes", t => t.CondicionPago_CondicionPagoId)
            .ForeignKey("dbo.GrupoDescuentoes", t => t.GrupoDescuento_GrupoDescuentoId)
            .Index(t => t.CondicionPago_CondicionPagoId)
            .Index(t => t.GrupoDescuento_GrupoDescuentoId);

            CreateTable(
                "dbo.CondiccionPagoes",
                c => new
                    {
                        CondicionPagoId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Descripcion = c.String(),
                        Dias = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CondicionPagoId);
            
            CreateTable(
                "dbo.GrupoDescuentoes",
                c => new
                    {
                        GrupoDescuentoId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Descripcion = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GrupoDescuentoId);
            
            CreateTable(
                "dbo.FacturaDetalles",
                c => new
                    {
                        FacturaDetalleId = c.Int(nullable: false, identity: true),
                        FacturaId = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
            .PrimaryKey(t => t.FacturaDetalleId)
            .ForeignKey("dbo.Facturas", t => t.FacturaId, cascadeDelete: true)
            .ForeignKey("dbo.Productoes", t => t.ProductoId, cascadeDelete: true)
            .Index(t => t.FacturaId)
            .Index(t => t.ProductoId);

            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        FacturaId = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        PedidoId = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaFactura = c.DateTime(nullable: false),
                        Estado = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.FacturaId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Pedidoes", t => t.PedidoId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.PedidoId);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        PedidoId = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaPedido = c.DateTime(nullable: false),
                        Estado = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PedidoId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: false)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.PedidoDetalles",
                c => new
                    {
                        PedidoDetalleId = c.Int(nullable: false, identity: true),
                        PedidoId = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PedidoDetalleId)
                .ForeignKey("dbo.Pedidoes", t => t.PedidoId, cascadeDelete: true)
                .ForeignKey("dbo.Productoes", t => t.ProductoId, cascadeDelete: true)
                .Index(t => t.PedidoId)
                .Index(t => t.ProductoId);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        ProductoId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Descripcion = c.String(),
                        CategoriaId = c.Int(nullable: false),
                        UnidadMedidaId = c.Int(nullable: false),
                        PrecioCompra = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecioVenta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stock = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProductoId)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .ForeignKey("dbo.UnidadMedidas", t => t.UnidadMedidaId, cascadeDelete: true)
                .Index(t => t.CategoriaId)
                .Index(t => t.UnidadMedidaId);
            
            CreateTable(
                "dbo.UnidadMedidas",
                c => new
                    {
                        UnidadMedidaId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Descripcion = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UnidadMedidaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Facturas", "PedidoId", "dbo.Pedidoes");
            DropForeignKey("dbo.Productoes", "UnidadMedidaId", "dbo.UnidadMedidas");
            DropForeignKey("dbo.PedidoDetalles", "ProductoId", "dbo.Productoes");
            DropForeignKey("dbo.FacturaDetalles", "ProductoId", "dbo.Productoes");
            DropForeignKey("dbo.Productoes", "CategoriaId", "dbo.Categorias");
            DropForeignKey("dbo.PedidoDetalles", "PedidoId", "dbo.Pedidoes");
            DropForeignKey("dbo.Pedidoes", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.FacturaDetalles", "FacturaId", "dbo.Facturas");
            DropForeignKey("dbo.Facturas", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Clientes", "GrupoDescuento_GrupoDescuentoId", "dbo.GrupoDescuentoes");
            DropForeignKey("dbo.Clientes", "CondicionPago_CondicionPagoId", "dbo.CondiccionPagoes");
            DropIndex("dbo.Productoes", new[] { "UnidadMedidaId" });
            DropIndex("dbo.Productoes", new[] { "CategoriaId" });
            DropIndex("dbo.PedidoDetalles", new[] { "ProductoId" });
            DropIndex("dbo.PedidoDetalles", new[] { "PedidoId" });
            DropIndex("dbo.Pedidoes", new[] { "ClienteId" });
            DropIndex("dbo.Facturas", new[] { "PedidoId" });
            DropIndex("dbo.Facturas", new[] { "ClienteId" });
            DropIndex("dbo.FacturaDetalles", new[] { "ProductoId" });
            DropIndex("dbo.FacturaDetalles", new[] { "FacturaId" });
            DropIndex("dbo.Clientes", new[] { "GrupoDescuento_GrupoDescuentoId" });
            DropIndex("dbo.Clientes", new[] { "CondicionPago_CondicionPagoId" });
            DropTable("dbo.UnidadMedidas");
            DropTable("dbo.Productoes");
            DropTable("dbo.PedidoDetalles");
            DropTable("dbo.Pedidoes");
            DropTable("dbo.Facturas");
            DropTable("dbo.FacturaDetalles");
            DropTable("dbo.GrupoDescuentoes");
            DropTable("dbo.CondiccionPagoes");
            DropTable("dbo.Clientes");
            DropTable("dbo.Categorias");
        }
    }
}
