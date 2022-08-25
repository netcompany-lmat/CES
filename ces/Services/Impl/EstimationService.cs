using ces.Models;
using System.Runtime.CompilerServices;
using Route = ces.Models.Route;

namespace ces.Services.Impl
{
    public class EstimationService : IEstimationService
    {
        public List<Estimation> GetEstimations(string a, string b)
        {
            List<Estimation> estimations = new List<Estimation>();

            

            return estimations;
        }

        private Estimation GetPromotedEstimation(string a, string b)
        {
            Dictionary<string, List<Route>> routes = new Dictionary<string, List<Route>>();
            routes.Add(a, )
            return new Estimation();
        }
    }
}
