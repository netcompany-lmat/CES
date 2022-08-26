using ces.Controllers;
using ces.Models;
using ces.Services;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ces_test
{
    public class CityTests
    {
        Mock<ILogger<CityController>> loggerMock;
        Mock<ICityService>? cityServiceMock;
        [SetUp]
        public void Setup()
        {
            loggerMock = new Mock<ILogger<CityController>>();
        }

        [Test]
        public async Task ReturnCities()
        {
            cityServiceMock = new Mock<ICityService>();


            List<City> cities = new()
            {
                new City()
                {
                   Name = "London"
                },
                new City()
                {
                   Name = "Copenhagen"
                },
            };

            cityServiceMock.Setup(x => x.GetCities())
                .ReturnsAsync(cities);

            var cityController = new CityController(loggerMock.Object, cityServiceMock.Object);
            var response = await cityController.GetCities();


            Assert.AreEqual(cities.Count, response.Value.Count);
        }
    }
}
