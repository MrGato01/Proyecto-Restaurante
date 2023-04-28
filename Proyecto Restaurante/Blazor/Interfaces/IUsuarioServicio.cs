﻿using Modelos;

namespace Blazor.Interfaces
{
    public interface IUsuarioServicio
    {
        Task<Usuario> GetPorCodigoAsync(string codigo);
        Task<bool> NuevoAsync(Usuario usuario);
        Task<bool> ActualizarAsync(Usuario usuario);
        Task<bool> EliminarAsync(Usuario codigo);
        Task<IEnumerable<Usuario>> GetListaAsync();
        Task<bool> EliminarAsync(string codigoUsuario);
    }
}
