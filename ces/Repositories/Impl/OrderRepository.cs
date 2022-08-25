using ces.Models;
using ces.ORM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace ces.Repositories.Impl
{
    public class OrderRepository : IOrderRepository
    {
        private ApplicationDbContext _applicationDbContext;

        public OrderRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void DeleteOrder(Guid orderId)
        {
            var entity = new Order()
            {
                Id = orderId
            };
            _applicationDbContext.Orders.Remove(entity);
            _applicationDbContext.SaveChanges();
        }

        public async Task<Order> GetOrderById(Guid id)
        {
             return await _applicationDbContext.
                Orders.FirstOrDefaultAsync(order => order.Id == id);
        }

     

        public async Task<List<Order>> GetOrders()
        {
            return  await  _applicationDbContext.Orders.ToListAsync();
        }

        public async Task InsertOrder(Order order)
        {

            await _applicationDbContext.AddAsync(order);
            _applicationDbContext.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            var UpdateOrder =  _applicationDbContext.Orders.Attach(order);
            UpdateOrder.State = EntityState.Modified;
            _applicationDbContext.SaveChanges();
        }
       
    }
}
