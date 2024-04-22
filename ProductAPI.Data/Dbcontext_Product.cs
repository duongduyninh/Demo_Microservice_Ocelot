using Microsoft.EntityFrameworkCore;
using ProductAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Data
{
    public class Dbcontext_Product : DbContext
    {
        public Dbcontext_Product(DbContextOptions<Dbcontext_Product> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Product> Products { get; set; }
    }
}
