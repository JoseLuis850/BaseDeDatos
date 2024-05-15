using BaseDeDatos.Data;
using Microsoft.EntityFrameworkCore;

namespace BaseDeDatos.Repositorio
{
    public class RepositorioProveedores : IRepositorioProveedores
    {
        private readonly InventarioDBContext _context;

        public RepositorioProveedores(InventarioDBContext context)
        {
            _context = context;
        }

        public async Task<Proveedor> Add(Proveedor proveedor)
        {
            await _context.Proveedores.AddAsync(proveedor);
            await _context.SaveChangesAsync();
            return proveedor;
        }

        public async Task Delete(int ID)
        {
            var proveedor = await _context.Proveedores.FindAsync(ID);
            if (proveedor != null)
            {
                _context.Proveedores.Remove(proveedor);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Proveedor?> Get(int ID)
        {
            return await _context.Proveedores.FindAsync(ID);
        }

        public async Task<List<Proveedor>> GetAll()
        {
            return await _context.Proveedores.Include(r => r.Productos).ToListAsync();
        }

        public async Task Update(int ID, Proveedor proveedor)
        {
            var proveedoractual = await _context.Proveedores.FindAsync(ID);
            if (proveedoractual != null)
            {
                proveedoractual.Nombre = proveedor.Nombre;
                proveedoractual.Direccion = proveedor.Direccion;
                proveedoractual.Telefono = proveedor.Telefono;
                proveedoractual.Correo = proveedor.Correo;
                await _context.SaveChangesAsync();
            }
        }

    }
}
