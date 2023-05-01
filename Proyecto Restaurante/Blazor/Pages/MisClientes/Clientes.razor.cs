using Blazor.Interfaces;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Blazor.Pages.MisUsuarios
{
    public partial class Clientes
    {
        [Inject] private IClienteServicio ClientesServicio { get; set; }

        private IEnumerable<Cliente> lista { get; set; }

        protected override async Task OnInitializedAsync()
        {
            lista = await ClienteServicio.GetListaAsync();
        }
    }
}