using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAreaForTaskTwo
{
    public static class CustomerExtensions
    {
        public static string ToString(this Customer customer, string format)
        {
            return customer.ToString(format, CultureInfo.CurrentCulture);
        }
    }
}
