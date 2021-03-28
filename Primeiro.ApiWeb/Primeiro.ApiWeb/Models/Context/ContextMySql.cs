using Microsoft.EntityFrameworkCore;

namespace Primeiro.ApiWeb.Models.Context
{
    public class ContextMySql : DbContext
    {
        public ContextMySql()
        {

        }

        public ContextMySql(DbContextOptions<ContextMySql> options) : base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Books> Books { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
