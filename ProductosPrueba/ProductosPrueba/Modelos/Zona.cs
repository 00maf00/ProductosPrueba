using System.ComponentModel.DataAnnotations;

namespace ProductosPrueba.Modelos
{
    public class Zona
    {
        public int Id { get; set; }
        [Required]
        public string NombreZona { get; set; } = string.Empty;
    }
}
