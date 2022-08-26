using ces.DTO.Routes;

namespace ces.Clients.Oceanic;

public interface IOceanicClient
{
    Task<string> GetRoutesAsync(GetRoutesRequest request);
}
