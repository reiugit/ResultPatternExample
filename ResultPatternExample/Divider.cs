using ResultPatternExample.Results;

namespace ResultPatternExample;

internal class Divider
{
    private Divider(double dividend, double divisor)
    {
        Dividend = dividend;
        Divisor = divisor;
    }

    public double Dividend { get; }
    public double Divisor { get; }

    public static Divider Create(double dividend, double divisor)
        => new(dividend, divisor);

    public Result<double> Divide() =>
        Divisor != 0
        ? Dividend / Divisor
        : Errors.DivisionByZero;
}
