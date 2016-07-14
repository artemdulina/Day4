using System;

namespace MatrixOperations
{
    public delegate int[] ComparedValues(int[][] array);

    public sealed class ComparerOnFunction : IJaggedArraysComparer
    {
        private Comparison<int> comparison;

        private ComparedValues comparisonValues;

        public ComparerOnFunction(Comparison<int> comparison, ComparedValues comparisonValues)
        {
            this.comparison = comparison;
            this.comparisonValues = comparisonValues;
        }

        public int Compare(int x, int y)
        {
            return comparison(x, y);
        }

        public int[] GetCompareElements(int[][] array)
        {
            return comparisonValues(array);
        }
    }
}
