using Serwis.Models;
using Microsoft.EntityFrameworkCore;

namespace Serwis.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options) { }
        public DbSet<Person> Person { get; set; }
       

    }

}
