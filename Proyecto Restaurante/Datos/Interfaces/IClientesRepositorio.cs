using Modelos;

namespace Datos.Interfaces
{
    public interface IClientesRepositorio
    {
        Task<bool> Nuevo(Clientes cliente);
        Task<bool> Actualizar(Clientes cliente);
        Task<bool> Eliminar(string DNIcliente);
        Task<IEnumerable<Clientes>> GetLista();
        Task<Clientes> GetPorCodigo(string DNIcliente);
    }
}
