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

        static int Add(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine($"The sum of {x} and {y} is {sum}");
            return sum;

        }

        static int Subtract(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine($"{x} minus {y} equals {sub}");
            return sub;
        }

        
        static int Multiply(int x, int y)
        {
            int multi = x * y;
            Console.WriteLine($"{x} times {y} equals {multi}");
            return multi;
        }

        static int Divide(int x, int y)
        {
            int div = x / y;
            Console.WriteLine($"{x} divided by {y} equals {div}");
            return div;
        }
        
    }
}
