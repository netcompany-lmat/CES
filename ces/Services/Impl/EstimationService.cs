using ces.Models;
using Dijkstra.Algorithm.Graphing;
using Dijkstra.Algorithm.Pathing;
using System.Runtime.CompilerServices;
using Route = ces.Models.Route;
using Path = Dijkstra.Algorithm.Pathing.Path;

namespace ces.Services.Impl
{
    public class EstimationService : IEstimationService
    {
        public List<Estimation> GetEstimations(string a, string b)
        {
            List<Estimation> estimations = new List<Estimation>();
            
            

            return estimations;
        }

        private Path GetPromotedEstimation(string a, string b)
        {
            
            return GetLocalMap().Dijkstra(a, b);
        }

        private GraphBuilder GetCities()
        {
            var builder = new GraphBuilder();
            var cities = new List<City>(); // from db
            foreach (City city in cities)
            {
                builder.AddNode(city.Name);
            }
            return builder;
        }

        private Graph GetLocalMap()
        {
            var cities = GetCities();

            foreach(City city in cities.np)
            {
                foreach(Route route in city.Routes)
                {
                    var a = cities.Single(q => q.Id == route.A);
                    var b = cities.Single(q => q.Id == route.B);

                    builder.AddLink(a.Name, b.Name, route.Distance);
                }
            }

            return builder.Build();
        }

        private Graph GetMapPrice()
        {

        }
    }
}
