using Microsoft.EntityFrameworkCore;
using tpeapp.Context;
using tpeapp.Models;
using tpeapp.Repositories.Interfaces;

namespace tpeapp.Repositories
{
    public class PointsRepository :IPointsRepository
    {
        private readonly AppDbContext _dbContext;

        public PointsRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       public IEnumerable<PointsModel> Points => _dbContext.Points.Include(p => p.Schedules);
    }
}
