
var matrix1 = new int[3][];
matrix1[0] = new int[3] { 1, 1, 1};
matrix1[1] = new int[3] { 1, 0, 1};
matrix1[2] = new int[3] { 1, 1, 1};

var matrix2 = new int[3][];
matrix2[0] = new int[4] { 0, 1, 2, 0 };
matrix2[1] = new int[4] { 3, 4, 5, 2 };
matrix2[2] = new int[4] { 1, 3, 1, 5 };

var testMatrix = matrix2;

// PrintMatrix(testMatrix);
// Console.WriteLine();

var solution = new Solution();
solution.SetZeroes(testMatrix);

PrintMatrix(testMatrix);




void PrintMatrix(int[][] matrix) {

    for (var r=0;r<matrix.Length;r++) {
        for (var c=0;c<matrix[0].Length;c++) {
            Console.Write($"[{matrix[r][c]}]");
        }
        Console.WriteLine();
    }

}
