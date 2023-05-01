using Blazor.Interfaces;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Blazor.Pages.MisProductos
{
    public partial class NuevoProducto
    {
        [Inject] private IProductoServicio productoServicio { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }
        [Inject] private SweetAlertService Swal { get; set; }

        Producto prod = new Producto();

        protected override async Task OnInitializedAsync()
        {
            prod.FechaVencimiento = DateTime.Now;
        }

        protected async Task Guardar()
        {
            if (string.IsNullOrWhiteSpace(prod.CodigoProducto) || string.IsNullOrWhiteSpace(prod.Nombre))
            {
                return;
            }

            Producto prodExistente = new Producto();

            prodExistente = await productoServicio.GetPorCodigo(prod.CodigoProducto);

            if (prodExistente != null)
            {
                if (!string.IsNullOrEmpty(prodExistente.CodigoProducto))
                {
                    await Swal.FireAsync("Aviso", "Ya se encuentra un producto registrado con el mismo código", SweetAlertIcon.Warning);
                    return;
                }
            }

            bool inserto = await productoServicio.Nuevo(prod);
            if (inserto)
            {
                await Swal.FireAsync("Atención", "Producto se ha añadido correctamente", SweetAlertIcon.Success);
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
    }
}
