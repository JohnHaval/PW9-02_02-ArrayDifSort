using System.Diagnostics;

namespace ArrayUnitTest
{
    public static class TraceTransfer
    {
        public static void ToTrace(double[] avgArr)
        {
            for (int i = 0; i < avgArr.Length; i++)
            {
                Debug.Write($"{avgArr[i]} ");
            }
            Debug.WriteLine("");
            Debug.WriteLine("");
        }
        public static void ToTrace(double[,] sortArr)
        {
            for (int i = 0; i < sortArr.GetLength(0); i++)
            {
                for (int j = 0; j < sortArr.GetLength(1); j++)
                {
                    Debug.Write($"{sortArr[i, j]} ");
                }
                Debug.WriteLine("");
            }
            Debug.WriteLine("");
        }
    }
}
