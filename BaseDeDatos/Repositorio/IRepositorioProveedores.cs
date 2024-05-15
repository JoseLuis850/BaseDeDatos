using BaseDeDatos.Data;

namespace BaseDeDatos.Repositorio
{
    public interface IRepositorioProveedores
    {
        Task<List<Proveedor>> GetAll();
        Task<Proveedor?> Get(int ID);
        Task<Proveedor> Add(Proveedor proveedor);
        Task Update(int ID, Proveedor proveedor);
        Task Delete(int ID);
    }
}