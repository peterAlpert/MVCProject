using Microsoft.EntityFrameworkCore;

namespace MVCProject.Models
{
    public class Context :DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Car> Car { get; set; }

        public DbSet<Category> Category { get; set; }
        public DbSet<Client> Client { get; set; }

        public DbSet<Purchase> Purchase { get; set; }


        public Context() : base()
        {
            
        }

        public Context(DbContextOptions options) : base(options)
        {
            
        }

    }
}
