using EdenWebAPI.Models;
using EdenWebAPI.Repository;

namespace EdenWebAPI.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly IConfiguration Configuration;
        private EdenDBContext _DbContext;
        public UnitOfWork(IConfiguration Config, EdenDBContext DbContext)
        {
            Configuration = Config;
            _DbContext = DbContext;

            ordersRepo = new OrdersRepo(DbContext);
            bevRepo = new BevRepo(DbContext);
        }
        public IOrdersRepo ordersRepo { get; private set; }

        public IBevRepo bevRepo { get; private set; }

        public ValueTask DisposeAsync()
        {
            return ((IAsyncDisposable)_DbContext).DisposeAsync();
        }

        public async Task SaveAsync()
        {
            await _DbContext.SaveChangesAsync();
        }
    }
}
