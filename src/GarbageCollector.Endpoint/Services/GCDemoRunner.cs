namespace GarbageCollector.Endpoint.Services;
public class GCDemoRunner
{
    public void RunAll()
    {
        Console.WriteLine("=== GC Generations Demo ===");
        Console.WriteLine($".NET Version: {Environment.Version}\n");

        new Gen0Demo().Run();
        new Gen1Demo().Run();
        new Gen2Demo().Run();

        Console.WriteLine("\n=== Demo Finished ===");
    }
}
