using EdenWebAPI.Models;

namespace EdenWebAPI.Repository
{
    public interface IBevRepo
    {
        //Add
        Task<bool> AddBevAsync(Beverages beverages);
        //Read
        Task<bool> GetBevAsync(int ID);
        //Read All
        Task<List<Beverages>?> GetAllBevsAsync();
        //Update
        Task<bool> UpdateBevAsync(Beverages beverages);
        //Delete
        Task<bool> DeleteBevAsync(int ID);
    }
}
