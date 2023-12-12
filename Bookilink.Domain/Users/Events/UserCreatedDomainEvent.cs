using Bookilink.Domain.Abstractions;

namespace Bookilink.Domain.Users.Events;

public record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;
