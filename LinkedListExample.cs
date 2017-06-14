using System;
using System.Collections.Generic;

namespace Collections
{
    class LinkedListExample
    {
        public static void Main()
        {
            LinkedList<string> programingLanguages = new LinkedList<string>();
            programingLanguages.AddLast(new LinkedListNode<string>("C#"));
            programingLanguages.AddLast(new LinkedListNode<string>("Java"));
            programingLanguages.AddLast(new LinkedListNode<string>("C++"));
            programingLanguages.AddLast(new LinkedListNode<string>("C"));
            programingLanguages.AddLast(new LinkedListNode<string>("COBOL"));
            programingLanguages.AddLast(new LinkedListNode<string>("PASCAL"));
            
            LinkedListNode<string> node = programingLanguages.First;
            while(node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }

            Console.ReadLine();
        }
    }
}
