namespace Bookify.Core.Domain.Common.Interface;

public interface IBaseEntity<TVariable>
{
    TVariable Id { get; set; }
}