using ces.Models;

namespace ces.Repositories
{
    public interface ICityRepository
    {
        public Task<List<City>> GetCities();
    }
}
