using Microsoft.EntityFrameworkCore;
using T3_Apellido_Nombre.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace T3_Apellido_Nombre.Datos
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Libro> Libro { get; set; }
    }
}

