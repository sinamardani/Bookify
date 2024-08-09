namespace Bookify.Core.Domain.Common.Shared;

public sealed record CurrencyValueObjet
{
    internal static readonly CurrencyValueObjet None = new("");
    public static readonly CurrencyValueObjet Usd = new("USD");
    public static readonly CurrencyValueObjet Eur = new("EUR");
    public string Code { get; init; }

    private CurrencyValueObjet(string code) => Code = code;


    public static CurrencyValueObjet FromCode(string code)
    {
        return All.FirstOrDefault(c => c.Code == code) ??
               throw new ApplicationException("The currency code is invalid");
    }

    public static readonly IReadOnlyCollection<CurrencyValueObjet> All = new[]
    {
        Usd,
        Eur
    };
}