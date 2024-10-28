using EdenWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EdenWebAPI.Repository
{
    public class BevRepo : BaseRepo<Beverages>, IBevRepo
    {
        public BevRepo(EdenDBContext dbSet) : base(dbSet.Set<Beverages>())
        {
        }

        public async Task<bool> AddBevAsync(Beverages beverages)
        {
            return await base.AddAsync(beverages);
        }

        public async Task<bool> DeleteBevAsync(int ID)
        {
            return await base.DeleteAsync(ID);
        }

        public async Task<List<Beverages>?> GetAllBevsAsync()
        {
            return await base.GetAllAsync();
        }

        public Task<bool> GetBevAsync(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateBevAsync(Beverages beverages)
        {
            throw new NotImplementedException();
        }
    }
}
