using MediatR;
using eshop.Web.ViewModels;
using System.Collections.Generic;

namespace eshop.Web.Features.MyOrders
{
    public class GetMyOrders : IRequest<IEnumerable<OrderViewModel>>
    {
        public string UserName { get; set; }

        public GetMyOrders(string userName)
        {
            UserName = userName;
        }
    }
}
