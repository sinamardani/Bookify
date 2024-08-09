namespace Bookify.Core.Domain.Common.Interface;

public interface IBaseEntity<TVariable>
{
    TVariable Id { get; set; }
    IReadOnlyList<IDomainEvent> GetDomainEvents();
    void ClearDomainEvents();
    //void RaiseDomainEvent(IDomainEvent domainEvent);
}