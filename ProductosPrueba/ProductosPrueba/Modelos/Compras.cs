using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductosPrueba.Modelos
{
    public class Compras
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdProducto { get; set; }
        public int IdTrabajador { get; set; }
        public int Cantidad { get; set; }
        public string? Boleta { get; set; }
        public string? Observaciones { get; set; } // puede ser llenado como no llenado 
        public bool Estado { get; set; }

        [DisplayName("Zona")]
        public int IdZona { get; set; }

        [DisplayName("Categorias")]
        public int IdCategorias { get; set; }

    }
}
