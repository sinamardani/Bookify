namespace Bookify.Core.Domain.Common.ValueObjects.Apartment;

public sealed record AddressValueObject(
    string Country,
    string State,
    string ZipCode,
    string City,
    string Street);