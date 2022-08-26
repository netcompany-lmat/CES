using ces.Models;

namespace ces.Services
{
    public interface ICityService
    {
        public Task<List<City>> GetCities();
    }
}
