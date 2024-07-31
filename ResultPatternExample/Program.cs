using ResultPatternExample;
using ResultPatternExample.Extensions;

// 1.) Create 'Result.Success'
Divider.Create(4, 2)
    .PrintNumbers()
    .Divide()
    .Match(
        value => $"Result: {value}",
        error => $"Error: '{error}'")
    .Print();

// 2. Create 'Result.Failure'
Divider.Create(5, 0)
    .PrintNumbers()
    .Divide()
    .Match(
        value => $"Result: {value}",
        error => $"Error: '{error}'")
    .Print();

Console.WriteLine("\n\nPress any key to exit...");
Console.ReadKey();
