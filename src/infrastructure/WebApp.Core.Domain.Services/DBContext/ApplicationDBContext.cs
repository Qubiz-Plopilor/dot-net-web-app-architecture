using Microsoft.EntityFrameworkCore;
using System;
using WebApp.Core.Domain.Entities;

namespace WebApp.Core.Domain.Services.DBContext
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
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb; database=BlogAppDB; trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Article>().ToTable("Article");
            modelBuilder.Entity<Comment>().ToTable("Comment");
            modelBuilder.Entity<Tag>().ToTable("Tag");
            modelBuilder.Entity<ArticleTag>().ToTable("ArticleTag");

            modelBuilder.Entity<User>()
                .HasOne(x => x.Account)
                .WithOne(x => x.User)
                .HasForeignKey<Account>(x => x.UserID);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Articles)
                .WithOne(x => x.User);
            modelBuilder.Entity<Article>()
                .HasOne(x => x.User)
                .WithMany(x => x.Articles);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Comments)
                .WithOne(x => x.User);
            modelBuilder.Entity<Comment>()
                .HasOne(x => x.User)
                .WithMany(x => x.Comments);

            modelBuilder.Entity<Article>()
                .HasMany(x => x.Comments)
                .WithOne(x => x.Article);
            modelBuilder.Entity<Comment>()
                .HasOne(x => x.Article)
                .WithMany(x => x.Comments);

            modelBuilder.Entity<ArticleTag>()
                .HasKey(x => new { x.ArticleID, x.TagID });
            modelBuilder.Entity<ArticleTag>()
                .HasOne(x => x.Article)
                .WithMany(x => x.ArticleTags)
                .HasForeignKey(x => x.ArticleID);
            modelBuilder.Entity<ArticleTag>()
                .HasOne(x => x.Tag)
                .WithMany(x => x.ArticleTags)
                .HasForeignKey(x => x.TagID);


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
