using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static double[,] FirstWaySortToUpRowElements(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                TemporaryValue temporaryValue = new TemporaryValue(i, 0, arr[i, 0]);
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (temporaryValue.Value > arr[i, j])
                    {

                        arr[temporaryValue.FirstIndex, temporaryValue.SecondIndex] = arr[i, j];
                        arr[i, j] = temporaryValue.Value;
                        temporaryValue.FirstIndex = i;
                        temporaryValue.SecondIndex = j;
                    }
                }
            }
            return arr;
        }
        public static double[,] SecondWaySortToUpRowElements(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int jTemporary = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, jTemporary] > arr[i, j])
                    {
                        double temporaryValue = arr[i, j];
                        arr[i, j] = arr[i, jTemporary];
                        arr[i, jTemporary] = temporaryValue;
                        jTemporary = j;
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
        public static double[,] FirstWaySortToUpRowsOnAvgElements(double[,] arr)
        {
            double[] avgArr = FindArrayAvgOfRows(arr);
            TemporaryValue temporaryValue = new TemporaryValue(0, 0, avgArr[0]);
            double[] newArrRow = new double[arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (temporaryValue.Value > avgArr[i])
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        newArrRow[j] = arr[temporaryValue.FirstIndex, j];
                        arr[temporaryValue.FirstIndex, j] = arr[i, j];
                        arr[i, j] = newArrRow[j];
                        temporaryValue.Value = avgArr[i];
                    }
                }
            }
            return arr;
        }
        public static double[,] SecondWaySortToUpRowsOnAvgElements(double[,] arr)
        {
            double[] avgArr = FindArrayAvgOfRows(arr);          
            int currentIndex = 0;
            for (int i = 0; i < avgArr.Length; i++)
            {
                if (avgArr[currentIndex] > avgArr[i])
                {
                    double temporaryValue = avgArr[i];
                    avgArr[i] = avgArr[currentIndex];
                    avgArr[currentIndex] = temporaryValue;
                    double[] newArrRow = new double[arr.GetLength(1)];
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        newArrRow[j] = arr[i, j];
                        arr[i, j] = arr[currentIndex, j];
                        arr[currentIndex, j] = newArrRow[j];
                    }
                    currentIndex = i;
                }
            }
            return arr;
        }
    }
}
