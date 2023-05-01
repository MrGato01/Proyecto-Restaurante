using Blazor.Interfaces;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Blazor.Pages.MisClientes
{
    public partial class EditarClientes
    {
        [Inject] private IClienteServicio clienteServicio { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }
        [Inject] private SweetAlertService Swal { get; set; }

        private Cliente cliente = new Cliente();
        [Parameter] public string Identidad { get; set; }


        protected override async Task OnInitializedAsync()
        {
            if (!string.IsNullOrEmpty(Identidad))
            {
				cliente = await clienteServicio.GetPorIdentidad(Identidad);
            }
        }



        protected async void Guardar()
        {
            if (string.IsNullOrWhiteSpace(cliente.Identidad) || string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                return;
            }

            bool edito = await clienteServicio.Actualizar(cliente);

            if (edito)
            {
                await Swal.FireAsync("Felicidades", "El cliente se actualizo correctamente", SweetAlertIcon.Success);
            }
            else
            {
                await Swal.FireAsync("Error", "No se pudo actualizar el cliente de forma correcta", SweetAlertIcon.Error);
            }
        }

        protected async void Cancelar()
        {
            navigationManager.NavigateTo("/Clientes");
        }
        protected async void Eliminar()
        {
            SweetAlertResult result = await Swal.FireAsync(new SweetAlertOptions
            {
                Title = "¿Estas Seguro que deseas eliminar al cliente?",
                Icon = SweetAlertIcon.Question,
                ShowCancelButton = true,
                ConfirmButtonText = "Aceptar",
                CancelButtonText = "Cancelar"
            });

            if (!string.IsNullOrEmpty(result.Value))
            {
                bool elimino = await clienteServicio.Eliminar(cliente.Identidad);

                if (elimino)
                {
                    await Swal.FireAsync("Felicidades", "El cliente ha sido eliminado correctamente", SweetAlertIcon.Success);
                    navigationManager.NavigateTo("/Clientes");
                }
                else
                {
                    await Swal.FireAsync("Error", "No se pudo eliminar al cliente", SweetAlertIcon.Error);
                }
            }
        }
    }
}