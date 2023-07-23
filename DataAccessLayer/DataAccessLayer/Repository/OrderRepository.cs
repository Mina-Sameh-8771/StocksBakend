using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly StockContext _context;

        public OrderRepository(StockContext context)
        {
            _context = context;
        }
        public async Task<Order> CreateOrder(Order order)
        {
            var selectedStock = await _context.Stocks.FindAsync(order.StockID);
            order.Price = selectedStock.Price * order.Quantity;
            await _context.AddAsync(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task<IEnumerable<Order>> GetOrders()
        {
            return await _context.Orders.Include(s => s.Stock).OrderByDescending(s => s.ID).ToListAsync();
        }
    }
}
