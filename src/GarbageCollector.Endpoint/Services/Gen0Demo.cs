using GarbageCollector.Endpoint.Utils;

namespace GarbageCollector.Endpoint.Services;
public class Gen0Demo
{
    public void Run()
    {
        Console.WriteLine("-- Generation 0 Demo --");

        var obj1 = new object();
        var obj2 = new object();

        MemoryPrinter.PrintGenerations(obj1, obj2);

        GC.Collect(0, GCCollectionMode.Forced);
        GC.WaitForPendingFinalizers();

        MemoryPrinter.PrintGenerations(obj1, obj2);
        MemoryPrinter.PrintCollectionCounts();
        Console.WriteLine();
    }
}
