using System;

public class Solution {

    public int[] PlusOne(int[] digits) => PlusOne_ReverseTraverse(digits);

    int[] PlusOne_ReverseTraverse(int[] digits) {

        for (var i=digits.Length-1;i>=0;i--)
        {
            if (digits[i]==9)
            {
                digits[i]=0;
                if (i==0)
                {
                    Array.Resize(ref digits, digits.Length+1);
                    Array.Copy(digits, 0, digits, 1, digits.Length-1);
                    digits[0]=1;
                    break;
                }
            }
            else
            {
                digits[i]++;
                break;
            }
        }
        return digits;
    }

    int[] PlusOne_ToNumberAndBack(int[] digits) {
        
        var number=0;
        for (var n=1;n<=digits.Length;n++)
        {
            var e = (int)Math.Pow(10,digits.Length-n);
            number += e*digits[n-1];
        }

        number+=1;
        
        var arraySize = Math.Log10(number);
        var outputLength = (int)Math.Floor(Math.Log10(number))+1;
        if (outputLength!=digits.Length) {
            Array.Resize(ref digits, outputLength);
            Array.Copy(digits, 0, digits, 1, digits.Length-1);
        }

        for (var n=1;n<=digits.Length;n++)
        {
            var e = (int)Math.Pow(10,digits.Length-n);
            var d = number/e;
            digits[n-1]=d;
            number-=d*e;
        }
        
        return digits;
    }
}