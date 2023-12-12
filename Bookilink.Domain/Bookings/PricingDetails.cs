using Bookilink.Domain.Apartments;

namespace Bookilink.Domain.Bookings;

public record PricingDetails(Money PriceForPeriod, Money CleaningFee, Money AmenitiesUpcharge, Money TotalPrice);