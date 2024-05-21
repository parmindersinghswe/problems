namespace Problems.Library.Easy.PascalTriangle
{
    public class PascalsTriangleSolution
    {
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
    }
}
