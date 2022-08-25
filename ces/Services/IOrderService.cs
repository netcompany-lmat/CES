using ces.Models;

namespace ces.Services
{
    public interface IOrderService
    {
        public Task<Order> GetOrderById(Guid Id);
        public Task InsertOrder(Order order);
        public void UpdateOrder(Order order);
        public void DeleteOrder(Guid orderId);
        public Task<List<Order>> GetOrders();
    }
}
