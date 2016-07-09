using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{

    public static class GroupOperations
    {
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }

        /*private static int[] FindMaxOfEachRow(int[][] array)
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

        private static int[] FindMinOfEachRow(int[][] array)
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

        private static int[] FindSumOfEachRow(int[][] array)
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
        }*/

        public static IJaggedArraysComparer SortRowsBySumOfTheElements
        {
            get { return new SortBySumOfTheElements(); }
        }

        public static IJaggedArraysComparer SortRowsByMaximumOfTheElements
        {
            get { return new SortByMaximumOfTheElements(); }
        }

        public static IJaggedArraysComparer SortRowsByMinimumOfTheElements
        {
            get { return new SortByMinimumOfTheElements(); }
        }

        public static void SortingByRows(int[][] array, IJaggedArraysComparer comparer, bool reverse = false)
        {
            int[] helper = comparer.GetCompareElements(array);

            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 1; j < array.Length - i; j++)
                {
                    if (comparer.Compare(helper[j], helper[j - 1]) == -1)
                    {
                        Swap(ref array[j], ref array[j - 1]);
                        Swap(ref helper[j], ref helper[j - 1]);
                    }
                }
            }

            if (reverse)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    Swap(ref array[i], ref array[array.Length - 1 - i]);
                }
            }
        }

        /*public static void SortingByRows(int[][] array, IComparer comparer, bool reverse = false)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 1; j < array.Length - i; j++)
                {
                    if (comparer.Compare(array[j], array[j - 1]) == -1)
                        Swap(ref array[j], ref array[j - 1]);
                }
            }

            if (reverse)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    Swap(ref array[i], ref array[array.Length - 1 - i]);
                }
            }
        }*/

        /*public static void SortArrayByMaximumOfTheElements(int[][] array, bool reverse = false)
        {
            int[] helper = FindMaxOfEachRow(array);

            SimpleSort(array, helper, reverse);
        }

        public static void SortArrayByMinimumOfTheElements(int[][] array, bool reverse = false)
        {
            int[] helper = FindMinOfEachRow(array);

            SimpleSort(array, helper, reverse);
        }

        public static void SortArrayBySumOfTheElements(int[][] array, bool reverse = false)
        {
            int[] helper = FindSumOfEachRow(array);

            SimpleSort(array, helper, reverse);
        }

        private static void SimpleSort(int[][] array, int[] helper, bool reverse = false)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 1; j < array.Length - i; j++)
                {
                    if (helper[j] < helper[j - 1])
                    {
                        Swap(ref array[j], ref array[j - 1]);
                        Swap(ref helper[j], ref helper[j - 1]);
                    }
                }
            }

            if (reverse)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    Swap(ref array[i], ref array[array.Length - 1 - i]);
                }
            }
        }*/
    }
}
