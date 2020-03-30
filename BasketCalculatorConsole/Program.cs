using System;
using BasketCalculatorConsole.Helpers;
using BasketCalculatorConsole.Models;

namespace BasketCalculatorConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello and welcome, to Basket Calculator!");
      Console.WriteLine("Please see below for your basket data");
      Console.WriteLine();

      for (int i = 1; i < 4; i++)
      {
        DisplayBasketData(i);
      }

      Console.ReadKey();
    }

    static void DisplayBasketData(int basketId)
    {
      var basket = MockData.GetBasketData(basketId);

      Console.WriteLine($"Basket {basketId} contained:");

      basket.ForEach(
        item => Console.WriteLine($"{item.Count} {item.Name} at {item.Price}")
      );

      Console.WriteLine();
      Console.WriteLine("Here is your receipt for the above basket:");

      var receipt = new Receipt() { BasketItems = basket };
      receipt.BasketItems.ForEach(
        item => Console.WriteLine($"{item.Count} {item.Name} at {item.PriceWithTax}")
      );

      Console.WriteLine($"Sales Taxes: {receipt.Taxes}");
      Console.WriteLine($"Total: {receipt.Total}");
      Console.WriteLine();
    }
  }
}
