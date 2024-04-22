using Microsoft.EntityFrameworkCore;
using OrderingAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingAPI.Data
{
    public class Dbcontext_Ordering
    {
        public class Dbcontext_Ordering : DbContext
        {
            public Dbcontext_Ordering(DbContextOptions<Dbcontext_Ordering> options) : base(options) { }

            public DbSet<Order> Orders { get; set; }
        }
    }
}
