using Domain.Primitives;

namespace Domain.Users
{
    public sealed class User : Entity
    {
        public User(Guid id, Name name, string email, string password) 
            : base(id)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public Name Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
