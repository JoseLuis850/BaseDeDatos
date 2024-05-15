using System.ComponentModel.DataAnnotations;

namespace BaseDeDatos.Data
{
    public class Proveedor
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "La dirección es requerida.")]
        public string? Direccion { get; set; }

        [Required(ErrorMessage = "El teléfono es requerido.")]
        [Phone(ErrorMessage = "Por favor, ingrese un número de teléfono válido.")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "El correo es requerido.")]
        [EmailAddress(ErrorMessage = "Por favor, ingrese una dirección de correo electrónico válida.")]
        public string? Correo { get; set; }

        public virtual ICollection<Producto>? Productos { get; set; }
    }
}