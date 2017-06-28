using System;
using System.Collections.Generic;

namespace OOPs
{
    class TowerOfHannoi
    {
        public static int N;
        /* Creating Stack array  */
        public static Stack<int>[] tower = new Stack<int>[4];

        public static void Main(String[] args)
        {
            tower[1] = new Stack<int>();
            tower[2] = new Stack<int>();
            tower[3] = new Stack<int>();
            /* Accepting number of disks */
            Console.WriteLine("Enter number of disks");
            int num = Convert.ToInt32(Console.ReadLine());
            N = num;
            toh(num);

            Console.ReadLine();
        }
        /* Function to push disks into stack */
        public static void toh(int n)
        {
            for (int d = 1; d <= n; d++)
                tower[1].Push(d);
            display();
            move(n, 1, 2, 3);
        }
        /* Recursive Function to move disks */
        public static void move(int n, int a, int b, int c)
        {
            if (n > 0)
            {
                move(n - 1, a, c, b);
                int d = tower[a].Pop();
                tower[c].Push(d);
                display();
                move(n - 1, b, a, c);
            }
        }
        /*  Function to display */
        public static void display()
        {
            Console.WriteLine("  A  |  B  |  C");
            Console.WriteLine("---------------");
            for (int i = N - 1; i >= 0; i--)
            {
                String d1 = " ", d2 = " ", d3 = " ";
                try
                {
                    d1 = Convert.ToInt32(tower[1].ToArray().GetValue(i)).ToString();
                }
                catch (Exception e)
                {
                }
                try
                {
                    d2 = Convert.ToInt32(tower[2].ToArray().GetValue(i)).ToString();
                }
                catch (Exception e)
                {
                }
                try
                {
                    d3 = Convert.ToInt32(tower[3].ToArray().GetValue(i)).ToString();
                }
                catch (Exception e)
                {
                }
                Console.WriteLine("  " + d1 + "  |  " + d2 + "  |  " + d3);
            }
            Console.WriteLine("\n");
        }
    }
}
