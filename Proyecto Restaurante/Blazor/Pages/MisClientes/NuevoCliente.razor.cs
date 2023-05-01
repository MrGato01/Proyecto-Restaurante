using Blazor.Interfaces;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Blazor.Pages.MisClientes
{
    public partial class NuevoCliente
    {

        [Inject] private IClienteServicio clienteServicio { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }
        [Inject] private SweetAlertService Swal { get; set; }
        private Cliente cliente = new Cliente();
        [Parameter] public string Identidad { get; set; }


       

        protected async void Guardar()
        {
            if (string.IsNullOrWhiteSpace(cliente.Identidad) || string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                return;
            }
			cliente.FechaNacimiento = DateTime.Now;

            bool inserto = await clienteServicio.Nuevo(cliente);

            if (inserto)
            {
                await Swal.FireAsync("Felicidades", "Cliente Guardado satisfactoriamente", SweetAlertIcon.Success);
            }
            else
            {
                await Swal.FireAsync("Error", "No se pudo Guardar el cliente de forma excitosa", SweetAlertIcon.Error);
            }
        }

        protected async void Cancelar()
        {
            NavigationManager.NavigateTo("/Clientes");
        }
    }
}

