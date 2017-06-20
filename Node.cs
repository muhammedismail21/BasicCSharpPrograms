using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Node
    {
        int value;

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        Node nextNode;

        public Node NextNode
        {
            get { return nextNode; }
            set { nextNode = value; }
        }
        Node prevNode;

        public Node PrevNode
        {
            get { return prevNode; }
            set { prevNode = value; }
        }
        public Node()
        {
            nextNode = null;
            prevNode = null;
        }
    }
}
