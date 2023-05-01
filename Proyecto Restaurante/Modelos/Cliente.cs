using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Cliente
    {

        [Required(ErrorMessage = "EL número de identidad es necesario")]
        public string Identidad { get; set; }
        [Required(ErrorMessage = "El nombre es necesario")]
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es necesaria")]
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        [Required(ErrorMessage = "El número de teléfono es necesario")]
        public string Telefono { get; set; }

        public Cliente(string identidad, string nombre, string direccion, DateTime fechaNacimiento, string correo, string telefono)
        {
            Identidad = identidad;
            Nombre = nombre;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            Correo = correo;
            Telefono = telefono;
        }

        public Cliente()
        {
        }
    }
}
