using ces.Controllers;
using ces.Models;
using ces.Services;
using Microsoft.Extensions.Logging;
using Moq;

namespace ces_test
{
    public class OrderTests
    {
        Mock<ILogger<OrderController>> loggerMock;
        Mock<IOrderService>? orderServiceMock;
        [SetUp]
        public void Setup()
        {
            loggerMock = new Mock<ILogger<OrderController>>();
            orderServiceMock = new Mock<IOrderService>();
        }

        [Test]
        public async Task ReturnsOrderByOrderId()
        {
            Guid validOrderId = new();

            Order order = new()
            {
                DateTime = DateTime.Now,
                Price = 3.5                
            };

            orderServiceMock.Setup(x => x.GetOrderById(validOrderId))
                .ReturnsAsync(new Order()
                {
                    DateTime = DateTime.Now,
                    Price = 3.5
                });

            var orderController = new OrderController(loggerMock.Object, orderServiceMock.Object);
            var response = await orderController.GetOrderById(validOrderId);

            Assert.AreEqual(order.Price, response.Value.Price);
        }
    }
}