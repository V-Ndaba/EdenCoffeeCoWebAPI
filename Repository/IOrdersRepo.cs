using EdenWebAPI.Models;

namespace EdenWebAPI.Repository
{
    public interface IOrdersRepo
    {
        //Add
        Task<bool> AddOrderAsync(Orders order);
        //Read
        Task<bool> GetOrderAsync(int ID);
        //Read All
        Task<List<Orders>?> GetAllOrdersAsync();
        //Update
        Task<bool> UpdateOrderAsync(Orders order);
        //Delete
        Task<bool> DeleteOrderAsync(int ID);
    }
}
