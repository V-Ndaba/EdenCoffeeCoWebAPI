using EdenWebAPI.Models;

namespace EdenWebAPI.Repository
{
    public interface IHistoryRepo
    {
        //Add
        Task<bool> AddHistoryAsync(History history);
        //Read
        Task<List<History>?> GetHistoryAsync(DateOnly date);
        //Read All
        Task<List<History>?> GetAllHistoryAsync();
    }
}
