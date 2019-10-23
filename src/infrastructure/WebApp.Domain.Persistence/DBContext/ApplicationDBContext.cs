using Microsoft.EntityFrameworkCore;
using System;

namespace WebApp.Domain.Persistence.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        private readonly Action<ModelBuilder> _modifyModel;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, Action<ModelBuilder> modifyModel = null)
        : base(options)
        {
            _modifyModel = modifyModel;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var foreignKey in entity.GetForeignKeys())
                {
                    foreignKey.DeleteBehavior = DeleteBehavior.NoAction;
                }
            }

            _modifyModel?.Invoke(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}
