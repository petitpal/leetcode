using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = "Hello world";
            var chrarr = inputString.ToCharArray();
            
            ReverseString(chrarr);
            
            Console.WriteLine(new String(chrarr));

        }

        public static void ReverseString(char[] s) {
            
            var start = 0;
            var end = s.Length-1;
            char temp;
            
            while (start < end) {
                temp = s[start];
                s[start] = s[end];
                s[end] = temp;
                
                start += 1;
                end -= 1;
            }
            
        }
    }
}
