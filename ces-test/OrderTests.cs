using ces.Controllers;
using ces.Models;
using ces.Services;
using Microsoft.Extensions.Logging;
using Moq;

namespace ces_test
{
    public class OrderTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task ReturnsOrderByOrderId()
        {
            //var logger = new Mock<ILogger<OrderController>>();
            //var orderStub = new Mock<IOrderService>(logger);

            //Guid validOrderId = new();

            //Order order = new()
            //{

            //};

            //orderStub.Setup(x => x.GetOrderById(validOrderId))
            //    .ReturnsAsync(new Order()
            //    {
                                       
            //    });

            //var orderController = new OrderController(logger.Object, orderStub.Object);
            //var response = await orderController.GetOrderById(validOrderId);

            //Assert.AreSame("","");            
        }
    }
}