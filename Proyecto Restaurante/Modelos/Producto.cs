using System.ComponentModel.DataAnnotations;

namespace Modelos
{

    public class Producto
    {
        [Required(ErrorMessage = "El código es obligatorio")]
        public string CodigoProducto { get; set; }
        [Required(ErrorMessage = "El tipo de producto es obligatorio")]
        public string TipoProducto { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La cantidad en existencias es obligatorio")]
        public int Existencia { get; set; }

        public decimal Precio { get; set; }

        [Required(ErrorMessage = "La fecha de vencimiento es obligatoria")]
        public DateTime FechaVencimiento { get; set; }
        public bool EstaActivo { get; set; }
    }
}
