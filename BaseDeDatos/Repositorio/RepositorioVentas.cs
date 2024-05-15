using BaseDeDatos.Data;
using Microsoft.EntityFrameworkCore;

namespace BaseDeDatos.Repositorio
{
    public class RepositorioVentas : IRepositorioVentas
    {
        private readonly InventarioDBContext _context;

        public RepositorioVentas(InventarioDBContext context)
        {
            _context = context;
        }

        public async Task<Venta> Add(Venta venta)
        {
            await _context.Ventas.AddAsync(venta);
            await _context.SaveChangesAsync();
            return venta;
        }

        public async Task Delete(int ID)
        {
            var venta = await _context.Ventas.FindAsync(ID);
            if (venta != null)
            {
                _context.Ventas.Remove(venta);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Venta?> Get(int ID)
        {
            return await _context.Ventas.FindAsync(ID);
        }

        public async Task<List<Venta>> GetAll()
        {
            return await _context.Ventas.Include(r => r.Producto).ToListAsync();
        }

        public async Task<List<Producto>> GetProductos()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task Update(int ID, Venta venta)
        {
            var ventaactual = await _context.Ventas.FindAsync(ID);
            if (ventaactual != null)
            {
                ventaactual.Cantidad = venta.Cantidad;
                ventaactual.FechaVenta = venta.FechaVenta;
                ventaactual.PrecioVenta = venta.PrecioVenta;
                await _context.SaveChangesAsync();
            }
        }
    }
}