namespace Rendimentos.Api.Common;

public struct ErrorOr<T>
    where T : class?
{
    public string? ErrorMessage { get; set; }
    public T? Value { get; set; }

    public readonly bool HasError => ErrorMessage is not null;
    public readonly bool HasValue => Value is not null;

    public ErrorOr() { }
    public ErrorOr(T success) => Value = success;
    public ErrorOr(string error) => ErrorMessage = error;

    public readonly TResult Match<TResult>(Func<T, TResult> onSuccess, Func<string, TResult> onError)
    {
        if (HasError)
        {
            return onError(ErrorMessage!);
        }

        return onSuccess(Value!);
    }

    public static implicit operator ErrorOr<T>(T success)
    {
        return new ErrorOr<T>(success);
    }

    public static implicit operator ErrorOr<T>(string error)
    {
        return new ErrorOr<T>(error);
    }
}
