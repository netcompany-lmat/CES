using ces.DTO.Routes;
using ces.ORM;
using ces.Repositories.Impl;
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
    private readonly CityService _cityService;

    public RouteController(ILogger<RouteController> logger, CityService cityService)
    {
        _logger = logger;
        _cityService = cityService;
    }

    [HttpPost]
    [Route("get-routes")]
    public IEnumerable<GetRoutesResponse> GetRoutes(GetRoutesRequest request)
    {
        return (IEnumerable<GetRoutesResponse>) _cityService.GetCity(request.StartCity).Routes;
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
