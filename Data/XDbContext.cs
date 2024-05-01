using Microsoft.EntityFrameworkCore;
using MrjSite.Model;

namespace MrjSite.Data
{
    public class XDbContext : DbContext
    {
        public XDbContext(DbContextOptions<XDbContext> options) : base(options)
        {
        }
        public DbSet<Message> Messages { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
