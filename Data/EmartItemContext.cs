using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmartApplication.Data
{
    public class EmartItemContext:DbContext

    {
        public EmartItemContext(DbContextOptions<EmartItemContext> options)
           : base(options)
        {
        }

        public DbSet<EmartApplication.Models.Item> Item { get; set; }
        public DbSet<EmartApplication.Models.SubCategory> SubCategory{ get; set; }

    }
}
