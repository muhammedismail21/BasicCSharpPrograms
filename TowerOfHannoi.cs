using System;
using System.Collections.Generic;

namespace OOPs
{
    class TowerOfHannoi
    {
        static Stack<string> tower1 = null;
        static Stack<string> tower2 = null;
        static Stack<string> tower3 = null;
        public void Move(Stack<string> [] towers)
        {
            int count = 0;
            tower1 = towers[0];
            tower2 = towers[1];
            tower3 = towers[2];

            tower1.Push("3");
            tower1.Push("2");
            tower1.Push("1");

            display();

            while (!complete())
            {
                count++;
                int moveFrom;
                int moveTo;
                Stack<String> fromTower = null;
                Stack<String> toTower = null;
                Console.Write("Move from: ");
                moveFrom = Convert.ToInt32(Console.ReadLine());
                Console.Write("Move to: ");
                moveTo = Convert.ToInt32(Console.ReadLine());

                switch (moveFrom)
                {
                    case 1:
                        fromTower = tower1;
                        break;
                    case 2:
                        fromTower = tower2;
                        break;
                    case 3:
                        fromTower = tower3;
                        break;

                    default:
                        break;
                }
                switch (moveTo)
                {
                    case 1:
                        toTower = tower1;
                        break;
                    case 2:
                        toTower = tower2;
                        break;
                    case 3:
                        toTower = tower3;
                        break;

                    default:
                        break;
                }

                if (fromTower.IsEmpty() == true || toTower.Count == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cannot move the disk.");
                    Console.ResetColor();
                }
                else
                {
                    if (toTower.IsEmpty())
                    {
                        toTower.Push(fromTower.Pop());
                    }
                    else
                    {

                        if (Convert.ToInt32(fromTower.Peek()) > Convert.ToInt32(toTower.Peek()))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You cannot move a big disk over small disk.");
                            Console.ResetColor();
                        }
                        else
                        {
                            toTower.Push(fromTower.Pop());
                        }
                    }
                }
                display();
            }
            finish(count);
            Console.ReadLine();
        }
        public static void display()
        {
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("Tower-1 | Tower-2 | Tower-3");
            Console.WriteLine("----------------------------");
            String d1 = " ", d2 = " ", d3 = " ";
            for (int i = 2; i >= 0; i--)
            {
                try
                {
                    d1 = tower1.GetElement(i);
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

                    d2 = tower2.GetElement(i);

                    d2 = Convert.ToInt32(tower[2].ToArray().GetValue(i)).ToString();

                }
                catch (Exception e)
                {
                }
                try
                {

                    d3 = tower3.GetElement(i);

                    d3 = Convert.ToInt32(tower[3].ToArray().GetValue(i)).ToString();

                }
                catch (Exception e)
                {
                }

                Console.WriteLine("  " + d1 + "     |  " + d2 + "      |  " + d3);

            }
            Console.WriteLine("----------------------------\n");
        }
        public static bool complete()
        {
            return tower3.Count == 3;
        }
        public static void finish(int count)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCongratulation!! you have moved all disks in {0} moves", count);
            Console.ResetColor();

                Console.WriteLine("  " + d1 + "  |  " + d2 + "  |  " + d3);
            }
            Console.WriteLine("\n");

        }
    }
}
