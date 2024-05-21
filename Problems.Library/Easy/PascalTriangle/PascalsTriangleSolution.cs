namespace Problems.Library.Easy.PascalTriangle
{
    /// <summary>
    /// Solutions related to the Pascals Triangle
    /// </summary>
    public class PascalsTriangleSolution
    {
        /// <summary>
        /// Return the Jagged Array represent the Pascal Triangle with the number of rows given in the input parameter.
        /// </summary>
        /// <param name="numRows">Number of rows input parameter.</param>
        /// <returns></returns>
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
        /// Return the particular row after generating based on the given row index.
        /// </summary>
        /// <param name="rowIndex">Input of row index.</param>
        /// <returns></returns>
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
