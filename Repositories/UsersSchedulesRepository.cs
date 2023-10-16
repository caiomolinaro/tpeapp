using Microsoft.EntityFrameworkCore;
using tpeapp.Context;
using tpeapp.Models;
using tpeapp.Repositories.Interfaces;

namespace tpeapp.Repositories
{
    public class UsersSchedulesRepository //: IUsersSchedulesRepository
    {
        private readonly AppDbContext _dbContext;

        public UsersSchedulesRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public IEnumerable<UsersSchedulesModel> UsersSchedules => _dbContext.UsersSchedules.Include(u => u.Users);
    }
}
