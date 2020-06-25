using Microsoft.AspNetCore.Mvc.Rendering;
using eshop.Web.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eshop.Web.Services
{
    public interface ICatalogViewModelService
    {
        Task<CatalogIndexViewModel> GetCatalogItems(int pageIndex, int itemsPage, int? brandId, int? typeId);
        Task<IEnumerable<SelectListItem>> GetBrands();
        Task<IEnumerable<SelectListItem>> GetTypes();
    }
}
