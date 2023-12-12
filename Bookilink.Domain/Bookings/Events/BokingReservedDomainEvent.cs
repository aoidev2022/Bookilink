using Bookilink.Domain.Abstractions;

namespace Bookilink.Domain.Bookings.Events;

public sealed record BokingReservedDomainEvent(Guid BookingId) : IDomainEvent;
public sealed record BookingConfirmedDomainEvent(Guid BookingId) : IDomainEvent;
public sealed record BookingRejectedDomainEvent(Guid BookingId) : IDomainEvent;
public sealed record BookingCancelledDomainEvent(Guid BookingId) : IDomainEvent;