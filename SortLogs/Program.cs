using System;

namespace SortLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var logs = new string[] {"dig1 8 1 5 1","let1 art can","dig2 3 6","let2 own kit dig","let3 art zero"};
            var service = new Solution();
            var output = service.ReorderLogFiles(logs);
            var ctrlBreak = "";
        }

    }
}
