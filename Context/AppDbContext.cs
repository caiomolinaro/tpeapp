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

        public DbSet<UsersModel> Users { get; set; }
        public DbSet<WeekDaysModel> WeekDays { get; set; }
        public DbSet<PrivilegesModel> Privileges { get; set; }
        public DbSet<SchedulesModel> Hours { get; set; }
        public DbSet<PointsModel> Points { get; set; }
        public DbSet<CircuitsModel> Circuits { get; set; }
        public DbSet<CongregationsModel> Congregations { get; set; }


    }
}
