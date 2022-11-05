using System;

namespace CreatingArray
{
    public static class ArrayCreator
    {
        public struct Range
        {
            private int _secondValue;
            public Range(int firstValue, int secondValue)
            {
                FirstValue = firstValue;
                _secondValue = secondValue;
            }
            public int FirstValue { get; set; }
            public int SecondValue
            {
                get => _secondValue;
                set
                {
                    if (FirstValue > value) throw new Exception("Второе значение диапазона больше или равно первому!");
                    _secondValue = value;
                }

            }
        }
        /// <summary>
        /// Создает двумерный массив данных, заполненный нулями.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static double[,] CreateArray(int n, int m)
        {
            double[,] arr = new double[n, m];
            return arr;
        }
        public static double[,] CreateArray(int n, int m, Range range)
        {
            var arr = CreateArray(n, m);
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(range.FirstValue, range.SecondValue);
                }
            }
            return arr;
        }
    }
}
