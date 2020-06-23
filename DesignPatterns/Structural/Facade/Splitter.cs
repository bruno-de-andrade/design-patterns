using System.Collections.Generic;

namespace DesignPatterns.Structural.Facade
{
    public static class Splitter
    {
        /// <summary>
        /// Splits a 2D square matrix into several lists containing all rows, all columns and all diagonals.
        /// </summary>
        public static List<List<int>> Split(List<List<int>> array)
        {
            var result = new List<List<int>>();
            var rowCount = array.Count;
            var colCount = array[0].Count;

            // get the rows
            for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
            {
                var row = new List<int>();

                for (int colIndex = 0; colIndex < colCount; ++colIndex)
                    row.Add(array[rowIndex][colIndex]);

                result.Add(row);
            }

            // get the columns
            for (int colIndex = 0; colIndex < colCount; ++colIndex)
            {
                var column = new List<int>();

                for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
                    column.Add(array[rowIndex][colIndex]);

                result.Add(column);
            }

            // now the diagonals
            var diagonal1 = new List<int>();
            var diagonal2 = new List<int>();
            for (int colIndex = 0; colIndex < colCount; ++colIndex)
            {
                for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
                {
                    if (colIndex == rowIndex)
                        diagonal1.Add(array[rowIndex][colIndex]);

                    var r2 = rowCount - rowIndex - 1;

                    if (colIndex == r2)
                        diagonal2.Add(array[rowIndex][colIndex]);
                }
            }

            result.Add(diagonal1);
            result.Add(diagonal2);

            return result;
        }
    }
}
