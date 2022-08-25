using Route = ces.Models.Route;

namespace ces.Services;

public interface IRouteService
{
    public Task InsertRoute(Route route);
}
