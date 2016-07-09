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
        int[] GetCompareElements(int[][] array);
    }
}
