using BaseDeDatos.Data;
using Microsoft.EntityFrameworkCore;

namespace BaseDeDatos.Repositorio
{
    public class RepositorioProductos : IRepositorioProductos
    {
        private readonly InventarioDBContext _context;

        public RepositorioProductos(InventarioDBContext context)
        {
            _context = context;
        }

        public async Task<Producto> Add(Producto producto)
        {
            await _context.Productos.AddAsync(producto);
            await _context.SaveChangesAsync();
            return producto;
        }

        public async Task Delete(int ID)
        {
            var producto = await _context.Productos.FindAsync(ID);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Producto?> Get(int ID)
        {
            return await _context.Productos.FindAsync(ID);
        }

        public async Task<List<Producto>> GetAll()
        {
            return await _context.Productos.Include(p => p.Proveedor).Include(p => p.Ventas).ToListAsync();
        }

        public async Task<List<Proveedor>> GetProveedores()
        {
            return await _context.Proveedores.ToListAsync();
        }

        public async Task Update(int ID, Producto producto)
        {
            var productoactual = await _context.Productos.FindAsync(ID);
            if (productoactual != null)
            {
                productoactual.Nombre = producto.Nombre;
                productoactual.Precio = producto.Precio;
                productoactual.Cantidad = producto.Cantidad;
                productoactual.FechaCaducidad = producto.FechaCaducidad;
                await _context.SaveChangesAsync();
            }
        }

    }
}
