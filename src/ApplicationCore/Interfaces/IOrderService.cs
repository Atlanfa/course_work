using eshop.ApplicationCore.Entities.OrderAggregate;
using System.Threading.Tasks;

namespace eshop.ApplicationCore.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrderAsync(int basketId, Address shippingAddress);
    }
}
