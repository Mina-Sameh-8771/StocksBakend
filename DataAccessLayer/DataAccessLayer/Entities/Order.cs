using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Order : BaseEntity
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string PersonName { get; set; }
        public int StockID { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
