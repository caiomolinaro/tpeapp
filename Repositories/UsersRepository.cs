using Microsoft.EntityFrameworkCore;
using tpeapp.Context;
using tpeapp.Models;
using tpeapp.Repositories.Interfaces;

namespace tpeapp.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly AppDbContext _dbContext;

        public UsersRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<UsersModel> Users => _dbContext.Users.Include(u => u.UserName);
    }
}
