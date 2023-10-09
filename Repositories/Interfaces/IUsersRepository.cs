using tpeapp.Models;

namespace tpeapp.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        IEnumerable<UsersModel> Users { get; }
    }
}
