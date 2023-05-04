using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductosPrueba.Modelos
{
    public class PR_COMPRAS_MMR
    {
        //Toda la información que se requiere de la tabla Compras
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public string? Boleta { get; set; }
        public bool Estado { get; set; }
        public decimal PrecioFinal { get; set; }

        //Id de cada tabla llamada 
        [DisplayName("Trabajador")]
        public string TipoDocumento { get; set; } = string.Empty;
        public string NumeroDocumento { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public string Sexo { get; set; } = string.Empty;

        [DisplayName("Producto")]
        public string NombreProducto { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        [DisplayName("Zona")]
        public string NombreZona { get; set; } = string.Empty;
        [DisplayName("Categoría")]
        public string NombreCategoria { get; set; } = string.Empty;

    }
}
