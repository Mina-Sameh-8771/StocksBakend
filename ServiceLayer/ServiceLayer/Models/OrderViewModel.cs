using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class OrderViewModel
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string PersonName { get; set; }
        public string StockName { get; set; }
    }
}
