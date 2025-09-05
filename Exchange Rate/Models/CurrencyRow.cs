
namespace Exchange_Rate.Models;

public sealed class CurrencyRow
{
    public required string Code { get; init; }
    public required string Name { get; init; }
    public string? Flag { get; init; }

    public double Rate { get; set; } // 1 BaseCurrency = Rate * Code
    public double ConvertedAmount(double baseAmount) => Rate * baseAmount;
}
