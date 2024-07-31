namespace ResultPatternExample.Results;

internal record Error(string Message)
{
    public override string ToString() => Message;
}
