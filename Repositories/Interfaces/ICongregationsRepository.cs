using tpeapp.Models;

namespace tpeapp.Repositories.Interfaces
{
    public interface ICongregationsRepository
    {
        IEnumerable<CongregationsModel> Congregations { get; }
    }
}
