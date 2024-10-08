namespace ConsoleApp1;

public record KilogramQuantity(decimal Kilograms) : IQuantity
{
    public decimal GetPriceForQuantity(decimal pricePerUnit)
    {
        return Kilograms * pricePerUnit;
    }
}