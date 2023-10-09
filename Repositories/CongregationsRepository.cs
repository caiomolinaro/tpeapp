using Microsoft.EntityFrameworkCore;
using tpeapp.Context;
using tpeapp.Models;
using tpeapp.Repositories.Interfaces;

namespace tpeapp.Repositories
{
    public class CongregationsRepository : ICongregationsRepository
    {
        private readonly AppDbContext _dbContext;

        public CongregationsRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<CongregationsModel> Congregations => _dbContext.Congregations.Include(c => c.CongregationName);
    }
}
