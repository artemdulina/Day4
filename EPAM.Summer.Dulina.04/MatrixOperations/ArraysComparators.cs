using System;

namespace MatrixOperations
{
    public class SortBySumOfTheElements : IJaggedArraysComparer
    {
        public int Compare(int x, int y)
        {
            if (x > y)
                return 1;
            if (x < y)
                return -1;
            return 0;
        }

        public int[] GetCompareElements(int[][] array)
        {
            int[] sumValues = new int[array.Length];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }
                sumValues[i] = sum;
                sum = 0;
            }
            return sumValues;
        }
    }

    public class SortByMaximumOfTheElements : IJaggedArraysComparer
    {
        public int Compare(int x, int y)
        {
            if (x > y)
                return 1;
            if (x < y)
                return -1;
            return 0;
        }

        public int[] GetCompareElements(int[][] array)
        {
            int max = int.MinValue;
            int[] maxValues = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] > max)
                        max = array[i][j];
                }
                maxValues[i] = max;
                max = int.MinValue;
            }
            return maxValues;
        }
    }

    public class SortByMinimumOfTheElements : IJaggedArraysComparer
    {
        public int Compare(int x, int y)
        {
            if (x > y)
                return 1;
            if (x < y)
                return -1;
            return 0;
        }

        public int[] GetCompareElements(int[][] array)
        {
            int min = int.MaxValue;
            int[] minValues = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] < min)
                        min = array[i][j];
                }
                minValues[i] = min;
                min = int.MaxValue;
            }
            return minValues;
        }
    }

    public class SortByMaximumModulusOfTheElements : IJaggedArraysComparer
    {
        public int Compare(int x, int y)
        {
            if (x > y)
                return 1;
            if (x < y)
                return -1;
            return 0;
        }

        public int[] GetCompareElements(int[][] array)
        {
            int max = int.MinValue;
            int[] maxValues = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (Math.Abs(array[i][j]) > max)
                        max = Math.Abs(array[i][j]);
                }
                maxValues[i] = max;
                max = int.MinValue;
            }
            return maxValues;
        }
    }
}
