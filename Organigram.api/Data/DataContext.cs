using Microsoft.EntityFrameworkCore;
using Organigram.api.Models;

namespace Organigram.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OrgObject> Objects { get; set; }
    }
}