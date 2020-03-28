using System.Collections.Generic;

namespace BasketCalculatorConsole.Models
{
  public class Receipt
  {
    public List<BasketItem> BasketItems { get; set; }
    public decimal Taxes
    {
      get
      {
        var total = 0.0m;
        BasketItems.ForEach(item => total += (item.PriceWithTax - item.Price));
        return total;
      }
    }
    public decimal Total
    {
      get
      {
        var total = 0.0m;
        BasketItems.ForEach(item => total += item.PriceWithTax);
        return total;
      }
    }
  }
}