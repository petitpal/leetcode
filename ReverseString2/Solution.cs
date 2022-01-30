public class Solution {
    public void ReverseString(char[] s) {

        for (var p1=0; p1<System.Math.Ceiling((double)s.Length/2); p1++)
        {
            var c = s[p1];
            var p2 = s.Length-1-p1;
            if (p1==p2) break;

            s[p1]=s[p2];
            s[p2]=c;
        }

    }
}