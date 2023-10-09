using tpeapp.Models;

namespace tpeapp.Repositories.Interfaces
{
    public interface ISchedulesRepository
    {
        IEnumerable<SchedulesModel> Schedules { get; }
    }
}
