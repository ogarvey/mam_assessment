using BasketCalculatorConsole.Helpers;

namespace BasketCalculatorConsole.Models
{
  public class BasketItem
  {
    public int Count { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal PriceWithTax
    {
      get
      {
        var rate = TaxHelper.CalculateTaxRate(Name);
        var tax = ((Price * rate) / 100.0m);
        // https://stackoverflow.com/a/4760145 - How to round to nearest 0.05
        tax = decimal.Ceiling((tax / 0.05m)) * 0.05m;
        return Price + tax;
      }
    }

  }
}