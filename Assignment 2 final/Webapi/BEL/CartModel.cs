using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CartModel
    {
        public int order_id { get; set; }
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int quanitity { get; set; }
        public int price { get; set; }
        public int id { get; set; }
    }
}
