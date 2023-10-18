using tpeapp.Context;
using tpeapp.Models;
using tpeapp.Repositories.Interfaces;


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
