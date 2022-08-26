using ces.Models;

namespace ces.Services
{
    public interface IEstimationService
    {
        public List<Estimation> GetEstimations(string a, string b);
    }
}
