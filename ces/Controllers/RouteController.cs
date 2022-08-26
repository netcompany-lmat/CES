
using ces.Clients.EIT;
using ces.Clients.Oceanic;
using ces.DTO.Routes;
using ces.ORM;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Net;

namespace ces.Controllers;

[ApiController]
[Route("api/v0")]
public class RouteController : ControllerBase
{
    private readonly ILogger<RouteController> _logger;
    private readonly IEastIndiaClient _eastIndiaclient;
    private readonly IOceanicClient _oceanicClient;

    public RouteController(ILogger<RouteController> logger, IEastIndiaClient eastIndiaClient, IOceanicClient oceanicClient)
    {
        _logger = logger;
        _eastIndiaclient = eastIndiaClient;
        _oceanicClient = oceanicClient;
    }

    // For mock-up purposes
    [HttpPost]
    [Route("get-routes")]
    public IEnumerable<GetRoutesResponse> GetRoutes(GetRoutesRequest request)
    {
        return RoutesMockup();
    }

    [HttpPost]
    [Route("get-eit-routes")]
    public async Task<string> GetEastIndiaRoutesAsync(GetRoutesRequest request)
    {
        return await _eastIndiaclient.GetRoutesAsync(request);
    }

    [HttpPost]
    [Route("get-oceanic-routes")]
    public async Task<string> GetOceanicRoutesAsync(GetRoutesRequest request)
    {
        return await _oceanicClient.GetRoutesAsync(request);
    }

    private IEnumerable<GetRoutesResponse> RoutesMockup()
    {
        return new List<GetRoutesResponse>
        {
            new GetRoutesResponse
            {
                DestCity = "Cairo",
                Price = 1000,
                Time = 120
            },
            new GetRoutesResponse
            {
                DestCity = "Cape Town",
                Price = 2000,
                Time = 50
            },
            new GetRoutesResponse
            {
                DestCity = "Tunis",
                Price = 5000.50,
                Time = 60,
            },
            new GetRoutesResponse
            {
                DestCity = "Miami",
                Price = 1000,
                Time = 12
            },
            new GetRoutesResponse
            {
                DestCity = "Szczebrzeszyn",
                Price = 420.60,
                Time = 13
            }
        };
    }
}
