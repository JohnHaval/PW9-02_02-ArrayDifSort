using System.Data;

namespace PW9_02_02_ArrayDifSort
{
    public class VisualArray
    {
        public DataTable CurrentTable { get; private set; } = new DataTable();
        public DataTable CreateTable(double[,] arr)
        {
            CurrentTable = new DataTable();
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                CurrentTable.Columns.Add("Col_" + (i + 1), typeof(string));
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                var row = CurrentTable.NewRow();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    row[j] = arr[i, j];
                }
                CurrentTable.Rows.Add(row);
            }
            return CurrentTable;
        }
        public void EditCell(int i, int j, double value)
        {
            var row = CurrentTable.Rows[i];//ПРОВЕРИТЬ АКТУАЛЬНОСТЬ РАБОТЫ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            row[j] = value;
        }
        public void ClearTable()
        {
            CurrentTable = new DataTable();
        }
    }
}
