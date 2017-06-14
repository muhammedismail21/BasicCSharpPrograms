using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList alist = new ArrayList(5);
            Console.WriteLine("Initial Capacity: " + alist.Capacity);
            Console.WriteLine("No of Elements: " + alist.Count);
            alist.Add("C#");
            alist.Add("VB.NET");
            alist.Add("ADO.NET");
            alist.Add("ASP.NET");
            alist.Add("ASP.NET MVC");           
            Console.WriteLine("\n");
            Console.WriteLine("Capacity: " + alist.Capacity);
            Console.WriteLine("No of Elements: " + alist.Count);
            foreach (string item in alist)
            {
                Console.WriteLine(item);
            }

            alist.Add("WCF");// adiing 6th element
            Console.WriteLine("\nAfter adding 6th element");
            Console.WriteLine("Capacity: " + alist.Capacity);
            Console.WriteLine("No of Elements: " + alist.Count);
            foreach (string item in alist)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
