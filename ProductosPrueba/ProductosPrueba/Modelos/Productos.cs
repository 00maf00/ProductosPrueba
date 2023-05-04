using System.ComponentModel.DataAnnotations;

namespace ProductosPrueba.Modelos
{
    public class Productos
    {
        public int Id { get; set; }
        [Required]
        public int IdCategoria { get; set; }
        [Required]
        public string NombreProducto { get; set; } = string.Empty;
        [Required]
        public string Marca { get; set; } = string.Empty;
        [Required]
        public string UnidadMedida { get; set; } = string.Empty;
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public decimal Stock { get; set; }
        [Required]
        public DateTime FechaVencimiento { get; set; }
        [Required]
        public int IdProveedor { get; set; }
        [Required]
        public string DocumentoTecnico { get; set; } = string.Empty;
        [Required]        
        public string Imagen { get; set;} = string.Empty;
        public bool? Estado { get; set; }

    }
}
