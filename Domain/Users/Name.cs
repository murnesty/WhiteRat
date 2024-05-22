using Domain.Primitives;

namespace Domain.Users;

public sealed class Name : ValueObject
{
    public const int MaxLength = 50;

    private Name(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public static Name Create(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException(nameof(name));
        }

        if (name.Length > MaxLength)
        {
            throw new ArgumentOutOfRangeException($"Name too long, greater than {MaxLength}.");
        }

        return new Name(name);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
