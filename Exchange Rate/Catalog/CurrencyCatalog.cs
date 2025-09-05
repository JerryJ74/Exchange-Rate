using Exchange_Rate.Models;

namespace Exchange_Rate.Catalog;

public static class CurrencyCatalog
{
    public static readonly IReadOnlyList<CurrencyInfo> All = new List<CurrencyInfo>
    {
        new() { Code="EUR", Name="Euro" },
        new() { Code="USD", Name="US Dollar" },
        new() { Code="JPY", Name="Japanese Yen" },
        new() { Code="BGN", Name="Bulgarian Lev" },
        new() { Code="CZK", Name="Czech Republic Koruna" },
        new() { Code="DKK", Name="Danish Krone" },
        new() { Code="GBP", Name="British Pound Sterling" },
        new() { Code="HUF", Name="Hungarian Forint" },
        new() { Code="PLN", Name="Polish Zloty" },
        new() { Code="RON", Name="Romanian Leu" },
        new() { Code="SEK", Name="Swedish Krona" },
        new() { Code="CHF", Name="Swiss Franc" },
        new() { Code="ISK", Name="Icelandic Króna" },
        new() { Code="NOK", Name="Norwegian Krone" },
        new() { Code="HRK", Name="Croatian Kuna" },
        new() { Code="RUB", Name="Russian Ruble" },
        new() { Code="TRY", Name="Turkish Lira" },
        new() { Code="AUD", Name="Australian Dollar" },
        new() { Code="BRL", Name="Brazilian Real" },
        new() { Code="CAD", Name="Canadian Dollar" },
        new() { Code="CNY", Name="Chinese Yuan" },
        new() { Code="HKD", Name="Hong Kong Dollar" },
        new() { Code="IDR", Name="Indonesian Rupiah" },
        new() { Code="ILS", Name="Israeli New Sheqel" },
        new() { Code="INR", Name="Indian Rupee" },
        new() { Code="KRW", Name="South Korean Won" },
        new() { Code="MXN", Name="Mexican Peso" },
        new() { Code="MYR", Name="Malaysian Ringgit" },
        new() { Code="NZD", Name="New Zealand Dollar" },
        new() { Code="PHP", Name="Philippine Peso" },
        new() { Code="SGD", Name="Singapore Dollar" },
        new() { Code="THB", Name="Thai Baht" },
        new() { Code="ZAR", Name="South African Rand" },
    };
}
