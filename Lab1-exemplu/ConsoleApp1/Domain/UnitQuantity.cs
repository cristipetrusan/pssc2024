namespace ConsoleApp1;

public record UnitQuantity(int Units) : IQuantity
{
    public decimal GetPriceForQuantity(decimal pricePerUnit) => Units * pricePerUnit;
}
