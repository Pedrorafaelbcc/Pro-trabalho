using Microsoft.EntityFrameworkCore;
using bcc.Models;

namespace bcc.Data
{
    public class BccContext : DbContext
    {
        public BccContext (DbContextOptions<BccContext>options) : base(options)
        {
        }
        public DbSet<Movie> Movie {get; set;}
    }
}
