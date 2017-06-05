using System;

namespace BasicCSharpPrograms
{
    class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            // Declaring three integer variables
            int number1; // stores the first number
            int number2; // stores the second number
            int sum = 0; // stores the sum of number1 and number2

            // initializing 
            number1 = 10;
            number2 = 20;
            sum = number1 + number2; // using + operator to add two numbers
            Console.WriteLine("Sum: " + sum); // writes the output to the sccreen
        }
    }
}
