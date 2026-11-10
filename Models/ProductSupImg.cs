
public class ProductSupImg
{
    public int Id { get; set; }
    public string SupImg { get; set; } = string.Empty;
    public int ProductId { get; set; }
    public Product? Product { get; set; }
}
