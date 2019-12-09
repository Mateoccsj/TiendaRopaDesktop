using Datos.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class TiendaDeRopaDesktopContext : DbContext
    {
        public TiendaDeRopaDesktopContext() : base("RotiseriaDesktopContext")
        {
            Database.SetInitializer<TiendaDeRopaDesktopContext>(
              new MigrateDatabaseToLatestVersion<TiendaDeRopaDesktopContext, Configuration>());
            
        }

        

        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<DetalleCompra> DetalleCompras { get; set; }
        public DbSet<TipoProducto> TipoProductos { get; set; }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
