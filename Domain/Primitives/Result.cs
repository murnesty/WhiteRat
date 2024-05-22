namespace Domain.Primitives;

public class Result
{
    private Result(bool isSuccess, MyError error)
    {
        if (isSuccess && error != MyError.None ||
            !isSuccess && error == MyError.None)
        {
            throw new ArgumentException("Invalid error", nameof(error));
        }

        IsSuccess = isSuccess;
        Error = error;
    }

    public bool IsSuccess { get; }

    public bool IsFailure => !IsSuccess;

    public MyError Error { get; }

    public static Result Success() => new (true, MyError.None);

    public static Result Failure(MyError error) => new (false, error);
}
