namespace Bookify.Core.Domain.Common.Interface;

public interface IBaseAuditTable<TVariable>
{
    DateTime CreatedDate { get; set; }
    TVariable CreatedBy { get; set; }
    DateTime? EditedDate { get; set; }
    TVariable? EditedBy { get; set; }
    DateTime? DeletedDate { get; set; }
    TVariable? DeletedBy { get; set; }
    bool IsDeleted { get; set; }
}