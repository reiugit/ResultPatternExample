namespace ResultPatternExample.Extensions;

internal static class GlobalPrintExtensions
{
    public static T Print<T>(this T value)
    {
        Console.WriteLine(value);

        return value;
    }
}
