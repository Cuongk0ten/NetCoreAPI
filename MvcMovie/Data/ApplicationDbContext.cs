using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class AppliticationDbcontex : DbContext
    {
        public AppliticationDbcontex(DbContextOptions<AppliticationDbcontex>options) : base(options)
        {}
        public DbSet<Person> Person {get; set;}
    }
}