using System;
using BasketCalculatorConsole.Helpers;

namespace BasketCalculatorConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello and welcome, to Basket Calculator!");
      Console.WriteLine("Please see below for your basket data");

      var basket = MockData.GetReceiptData(1);
      Console.WriteLine("Your first basket contained:");
      basket.ForEach(item => Console.WriteLine($"{item.Count} {item.Name} at {item.Price}"));
    }
  }
}
