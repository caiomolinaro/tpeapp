using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tpeapp.Models;

namespace tpeapp.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<UsersModel> Usuarios { get; set; }
        public DbSet<WeekDaysModel> DiasSemana { get; set; }
        public DbSet<PrivilegesModel> Privilegios { get; set; }
        public DbSet<SchedulesModel> Horarios { get; set; }
        public DbSet<PointsModel> Pontos { get; set; }
        public DbSet<CircuitsModel> Circuitos { get; set; }
        public DbSet<CongregationsModel> Congregacoes { get; set; }


    }
}
