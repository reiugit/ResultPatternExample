# Result-Pattern Example


* Implicit Result-Generation:
<pre>
  public static implicit operator Result<TValue>(TValue value) => new(value);
  public static implicit operator Result<TValue>(Error error) => new(error);
</pre>
