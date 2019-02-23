using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_mug_test.Models
{
    public class CoffeeMugTestDbContext : DbContext
    {
        public CoffeeMugTestDbContext(DbContextOptions<CoffeeMugTestDbContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
    }
}
