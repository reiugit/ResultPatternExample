namespace ResultPatternExample.Results;

internal class Errors
{
    public static Error None => new(string.Empty);

    public static Error DivisionByZero => new("Cannot divide by zero");
}
