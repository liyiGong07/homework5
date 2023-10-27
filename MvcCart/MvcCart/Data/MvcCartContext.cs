using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcCart.Models;

namespace MvcCart.Data
{
    public class MvcCartContext : DbContext
    {
        public MvcCartContext (DbContextOptions<MvcCartContext> options)
            : base(options)
        {
        }

        public DbSet<MvcCart.Models.Cart> Cart { get; set; } = default!;
    }
}
