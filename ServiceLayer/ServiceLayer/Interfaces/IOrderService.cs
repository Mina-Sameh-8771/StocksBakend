using ServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrder(OrderModel order);
        Task<IEnumerable<OrderViewModel>> GetOrders();
    }
}
