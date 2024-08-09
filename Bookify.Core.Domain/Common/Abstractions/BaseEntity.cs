using Bookify.Core.Domain.Common.Interface;

namespace Bookify.Core.Domain.Common.Abstractions;

public abstract class BaseEntity<T> : IBaseEntity<T>
{
    protected BaseEntity(T id)
    {
        Id = id;
    }

    private readonly List<IDomainEvent> _domainEvents = new();
    public T Id { get; set; }
    public IReadOnlyList<IDomainEvent> GetDomainEvents()
    {
        return _domainEvents.ToList();
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    protected void RaiseDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}