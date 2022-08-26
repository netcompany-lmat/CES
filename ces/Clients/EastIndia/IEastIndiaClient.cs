using ces.DTO.Routes;

namespace ces.Clients.EIT;

public interface IEastIndiaClient
{
    Task<string> GetRoutesAsync(GetRoutesRequest request);
}
