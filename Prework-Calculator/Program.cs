using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(3, 4);
            Subtract(7, 4);
            Multiply(2, 3);
            Divide(15, 5);
        }
        // The below code takes in two parameters and returns their sum.
        static int Add(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine($"The sum of {x} and {y} is {sum}");
            return sum;

        }

        // The below code takes in two parameters and subtracts the second from the first.
        static int Subtract(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine($"{x} minus {y} equals {sub}");
            return sub;
        }

        // The below code takes in two parameters and multiplies them.
        static int Multiply(int x, int y)
        {
            int multi = x * y;
            Console.WriteLine($"{x} times {y} equals {multi}");
            return multi;
        }

        // The below code takes in two parameters and divides the first by the second.
        static int Divide(int x, int y)
        {
            int div = x / y;
            Console.WriteLine($"{x} divided by {y} equals {div}");
            return div;
        }
        
    }
}
