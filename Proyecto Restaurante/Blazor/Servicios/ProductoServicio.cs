using Blazor.Interfaces;
using Datos.Interfaces;
using Datos.Repositorios;
using Modelos;

namespace Blazor.Servicios
{
    public class ProductoServicio : IProductoServicio
    {
        private readonly Config _config;
        private IProductoRepositorio productoRepositorio;

        public ProductoServicio(Config config)
        {
            _config = config;
            productoRepositorio = new ProductoRepositorio(config.CadenaConexion);
        }

        public async Task<bool> Actualizar(Producto producto)
        {
            return await productoRepositorio.Actualizar(producto);
        }

        public async Task<bool> Eliminar(string codigoProducto)
        {
            return await productoRepositorio.Eliminar(codigoProducto);
        }

        public async Task<IEnumerable<Producto>> GetLista()
        {
            return await productoRepositorio.GetLista();
        }

        public async Task<Producto> GetPorCodigo(string codigoProducto)
        {
            return await productoRepositorio.GetPorCodigo(codigoProducto);
        }

        public async Task<bool> Nuevo(Producto producto)
        {
            return await productoRepositorio.Nuevo(producto);
        }
    }
}
