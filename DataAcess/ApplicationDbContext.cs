

public class ApplicationDbContext : DbContext
{
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductSupImg> ProductSupImgs { get; set; }
    public DbSet<ProductColor> ProductColors { get; set; }

    override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ECommerce534;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.ApplyConfiguration(new BrandEntityTypeConfiguration());
        //modelBuilder.ApplyConfiguration(new CategoryEntityTypeConfiguration());
        //modelBuilder.ApplyConfiguration(new ProductEntityTypeConfiguration());
        //modelBuilder.ApplyConfiguration(new ProductSupImgEntityTypeConfiguration());
        //modelBuilder.ApplyConfiguration(new ProductColorEntityTypeConfiguration());

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductEntityTypeConfiguration).Assembly);
    }
}
