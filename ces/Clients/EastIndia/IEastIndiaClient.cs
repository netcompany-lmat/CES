using ces.DTO.Routes;

namespace ces.Clients.EIT;

public interface IEastIndiaClient
{
    Task<List<GetRoutesResponse>> GetRoutesAsync(GetRoutesRequest request);
}
