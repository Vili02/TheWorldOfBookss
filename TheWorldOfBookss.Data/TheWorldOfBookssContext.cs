using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheWorldOfBookss.Data.Models;

namespace TheWorldOfBookss.Data
{
    public class TheWorldOfBookssContext : IdentityDbContext<User>
    {
        public TheWorldOfBookssContext(DbContextOptions<TheWorldOfBookssContext> options) : base(options)
        {
        }

        public override DbSet<User> Users { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Genre> Genres { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}