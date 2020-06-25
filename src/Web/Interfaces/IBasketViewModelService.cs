using eshop.Web.Pages.Basket;
using System.Threading.Tasks;

namespace eshop.Web.Interfaces
{
    public interface IBasketViewModelService
    {
        Task<BasketViewModel> GetOrCreateBasketForUser(string userName);
    }
}
