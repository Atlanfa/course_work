﻿using Ardalis.Specification;
using eshop.ApplicationCore.Entities.OrderAggregate;
using eshop.ApplicationCore.Interfaces;
using eshop.Web.Features.MyOrders;
using Moq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace eshop.UnitTests.MediatorHandlers.OrdersTests
{
    public class GetMyOrders
    {
        private readonly Mock<IOrderRepository> _mockOrderRepository;

        public GetMyOrders()
        {
            var item = new OrderItem(new CatalogItemOrdered(1, "ProductName", "URI"), 10.00m, 10);
            var address = new Address(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());
            Order order = new Order("buyerId", address, new List<OrderItem> { item });

            _mockOrderRepository = new Mock<IOrderRepository>();
            _mockOrderRepository.Setup(x => x.ListAsync(It.IsAny<ISpecification<Order>>())).ReturnsAsync(new List<Order> { order });
        }

        [Fact]
        public async Task NotReturnNullIfOrdersArePresent()
        {
            var request = new eshop.Web.Features.MyOrders.GetMyOrders("SomeUserName");

            var handler = new GetMyOrdersHandler(_mockOrderRepository.Object);

            var result = await handler.Handle(request, CancellationToken.None);

            Assert.NotNull(result);
        }
    }
}
