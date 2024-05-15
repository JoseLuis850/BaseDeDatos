using System.ComponentModel.DataAnnotations;

namespace BaseDeDatos.Data
{
    public class Venta
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El producto es requerido.")]
        public int ProductoID { get; set; }
        virtual public Producto? Producto { get; set; }

        public int Cantidad { get; set; }

        [Required(ErrorMessage = "La fecha de venta es requerida.")]
        [DataType(DataType.Date, ErrorMessage = "El formato de fecha es inválido.")]
        public DateTime? FechaVenta { get; set; }

        public int PrecioVenta { get; set; }
    }
}