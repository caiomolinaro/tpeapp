using tpeapp.Models;

namespace tpeapp.Repositories
{
    public interface ICircuitsRepository
    {
        IEnumerable<CircuitsModel> Circuits { get; }
    }
}
