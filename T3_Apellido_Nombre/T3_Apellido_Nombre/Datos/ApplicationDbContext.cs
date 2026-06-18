using Microsoft.EntityFrameworkCore;
using T3_Apellido_Nombre.Models;

namespace T3_Apellido_Nombre.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Libro> Libro { get; set; }
    }
}

