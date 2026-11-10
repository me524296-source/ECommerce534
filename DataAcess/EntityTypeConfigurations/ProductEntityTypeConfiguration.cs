using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(e => e.Discrption)
            .HasMaxLength(2000);

        builder.Property(e => e.Price)
            .HasColumnType("decimal(10, 2)")
            .IsRequired();

        builder.Property(e => e.Discount)
            .HasColumnType("decimal(10, 2)")
            .HasDefaultValue(0);

        builder.Property(e => e.Traffic)
            .HasDefaultValue(0);

        builder.Property(e => e.Quantity)
            .HasDefaultValue(0);

        builder.Property(e => e.MainImage)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(e => e.Rating)
            .HasDefaultValue(0.0);

        builder.Property(e => e.Status)
            .HasDefaultValue(true);

        // Foreign Key: Category
        builder.HasOne(e => e.Category)
            .WithMany()
            .HasForeignKey(e => e.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        // Foreign Key: Brand
        builder.HasOne(e => e.Brand)
            .WithMany()
            .HasForeignKey(e => e.BrandId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
