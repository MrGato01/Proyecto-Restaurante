using Blazor.Interfaces;
using Datos.Interfaces;
using Datos.Repositorios;
using Modelos;

namespace Blazor.Servicios
{
    public class ClienteServicio : IClienteServicio
    {

        private readonly Config _config;
        private IClientesRepositorio clientesRepositorio;

        public ClienteServicio(Config config)
        {
            _config = config;
            clientesRepositorio = new ClientesRepositorio(config.CadenaConexion);
        }
        public async Task<bool> Actualizar(Clientes cliente)
        {
            return await clientesRepositorio.Actualizar(cliente);
        }

        public async Task<bool> Eliminar(string DNIcliente)
        {
            return await clientesRepositorio.Eliminar(DNIcliente);
        }

        public async Task<IEnumerable<Clientes>> GetLista()
        {
            return await clientesRepositorio.GetLista();
        }

        public async Task<Clientes> GetPorCodigo(string DNIcliente)
        {
            return await clientesRepositorio.GetPorCodigo(DNIcliente);
        }

        public async Task<bool> Nuevo(Clientes cliente)
        {
            return await clientesRepositorio.Nuevo(cliente);
        }
    }
}
