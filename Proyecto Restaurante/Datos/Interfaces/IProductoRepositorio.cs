﻿using Modelos;

namespace Datos.Interfaces
{
    public interface IProductoRepositorio
    {
        Task<bool> Nuevo(Producto producto);
        Task<bool> Actualizar(Producto producto);
        Task<bool> Eliminar(string codigoProducto);
        Task<IEnumerable<Producto>> GetLista();
        Task<Producto> GetPorCodigo(string codigoProducto);
    }
}