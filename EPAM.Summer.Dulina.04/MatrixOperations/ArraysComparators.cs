using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    public class SortBySumOfTheElements : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            int[] a = x as int[];
            int[] b = y as int[];
            int sumA = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sumA += a[i];
            }
            int sumB = 0;
            for (int i = 0; i < b.Length; i++)
            {
                sumB += b[i];
            }
            if (sumA > sumB)
                return 1;
            else if (sumA < sumB)
                return -1;
            else return 0;
        }
    }

    public class SortByMaximumOfTheElements : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            int[] a = x as int[];
            int[] b = y as int[];
            int maxA = int.MinValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (maxA < a[i])
                    maxA = a[i];
            }
            int maxB = int.MinValue;
            for (int i = 0; i < b.Length; i++)
            {
                if (maxB < b[i])
                    maxB = b[i];
            }
            if (maxA > maxB)
                return 1;
            else if (maxA < maxB)
                return -1;
            else return 0;
        }
    }

    public class SortByMinimumOfTheElements : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            int[] a = x as int[];
            int[] b = y as int[];
            int minA = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (minA > a[i])
                    minA = a[i];
            }
            int minB = int.MaxValue;
            for (int i = 0; i < b.Length; i++)
            {
                if (minB > b[i])
                    minB = b[i];
            }
            if (minA > minB)
                return 1;
            else if (minA < minB)
                return -1;
            else return 0;
        }
    }
}
