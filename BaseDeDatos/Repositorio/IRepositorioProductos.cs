using BaseDeDatos.Data;

namespace BaseDeDatos.Repositorio
{
    public interface IRepositorioProductos
    {
        Task<List<Producto>> GetAll();
        Task<Producto?> Get(int ID);
        Task<List<Proveedor>> GetProveedores();
        Task<Producto> Add(Producto producto);
        Task Update(int ID, Producto producto);
        Task Delete(int ID);
    }
}