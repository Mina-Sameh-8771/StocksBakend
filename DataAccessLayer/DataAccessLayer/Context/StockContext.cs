using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class StockContext : DbContext
    {
        public StockContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedStocksData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Order> Orders { get; set; }

        private void SeedStocksData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>().HasData(
                new Stock { ID = 1, Name = "Vianet", Price = 10 },
                new Stock { ID = 2, Name = "Agritek", Price = 10 },
                new Stock { ID = 3, Name = "Akamai", Price = 10 },
                new Stock { ID = 4, Name = "Baidu", Price = 10 },
                new Stock { ID = 5, Name = "Blinkx", Price = 10 },
                new Stock { ID = 6, Name = "Blucora", Price = 10 },
                new Stock { ID = 7, Name = "Boingo", Price = 10 },
                new Stock { ID = 8, Name = "Brainybrawn", Price = 10 },
                new Stock { ID = 9, Name = "Carbonite", Price = 10 },
                new Stock { ID = 10, Name = "China Finance", Price = 10 },
                new Stock { ID = 11, Name = "ChinaCache", Price = 10 },
                new Stock { ID = 12, Name = "ADR", Price = 10 },
                new Stock { ID = 13, Name = "ChitrChatr", Price = 10 },
                new Stock { ID = 14, Name = "Cnova", Price = 10 },
                new Stock { ID = 15, Name = "Cogent", Price = 10 },
                new Stock { ID = 16, Name = "Crexendo", Price = 10 },
                new Stock { ID = 17, Name = "CrowdGather", Price = 10 },
                new Stock { ID = 18, Name = "EarthLink", Price = 10 },
                new Stock { ID = 19, Name = "Eastern", Price = 10 },
                new Stock { ID = 20, Name = "ENDEXX", Price = 10 },
                new Stock { ID = 21, Name = "Envestnet", Price = 10 },
                new Stock { ID = 22, Name = "Epazz", Price = 10 },
                new Stock { ID = 23, Name = "FlashZero", Price = 10 },
                new Stock { ID = 24, Name = "Genesis", Price = 10 },
                new Stock { ID = 25, Name = "InterNAP", Price = 10 },
                new Stock { ID = 26, Name = "MeetMe", Price = 10 },
                new Stock { ID = 27, Name = "Netease", Price = 10 },
                new Stock { ID = 28, Name = "Qihoo", Price = 10 }
                );
        }

    }
}
