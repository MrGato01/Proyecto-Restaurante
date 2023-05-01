using Modelos;

namespace Blazor.Interfaces
{
    interface IProductoServicio
    {
        Task<bool> Nuevo(Producto producto);
        Task<bool> Actualizar(Producto producto);
        Task<bool> Eliminar(string CodigoProducto);
        Task<IEnumerable<Producto>> GetLista();
        Task<Producto> GetPorCodigo(string CodigoProducto);
    }
}
