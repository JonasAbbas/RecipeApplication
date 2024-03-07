using Microsoft.EntityFrameworkCore;
using RecipeApplication.Shared.Models;
using System.Security.Cryptography;

namespace RecipeApplication.Server.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Favorites> Favorites { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)

        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Favorites>().HasKey(favorite => favorite.IdDBMeal);
        }
    }
}
