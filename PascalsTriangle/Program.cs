using System;

namespace PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            
            // 3 rows
            var example1 = solution.Generate(3);

            // 5 rows
            var example2 = solution.Generate(5);

            // 15 rows
            var example4 = solution.Generate(15);

            // 1 row
            var example5 = solution.Generate(1);

        }
    }
}
