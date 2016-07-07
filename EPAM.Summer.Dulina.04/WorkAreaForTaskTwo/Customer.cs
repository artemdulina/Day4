using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAreaForTaskTwo
{
    public class Customer : IFormattable
    {
        public string Name { get; private set; }

        public string ContactPhone { get; private set; }

        public decimal Revenue { get; private set; }

        public Customer(string name, string contactPhone, decimal revenue)
        {
            Name = name;
            ContactPhone = contactPhone;
            Revenue = revenue;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "Customer record: {0}, {1}, {2}", Name, ContactPhone, Revenue);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (String.IsNullOrEmpty(format)) format = "G";
            if (formatProvider == null) formatProvider = CultureInfo.CurrentCulture;

            switch (format.ToUpperInvariant())
            {
                case "G":
                    return ToString();
                case "N":
                    return "Customer record: " + Name;
                case "P":
                    return "Customer record: " + ContactPhone;
                case "R":
                    return Revenue.ToString("F2", formatProvider);
                default:
                    throw new FormatException(string.Format("The {0} format string is not supported.", format));
            }
        }
    }
}
