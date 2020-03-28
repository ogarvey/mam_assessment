using System.Collections.Generic;
using BasketCalculatorConsole.Models;

namespace BasketCalculatorConsole.Helpers
{
  public static class MockData
  {
    private static List<BasketItem> MockBasket1 = new List<BasketItem>(){
        new BasketItem() {Count = 1, Name = "Book", Price = 12.49m },
        new BasketItem() {Count = 1, Name = "Music CD", Price = 14.99m },
        new BasketItem() {Count = 1, Name = "Chocolate bar", Price = 0.85m }
    };
    private static List<BasketItem> MockBasket2 = new List<BasketItem>(){
        new BasketItem() {Count = 1, Name = "Imported box of chocolates", Price = 10.00m },
        new BasketItem() {Count = 1, Name = "Imported bottle of perfume", Price = 47.50m }
    };
    private static List<BasketItem> MockBasket3 = new List<BasketItem>(){
        new BasketItem() {Count = 1, Name = "Imported bottle of perfume", Price = 27.99m },
        new BasketItem() {Count = 1, Name = "Bottle of perfume", Price = 18.99m },
        new BasketItem() {Count = 1, Name = "Packet of paracetamol", Price = 9.75m },
        new BasketItem() {Count = 1, Name = "Box of imported chocolates", Price = 11.25m }
    };

    public static List<BasketItem> GetBasketData(int basketId)
    {
      switch (basketId)
      {
        case 1:
          return MockBasket1;
        case 2:
          return MockBasket2;
        case 3:
          return MockBasket3;
        default:
          return MockBasket1;
      }
    }
  }
}