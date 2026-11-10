using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProductSupImgEntityTypeConfiguration : IEntityTypeConfiguration<ProductSupImg>
{
    public void Configure(EntityTypeBuilder<ProductSupImg> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.SupImg)
            .IsRequired()
            .HasMaxLength(500);

        builder.HasOne(e => e.Product)
            .WithMany()
            .HasForeignKey(e => e.ProductId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
