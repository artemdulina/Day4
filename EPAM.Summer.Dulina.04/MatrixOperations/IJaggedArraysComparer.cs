using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    public interface IJaggedArraysComparer : IComparer<int>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array">Jagged array to be sorted.</param>
        /// <returns>Array of elements according to the sorting criteria.</returns>
        int[] GetCompareElements(int[][] array);
    }
}
