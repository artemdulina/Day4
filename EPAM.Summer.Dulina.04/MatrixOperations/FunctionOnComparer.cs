using System;
using System.Collections;

namespace MatrixOperations
{
    public static class FunctionOnComparer
    {
        public static Comparison<int> Comparison(IJaggedArraysComparer comparer)
        {
            return comparer.Compare;
        }

        public static ComparedValues ComparedValues(IJaggedArraysComparer comparer)
        {
            return comparer.GetCompareElements;
        }
    }
}
