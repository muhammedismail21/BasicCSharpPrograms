using System;

namespace DataStructures
{
    class TestQueue
    {
        public static void Main(string[] args)
        {
            Queue queue = new Queue(10);
            Random randomIntegers = new Random(10);
            for (int i = 0; i < 5; i++)
            {
                queue.EnQueue(randomIntegers.Next(100));
            }
            queue.Display();
            queue.DeQueue();
            queue.Display();
            queue.EnQueue(25);
            queue.Display();
            
            
            Console.ReadLine();
        }
    }
}
