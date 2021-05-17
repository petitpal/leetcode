using System;

namespace FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var x = solution.Fib(4);
            x = solution.Fib(0);
            x = solution.Fib(6);

            x = solution.Fib(3);
            x = solution.Fib(1);
            x = solution.Fib(30);

            Console.WriteLine("Hello World!");
        }
    }
}