using Blazor.Interfaces;
using Datos.Interfaces;
using Datos.Repositorios;
using Modelos;

namespace Blazor.Servicios
{
    public class ClienteServicio : IClienteServicio
    {

        private readonly Config _config;
        private IClienteRepositorio clienteRepositorio;

        public ClienteServicio(Config config)
        {
            _config = config;
            clienteRepositorio = new ClienteRepositorio(config.CadenaConexion);
        }
        public async Task<bool> Actualizar(Cliente cliente)
        {
            return await clienteRepositorio.Actualizar(cliente);
        }

        public async Task<bool> Eliminar(string identidad)
        {
            return await clienteRepositorio.Eliminar(identidad);
        }

        public async Task<IEnumerable<Cliente>> GetLista()
        {
            return await clienteRepositorio.GetLista();
        }

        public async Task<Cliente> GetPorIdentidad(string identidad)
        {
            return await clienteRepositorio.GetPorIdentidad(identidad);
        }

        public async Task<bool> Nuevo(Cliente cliente)
        {
            return await clienteRepositorio.Nuevo(cliente);
        }
    }
}
