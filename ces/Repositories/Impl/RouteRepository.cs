using Route = ces.Models.Route;
using ces.ORM;

namespace ces.Repositories.Impl;

public class RouteRepository : IRouteRepository
{
    private ApplicationDbContext _applicationDbContext;

    public RouteRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public async Task InsertRoute(Route route)
    {
        await _applicationDbContext.AddAsync(route);
        _applicationDbContext.SaveChanges();
    }
}
