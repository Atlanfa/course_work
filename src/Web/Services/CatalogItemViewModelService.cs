using eshop.ApplicationCore.Entities;
using eshop.ApplicationCore.Interfaces;
using eshop.Web.Interfaces;
using eshop.Web.ViewModels;
using System.Threading.Tasks;

namespace eshop.Web.Services
{
    public class CatalogItemViewModelService : ICatalogItemViewModelService
    {
        private readonly IAsyncRepository<CatalogItem> _catalogItemRepository;

        public CatalogItemViewModelService(IAsyncRepository<CatalogItem> catalogItemRepository)
        {
            _catalogItemRepository = catalogItemRepository;
        }

        public async Task UpdateCatalogItem(CatalogItemViewModel viewModel)
        {
            var existingCatalogItem = await _catalogItemRepository.GetByIdAsync(viewModel.Id);
            existingCatalogItem.Update(viewModel.Name, viewModel.Price);
            await _catalogItemRepository.UpdateAsync(existingCatalogItem);
        }
    }
}
