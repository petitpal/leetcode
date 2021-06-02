using System;

namespace FindAndReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Solution();
            var words = new string[] {"abc","deq","mee","aqq","dkd","ccc"};
            var pattern = "abb";

            var matches = test.FindAndReplacePattern(words, pattern);
            var ctrlbreak = "";
        }
    }
}
