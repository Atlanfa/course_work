using eshop.ApplicationCore.Entities.OrderAggregate;
using System.Threading.Tasks;

namespace eshop.ApplicationCore.Interfaces
{

    public interface IOrderRepository : IAsyncRepository<Order>
    {
        Task<Order> GetByIdWithItemsAsync(int id);
    }
}
