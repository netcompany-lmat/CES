using ces.Clients.EIT;
using ces.Clients.Oceanic;
using ces.DTO.Routes;
using ces.ORM;
using ces.Repositories.Impl;
using ces.Services;
using ces.Services.Impl;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Net;

namespace ces.Controllers;

[ApiController]
[Route("api/v0")]
public class RouteController : ControllerBase
{
    private readonly ILogger<RouteController> _logger;
    private readonly ICityService _cityService;
    private readonly IEastIndiaClient _eastIndiaclient;
    private readonly IOceanicClient _oceanicClient;

    public RouteController(ILogger<RouteController> logger, IEastIndiaClient eastIndiaClient, IOceanicClient oceanicClient, ICityService cityService)
    {
        _logger = logger;
        _eastIndiaclient = eastIndiaClient;
        _oceanicClient = oceanicClient;
        _cityService = cityService;
    }

    [HttpPost]
    [Route("get-routes")]
    public IEnumerable<GetRoutesResponse> GetRoutes(GetRoutesRequest request)
    {
        return RoutesMockup();
    }

    [HttpPost]
    [Route("get-eit-routes")]
    public async Task<List<GetRoutesResponse>> GetEastIndiaRoutesAsync(GetRoutesRequest request)
    {
        return await _eastIndiaclient.GetRoutesAsync(request);
    }

    [HttpPost]
    [Route("get-oceanic-routes")]
    public async Task<List<GetRoutesResponse>> GetOceanicRoutesAsync(GetRoutesRequest request)
    {
        return await _oceanicClient.GetRoutesAsync(request);
    }

    private IEnumerable<GetRoutesResponse> RoutesMockup()
    {
        return new List<GetRoutesResponse>
        {
            new GetRoutesResponse
            {
                DestinationCity = "Cairo",
                Price = 1000,
                Time = 120
            },
            new GetRoutesResponse
            {
                DestinationCity = "Cape Town",
                Price = 2000,
                Time = 50
            },
            new GetRoutesResponse
            {
                DestinationCity = "Tunis",
                Price = 5000.50,
                Time = 60,
            },
            new GetRoutesResponse
            {
                DestinationCity = "Miami",
                Price = 1000,
                Time = 12
            },
            new GetRoutesResponse
            {
                DestinationCity = "Szczebrzeszyn",
                Price = 420.60,
                Time = 13
            }
        };
    }
}
