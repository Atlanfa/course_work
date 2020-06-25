using Ardalis.Specification;
using eshop.ApplicationCore.Entities;
using System;
using System.Linq;

namespace eshop.ApplicationCore.Specifications
{
    public class CatalogItemsSpecification : BaseSpecification<CatalogItem>
    {
        public CatalogItemsSpecification(params int[] ids) : base(c => ids.Contains(c.Id))
        {

        }
    }
}
