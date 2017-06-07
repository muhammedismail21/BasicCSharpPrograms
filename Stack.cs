using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Stack
    {
        int stackSize;
        int[] stackElements;
        int index;
        public Stack()
        {
            stackSize = 5;
            stackElements = new int[stackSize];
            index = -1;
        }
        public Stack(int stackSize)
        {
            this.stackSize = stackSize;
            stackElements = new int[stackSize];
            index = -1;
        }
        public bool Push(int element)
        {
            throw new NotImplementedException();
        }
        public int Pop()
        {
            throw new NotImplementedException();
        }
        public int Peek()
        {
            throw new NotImplementedException();
        }
    }
}
