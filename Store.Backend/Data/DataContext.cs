using Microsoft.EntityFrameworkCore;
using Store.Shared.Entities;

namespace Store.Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Rol>? roles { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Country>? Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Rol>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Country>().HasIndex(y => y.Name).IsUnique();
            modelBuilder.Entity<User>().HasIndex(z => z.Email).IsUnique();
            DisableCascadingDelete(modelBuilder);
        }

        private void DisableCascadingDelete(ModelBuilder modelBuilder)
        {
            var relations = modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys());
            foreach (var relation in relations)
            {
                relation.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}