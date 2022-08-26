using ces.DTO.Routes;

namespace ces.Clients.Oceanic;

public interface IOceanicClient
{
    Task<List<GetRoutesResponse>> GetRoutesAsync(GetRoutesRequest request);
}
