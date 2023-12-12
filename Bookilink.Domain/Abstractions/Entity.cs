namespace Bookilink.Domain.Abstractions;

public abstract class Entity
{
    private readonly List<IDomainEvent> _domainEvents = new();

    public Guid Id { get; init; }

    protected Entity(Guid id)
    {
        Id = id;
    }

    public IReadOnlyCollection<IDomainEvent> DomainEvents() => _domainEvents;

    public void ClearDomainEvents() => _domainEvents.Clear();

    protected void RaiseDomainEvents(IDomainEvent domainEvent) => _domainEvents.Add(domainEvent);
}
