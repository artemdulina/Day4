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

        /// <summary>
        /// The sort compares the elements to each
        /// other using the IComparable interface, which must be implemented
        /// by all elements of the array.
        /// </summary>
        /// <param name="array">Jagged array to be sorted.</param>
        /// <returns>Sorted jagged array</returns>
        public static void SortingByRows(int[][] array, IJaggedArraysComparer comparer)
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
        }

        public static void Reverse(int[][] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[array.Length - i - 1]);
            }
        }
    }
}
