using System;
using System.Collections;

namespace Collections
{
    class StackAndQueue
    {
        public static void Main()
        {
            Stack stack = new Stack();
            stack.Push("One");
            stack.Push("Two");
            stack.Push("Three");
            Queue queue = new Queue();
            queue.Enqueue("Four");
            queue.Enqueue("Five");
            queue.Enqueue("Six");

            Console.WriteLine("Stack:");
            foreach (string item in stack)
            {
                Console.WriteLine("\t"+item);
            }
            Console.Write("\nQueue: ");
            foreach (string item in queue)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine(  "\n\n\nPopped: " + stack.Pop());
            Console.WriteLine("Stack after popping an element:");
            foreach (string item in stack)
            {
                Console.WriteLine("\t" + item);
            }
            Console.WriteLine("\nDeleted: " + queue.Dequeue());
            Console.Write("Queue after deleting the element: ");
            foreach (string item in queue)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
