using Microsoft.EntityFrameworkCore;
using APIDemo2023.Models;

namespace APIDemo2023.Models
{
    public class DemoContext:DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options) 
        {

        }

        //DBSet
        public DbSet<Person> People { get; set; }

        //DBSet
        public DbSet<Category> Category { get; set; }

        //DBSet
        public DbSet<Product> Product { get; set; }
    }
}
