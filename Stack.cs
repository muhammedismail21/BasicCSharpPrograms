using System;

namespace DataStructures
{
    class Stack
    {
        int stackSize;
        int[] stackElements;
        int top;
        public Stack()
        {
            stackSize = 5;
            stackElements = new int[stackSize];
            top = -1;
        }
        public Stack(int stackSize)
        {
            this.stackSize = stackSize;
            stackElements = new int[stackSize];
            top = -1;
        }
        public bool Push(int element)
        {
            if (top == (stackSize - 1))
            {
                throw new StackOverflowException();
            }
            else
            {
                top++;
                stackElements[top] = element;
                return true;
            }
        }
        public int Pop()
        {
            if (top == -1)
            {
                throw new Exception("Stack is empty");
            }
            else
            {
                int deletedElement = stackElements[top];
                top--;
                return deletedElement;
            }
        }
        public int Peek()
        {
            if (top == -1)
            {
                throw new Exception("Stack is empty");
            }
            else
            {
                int topElement = stackElements[top];
                return topElement;
            }
        }
    }
}
