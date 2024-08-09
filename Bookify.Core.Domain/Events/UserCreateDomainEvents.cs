using Bookify.Core.Domain.Common.Interface;

namespace Bookify.Core.Domain.Events;

public sealed record UserCreateDomainEvents(Guid UserId) : IDomainEvent;