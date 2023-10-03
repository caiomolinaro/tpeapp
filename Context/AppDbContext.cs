using Microsoft.EntityFrameworkCore;
using tpeapp.Models;

namespace tpeapp.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<DiasSemana> DiasSemana { get; set; }
        public DbSet<Privilegios> Privilegios { get; set; }
        public DbSet<Schedules> Horarios { get; set; }
        public DbSet<Pontos> Pontos { get; set; }
        public DbSet<Circuitos> Circuitos { get; set; }
        public DbSet<Congregacoes> Congregacoes { get; set; }

    }
}
