namespace SF10;

public class SimpleCalculator : IAddition
{
    ILogger Logger { get; }

    public SimpleCalculator(ILogger logger)
    {
        Logger = logger;
    }
    
    public long Add(long a, long b)
    {
        Logger.Event("Считаем...");
        return a + b;
    }
}