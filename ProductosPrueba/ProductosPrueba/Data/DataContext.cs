using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductosPrueba.Modelos;

namespace ProductosPrueba.Data

{
    public class DataContext : IdentityDbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Zona> Zonas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}

