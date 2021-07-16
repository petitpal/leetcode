using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        
        var triangle = new List<IList<int>>();

        IList<int> currentRow = new List<int>() { 1 };
        triangle.Add(currentRow);

        for (var rowIndex = 0; rowIndex < numRows-1; rowIndex++) {
            currentRow = GenerateNextRow(currentRow);
            triangle.Add(currentRow);
        }

        return (IList<IList<int>>)triangle;
    }

    public IList<int> GenerateNextRow(IList<int> currentRow) {

        var nextRow = new int[currentRow.Count+1];
        var midPoint = Math.Floor((double)currentRow.Count/2);

        nextRow[0] = currentRow[0];
        nextRow[nextRow.Length-1] = currentRow[currentRow.Count-1];
        
        for (var i = 1; i <= midPoint; i++) {
            nextRow[i] = currentRow[i-1] + currentRow[i];
            nextRow[(nextRow.Length-1)-i] = nextRow[i];
        }

        return nextRow.ToList<int>();
    }
}