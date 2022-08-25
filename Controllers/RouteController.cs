using ces.DTO.Routes;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace ces.Controllers;

[ApiController]
[Route("api/v0")]
public class RouteController : ControllerBase
{
    private readonly ILogger<RouteController> _logger;

    public RouteController(ILogger<RouteController> logger)
    {
        _logger = logger;
    }

    // For mock-up purposes
    [HttpPost]
    [Route("get-routes")]
    public IEnumerable<GetRoutesResponse> GetRoutes(GetRoutesRequest request)
    {
        return RoutesMockup();
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
