﻿using eshop.Web;
using eshop.Web.Extensions;
using Xunit;

namespace eshop.UnitTests.Web.Extensions.CacheHelpersTests
{
    public class GenerateCatalogItemCacheKey
    {
        [Fact]
        public void ReturnsCatalogItemCacheKey()
        {
            var pageIndex = 0;
            int? brandId = null;
            int? typeId = null;

            var result = CacheHelpers.GenerateCatalogItemCacheKey(pageIndex, Constants.ITEMS_PER_PAGE, brandId, typeId);

            Assert.Equal("items-0-10--", result);
        }
    }
}
