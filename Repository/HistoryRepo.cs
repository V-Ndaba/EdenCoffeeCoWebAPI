using EdenWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EdenWebAPI.Repository
{
    public class HistoryRepo : BaseRepo<History>, IHistoryRepo
    {
        public HistoryRepo(EdenDBContext dbSet) : base(dbSet.Set<History>())
        {
        }

        public async Task<bool> AddHistoryAsync(History history)
        {
            return await base.AddAsync(history);
        }

        public async Task<List<History>?> GetAllHistoryAsync()
        {
            return await base.GetAllAsync();
        }

        //
        public async Task<List<History>?> GetHistoryAsync(DateOnly date)
        {
            List<History> histories = new List<History>();
            /*while (await Task )
            {
                //Add all the orders with same date to histories and push them

            }*/
            return histories;
        }
    }
}
