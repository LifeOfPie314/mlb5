using System.Data.Entity;
using Mlb5.Models;

namespace Mlb5
{
    public class PrototypeContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}