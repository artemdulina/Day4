using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace MatrixOperations
{
    public interface IJaggedArraysComparer : IComparer<int>
    {
        /// <summary>
        /// Returns an array of elements by which objects are sorted.
        /// </summary>
        /// <param name="array">Jagged array to be sorted.</param>
        /// <returns>Array of elements according to the sorting criteria.</returns>
        int[] GetCompareElements(int[][] array);

    }
}
