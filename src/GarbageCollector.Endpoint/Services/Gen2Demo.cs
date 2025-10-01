using GarbageCollector.Endpoint.Utils;

namespace GarbageCollector.Endpoint.Services;
public class Gen2Demo
{
    public void Run()
    {
        Console.WriteLine("-- Generation 2 Demo --");

        var obj = new object();
        var arr = new byte[50000];

        MemoryPrinter.PrintGenerations(obj, arr);

        GC.Collect(2, GCCollectionMode.Forced);
        GC.WaitForPendingFinalizers();

        MemoryPrinter.PrintGenerations(obj, arr);
        MemoryPrinter.PrintCollectionCounts();
        Console.WriteLine();
    }
}
