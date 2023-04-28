using System.ComponentModel.DataAnnotations;

namespace ProductosPrueba.Modelos
{
    public class Proveedor
    {
        public int Id { get; set; }
        [Required]
        public int RUC { get; set; }
        public string NombreProveedor { get; set; } = string.Empty;
        public int Telefono { get; set; }
        public string Direccion { get; set; } = string.Empty;
        public bool Estado { get; set; }


    }
}
