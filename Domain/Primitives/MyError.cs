namespace Domain.Primitives;

public sealed record MyError(string Code, string? Message = null)
{
    public static readonly MyError None = new MyError(string.Empty);

#pragma warning disable S125 // Sections of code should not be commented out
    //public static implicit operator Result(Error error) => Result.Failure(error);
#pragma warning restore S125 // Sections of code should not be commented out
}
