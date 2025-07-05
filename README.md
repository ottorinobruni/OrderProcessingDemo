# OrderProcessingDemo

This is a simple .NET Console Application that demonstrates how to use core collection types from the `System.Collections` namespace in C#.

It is part of the blog post:  
👉 [Getting Started with System.Collections and Immutable Types in C# and .NET – Part 1](https://www.ottorinobruni.com/getting-started-with-system-collections-and-immutable-types-in-csharp-and-dotnet-part-1/)

## What It Shows

This example simulates a basic order processing system and demonstrates how to use:

### Part 1 (main branch)
- `List<T>` for storing dynamic collections of orders  
- `Dictionary<TKey, TValue>` for fast lookups by order ID  
- `Queue<T>` for processing orders in FIFO order  
- `Stack<T>` for implementing simple undo logic  
- `IEnumerable<T>` with LINQ to filter and display data  

### Part 2 (collections-advanced branch)
- `SortedSet<T>` to maintain ordered, unique product categories  
- `ImmutableHashSet<T>` to safely represent customer tags  
- `BlockingCollection<T>` to handle thread-safe order queues (Producer/Consumer)  
- `record` types for immutable order data models 

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio Code](https://code.visualstudio.com/)
- C# extension for VSCode

## How to Run

1. Clone the repository or download the source code.
2. Open the folder in Visual Studio Code.
3. Open the terminal and run:

   ```bash
   dotnet run

## Contributions

Contributions are welcome! If you'd like to improve this project, feel free to open a pull request or report an issue.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---
