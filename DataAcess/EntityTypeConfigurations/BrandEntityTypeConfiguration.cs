using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class BrandEntityTypeConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder
            .HasKey(e => e.Id);

        builder
            .Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder
            .Property(e => e.Status)
            .HasDefaultValue(true);

        builder
            .Property(e => e.Logo)
            .HasMaxLength(500);
    }
}
