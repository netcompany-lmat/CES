using ces.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ces.Repositories
{
    public interface IOrderRepository
    {
        public Task<Order> GetOrderById(Guid Id);
        public Task InsertOrder(Order order);
        public void UpdateOrder(Order order);
        public void DeleteOrder(Guid orderId);
        public Task<List<Order>> GetOrders();

    }
}
    