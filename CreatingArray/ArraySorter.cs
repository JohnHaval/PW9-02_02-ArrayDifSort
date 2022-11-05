namespace CreatingArray
{
    public static class ArraySorter
    {
        public struct TemporaryValue
        {
            public double Value { get; set; }
            public int FirstIndex { get; set; }
            public int SecondIndex { get; set; }
            public TemporaryValue(int firstIndex, int secondIndex, double value)
            {
                FirstIndex = firstIndex;
                SecondIndex = secondIndex;
                Value = value;
            }
        }
        //Правился при тестировании 
        public static double[,] FirstWaySortToUpRowElements(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int jT = 0; jT < arr.GetLength(1) - 1; jT++)
                {
                    TemporaryValue temporaryValue = new TemporaryValue(i, jT, arr[i, jT]);
                    for (int j = jT + 1; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, jT] > arr[i, j])
                        {
                            temporaryValue.Value = arr[i, j];
                            arr[i, j] = arr[temporaryValue.FirstIndex, temporaryValue.SecondIndex];
                            arr[temporaryValue.FirstIndex, temporaryValue.SecondIndex] = temporaryValue.Value;
                        }
                    }
                }
            }
            return arr;
        }
        //Исправлялся при тестировании
        public static double[,] SecondWaySortToUpRowElements(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int jT = 0; jT < arr.GetLength(1) - 1; jT++)
                {
                    for (int j = jT + 1; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, jT] > arr[i, j])
                        {
                            double temporaryValue = arr[i, j];
                            arr[i, j] = arr[i, jT];
                            arr[i, jT] = temporaryValue;
                        }
                    }
                }
            }
            return arr;
        }
        public static double[] FindArrayAvgOfRows(double[,] arr)
        {
            double[] avgArr = new double[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                double avg = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    avg += arr[i, j];
                }
                avgArr[i] = avg / arr.GetLength(1);
            }
            return avgArr;
        }
        //Исправлялся при тестировании
        public static double[,] FirstWaySortToUpRowsOnAvgElements(double[,] arr)
        {
            double[] avgArr = FindArrayAvgOfRows(arr);
            double tempVal;
            for (int iT = 0; iT < arr.GetLength(0) - 1; iT++)
            {
                TemporaryValue temporaryValue = new TemporaryValue(iT, 0, avgArr[iT]);
                for (int i = iT + 1; i < arr.GetLength(0); i++)
                {
                    if (temporaryValue.Value > avgArr[i])
                    {
                        for (int j = 0; j < avgArr.Length; j++)
                        {
                            tempVal = arr[i, j];
                            arr[i, j] = arr[iT, j];
                            arr[iT, j] = tempVal;
                        }
                        temporaryValue.Value = avgArr[i];
                        tempVal = avgArr[iT];
                        avgArr[iT] = avgArr[i];
                        avgArr[i] = tempVal;
                    }
                }
            }
            return arr;
        }
        //Исправлялся при тестировании
        public static double[,] SecondWaySortToUpRowsOnAvgElements(double[,] arr)
        {
            double[] avgArr = FindArrayAvgOfRows(arr);
            double tempVal;
            for (int iT = 0; iT < arr.GetLength(0) - 1; iT++)
            {
                for (int i = iT + 1; i < arr.GetLength(0); i++)
                {
                    if (avgArr[iT] > avgArr[i])
                    {
                        for (int j = 0; j < avgArr.Length; j++)
                        {
                            tempVal = arr[i, j];
                            arr[i, j] = arr[iT, j];
                            arr[iT, j] = tempVal;
                        }
                        tempVal = avgArr[iT];
                        avgArr[iT] = avgArr[i];
                        avgArr[i] = tempVal;
                    }
                }
            }
            return arr;
        }
    }
}
