using BasketCalculatorConsole.Models;

namespace BasketCalculatorConsole.Helpers
{
  public static class TaxHelper
  {
    private readonly static decimal ZeroRate = 0.0m;
    private readonly static decimal BasicRate = 10.0m;
    private readonly static decimal ImportRate = 5.0m;

    public static decimal CalculateTaxRate(string item)
    {
      var taxRate = 0.0m;
      bool isImported = item.ToLower().Contains("imported");
      bool isBook = item.ToLower().Contains("book");
      bool isMedication = item.ToLower().Contains("paracetamol");
      bool isFood = item.ToLower().Contains("chocolate");

      if (isBook || isMedication || isFood)
      {
        taxRate += ZeroRate;
      }
      else
      {
        taxRate += BasicRate;
      }

      if (isImported) taxRate += ImportRate;

      return taxRate;
    }
  }
}