using Microsoft.EntityFrameworkCore;
using GameVault.Models;

namespace GameVault.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        public DbSet<Videojuego> Videojuegos { get; set; }


    }
}
