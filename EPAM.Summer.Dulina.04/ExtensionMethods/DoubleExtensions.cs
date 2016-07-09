using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    /// <summary>
    /// Returns binary representation in IEEE 754 standart. 
    /// </summary>
    /// <param name="value">A double-precision floating-point number to be converted</param>
    /// <returns>Binary string.</returns>
    public static class DoubleExtensions
    {
        public static string GetBinary(this float value)
        {
            int bitCount = sizeof(float) * 8;
            int sign = value > 0 ? 0 : 1;
            value = Math.Abs(value);
            int bias = 127;
            int orderSize = 8;
            int mantisaSize = 23;
            int shift = 0;
            StringBuilder result = new StringBuilder(bitCount);
            string integerPart = Convert.ToString((int)Math.Truncate(value), 2);
            int pointIndex = integerPart.Length;
            result.Append(integerPart);

            value = value - (int)value;
            int t, count = 0;
            do
            {
                value *= 2;
                t = (int)value;
                value = value - t;
                result.Append(t);
                count++;
            } while (value != 0 && count < mantisaSize);

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '1')
                {
                    if (pointIndex > i)
                    {
                        shift = pointIndex - i - 1;
                        result.Remove(0, i + 1);
                    }
                    else if (pointIndex == i)
                    {
                        shift = -1;
                        result.Remove(0, 2);
                    }
                    break;
                }
            }
            int order = bias + shift;
            string orderBinary = Convert.ToString(order, 2);
            result.Insert(0, orderBinary);
            if (orderBinary.Length < orderSize)
            {
                result.Insert(0, "0", orderSize - orderBinary.Length);
            }
            result.Insert(0, sign == 1 ? '1' : '0');

            if (result.Length < bitCount)
            {
                result.Append('0', bitCount - result.Length);
            }
            else if (result.Length > bitCount)
            {
                result.Remove(bitCount, result.Length - bitCount);
            }
            Console.WriteLine(result.Length);

            return result.ToString();
        }

        public static string GetBinary(this double value)
        {
            int bitCount = sizeof(double) * 8;
            int sign = value > 0 ? 0 : 1;
            value = Math.Abs(value);
            int bias = 1023;
            int orderSize = 11;
            int mantisaSize = 52;
            int shift = 0;
            StringBuilder result = new StringBuilder(bitCount);
            string integerPart = Convert.ToString((int)Math.Truncate(value), 2);
            int pointIndex = integerPart.Length;
            result.Append(integerPart);

            value = value - (int)value;
            int t, count = 0;
            do
            {
                value *= 2;
                t = (int)value;
                value = value - t;
                result.Append(t);
                count++;
            } while (value != 0 && count < mantisaSize);

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '1')
                {
                    if (pointIndex > i)
                    {
                        shift = pointIndex - i - 1;
                        result.Remove(0, i + 1);
                    }
                    else if (pointIndex == i)
                    {
                        shift = -1;
                        result.Remove(0, 2);
                    }
                    break;
                }
            }
            int order = bias + shift;
            string orderBinary = Convert.ToString(order, 2);
            result.Insert(0, orderBinary);
            if (orderBinary.Length < orderSize)
            {
                result.Insert(0, "0", orderSize - orderBinary.Length);
            }
            result.Insert(0, sign == 1 ? '1' : '0');

            if (result.Length < bitCount)
            {
                result.Append('0', bitCount - result.Length);
            }
            else if (result.Length > bitCount)
            {
                result.Remove(bitCount, result.Length - bitCount);
            }
            Console.WriteLine(result.Length);

            return result.ToString();
        }
    }
}
