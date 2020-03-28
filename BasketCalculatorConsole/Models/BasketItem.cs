namespace BasketCalculatorConsole.Models
{
  public class BasketItem
  {
    public int Count { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal PriceWithTax
    {
      get { return 0.0m; }
    }

  }
}