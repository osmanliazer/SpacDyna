using Microsoft.EntityFrameworkCore;
using SpacDyna.Models;

namespace SpacDyna.DAL
{
    public class SpacContext:DbContext
    {
        public SpacContext(DbContextOptions<SpacContext> options):base(options) { }
        public DbSet<Category> Categories { get; set; }
      
    }
}
