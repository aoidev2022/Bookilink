﻿using Bookilink.Domain.Abstractions;

namespace Bookilink.Domain.Apartments;

public sealed class Apartment : Entity
{
    public Apartment(Guid id, Name name, Description description, Money price, Money cleaningFee, DateTime? lastBookedOnUtc, List<Amenity> amenities) : base(id)
    {
        Name = name;
        Description = description;
        Price = price;
        CleaningFee = cleaningFee;
        LastBookedOnUtc = lastBookedOnUtc;
        Amenities = amenities;
    }

    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public Money Price { get; private set; }
    public Money CleaningFee { get; private set; }
    public DateTime? LastBookedOnUtc { get; private set; }
    public List<Amenity> Amenities { get; private set; } = new();
}
