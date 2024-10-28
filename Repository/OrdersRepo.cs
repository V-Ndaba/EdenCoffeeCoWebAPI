using EdenWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EdenWebAPI.Repository
{
    public class OrdersRepo : BaseRepo<Orders>, IOrdersRepo
    {
        public OrdersRepo(EdenDBContext dbSet) : base(dbSet.Set<Orders>())
        {
        }

        public async Task<bool> AddOrderAsync(Orders order)
        {
            return await base.AddAsync(order);
        }

        public async Task<bool> DeleteOrderAsync(int ID)
        {
            return await base.DeleteAsync(ID);
        }

        public Task<List<Orders>?> GetAllOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetOrderAsync(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOrderAsync(Orders order)
        {
            throw new NotImplementedException();
        }
    }
}
