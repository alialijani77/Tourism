using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Context
{
    public class GardeshgariDbContext : DbContext
    {
        public GardeshgariDbContext(DbContextOptions<GardeshgariDbContext> options) : base(options)
        {
        }

        public DbSet<Pages> pages { get; set; }

        public DbSet<PageGroup> pageGroups { get; set; }
    }
}
