# Result-Pattern Example

* Implicit Result-Generation:
<pre>
  public static implicit operator Result<TValue>(TValue value) => new(value);
  public static implicit operator Result<TValue>(Error error) => new(error);
</pre>

* 'Match' function for handling the result
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
