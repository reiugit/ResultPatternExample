using ResultPatternExample.Results;

namespace ResultPatternExample;

internal class Divider
{
    private Divider(int dividend, int divisor)
    {
        Dividend = dividend;
        Divisor = divisor;
    }

    public int Dividend { get; }
    public int Divisor { get; }

    public static Divider Create(int dividend, int divisor)
        => new(dividend, divisor);

    public Result<int> Divide() =>
        Divisor != 0
        ? Dividend / Divisor
        : Errors.DivisionByZero;
}
