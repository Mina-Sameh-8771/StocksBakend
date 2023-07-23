using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using Microsoft.AspNetCore.SignalR;
using ServiceLayer.Interfaces;
using ServiceLayer.Models;
using ServiceLayer.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IHubContext<stockHub> _hub;


        public OrderService(IOrderRepository orderRepository, IHubContext<stockHub> hub)
        {
            _orderRepository = orderRepository;
            _hub = hub;
        }

        public async Task CreateOrder(OrderModel order)
        {
            var newOrder = new Order
            {
                PersonName = order.PersonName,
                Quantity = order.Quantity,
                StockID = order.StockID
            };
            await _orderRepository.CreateOrder(newOrder);
            await _hub.Clients.All.SendAsync("neworderdata" , new OrderViewModel
            {
                PersonName = newOrder.PersonName,
                Price = newOrder.Price,
                Quantity = newOrder.Quantity,
                StockName = newOrder.Stock.Name
            });
        }

        public async Task<IEnumerable<OrderViewModel>> GetOrders()
        {
            var orders = await  _orderRepository.GetOrders();
            return orders.Select(s => new OrderViewModel
            { 
                PersonName = s.PersonName,
                Price = s.Price,
                Quantity = s.Quantity,
                StockName = s.Stock.Name
            });
        }
    }
}
