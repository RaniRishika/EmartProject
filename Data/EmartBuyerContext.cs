using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmartApplication.Models;

    public class EmartBuyerContext : DbContext
    {
        public EmartBuyerContext (DbContextOptions<EmartBuyerContext> options)
            : base(options)
        {
        }

        public DbSet<EmartApplication.Models.Buyer> Buyer { get; set; }
    }
