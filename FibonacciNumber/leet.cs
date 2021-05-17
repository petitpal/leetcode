using System;

namespace FibonacciNumber
{
    public class Solution {
    
        // int[] fib = new int[30];

        // public Solution()
        // {
        //     fib[0]=0;
        //     fib[1]=1;
            
        //     for (var n=2;n<=29;n++) fib[n] = fib[n-2] + fib[n-1];

        //     var nums = "";
        //     foreach (var num in fib) nums = $"{nums},{num}";
        // }
    
        // public int Fib(int n) => fib[n];

        const float sqrt5 = 2.23606797749979f;
        const float varphi = 1.618033988749895f;
        const float psi = -0.1180339887498949f;

        public int Fib(int n) => Convert.ToInt32((Math.Pow(varphi,n) - Math.Pow(psi,n)) / sqrt5);
    }
}