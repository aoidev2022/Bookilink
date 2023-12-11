namespace Bookilink.Domain.Apartments;

public class Currency
{
    public static readonly Currency None = new("");
    public static readonly Currency Usd = new("USD");
    public static readonly Currency Eur = new("USD");

    public string Code { get; init; }

    private Currency(string code) => Code = code;

    public static Currency FromCode(string code) => All.SingleOrDefault(q => q.Code == code) ?? throw new Exception("The currency code is invalid");

    public static IReadOnlyCollection<Currency> All = new[] { Usd, Eur };
}
