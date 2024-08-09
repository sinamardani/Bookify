using Bookify.Core.Domain.Common.Abstractions;
using Bookify.Core.Domain.Common.Shared;
using Bookify.Core.Domain.Common.ValueObjects.Apartment;
using Bookify.Core.Domain.Enums;

namespace Bookify.Core.Domain.Entities;

public sealed class Apartment : BaseEntity<Guid>
{
    public Apartment(Guid id,
        NameValueObject name,
        DescriptionValueObject description,
        AddressValueObject address,
        MoneyValueObject price,
        MoneyValueObject cleaningFee,
        DateTime? lastBookOnUtc, List<Amenity> amenities)
            : base(id)
    {
        Name = name;
        Description = description;
        Address = address;
        Price = price;
        CleaningFee = cleaningFee;
        LastBookOnUtc = lastBookOnUtc;
        Amenities = amenities;
    }
    public NameValueObject Name { get; set; }
    public DescriptionValueObject Description { get; private set; }
    public AddressValueObject Address { get; private set; }
    public MoneyValueObject Price { get; private set; }
    public MoneyValueObject CleaningFee { get; private set; }
    public DateTime? LastBookOnUtc { get; private set; }
    public List<Amenity> Amenities { get; private set; } = new();
}