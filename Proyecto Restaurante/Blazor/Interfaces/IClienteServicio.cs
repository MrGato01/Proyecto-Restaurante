﻿using Modelos;

namespace Blazor.Interfaces
{
    public interface IClienteServicio
    {
        Task<bool> Nuevo(Cliente cliente);
        Task<bool> Actualizar(Cliente cliente);
        Task<bool> Eliminar(string identidad);
        Task<IEnumerable<Cliente>> GetLista();
        Task<Cliente> GetPorIdentidad(string identidad);
    }
}
