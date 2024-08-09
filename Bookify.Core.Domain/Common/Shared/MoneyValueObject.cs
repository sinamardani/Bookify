using Bookify.Core.Domain.Common.Abstractions;

namespace Bookify.Core.Domain.Common.Shared;

public sealed record MoneyValueObject(decimal Amount, CurrencyValueObjet Currency)
{
    public static MoneyValueObject operator +(MoneyValueObject first, MoneyValueObject second)
    {
        if (first.Currency != second.Currency)
        {
            throw new InvalidOperationException("Currencies have to be equal");
        }

        return new MoneyValueObject(first.Amount + second.Amount, first.Currency);
    }

    public static MoneyValueObject Zero() => new(0, CurrencyValueObjet.None);

    public static MoneyValueObject Zero(CurrencyValueObjet currency) => new(0, currency);

    public bool IsZero() => this == Zero(Currency);
}