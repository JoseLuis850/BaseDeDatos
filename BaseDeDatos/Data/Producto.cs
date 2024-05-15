using System.ComponentModel.DataAnnotations;

namespace BaseDeDatos.Data
{
    public class Producto
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        public string? Nombre { get; set; }
        [Range(10, int.MaxValue, ErrorMessage = "Debe escribir un precio")]
        public int Precio { get; set; }

        [Range(10, int.MaxValue, ErrorMessage ="Debe escribir una cantidad")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "La fecha de caducidad es requerida.")]
        [DataType(DataType.Date, ErrorMessage = "El formato de fecha es inválido.")]
        public DateTime? FechaCaducidad { get; set; }

        public int ProveedorID { get; set; }
        virtual public Proveedor? Proveedor { get; set; }

        public virtual ICollection<Venta>? Ventas { get; set; }
    }
}