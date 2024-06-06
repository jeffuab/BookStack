using BookStack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStack.Infrastructure.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(t => t.Title)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(t => t.Author)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(t => t.Genre)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(t => t.PublishDate)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(t => t.PageCount)
                .IsRequired();
        }
    }
}