namespace ResultPatternExample.Extensions;

internal static class PrintExtensions
{
    public static Divider PrintNumbers(this Divider divider)
    {
        Console.WriteLine($"\nDivision: {divider.Dividend} / {divider.Divisor}");

        return divider;
    }

    public static T Print<T>(this T value)
    {
        Console.WriteLine(value);

        return value;
    }
}
