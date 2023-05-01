using Blazor.Interfaces;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Blazor.Pages.MisProductos
{
    public partial class EditarProducto
    {
        [Inject] private IProductoServicio productoServicio { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }
        [Inject] private SweetAlertService Swal { get; set; }

        Producto prod = new Producto();

        [Parameter] public string CodigoProducto { get; set; }

        string imgUrl = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            if (!string.IsNullOrEmpty(CodigoProducto))
            {
                prod = await productoServicio.GetPorCodigo(CodigoProducto);
            }
        }
        protected async Task Guardar()
        {
            if (string.IsNullOrWhiteSpace(prod.CodigoProducto) || string.IsNullOrWhiteSpace(prod.TipoProducto))
            {
                return;
            }

            bool edito = await productoServicio.Actualizar(prod);
            if (edito)
            {
                await Swal.FireAsync("Atención", "Producto guardado", SweetAlertIcon.Success);
            }
            else
            {
                await Swal.FireAsync("Error", "No se pudo guardar el producto", SweetAlertIcon.Error);
            }
        }

        protected async Task Cancelar()
        {
            navigationManager.NavigateTo("/Productos");
        }

        protected async Task Eliminar()
        {
            bool elimino = false;

            SweetAlertResult result = await Swal.FireAsync(new SweetAlertOptions
            {
                Title = "¿Seguro que desea eliminar el producto?",
                Icon = SweetAlertIcon.Question,
                ShowCancelButton = true,
                ConfirmButtonText = "Aceptar",
                CancelButtonText = "Cancelar"
            });

            if (!string.IsNullOrEmpty(result.Value))
            {
                elimino = await productoServicio.Eliminar(prod.CodigoProducto);

                if (elimino)
                {
                    await Swal.FireAsync("Felicidades", "Producto eliminado", SweetAlertIcon.Success);
                    navigationManager.NavigateTo("/Productos");
                }
                else
                {
                    await Swal.FireAsync("Error", "No se pudo eliminar el producto", SweetAlertIcon.Error);
                }
            }
        }

    }
}

enum TipoProducto
{
    Seleccionar,
    Comida,
    Bebida
}