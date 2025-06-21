Console.WriteLine("=== Order Processing System ===");

// 1. List<Order> - holds all orders
List<Order> orders = new()
{
    new Order { Id = "ORD001", Products = new List<string> { "Keyboard", "Mouse" } },
    new Order { Id = "ORD002", Products = new List<string> { "Monitor" } },
    new Order { Id = "ORD003", Products = new List<string> { "Laptop", "Headset" } }
};

// 2. Dictionary<string, Order> - fast access by ID
var orderLookup = new Dictionary<string, Order>();
foreach (var order in orders)
{
    orderLookup[order.Id] = order;
}

Console.WriteLine("ORD002 has " + orderLookup["ORD002"].Products.Count + " product(s).");

// 3. Queue<Order> - simulate a processing queue
Queue<Order> processingQueue = new(orders);

var currentOrder = processingQueue.Dequeue();
Console.WriteLine($"Processing order: {currentOrder.Id}");

// 4. Stack<Order> - simulate undo history
Stack<Order> undoStack = new();
currentOrder.Status = "Shipped";
undoStack.Push(currentOrder);

Console.WriteLine($"Order {currentOrder.Id} status updated to {currentOrder.Status}");

// Undo operation
var lastModified = undoStack.Pop();
lastModified.Status = "Pending";
Console.WriteLine($"Undo: Order {lastModified.Id} status reverted to {lastModified.Status}");

// 5. IEnumerable<Order> - filter and display
IEnumerable<Order> pendingOrders = orders.Where(o => o.Status == "Pending");

Console.WriteLine("Pending orders:");
foreach (var pendingOrder in pendingOrders) 
{
    Console.WriteLine($"- {pendingOrder.Id}");
}

class Order
{
    public string Id { get; set; }
    public List<string> Products { get; set; } = new();
    public string Status { get; set; } = "Pending";
}
