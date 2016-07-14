using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    public static class JaggedArraysHelper
    {
        private class SortBySumOfTheElements : IJaggedArraysComparer
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
        public static IJaggedArraysComparer DefaultComparer => new SortBySumOfTheElements();
    }
}
