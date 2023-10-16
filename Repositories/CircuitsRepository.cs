using Microsoft.EntityFrameworkCore;
using tpeapp.Context;
using tpeapp.Models;

namespace tpeapp.Repositories
{
    public class CircuitsRepository : ICircuitsRepository
    {
        private readonly AppDbContext _dbContext;

        public CircuitsRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<CircuitsModel> Circuits => _dbContext.Circuits;
    }
}
