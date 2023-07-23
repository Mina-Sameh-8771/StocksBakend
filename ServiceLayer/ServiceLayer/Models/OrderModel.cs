using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class OrderModel
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string PersonName { get; set; }
        public int StockID { get; set; }
    }
}
