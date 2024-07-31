# Result-Pattern Example

<pre>
    public TResult Match<TResult>(
        Func<TValue, TResult> success,
        Func<Error, TResult> failure)
    {
        return _isSuccess
            ? success(_value!)
            : failure(_error);
    }

</pre>


* Implicit Result-Generation:
<pre>
  public static implicit operator Result<TValue>(TValue value) => new(value);
  public static implicit operator Result<TValue>(Error error) => new(error);
</pre>
