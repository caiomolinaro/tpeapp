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
        //public DbSet<WeekDaysModel> WeekDays { get; set; }
        //public DbSet<UsersPrivilegesModel> Privileges { get; set; }
        public DbSet<SchedulesModel> SchedulesModel { get; set; }
        public DbSet<PointsModel> Points { get; set; }
        public DbSet<CircuitsModel> Circuits { get; set; }
        public DbSet<CongregationsModel> Congregations { get; set; }
        public DbSet<UsersSchedulesModel> UsersSchedules { get; set; }



        //conversor de dateonly
        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>()
                .HaveColumnType("date");
        }
    }

    /// <summary>
    /// Converts <see cref="DateOnly" /> to <see cref="DateTime"/> and vice versa.
    /// </summary>
    public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
    {
        /// <summary>
        /// Creates a new instance of this converter.
        /// </summary>
        public DateOnlyConverter() : base(
                d => d.ToDateTime(TimeOnly.MinValue),
                d => DateOnly.FromDateTime(d))
        { }


    }
}
