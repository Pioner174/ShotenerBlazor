using Microsoft.EntityFrameworkCore;
using ShotenerBlazor.Data.Models;

namespace ShotenerBlazor.Data
{
    public class ShotenerDataContext: DbContext
    {
        public ShotenerDataContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<ShortUrl> ShortUrls { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
