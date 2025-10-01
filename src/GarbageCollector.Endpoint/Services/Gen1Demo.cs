using GarbageCollector.Endpoint.Utils;

namespace GarbageCollector.Endpoint.Services;
public class Gen1Demo
{
    public void Run()
    {
        Console.WriteLine("-- Generation 1 Demo --");

        var arr = new byte[10000];
        MemoryPrinter.PrintGenerations(arr);

        GC.Collect(1, GCCollectionMode.Forced);
        GC.WaitForPendingFinalizers();

        MemoryPrinter.PrintGenerations(arr);
        MemoryPrinter.PrintCollectionCounts();
        Console.WriteLine();
    }
}
