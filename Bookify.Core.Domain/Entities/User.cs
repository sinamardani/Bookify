using Bookify.Core.Domain.Common.Abstractions;
using Bookify.Core.Domain.Common.ValueObjects.User;
using Bookify.Core.Domain.Events;

namespace Bookify.Core.Domain.Entities;

public sealed class User : BaseEntity<Guid>
{
    private User(Guid id, FirstName firstName, LastName lastName, Email email) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public FirstName FirstName { get; private set; }
    public LastName LastName { get; private set; }
    public Email Email { get; private set; }

    public static User Create(FirstName firstName, LastName lastName, Email email)
    {
        var user = new User(Guid.NewGuid(), firstName, lastName, email);
        user.RaiseDomainEvent(new UserCreateDomainEvents(user.Id));
        return user;
    }

}