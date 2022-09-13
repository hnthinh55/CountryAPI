using CountryAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace CountryAPI.Data
{
    public class CountryContext: DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<CountryItem> CountryItems { get; set; } = null!;
    }
}
