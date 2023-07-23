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
    public class StockService : IStockService
    {
        private readonly IStockRepository _stockRepository;
        private readonly IHubContext<stockHub> _hub;

        public StockService(IStockRepository stockRepository , IHubContext<stockHub> hub)
        {
            _stockRepository = stockRepository;
            _hub = hub;
        }

        public async Task<IEnumerable<StockModel>> GetAll()
        {
            var stocks = await _stockRepository.GetAll();
            return stocks.Select(s => new StockModel {
                ID = s.ID,
                Name = s.Name,
                Price = s.Price
            });
        }

        public async Task UpdateStockPrice()
        {

            var stocks = await GetAll();
            foreach(var stock in stocks)
            {
                var rng = new Random();
                int newPrice = rng.Next(1, 100);
                await _stockRepository.UpdateStockPrice(stock.ID, newPrice);
                await _hub.Clients.All.SendAsync("stockpricedata", stock.ID, newPrice.ToString());
            }

        }
    }
}
