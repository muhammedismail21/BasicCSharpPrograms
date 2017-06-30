using System;

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
                }
                catch (Exception e)
                {
                }
                try
                {
                    d2 = tower2.GetElement(i);
                }
                catch (Exception e)
                {
                }
                try
                {
                    d3 = tower3.GetElement(i);
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
        }
    }
}
