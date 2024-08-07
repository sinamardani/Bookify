using Bookify.Core.Domain.Common.Interface;

namespace Bookify.Core.Domain.Common.Abstractions;

public abstract class BaseEntity<T> : IBaseEntity<T>
{
    protected BaseEntity(T id)
    {
        Id = id;
    }

    public T Id { get; set; }
}