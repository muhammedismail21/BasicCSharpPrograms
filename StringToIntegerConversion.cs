using System;

namespace BasicCSharpPrograms
{
    class StringToIntegerConversion
    {
        public static void Main()
        {
            // Declaring three integer variables
            int number1; // stores the first number
            int number2; // stores the second number
            int sum = 0; // stores the sum of number1 and number2

            Console.WriteLine("Enter the first number");// prompt the user to enter a number
            /* initializing 
             * Reading the input from the console using Console.ReadLine()
             * Console.ReadLine() reads the input in string format
             * using Convert.ToInt32(...) to convert strng input to interger type
            */
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");// prompt the user to enter a number
            number2 = Convert.ToInt32(Console.ReadLine());
            sum = number1 + number2; // using + operator to add two numbers
            Console.WriteLine("Sum: " + sum); // writes the output to the sccreen
        }
    }
}
