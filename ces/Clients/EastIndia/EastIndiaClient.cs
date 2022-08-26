using ces.DTO.Routes;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace ces.Clients.EIT;

public class EastIndiaClient : IEastIndiaClient
{
    private static readonly string URL = "https://wa-eit-dk2.azurewebsites.net/findRoute";

    public async Task<List<GetRoutesResponse>> GetRoutesAsync(GetRoutesRequest request)
    {
        HttpClient client = new HttpClient();
        var result = await client.PostAsync(URL, new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json")).ConfigureAwait(false);
        string response = await result.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<GetRoutesResponse>>(response);
    }
}
