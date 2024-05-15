using BaseDeDatos.Data;

namespace BaseDeDatos.Repositorio
{
    public interface IRepositorioVentas
    {
        Task<List<Venta>> GetAll();
        Task<Venta?> Get(int ID);
        Task<List<Producto>> GetProductos();
        Task<Venta> Add(Venta venta);
        Task Update(int ID, Venta venta);
        Task Delete(int ID);
    }
}