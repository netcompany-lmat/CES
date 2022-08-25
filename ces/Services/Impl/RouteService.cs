using Route = ces.Models.Route;
using ces.Repositories;

namespace ces.Services.Impl;

public class RouteService : IRouteService
{
    private readonly IRouteRepository _routeRepository;

    public RouteService(IRouteRepository routeRepository)
    {
        _routeRepository = routeRepository;
    }

    public async Task InsertRoute(Route route)
    {
        await _routeRepository.InsertRoute(route);
    }
}
