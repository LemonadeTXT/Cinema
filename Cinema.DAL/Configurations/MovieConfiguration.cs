using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.DAL.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<MovieEntity>
    {
        public void Configure(EntityTypeBuilder<MovieEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(m => m.Title)
                .IsRequired();

            builder.Property(m => m.Description)
                .IsRequired();

            builder.Property(m => m.AgeRating)
                .IsRequired();

            builder.Property(m => m.FreeSeats)
                .IsRequired();

            builder.Property(m => m.Session)
                .IsRequired();
        }
    }
}
