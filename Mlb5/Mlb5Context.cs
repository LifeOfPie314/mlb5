using System.Data.Entity;
using Mlb5.Models;

namespace Mlb5
{
    public class Mlb5Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}