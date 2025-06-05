using BCDemoApplicationVer1.Models;
using Microsoft.EntityFrameworkCore;

namespace BCDemoApplicationVer1.DbContexts
{
    public class ShoppingItemContext : DbContext
    {
        public DbSet<ShoppingItem> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = ShoppingItemInfo.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
