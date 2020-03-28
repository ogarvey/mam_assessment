using System.Collections.Generic;

namespace BasketCalculatorConsole.Models
{
  public class Receipt
  {
    public List<string> BasketItems { get; set; }
    public decimal Taxes { get; set; }
    public decimal Total { get; set; }
  }
}