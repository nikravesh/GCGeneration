namespace GarbageCollector.Endpoint.Utils;
public class MemoryPrinter
{
    public static void PrintGenerations(params object[] objects)
    {
        for (int i = 0; i < objects.Length; i++)
        {
            Console.WriteLine($"Object {i + 1} is in generation: {GC.GetGeneration(objects[i])}");
        }
    }

    public static void PrintCollectionCounts()
    {
        Console.WriteLine("GC Collection Counts:");
        for (int i = 0; i <= GC.MaxGeneration; i++)
        {
            Console.WriteLine($"Generation {i}: {GC.CollectionCount(i)} collections");
        }
    }
}
