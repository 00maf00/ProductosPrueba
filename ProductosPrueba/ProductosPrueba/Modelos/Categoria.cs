using System.ComponentModel.DataAnnotations;

namespace ProductosPrueba.Modelos
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required]
        public string NombreCategoria { get; set; } = string.Empty;
        public int IdZona { get; set; }
    }
}
