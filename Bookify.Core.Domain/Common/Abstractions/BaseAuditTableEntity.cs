using Bookify.Core.Domain.Common.Interface;

namespace Bookify.Core.Domain.Common.Abstractions;

public abstract class BaseAuditTableEntity<T> : BaseEntity<T>, IBaseAuditTable<T>
{
    protected BaseAuditTableEntity(T id) : base(id)
    {
    }
    public DateTime CreatedDate { get; set; }
    public T CreatedBy { get; set; }
    public DateTime? EditedDate { get; set; }
    public T? EditedBy { get; set; }
    public DateTime? DeletedDate { get; set; }
    public T? DeletedBy { get; set; }
    public bool IsDeleted { get; set; }

}