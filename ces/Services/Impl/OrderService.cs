using ces.Models;
using ces.Repositories;

namespace ces.Services.Impl
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;   

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void DeleteOrder(Guid orderId)
        {
            _orderRepository.DeleteOrder(orderId);
        }

        public async Task<Order> GetOrderById(Guid Id)
        {
           return  await _orderRepository.GetOrderById(Id);
        }

        public async Task<List<Order>> GetOrders()
        {
            return await _orderRepository.GetOrders();
        }

        public async Task InsertOrder(Order order)
        {
            await _orderRepository.InsertOrder(order);
        }

        public  void UpdateOrder(Order order)
        {
             _orderRepository.UpdateOrder(order);
        }
    }
}
