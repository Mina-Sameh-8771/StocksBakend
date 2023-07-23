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
    public class StockRepository : IStockRepository
    {
        private readonly StockContext _context;

        public StockRepository(StockContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Stock>> GetAll()
        {
            return await _context.Stocks.ToListAsync();
        }

        public async Task UpdateStockPrice(int stockID, decimal newPrice)
        {
            var stockItem = await _context.Stocks.FindAsync(stockID);
            stockItem.Price = newPrice;
            //_context.Update(stockItem);
            _context.Entry(stockItem).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }
    }
}
