using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingAPI.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public ICollection<OrderDetail> OrderDetail { get; set; }

    }
}
