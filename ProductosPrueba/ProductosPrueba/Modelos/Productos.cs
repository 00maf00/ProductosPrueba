using System.ComponentModel.DataAnnotations;

namespace ProductosPrueba.Modelos
{
    public class Productos
    {
        public int Id { get; set; }
        [Required]
        public int IdCategoria { get; set; }
        public string NombreProducto { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string UnidadMedida { get; set; } = string.Empty;
        public double Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int IdProveedor { get; set; }
        public string DocumentoTecnico { get; set; } = string.Empty;
        public string Imagen { get; set;} = string.Empty;
        public bool? Estado { get; set; }

    }
}
