using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace queues_assignment_6._3
{
    class Call 
    {
        public string Callername {  get; set; }
        public string PhoneNumber {  get; set; }

        public Call(string callername, string phoneNumber) 
        {
            Callername = callername;
            PhoneNumber = phoneNumber;
        }
        public override string ToString() 
        {
            return $"Caller {Callername}, Phone#: {PhoneNumber}";
        }
    }
    class Node
    {
        public Call Data { get; set; }
        public Node Next { get; set; }
        public Node(Call data)
        {
            Data = data;
            Next = null;
        }
    }
    class LinkedListQueue
    {
        private Node head; // Front of the queue
        private Node tail; // End of the queue
        private int count; // Number of calls in the queue

        public LinkedListQueue()
        {
            head = null;
            tail = null;
            count = 0;
        }

        // Add a call to the queue
        public void Enqueue(Call call)
        {
            Node newNode = new Node(call);

            if (tail == null) // If the queue is empty
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }

            count++;
            Console.WriteLine($"Call added: {call}");
        }

        // Remove and return the first call in the queue
        public Call Dequeue()
        {
            if (head == null) // If the queue is empty
            {
                Console.WriteLine("No calls in the queue.");
                return null;
            }

            Call dequeuedCall = head.Data; // Store the call to return
            head = head.Next;             // Move the head pointer

            if (head == null) // If the queue is now empty
            {
                tail = null;
            }

            count--;
            Console.WriteLine($"Serving call: {dequeuedCall}");
            Console.WriteLine();
            return dequeuedCall;
        }

        // View the first call in the queue without removing it
        public Call Peek()
        {
            if (head == null)
            {
                Console.WriteLine("No calls in the queue.");
                return null;
            }

            return head.Data;
        }

        // Get the number of calls in the queue
        public int Size()
        {
            return count;
        }

        // Display all calls in the queue
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("No calls in the queue.");
                return;
            }

            Console.WriteLine("Current call queue:");
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}