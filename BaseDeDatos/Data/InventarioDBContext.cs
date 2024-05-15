using Microsoft.EntityFrameworkCore;

namespace BaseDeDatos.Data
{
    public class InventarioDBContext : DbContext
    {
        public InventarioDBContext(DbContextOptions<InventarioDBContext> options): base(options) 
        {

        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Venta> Ventas { get; set; }
    }
}