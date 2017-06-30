using System;

namespace OOPs
{
    class Stack<T>
    {
        int size;
        T[] arr;
        int top;
        int count;
        public int Count
        {
            get
            {
                return top + 1;
            }
        }
        public Stack()
        {
            size = 3;
            arr = new T[size];
            top = -1;
        }
        public Stack(int size)
        {
            this.size = size;
            arr = new T[size];
            top = -1;
        }
        public void Push(T element)
        {
            if (top != size)
            {
                arr[++top] = element;
            }
            else
            {
                throw new Exception("Stack overflows.");
            }
        }
        public T Pop()
        {
            if (top != -1)
            {
                return arr[top--];
            }
            else
            {
                throw new Exception("Stack is empty.");
            }
        }
        public T Peek()
        {
            if (top != -1)
            {
                return arr[top];
            }
            else
            {
                throw new Exception("Stack is empty.");
            }
        }
        public bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public T GetElement(int index)
        {
            if (index > -1 && index <= top)
            {
                return arr[index];
            }
            else
            {
                throw new Exception("Index out of range.");
            }
        }
    }
}
