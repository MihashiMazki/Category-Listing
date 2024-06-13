using learning.Models;
using Microsoft.EntityFrameworkCore;

namespace learning.Data
{
	public class ApplucationDbContext : DbContext
	{
        public ApplucationDbContext(DbContextOptions<ApplucationDbContext> options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
