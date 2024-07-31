namespace ResultPatternExample.Results;

internal class Result<TValue>
{
    private readonly bool _isSuccess;
    private readonly TValue? _value;
    private readonly Error _error = Errors.None;

    private Result(TValue value)
    {
        _isSuccess = true;
        _value = value;
    }

    private Result(Error error)
    {
        _isSuccess = false;
        _error = error;
    }

    public TResult Match<TResult>(
        Func<TValue, TResult> success,
        Func<Error, TResult> failure)
    {
        return _isSuccess
            ? success(_value!)
            : failure(_error);
    }

    public static implicit operator Result<TValue>(TValue value) => new(value);
    public static implicit operator Result<TValue>(Error error) => new(error);
}
