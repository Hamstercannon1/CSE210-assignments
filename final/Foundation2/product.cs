public class Product
{
    private string name;
    private string productId;
    private decimal pricePerUnit;
    private int quantity;

    public Product(string name, string productId, decimal pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public decimal TotalCost()
    {
        return pricePerUnit * quantity;
    }

    public override string ToString()
    {
        return $"{name} (ID: {productId})";
    }
}
