using Bookilink.Domain.Abstractions;
using Bookilink.Domain.Users.Events;

namespace Bookilink.Domain.Users;

public sealed class User : Entity
{
    public FirstName FirstName { get; set; }
    public LastName LastName { get; set; }
    public Email Email { get; set; }

    private User(Guid id, FirstName firstName, LastName lastName, Email email) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public User Create(FirstName firstName, LastName lastName, Email email)
    {
        var user = new User(Guid.NewGuid(), firstName, lastName, email);

        user.RaiseDomainEvents(new UserCreatedDomainEvent(user.Id));

        return user;
    }
}