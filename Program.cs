using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            HugeNumber hn1 = new HugeNumber();
            HugeNumber hn2 = new HugeNumber();
            HugeNumber res = new HugeNumber();

            String num1 = "91234567890123456789739951749201749";
            String num2 = "91234567890123456789394017305401298";
            String[] num1Digits = splitNumber(num1);
            String[] num2Digits = splitNumber(num2);


            Console.WriteLine("Sum of huge integers:\n------------------------\n\n");
            Console.Write("  ");
            for (int i = 0; i < num1Digits.Length; i++)
            {
                Console.Write(num1Digits[i] + " ");
                hn1.addDidit(Convert.ToInt32(num1Digits[i]));
            }
            Console.WriteLine();
            Console.Write("  ");
            for (int i = 0; i < num2Digits.Length; i++)
            {
                Console.Write(num2Digits[i] + " ");
                hn2.addDidit(Convert.ToInt32(num2Digits[i]));
            }

            Console.WriteLine("\n-----------------------------------------------------------------------");
            res = res.addNumbers(hn1, hn2);
            String sum = "";

            res.current = res.start;
            while (res.current != null)
            {
                sum += res.current.Value + " ";
                res.current = res.current.NextNode;
            }
            Console.WriteLine(sum);
            Console.WriteLine("-----------------------------------------------------------------------");

            Console.ReadLine();
        }

        public static String[] splitNumber(String num)
        {
            String[] arr = new String[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                arr[i] = num[i].ToString();
            }

            return arr;
        }

    }
}