using Microsoft.EntityFrameworkCore;
using tpeapp.Context;
using tpeapp.Models;
using tpeapp.Repositories.Interfaces;

namespace tpeapp.Repositories
{
    public class SchedulesRepository : ISchedulesRepository
    {
        private readonly AppDbContext _dbContext;

        public SchedulesRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<SchedulesModel> Schedules => _dbContext.Schedules.Include(s => s.SchedulesName);
    }
}
