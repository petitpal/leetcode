
// this doesn't work at the moment - plan is to use first row / col as indicator, but need to think
// how to make this work in cases where there are 0s on the top / left row originally

public class Solution {
    
    const int zero = 0;

    private int[][] _matrix = null;
    private int _numCols = 0;
    private int _numRows = 0;
    
    public void SetZeroes(int[][] matrix) {
        if (matrix==null || matrix.Length==0 || matrix[0].Length==0) return;
        
        _matrix = matrix;
        _numRows = matrix.Length;
        _numCols = matrix[0].Length;
        
        for (var r=1; r<_numRows;r++)
        {
            for (var c=1; c<_numCols;c++)
            {
                if (_matrix[r][c]==0) {
                    _matrix[r][0]=zero;
                    _matrix[0][c]=zero;
                }
            }
        }


        for (var c=0; c<_numCols;c++)
        {
            if (_matrix[0][c]==zero) {
                SetZeroes_Col(c);
            }
        }

        for (var r=0; r<_numRows;r++)
        {
            if (_matrix[r][0]==zero) {
                SetZeroes_Row(r);
            }
        }
    }

    void SetZeroes_Col(int colIndex) {
        for (var r=0; r<_numRows;r++)
        {
            if (_matrix[r][colIndex]!=0)
                _matrix[r][colIndex]=0;
        }
    }
    
    void SetZeroes_Row(int rowIndex) {
        for (var c=0; c<_numCols;c++)
        {
            if (_matrix[rowIndex][c]!=0)
                _matrix[rowIndex][c]=0;
        }
    }
}