using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public Costumer Costumer { get; set; }
    }
}
