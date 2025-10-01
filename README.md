# .NET GC Generations Demo  

This project is a simple **C# .NET console application** that demonstrates how the **.NET Garbage Collector (GC)** works across different generations (Gen 0, Gen 1, Gen 2).  

It shows:  
- How objects are allocated in generations.  
- How objects get promoted when GC runs.  
- How to force garbage collection for a specific generation.  
- How to check GC collection counts.  

---

##  Project Structure  
```
GarbageCollector/
│
├── Program.cs → Entry point
├── Services/
│ ├── Gen0Demo.cs → Demonstrates Generation 0 collection
│ ├── Gen1Demo.cs → Demonstrates Generation 1 collection
│ ├── Gen2Demo.cs → Demonstrates Generation 2 collection
│ └── GCDemoRunner.cs → Runs all demos together
├── Utils/
│ └── MemoryPrinter.cs → Helper for printing GC info
└── GarbageCollector.Endpoint.csproj → Project file
```

---

##  How It Works  

- **Gen 0** → Newly created short-lived objects (e.g., small variables, temp references).  
- **Gen 1** → Middle-aged objects that survived at least one GC.  
- **Gen 2** → Long-lived objects (e.g., static references, large arrays).  

This demo forces collection on each generation separately and prints results:  
- Object generation before and after collection.  
- Memory usage.  
- Collection counts with `GC.CollectionCount()`.  

---

##  GC Generations Diagram  
```
+-----------------+ +-----------------+ +-----------------+
| Generation 0 | ---> | Generation 1 | ---> | Generation 2 |
| Short-lived | | Survived 1 GC | | Long-lived |
| objects | | (promoted) | | objects |
+-----------------+ +-----------------+ +-----------------+
```

- Objects start in **Gen 0**.  
- If they survive a collection, they move to **Gen 1**.  
- If they survive more collections, they move to **Gen 2**.  
- Gen 2 collections are the most expensive.  

---

##  Run the Project  

Make sure you have **.NET 8 SDK** (or newer) installed.  

```bash
# Clone repo
git clone https://github.com/your-username/GCGenerationsDemo.git
cd GCGenerationsDemo

# Run project
dotnet run

=== GC Generations Demo ===
.NET Version: 9.0.9

-- Generation 0 Demo --
Object 1 is in generation: 0
Object 2 is in generation: 0
Object 1 is in generation: 1
Object 2 is in generation: 1
GC Collection Counts:
Generation 0: 1 collections
Generation 1: 0 collections
Generation 2: 0 collections

-- Generation 1 Demo --
Object 1 is in generation: 0
Object 1 is in generation: 1
GC Collection Counts:
Generation 0: 2 collections
Generation 1: 1 collections
Generation 2: 0 collections

-- Generation 2 Demo --
Object 1 is in generation: 0
Object 2 is in generation: 0
Object 1 is in generation: 1
Object 2 is in generation: 1
GC Collection Counts:
Generation 0: 3 collections
Generation 1: 2 collections
Generation 2: 1 collections


=== Demo Finished ===

