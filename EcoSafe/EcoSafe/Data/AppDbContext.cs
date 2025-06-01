using Microsoft.EntityFrameworkCore;
using EcoSafe.Models;

namespace EcoSafe.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ABRIGO> ABRIGOS { get; set; }
        public DbSet<ALERTA> ALERTAS { get; set; }
        public DbSet<SENSOR> SENSORES { get; set; }
        public DbSet<LEITURA_SENSOR> LEITURAS_SENSOR { get; set; }
        public DbSet<APPUSER> APPUSERS { get; set; }
    }
}
