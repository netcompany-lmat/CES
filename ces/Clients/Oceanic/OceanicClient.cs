using ces.DTO.Routes;
using Newtonsoft.Json;
using System.Text;

namespace ces.Clients.Oceanic;

public class OceanicClient : IOceanicClient
{
    private static readonly string URL = "https://wa-oa-dk2.azurewebsites.net/api/v0/get-routes";

    public async Task<string> GetRoutesAsync(GetRoutesRequest request)
    {
        HttpClient client = new HttpClient();
        var result = await client.PostAsync(URL, new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json")).ConfigureAwait(false);
        return await result.Content.ReadAsStringAsync();
    }
}
