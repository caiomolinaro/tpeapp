using tpeapp.Models;

namespace tpeapp.Repositories.Interfaces
{
    public interface IPointsRepository
    {
        IEnumerable<PointsModel> Points { get; }
    }
}
