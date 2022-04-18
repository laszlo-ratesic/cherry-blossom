using System.Diagnostics;
namespace cherry_blossom.DependencyInjection;
public class ConsoleWriter : IConsoleWriter
{
    public void Write()
    {
        Debug.WriteLine("Testing Dependency Injection...");
    }
}

