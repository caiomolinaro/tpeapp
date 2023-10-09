using tpeapp.Models;

namespace tpeapp.Repositories.Interfaces
{
    public interface IUsersSchedulesRepository
    {
        IEnumerable<UsersSchedulesModel> UsersSchedules { get; }
    }
}
