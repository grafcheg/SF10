namespace SF10;

public interface ILogger
{
    public void Error(string message);
    public void Event(string message);
}