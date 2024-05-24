namespace Problems.Library.Easy.PascalTriangle
{
    /// <summary>
    /// Solutions related to Pascal's Triangle.
    /// </summary>
    public class PascalsTriangleSolution
    {
        /// <summary>
        /// Generates a jagged array representing Pascal's Triangle with the specified number of rows.
        /// </summary>
        /// <param name="numRows">The number of rows for Pascal's Triangle.</param>
        /// <returns>A jagged array representing Pascal's Triangle.</returns>
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> list = new List<IList<int>>();
            if (numRows == 0) return list;

            list.Add(new List<int> { 1 });

            for (int i = 1; i < numRows; i++)
            {
                IList<int> row = new List<int> { 1 };
                IList<int> prevRow = list[i - 1];

                for (int j = 1; j < i; j++)
                {
                    row.Add(prevRow[j - 1] + prevRow[j]);
                }

                row.Add(1);
                list.Add(row);
            }

            return list;
        }

        /// <summary>
        /// Generates a specific row of Pascal's Triangle based on the given row index.
        /// </summary>
        /// <param name="rowIndex">The index of the row to generate.</param>
        /// <returns>A list representing the specified row of Pascal's Triangle.</returns>
        public IList<int> GetRow(int rowIndex)
        {
            IList<int> row = new List<int>(new int[rowIndex + 1]);
            row[0] = 1;
            for (int i = 1; i <= rowIndex; i++)
            {
                row[i] = 1;
                for (int j = i - 1; j > 0; j--)
                {
                    row[j] += row[j - 1];
                }
            }
            return row;
        }
    }
}
