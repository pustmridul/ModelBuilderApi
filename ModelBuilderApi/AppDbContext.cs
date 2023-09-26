using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;
using System.Collections.Generic;

namespace ModelBuilderApi
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AgeRange> AgeRanges { get; set; }
    }
}
