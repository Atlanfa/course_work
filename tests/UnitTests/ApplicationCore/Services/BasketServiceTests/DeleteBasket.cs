﻿using eshop.ApplicationCore.Entities.BasketAggregate;
using eshop.ApplicationCore.Interfaces;
using eshop.ApplicationCore.Services;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace eshop.UnitTests.ApplicationCore.Services.BasketServiceTests
{
    public class DeleteBasket
    {
        private readonly string _buyerId = "Test buyerId";
        private readonly Mock<IAsyncRepository<Basket>> _mockBasketRepo;

        public DeleteBasket()
        {
            _mockBasketRepo = new Mock<IAsyncRepository<Basket>>();
        }

        [Fact]
        public async Task ShouldInvokeBasketRepositoryDeleteAsyncOnce()
        {
            var basket = new Basket(_buyerId);
            basket.AddItem(1, It.IsAny<decimal>(), It.IsAny<int>());
            basket.AddItem(2, It.IsAny<decimal>(), It.IsAny<int>());
            _mockBasketRepo.Setup(x => x.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(basket);
            var basketService = new BasketService(_mockBasketRepo.Object, null);

            await basketService.DeleteBasketAsync(It.IsAny<int>());

            _mockBasketRepo.Verify(x => x.DeleteAsync(It.IsAny<Basket>()), Times.Once);
        }
    }
}
