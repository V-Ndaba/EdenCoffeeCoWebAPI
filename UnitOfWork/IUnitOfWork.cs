using EdenWebAPI.Repository;

namespace EdenWebAPI.UnitOfWork
{
    public interface IUnitOfWork
    {
        IOrdersRepo ordersRepo { get; }
        IBevRepo bevRepo { get; }

        ValueTask DisposeAsync();
        Task SaveAsync();
    }
}
