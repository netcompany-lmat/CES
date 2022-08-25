using ces.Models;
using ces.Repositories.Impl;
using ces.Services.Impl;
using Microsoft.AspNetCore.Mvc;

namespace ces.Controllers
{
    [ApiController]
    [Route("api/v0")]
    public class EstimationController : Controller
    {
        private readonly EstimationService _estimationService;

        public EstimationController(EstimationService estimationService)
        {
            _estimationService = estimationService;
        }

        [HttpPost]
        [Route("estimate")]
        public List<Estimation> Estimate(string a, string b)
        {
            return _estimationService.GetEstimations(a, b);
        }
    }
}
