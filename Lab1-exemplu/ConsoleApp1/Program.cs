using System;
using System.Collections.Generic;
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        var cart = new ShoppingCart();
        string option;
        
        do
        {
            Console.WriteLine("\nMeniu:");
            Console.WriteLine("1. Adauga produs în cos");
            Console.WriteLine("2. Elimina produs din cos");
            Console.WriteLine("3. Afiseaza cosul de cumparaturi");
            Console.WriteLine("4. Iesire");
            Console.Write("Selectează o optiune: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddProductToCart(cart);
                    break;
                case "2":
                    RemoveProductFromCart(cart);
                    break;
                case "3":
                    cart.DisplayCart();
                    break;
                case "4":
                    Console.WriteLine("La revedere!");
                    break;
                default:
                    Console.WriteLine("Opțiune invalidă!");
                    break;
            }
        } while (option != "4");
    }

    static void AddProductToCart(ShoppingCart cart)
    {
        Console.Write("Introdu numele produsului: ");
        string name = Console.ReadLine();

        Console.Write("Introdu prețul unitar al produsului: ");
        decimal price = decimal.Parse(Console.ReadLine());

        Console.Write("Produsul se vinde pe unitate sau kilogram? (u/k): ");
        string type = Console.ReadLine();
        
        IQuantity quantity = type.ToLower() switch
        {
            "u" => GetUnitQuantityFromUser(),
            "k" => GetKilogramQuantityFromUser(),
            _ => null
        };
    
        if (quantity == null)
        {
            Console.WriteLine("Tip invalid.");
            return;
        }

        cart.AddProduct(new Product(name, price, quantity));
        Console.WriteLine("Produsul a fost adăugat în coș.");
    }

    static void RemoveProductFromCart(ShoppingCart cart)
    {
        Console.Write("Introdu numele produsului care dorești să-l elimini: ");
        string name = Console.ReadLine();
        cart.RemoveProduct(name);
        Console.WriteLine("Produsul a fost eliminat din coș.");
    }
    static UnitQuantity GetUnitQuantityFromUser()
    {
        Console.Write("Introdu numărul de unități: ");
        int units = int.Parse(Console.ReadLine());
        return new UnitQuantity(units);
    }

    static KilogramQuantity GetKilogramQuantityFromUser()
    {
        Console.Write("Introdu numărul de kilograme: ");
        decimal kilograms = decimal.Parse(Console.ReadLine());
        return new KilogramQuantity(kilograms);
    }
}