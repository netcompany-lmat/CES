using ces.Models;
using ces.ORM;
using Microsoft.EntityFrameworkCore;

namespace ces.Repositories.Impl
{
    public class CityRepository : ICityRepository
    {
        private ApplicationDbContext _applicationDbContext;

        public CityRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<List<City>> GetCities()
        {
            return await _applicationDbContext.Cities.ToListAsync();
        }
    }
}
