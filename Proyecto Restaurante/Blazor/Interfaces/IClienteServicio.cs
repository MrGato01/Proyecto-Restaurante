using Modelos;

namespace Blazor.Interfaces
{
    public interface IClienteServicio
    {
        Task<bool> Nuevo(Clientes cliente);
        Task<bool> Actualizar(Clientes cliente);
        Task<bool> Eliminar(string DNIcliente);
        Task<IEnumerable<Clientes>> GetLista();
        Task<Clientes> GetPorCodigo(string DNIcliente);
    }
}
