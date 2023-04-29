﻿using Modelos;

namespace Datos.Interfaces
{
    public interface IProductosRepositorio
    {
        Task<bool> Nuevo(Menu Menu);
        Task<bool> Actualizar(Menu Menu);
        Task<bool> Eliminar(string CodigoMenu);
        Task<IEnumerable<Menu>> GetLista();
        Task<Menu> GetPorCodigo(string CodigoMenu);
    }
}
