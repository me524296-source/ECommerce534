
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Discrption { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
    public int Traffic { get; set; }
    public int Quantity { get; set; }
    public string MainImage { get; set; } = string.Empty;
    public double Rating { get; set; }
    public bool Status { get; set; } = true;
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public int BrandId { get; set; }
    public Brand? Brand { get; set; }

}
