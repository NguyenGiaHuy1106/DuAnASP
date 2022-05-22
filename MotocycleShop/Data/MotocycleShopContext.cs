using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MotocycleShop.Models;

namespace MotocycleShop.Data
{
    public class MotocycleShopContext : DbContext
    {
        public MotocycleShopContext (DbContextOptions<MotocycleShopContext> options)
            : base(options)
        {
        }

        public DbSet<MotocycleShop.Models.Kho> Kho { get; set; }
    }
}
