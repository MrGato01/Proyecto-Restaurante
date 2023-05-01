using Blazor.Interfaces;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Modelos;

namespace Blazor.Pages.MisClientes
{
    public partial class EditarClientes
    {
        [Inject] private IClienteServicio ClienteServicio { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }
        [Inject] private SweetAlertService Swal { get; set; }

        private Cliente user = new Cliente();
        [Parameter] public string CodigoCliente { get; set; }
        string imgUrl = string.Empty;


        protected override async Task OnInitializedAsync()
        {
            if (!string.IsNullOrEmpty(CodigoUsuario))
            {
                user = await ClienteServicio.GetPorCodigoAsync(CodigoCliente);
            }
        }

        private async Task SeleccionarImagen(InputFileChangeEventArgs e)
        {
            IBrowserFile imgFile = e.File;
            var buffers = new byte[imgFile.Size];
            user.Foto = buffers;
            await imgFile.OpenReadStream().ReadAsync(buffers);
            string imageType = imgFile.ContentType;
            imgUrl = $"data:{imageType};base64,{Convert.ToBase64String(buffers)}";
        }


        protected async void Guardar()
        {
            if (string.IsNullOrWhiteSpace(user.CodigoCliente) || string.IsNullOrWhiteSpace(user.Nombre) ||
                string.IsNullOrWhiteSpace(user.Contrasena) || string.IsNullOrWhiteSpace(user.Rol) || user.Rol == "Seleccionar")
            {
                return;
            }

            bool edito = await ClienteServicio.ActualizarAsync(user);

            if (edito)
            {
                await Swal.FireAsync("Felicidades", "Cliente se actualizo correctamente", SweetAlertIcon.Success);
            }
            else
            {
                await Swal.FireAsync("Error", "No se pudo actualizar el cliente", SweetAlertIcon.Error);
            }
        }

        protected async void Cancelar()
        {
            navigationManager.NavigateTo("/Usuarios");
        }
        protected async void Eliminar()
        {
            SweetAlertResult result = await Swal.FireAsync(new SweetAlertOptions
            {
                Title = "¿Estas Seguro que deseas eliminar el usuario?",
                Icon = SweetAlertIcon.Question,
                ShowCancelButton = true,
                ConfirmButtonText = "Aceptar",
                CancelButtonText = "Cancelar"
            });

            if (!string.IsNullOrEmpty(result.Value))
            {
                bool elimino = await ClienteServicio.EliminarAsync(user.CodigoCliente);

                if (elimino)
                {
                    await Swal.FireAsync("Felicidades", "Usuario eliminado correctamente", SweetAlertIcon.Success);
                    navigationManager.NavigateTo("/Clientes");
                }
                else
                {
                    await Swal.FireAsync("Error", "No se pudo eliminar el cliente", SweetAlertIcon.Error);
                }
            }
        }
    }
}
enum Roles
{
    Seleccionar,
    Administrador,
    Usuario
}