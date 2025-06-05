using BCDemoApplicationVer1.Models;
using Microsoft.EntityFrameworkCore;

namespace BCDemoApplicationVer1.DbContexts
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = PersonInfo.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
