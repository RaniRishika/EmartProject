using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmartApplication.Models;

    public class EmartSellerContext : DbContext
    {
        public EmartSellerContext (DbContextOptions<EmartSellerContext> options)
            : base(options)
        {
        }

        public DbSet<EmartApplication.Models.Seller> Seller { get; set; }
    }
