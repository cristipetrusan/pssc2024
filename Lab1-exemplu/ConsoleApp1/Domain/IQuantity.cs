namespace ConsoleApp1;

public interface IQuantity
{
    // Metodele definite in interfata trebuie implementate in clasele derivate (UnitQuantity/KilogramQuantity in cazul nostru)
    decimal GetPriceForQuantity(decimal pricePerUnit);
}