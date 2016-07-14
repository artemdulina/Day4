using System;

namespace MatrixOperations
{
    public static class GroupOperationsReverse
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
        /// Sorts the jagged array by rows using the specified MatrixOperations.IJaggedArraysComparer.
        /// </summary>
        /// <param name="array">Jagged array to be sorted.</param>
        /// <param name="comparer">The MatrixOperations.IJaggedArraysComparer implementation to use when comparing elements.</param>
        /// <returns>Sorted jagged array</returns>
        /// <exception cref="ArgumentNullException">array is null.</exception>
        public static void SortingByRows(int[][] array, IJaggedArraysComparer comparer = null)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            if (comparer == null)
            {
                comparer = JaggedArraysHelper.DefaultComparer;
            }
            Comparison<int> comparison = FunctionOnComparer.Comparison(comparer);
            ComparedValues comparisonValues = FunctionOnComparer.ComparedValues(comparer);
            SortingByRows(array, comparison, comparisonValues);
        }

        /// <summary>
        /// Sorts the jagged array by rows using the specified MatrixOperations.Comparison, MatrixOperations.ComparedValues.
        /// </summary>
        /// <param name="array">Jagged array to be sorted.</param>
        /// <param name="comparison">The MatrixOperations.Comparison to use when comparing rows by comparisonValues.</param>
        /// <param name="comparisonValues">The MatrixOperations.Comparison to use when comparing rows.</param>
        /// <returns>Sorted jagged array</returns> 
        /// <exception cref="ArgumentNullException">array is null or comparison is null or comparisonValues is null</exception>
        /// <exception cref="ArgumentException">array rows number not equals to the number of elements of comparisonValues returned value</exception>
        public static void SortingByRows(int[][] array, Comparison<int> comparison, ComparedValues comparisonValues)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            if (comparison == null)
            {
                throw new ArgumentNullException(nameof(comparison));
            }
            if (comparisonValues == null)
            {
                throw new ArgumentNullException(nameof(comparisonValues));
            }

            int[] helper = comparisonValues(array);
            if (helper.Length != array.Length)
            {
                throw new ArgumentException("Should return array with the number of elements equals to the number of rows of the array", nameof(comparisonValues));
            }

            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 1; j < array.Length - i; j++)
                {
                    if (comparison(helper[j], helper[j - 1]) == -1)
                    {
                        Swap(ref array[j], ref array[j - 1]);
                        Swap(ref helper[j], ref helper[j - 1]);
                    }
                }
            }

        }

        /// <summary>
        /// Reverses the sequence of the rows in the jagged array.
        /// </summary>
        /// <param name="array">The jagged array to reverse.</param>
        /// <exception cref="ArgumentNullException">array is null</exception>
        public static void Reverse(int[][] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[array.Length - i - 1]);
            }
        }
    }
}
