using System.Collections.Generic;

namespace queues_assignment_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue callQueue = new LinkedListQueue();

            // Add calls to the queue
            callQueue.Enqueue(new Call("Alice", "123-456-7890"));
            callQueue.Enqueue(new Call("Bob", "987-654-3210"));
            callQueue.Enqueue(new Call("Charlie", "555-555-5555"));

            // Peek at the first call
            Call nextCall = callQueue.Peek();
            if (nextCall != null)
                Console.WriteLine($"Next call: {nextCall}");

            // Serve the first call
            callQueue.Dequeue();

            // Display the remaining calls
            callQueue.Display();

            // Serve all remaining calls
            callQueue.Dequeue();
            callQueue.Dequeue();

            // Try serving from an empty queue
            callQueue.Dequeue();

            // Check the queue size
            Console.WriteLine($"Calls remaining: {callQueue.Size()}");
        }
    }
}
