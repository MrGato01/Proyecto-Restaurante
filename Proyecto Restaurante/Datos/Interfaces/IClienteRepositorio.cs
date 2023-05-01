using Modelos;

namespace Datos.Interfaces
{
    public interface IClienteRepositorio
    {
        Task<bool> Nuevo(Cliente cliente);
        Task<bool> Actualizar(Cliente cliente);
        Task<bool> Eliminar(string identidad);
        Task<IEnumerable<Cliente>> GetLista();
        Task<Cliente> GetPorIdentidad(string identidad);
    }
}
