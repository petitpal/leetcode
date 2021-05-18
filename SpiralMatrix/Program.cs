using System;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 7;
            var response = CreateMatrix(n);

            for (var r=0;r<n;r++) {
                for (var c=0;c<n;c++) {
                    Console.Write($"[{response[r,c]:000}]");
                }
                Console.WriteLine();
            }

        }


        static int[,] CreateMatrix(int n)  {

            var pow = n*n;
            var matrix = new int[n,n];
            var direction = 0;      // 0 = r, 1 = d, 2 = l, 3 = u
            var x = 0;
            var y = 0;

            for (var i=1;i<=pow;i++) {
                matrix[y,x]=i;
                switch (direction) {
                    case 0:
                        if (x+1 == n || matrix[y,x+1] != 0) {
                            direction = 1;
                            y += 1;
                        }
                        else
                        {
                            x += 1;
                        }
                        break;

                    case 1:
                        if (y+1 == n || matrix[y+1,x] != 0) {
                            direction = 2;
                            x -= 1;
                        }
                        else
                        {
                            y += 1;
                        }
                        break;

                    case 2:
                        if (x-1 == -1 || matrix[y,x-1] != 0) {
                            direction = 3;
                            y -= 1;
                        }
                        else
                        {
                            x -= 1;
                        }
                        break;

                    case 3:
                        if (y-1 == -1 || matrix[y-1,x] != 0) {
                            direction = 0;
                            x += 1;
                        }
                        else
                        {
                            y -= 1;
                        }
                        break;
                }
            }

            return matrix;
        }

    }
}
