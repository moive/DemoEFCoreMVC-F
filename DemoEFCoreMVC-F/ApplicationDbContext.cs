using DemoEFCoreMVC_F.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoEFCoreMVC_F
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
