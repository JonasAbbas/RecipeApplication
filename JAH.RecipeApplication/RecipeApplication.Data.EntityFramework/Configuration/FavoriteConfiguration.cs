using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeApplication.Shared.Models;

namespace RecipeApplication.Server.Data.Configuration
{
    public class FavoriteConfiguration : IEntityTypeConfiguration<Favorites>
    {
        public void Configure(EntityTypeBuilder<Favorites> builder)
        {
            builder.HasKey(favorite =>  favorite.IdDBMeal);

            builder.Property(favorite => favorite.IdMeal)
                .IsRequired();

            builder.Property(favorite => favorite.StrMeal) 
                .IsRequired();

            builder.Property(favorite => favorite.StrArea)
                .IsRequired();

            builder.Property(favorite => favorite.StrCategory)
                .IsRequired();

            builder.Property(favorite => favorite.StrInstructions)
                .IsRequired();
        }
    }
}
