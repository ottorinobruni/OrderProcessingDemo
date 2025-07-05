// Specialized Collection: SortedSet for unique, ordered categories
using System.Collections.Concurrent;
using System.Collections.Immutable;

var categories = new SortedSet<string> { "Electronics", "Books", "Toys", "Books" }; // "Books" added twice

Console.WriteLine("Product Categories:");
foreach (var category in categories)
{
    Console.WriteLine($"- {category}");
}

// Immutable Collection: Customer tags (e.g. loyalty, interest)
var baseTags = ImmutableHashSet<string>.Empty;
var customerTags = baseTags.Add("Loyal").Add("Newsletter").Add("VIP");

// Try to "mutate" the set
var updateTags = customerTags.Add("Referral");

Console.WriteLine("\nCustomer Tags:");
foreach (var tag in updateTags)
{
    Console.WriteLine($"- {tag}");
}

// Thread-Safe Collection: BlockingCollection for pending orders
var orderQueue = new BlockingCollection<Order>();

// Producer: add a few orders
orderQueue.Add(new Order(1, "John Doe", 99.99m));
orderQueue.Add(new Order(2, "Jane Smith", 49.50m));
orderQueue.CompleteAdding(); // Signal we're done

// Consumer: process orders
Console.WriteLine("\nProcessing Orders:");
foreach (var order in orderQueue.GetConsumingEnumerable())
{
    Console.WriteLine($"✔ Order #{order.Id} for {order.CustomerName}: €{order.Total}");
}

// Simple order record
record Order(int Id, string CustomerName, decimal Total);