using eshop.Web.ViewModels;
using System.Threading.Tasks;

namespace eshop.Web.Interfaces
{
    public interface ICatalogItemViewModelService
    {
        Task UpdateCatalogItem(CatalogItemViewModel viewModel);
    }
}
