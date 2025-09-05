// Models/CurrencyInfo.cs
namespace Exchange_Rate.Models;

public sealed class CurrencyInfo
{
    public required string Code { get; init; }   // ex: "USD"
    public required string Name { get; init; }   // ex: "US Dollar"
    public string? Flag { get; init; }           // flag image path
}
