using System;

var solution = new Solution();
var test = new int[] { 9 };
PrintArray(test);

var result = solution.PlusOne(test);
PrintArray(result);


void PrintArray(int[] arr)
{
    foreach (int a in arr)
    {
        Console.Write(a);
    }
    Console.WriteLine();
}