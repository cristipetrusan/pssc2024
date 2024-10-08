namespace ConsoleApp1;

public class ShoppingCart
{
    private readonly List<Product> _products = new();

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void RemoveProduct(string productName)
    {
        _products.RemoveAll(p => p.Name == productName);
    }

    public void DisplayCart()
    {
        if (_products.Count == 0)
        {
            Console.WriteLine("Cosul de cumpărături este gol.");
        }
        else
        {
            Console.WriteLine("Produsele din cos:");
            foreach (var product in _products)
                Console.WriteLine(
                    $"- {product.Name}, Cantitate: {product.Quantity}, Pret unitar: {product.PricePerUnit:C}");
            Console.WriteLine($"Pret total: {GetTotalPrice():C}");
        }
    }

    public decimal GetTotalPrice()
    {
        decimal total = 0;
        foreach (var product in _products) total += product.Quantity.GetPriceForQuantity(product.PricePerUnit);
        return total;
    }
}